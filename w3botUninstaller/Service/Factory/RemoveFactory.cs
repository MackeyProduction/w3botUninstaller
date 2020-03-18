using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w3botUninstaller.Command;
using w3botUninstaller.ExceptionMessage;
using w3botUninstaller.Utils;

namespace w3botUninstaller.Service.Factory
{
    public class RemoveFactory
    {
        public RemoveFactory()
        {
        }

        public ICommand Create(FileType fileType, string path)
        {
            switch (fileType)
            {
                case FileType.Documents:
                    return new RemoveDocumentFilesCommand(path);
                case FileType.Client:
                    return new RemoveClientCommand(path);
                default:
                    break;
            }

            throw new InvalidFileTypeException(fileType.ToString());
        }
    }
}
