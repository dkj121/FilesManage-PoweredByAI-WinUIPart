using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace FilesManage_PoweredByAI_.Models
{
    internal class MyFilesTreeNode
    {
        public string _name { get; set; } = string.Empty;
        public string _path { get; set; } = string.Empty;
        public StorageFile? _file { get; set; } = null;
        public StorageFolder? _folder { get; set; } = null;

        public ObservableCollection<MyFilesTreeNode> _children = new ObservableCollection<MyFilesTreeNode>();
        public MyFilesTreeNode? _parent { get; set; } = null;
        public bool _isFolder { get; set; } = false;
        public MyFilesTreeNode()
        {
            _children.Clear();
        }
        public void addParent(MyFilesTreeNode parent)
        {
            _parent = parent;
        }
        public void addChild(MyFilesTreeNode child)
        {
            _children.Add(child);
        }
    }
}
