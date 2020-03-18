using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using w3botUninstaller.Command;
using w3botUninstaller.Service;
using w3botUninstaller.Service.Factory;
using w3botUninstaller.Utils;

namespace w3botUninstaller.GUI
{
    public partial class Uninstaller : Form
    {
        private List<ICommand> _commandList = new List<ICommand>();
        private string _installPath = "";

        public Uninstaller()
        {
            InitializeComponent();
            UninstallerBackgroundWorker.WorkerReportsProgress = true;
            UninstallerBackgroundWorker.WorkerSupportsCancellation = true;
        }

        private void Uninstaller_Load(object sender, EventArgs e)
        {
            fileLocationLabel.Text = "";

            try
            {
                _installPath = RegistryUtils.GetRegistryEntry();
                installLocationLabel.Text = _installPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var removeFactory = new RemoveFactory();
            var removeService = new RemoveService(removeFactory);
            var clientRemove = removeService.Create(FileType.Client, _installPath);
            var documentsRemove = removeService.Create(FileType.Documents, BotDirectories.baseDir);

            _commandList.Add(clientRemove);
            _commandList.Add(documentsRemove);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want cancel the uninstallation?", "Cancel uninstall of w3bot?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (UninstallerBackgroundWorker.WorkerSupportsCancellation == true)
                {
                    // Cancel the asynchronous operation.
                    UninstallerBackgroundWorker.CancelAsync();
                }
            }
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to uninstall w3bot?", "Uninstall w3bot", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnCancel.Enabled = true;
                btnUninstall.Enabled = false;

                Run();
            }
        }

        private void SetFileLocationLabel(string message)
        {
            fileLocationLabel.Text = message;
        }

        private void Execute(ICommand c)
        {
            while (!c.IsHandled || c.IsRunning)
            {
                c.Execute();

                fileLocationLabel.Invoke(new MethodInvoker(delegate
                {
                    SetFileLocationLabel(c.Status);
                }));

                Thread.Sleep(100);
            }
        }

        private void Run()
        {
            if (UninstallerBackgroundWorker.IsBusy != true)
            {
                // Start the asynchronous operation.
                UninstallerBackgroundWorker.RunWorkerAsync();
            }
        }

        private void UninstallerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;

                for (int i = 0; i < _commandList.Count; i++)
                {
                    Execute(_commandList[i]);

                    Thread.Sleep(500);
                    double progress = ((i + 1.0) / _commandList.Count) * 100;
                    worker.ReportProgress((int)progress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UninstallerBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // removing registry entry to avoid bugs in reusing the client
            RegistryUtils.RemoveRegistryEntry();

            MessageBox.Show("Uninstallation completed!");
        }

        private void UninstallerBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressLabel.Text = String.Format("{0} / {1} %", e.ProgressPercentage, 100);
            pbUninstall.Value = e.ProgressPercentage;
        }
    }
}
