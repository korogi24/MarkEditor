using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MarkEditor.Dialogs;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MarkEditor
{
    public sealed partial class TabbedCommandBarControl : UserControl
    {
        public TabbedCommandBarControl()
        {
            InitializeComponent();
        }


        private async void LinkButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog
            {
                // XamlRoot must be set in the case of a ContentDialog running in a Desktop app
                XamlRoot = this.Content.XamlRoot,
                Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style,
                Title = "リンクの挿入",
                PrimaryButtonText = "OK",
                CloseButtonText = "キャンセル",
                DefaultButton = ContentDialogButton.Primary,
                Content = new LinkDialog()
            };
            _ = await dialog.ShowAsync();
        }
    }
}
