using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Platform.Storage;
using AccelerateDemo.ViewModels.MediaPlayer;

namespace AccelerateDemo.Views.MediaPlayer;

public partial class MediaPlayerView : UserControl
{
    public MediaPlayerView()
    {
        InitializeComponent();

        mediaPlayer.ErrorOccurred += (sender, args) =>
        {
            System.Diagnostics.Debug.WriteLine($"Media error: {args.Message}");
            args.Handled = true;
        };

        Loaded += (_, _) => LoadSource("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");
    }

    private void LoadSource(string url)
    {
        mediaPlayer.Source = new UriSource(url);
    }

    private void LoadSample1_Click(object? sender, RoutedEventArgs e)
    {
        LoadSource("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");
        if (DataContext is MediaPlayerViewModel vm) vm.SelectedSource = "sample1";
    }

    private void LoadSample2_Click(object? sender, RoutedEventArgs e)
    {
        LoadSource("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4");
        if (DataContext is MediaPlayerViewModel vm) vm.SelectedSource = "sample2";
    }

    private void LoadSample3_Click(object? sender, RoutedEventArgs e)
    {
        LoadSource("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/Sintel.mp4");
        if (DataContext is MediaPlayerViewModel vm) vm.SelectedSource = "sample3";
    }

    private async void OpenFile_Click(object? sender, RoutedEventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(this);
        if (topLevel?.StorageProvider is not { } storageProvider)
            return;

        var files = await storageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = "Open Media File",
            AllowMultiple = false,
            FileTypeFilter = new[]
            {
                new FilePickerFileType("Media Files")
                {
                    Patterns = new[] { "*.mp4", "*.mp3", "*.wav", "*.avi", "*.mkv", "*.webm", "*.m4a", "*.aac", "*.mov" }
                },
                FilePickerFileTypes.All
            }
        });

        if (files.Count != 1)
            return;

        mediaPlayer.Source = new StorageFileSource(files[0]);
        if (DataContext is MediaPlayerViewModel vm) vm.SelectedSource = "file";
    }
}
