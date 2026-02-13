using CommunityToolkit.Mvvm.ComponentModel;

namespace AccelerateDemo.ViewModels.VirtualKeyboard;

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
