using CommunityToolkit.Mvvm.ComponentModel;

namespace AccelerateDemo.ViewModels.MediaPlayer;

public partial class MediaPlayerViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsSample1Selected))]
    [NotifyPropertyChangedFor(nameof(IsSample2Selected))]
    [NotifyPropertyChangedFor(nameof(IsSample3Selected))]
    [NotifyPropertyChangedFor(nameof(IsFileSelected))]
    private string _selectedSource = "sample1";

    public bool IsSample1Selected => SelectedSource == "sample1";
    public bool IsSample2Selected => SelectedSource == "sample2";
    public bool IsSample3Selected => SelectedSource == "sample3";
    public bool IsFileSelected => SelectedSource == "file";
}
