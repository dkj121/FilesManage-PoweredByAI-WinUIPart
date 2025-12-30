using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.Storage.Pickers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FilesManage_PoweredByAI_.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChooseFolder : Page
    {
        public ChooseFolder()
        {
            InitializeComponent();
        }
        private async void PickMultipleFilesButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                //disable the button to avoid double-clicking
                button.IsEnabled = false;

                var picker = new FileOpenPicker(button.XamlRoot.ContentIslandEnvironment.AppWindowId);

                picker.CommitButtonText = "Pick Files";

                picker.SuggestedStartLocation = PickerLocationId.Desktop;

                picker.ViewMode = PickerViewMode.List;

                // Show the picker dialog window
                var files = await picker.PickMultipleFilesAsync();

                if (files.Count > 0)
                {
                    PickedMultipleFilesTextBlock.Text = "";
                    foreach (var file in files)
                    {
                        PickedMultipleFilesTextBlock.Text += "- Picked: " + file.Path + Environment.NewLine;
                    }
                }
                else
                {
                    PickedMultipleFilesTextBlock.Text = "No files selected.";
                }

                //re-enable the button
                button.IsEnabled = true;
            }
        }
    }
}
