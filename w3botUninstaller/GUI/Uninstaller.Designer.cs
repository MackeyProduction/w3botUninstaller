namespace w3botUninstaller.GUI
{
    partial class Uninstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srcDirectoryLabel = new System.Windows.Forms.Label();
            this.installLocationLabel = new System.Windows.Forms.Label();
            this.pbUninstall = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.UninstallerBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // srcDirectoryLabel
            // 
            this.srcDirectoryLabel.AutoSize = true;
            this.srcDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcDirectoryLabel.Location = new System.Drawing.Point(13, 13);
            this.srcDirectoryLabel.Name = "srcDirectoryLabel";
            this.srcDirectoryLabel.Size = new System.Drawing.Size(95, 16);
            this.srcDirectoryLabel.TabIndex = 0;
            this.srcDirectoryLabel.Text = "Install location:";
            // 
            // installLocationLabel
            // 
            this.installLocationLabel.AutoSize = true;
            this.installLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installLocationLabel.Location = new System.Drawing.Point(105, 13);
            this.installLocationLabel.Name = "installLocationLabel";
            this.installLocationLabel.Size = new System.Drawing.Size(42, 16);
            this.installLocationLabel.TabIndex = 1;
            this.installLocationLabel.Text = "NULL";
            // 
            // pbUninstall
            // 
            this.pbUninstall.Location = new System.Drawing.Point(13, 43);
            this.pbUninstall.Name = "pbUninstall";
            this.pbUninstall.Size = new System.Drawing.Size(409, 34);
            this.pbUninstall.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(13, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.Location = new System.Drawing.Point(347, 112);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 29);
            this.btnUninstall.TabIndex = 4;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.Location = new System.Drawing.Point(13, 80);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(33, 16);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "File:";
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocationLabel.Location = new System.Drawing.Point(49, 80);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(42, 16);
            this.fileLocationLabel.TabIndex = 6;
            this.fileLocationLabel.Text = "NULL";
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(347, 24);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(75, 16);
            this.progressLabel.TabIndex = 7;
            this.progressLabel.Text = "0 / 100";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UninstallerBackgroundWorker
            // 
            this.UninstallerBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UninstallerBackgroundWorker_DoWork);
            this.UninstallerBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UninstallerBackgroundWorker_ProgressChanged);
            this.UninstallerBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UninstallerBackgroundWorker_RunWorkerCompleted);
            // 
            // Uninstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 157);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.fileLocationLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUninstall);
            this.Controls.Add(this.installLocationLabel);
            this.Controls.Add(this.srcDirectoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Uninstaller";
            this.Text = "w3bot Uninstaller";
            this.Load += new System.EventHandler(this.Uninstaller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srcDirectoryLabel;
        private System.Windows.Forms.Label installLocationLabel;
        private System.Windows.Forms.ProgressBar pbUninstall;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.ComponentModel.BackgroundWorker UninstallerBackgroundWorker;
    }
}

