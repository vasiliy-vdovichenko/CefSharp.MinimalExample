using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenWebBrowser_OnClick(object sender, RoutedEventArgs e)
        {
            var webBrowserView = ScreenPlaceholder.Content as WebBrowserView;
            if (webBrowserView != null)
            {
                webBrowserView.Browser.Dispose();
            }
            ScreenPlaceholder.Content = new WebBrowserView();
        }
    }
}
