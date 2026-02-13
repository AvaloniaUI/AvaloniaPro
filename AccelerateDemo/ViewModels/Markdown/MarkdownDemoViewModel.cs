using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AccelerateDemo.Services;

namespace AccelerateDemo.ViewModels.Markdown;

public partial class MarkdownDemoViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _markdownText = SampleDataService.SampleMarkdownReadme;

    [ObservableProperty]
    private bool _isEditorVisible = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsReadmeSelected))]
    [NotifyPropertyChangedFor(nameof(IsFeaturesSelected))]
    [NotifyPropertyChangedFor(nameof(IsCodeBlocksSelected))]
    private string _selectedSample = "readme";

    public bool IsReadmeSelected => SelectedSample == "readme";
    public bool IsFeaturesSelected => SelectedSample == "features";
    public bool IsCodeBlocksSelected => SelectedSample == "codeblocks";

    [RelayCommand]
    private void LoadReadme()
    {
        MarkdownText = SampleDataService.SampleMarkdownReadme;
        SelectedSample = "readme";
    }

    [RelayCommand]
    private void LoadFeatures()
    {
        MarkdownText = SampleDataService.SampleMarkdownFeatures;
        SelectedSample = "features";
    }

    [RelayCommand]
    private void LoadCodeBlocks()
    {
        MarkdownText = SampleDataService.SampleMarkdownCode;
        SelectedSample = "codeblocks";
    }

    [RelayCommand]
    private void ToggleEditor() => IsEditorVisible = !IsEditorVisible;
}
