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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MarkEditor
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // XAML ‚Ì TitleBar ‚ðŽg‚¤
            this.ExtendsContentIntoTitleBar = true;
            this.SetTitleBar(TitleBar);

            // TitleBar Tell
            var appWindow = this.AppWindow; // WindowEx ‚È‚Ç‚ðŽg‚Á‚Ä‚¢‚é‘O’ñ
            appWindow.TitleBar.PreferredHeightOption =
                Microsoft.UI.Windowing.TitleBarHeightOption.Tall;
        }
    }
}