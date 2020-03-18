using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w3botUninstaller.Utils;

namespace w3botUninstaller.Command
{
    public class RemoveClientCommand : AbstractInputOutput, ICommand
    {
        public RemoveClientCommand(string path) : base(path)
        {
        }

        public string Status { get; set; }
        public bool IsHandled { get; set; }
        public bool IsRunning { get; set; }

        public void Execute()
        {
            try
            {
                Status = FilePath;

                if (IsFinished)
                {
                    IsHandled = true;
                    return;
                }

                Remove(DestinationPath);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
