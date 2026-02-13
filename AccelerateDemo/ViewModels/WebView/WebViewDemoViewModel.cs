using System;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AccelerateDemo.ViewModels.WebView;

public partial class WebViewDemoViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _addressText = "https://avaloniaui.net/";

    [ObservableProperty]
    private Uri _currentUri = new("https://avaloniaui.net/");

    public static string WebViewCacheFolder { get; } = GetWebViewCacheFolder();

    [RelayCommand]
    private void Navigate()
    {
        if (Uri.TryCreate(AddressText, UriKind.Absolute, out var uri))
        {
            CurrentUri = uri;
        }
        else if (Uri.TryCreate("https://" + AddressText, UriKind.Absolute, out var httpsUri))
        {
            CurrentUri = httpsUri;
            AddressText = httpsUri.ToString();
        }
    }

    private static string GetWebViewCacheFolder()
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        var cacheFolder = Path.Combine(appData, "AvaloniaUI", "AccelerateDemo", "WebView");
        Directory.CreateDirectory(cacheFolder);
        return cacheFolder;
    }
}
