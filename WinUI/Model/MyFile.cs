using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.Storage.Pickers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using WinRT.FilesManage_PoweredByAI_VtableClasses;

namespace FilesManage_PoweredByAI_.Model
{
    class MyFile
    {
        private StorageFile? _file;
        public string _path { get; set; } = string.Empty;
        public MyFile()
        {

        }
        public MyFile(string path)
        {
            _path = path;
            _file = StorageFile.GetFileFromPathAsync(path).AsTask().Result;
        }

    }
}
