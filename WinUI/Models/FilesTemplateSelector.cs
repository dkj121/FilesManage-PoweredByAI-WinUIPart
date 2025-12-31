using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesManage_PoweredByAI_.Models
{
    internal class FilesTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? FileTemplate { get; set; }
        public DataTemplate? FolderTemplate { get; set; }
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is MyFilesTreeNode node)
            {
                if (node._isFolder)
                {
                    return FolderTemplate!;
                }
                else
                {
                    return FileTemplate!;
                }
            }
            return base.SelectTemplateCore(item);
        }
    }
}
