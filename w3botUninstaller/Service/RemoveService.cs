using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w3botUninstaller.Command;
using w3botUninstaller.Service.Factory;
using w3botUninstaller.Utils;

namespace w3botUninstaller.Service
{
    public class RemoveService
    {
        private RemoveFactory _removeFactory;

        public RemoveService(RemoveFactory removeFactory)
        {
            _removeFactory = removeFactory;
        }

        public ICommand Create(FileType fileType, string path)
        {
            return _removeFactory.Create(fileType, path);
        }
    }
}
