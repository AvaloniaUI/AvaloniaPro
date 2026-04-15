using AvaloniaProDemo.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaProDemo.ViewModels.VirtualKeyboard;

public partial class VirtualKeyboardDemoViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _nameText = "";

    [ObservableProperty]
    private string _emailText = "";

    [ObservableProperty]
    private string _searchText = "";

    [ObservableProperty]
    private string _notesText = "";
}
