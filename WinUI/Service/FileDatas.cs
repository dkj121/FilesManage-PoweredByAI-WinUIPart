using FilesManage_PoweredByAI_.Models;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FilesManage_PoweredByAI_.Service
{
    internal static class FileDatas
    {
        public static MyFilesTree MyFilesTreeData { get; } = new MyFilesTree();
        public static ObservableCollection<MyFilesTreeNode> TreeItems { get; } = new();

        public static MyFilesTreeNode? RootNode { get; private set; }

        public static async Task LoadFromPathAsync(string path)
        {
            RootNode = await MyFilesTreeData.BuildTreeAsync(path);

            TreeItems.Clear();
            foreach (var child in RootNode._children)
                TreeItems.Add(child);
        }
        public static async Task Clear(string path)
        {
            RootNode = null;
            TreeItems.Clear();
        }
    }
}