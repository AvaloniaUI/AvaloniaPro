using Avalonia.Controls;
using Avalonia.Input;
using AccelerateDemo.ViewModels.WebView;
using Avalonia.Platform;

namespace AccelerateDemo.Views.WebView;

public partial class WebViewDemoView : UserControl
{
    public WebViewDemoView()
    {
        InitializeComponent();
    }

    private void OnBackClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WebView.GoBack();
    }

    private void OnForwardClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WebView.GoForward();
    }

    private void OnRefreshClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WebView.Refresh();
    }

    private void OnAddressKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter && DataContext is WebViewDemoViewModel vm)
        {
            vm.NavigateCommand.Execute(null);
        }
    }

    private void OnNavigationCompleted(object? sender, Avalonia.Controls.WebViewNavigationCompletedEventArgs e)
    {
        if (DataContext is WebViewDemoViewModel vm && WebView.Source is { } uri)
        {
            vm.AddressText = uri.ToString();
        }
    }

    private void WebView_OnEnvironmentRequested(object? sender, WebViewEnvironmentRequestedEventArgs e)
    {
        if (e is WindowsWebView2EnvironmentRequestedEventArgs webView2)
        {
            // On Windows, set a custom user data folder for WebView2, otherwise it doesn't have write access to Program Files directory.
            webView2.UserDataFolder = WebViewDemoViewModel.WebViewCacheFolder;
        }
    }
}
