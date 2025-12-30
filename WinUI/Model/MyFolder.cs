using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.Storage.Pickers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace FilesManage_PoweredByAI_.Model
{
    class MyFolder : IEnumerable<MyFile>, IEnumerable
    {
        public ObservableCollection<MyFile> _myFolder { get; set; } = new ObservableCollection<MyFile>();
        public MyFolder() 
        {
        
        }
        public void addFile(MyFile file)
        {
            _myFolder.Add(file);
        }
        public async Task openFolderAsync(FileOpenPicker picker)
        {
            var files = await picker.PickMultipleFilesAsync();
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    addFile(new MyFile(file.Path));
                }
            }
        }

    public IEnumerator<MyFile> GetEnumerator() => ((IEnumerable<MyFile>)_myFolder).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
