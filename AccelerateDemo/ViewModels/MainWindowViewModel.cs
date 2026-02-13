using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AccelerateDemo.ViewModels.DataGrid;
using AccelerateDemo.ViewModels.Markdown;
using AccelerateDemo.ViewModels.MediaPlayer;
using AccelerateDemo.ViewModels.Tooling;
using AccelerateDemo.ViewModels.VirtualKeyboard;
using AccelerateDemo.ViewModels.WebView;

namespace AccelerateDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase? _currentPage;

    [ObservableProperty]
    private NavigationItemViewModel? _selectedNavItem;

    [ObservableProperty]
    private bool _isDarkTheme;

    public ObservableCollection<NavigationItemViewModel> NavigationItems { get; }

    private readonly ObservableCollection<NavigationItemViewModel> _flatNavItems;

    public MainWindowViewModel()
    {
        _flatNavItems = new ObservableCollection<NavigationItemViewModel>
        {
            new() { Title = "HOME", IsCategory = true },
            new() { Title = "Dashboard", IconData = StreamGeometry.Parse(IconPaths.Accelerate), PageFactory = () => CreateDashboard() },
            new() { Title = "CONTROLS", IsCategory = true },
            new() { Title = "Flat Grid", IsSubItem = false, IconData = StreamGeometry.Parse(IconPaths.DataGrid), PageFactory = () => new FlatDataGridViewModel() },
            new() { Title = "Hierarchical Grid", IsSubItem = false, IconData = StreamGeometry.Parse(IconPaths.DataGrid), PageFactory = () => new HierarchicalDataGridViewModel() },
            new() { Title = "Editable Grid", IsSubItem = false, IconData = StreamGeometry.Parse(IconPaths.DataGrid), PageFactory = () => new EditableDataGridViewModel() },
            new() { Title = "Markdown", IconData = StreamGeometry.Parse(IconPaths.Markdown), PageFactory = () => new MarkdownDemoViewModel() },
            new() { Title = "Media Player", IconData = StreamGeometry.Parse(IconPaths.MediaPlayer), PageFactory = () => new MediaPlayerViewModel() },
            new() { Title = "Virtual Keyboard", IconData = StreamGeometry.Parse(IconPaths.VirtualKeyboard), PageFactory = () => new VirtualKeyboardDemoViewModel() },
            new() { Title = "WebView", IconData = StreamGeometry.Parse(IconPaths.WebView), PageFactory = () => new WebViewDemoViewModel() },
            new() { Title = "TOOLING", IsCategory = true },
            new() { Title = "Tools Overview", IconData = StreamGeometry.Parse(IconPaths.DevTools), PageFactory = () => new ToolingOverviewViewModel() },
        };

        NavigationItems = _flatNavItems;

        SelectedNavItem = _flatNavItems[1];
    }

    partial void OnSelectedNavItemChanged(NavigationItemViewModel? value)
    {
        if (value?.PageFactory != null)
        {
            CurrentPage = value.PageFactory();
        }
    }

    [RelayCommand]
    private void ToggleTheme()
    {
        IsDarkTheme = !IsDarkTheme;
        if (Application.Current is { } app)
        {
            app.RequestedThemeVariant = IsDarkTheme ? ThemeVariant.Dark : ThemeVariant.Light;
        }
    }

    public void NavigateByKey(string key)
    {
        var targetFactory = key switch
        {
            "FlatDataGrid" => (Func<ViewModelBase>)(() => new FlatDataGridViewModel()),
            "Markdown" => () => new MarkdownDemoViewModel(),
            "MediaPlayer" => () => new MediaPlayerViewModel(),
            "VirtualKeyboard" => () => new VirtualKeyboardDemoViewModel(),
            "WebView" => () => new WebViewDemoViewModel(),
            "Tooling" => () => new ToolingOverviewViewModel(),
            _ => null
        };

        if (targetFactory != null)
        {
            CurrentPage = targetFactory();

            // Find and select matching nav item
            var navTitle = key switch
            {
                "FlatDataGrid" => "Flat Grid",
                "MediaPlayer" => "Media Player",
                "VirtualKeyboard" => "Virtual Keyboard",
                "Tooling" => "Tools Overview",
                _ => key
            };

            var match = _flatNavItems.FirstOrDefault(n => n.Title == navTitle);
            if (match != null)
            {
                SelectedNavItem = match;
            }
        }
    }

    private DashboardViewModel CreateDashboard()
    {
        var vm = new DashboardViewModel();
        vm.NavigateRequested = NavigateByKey;
        return vm;
    }
}
