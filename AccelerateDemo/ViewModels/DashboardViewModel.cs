using System;
using System.Collections.ObjectModel;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AccelerateDemo.ViewModels;

public partial class DashboardCardViewModel : ViewModelBase
{
    public string Title { get; init; } = "";
    public string Description { get; init; } = "";
    public string Category { get; init; } = "";
    public string NavigationKey { get; init; } = "";
    public Geometry? IconData { get; init; }
    public IBrush BadgeBackground { get; init; } = Brushes.Transparent;
    public IBrush BadgeForeground { get; init; } = Brushes.Black;
}

public partial class DashboardViewModel : ViewModelBase
{
    public ObservableCollection<DashboardCardViewModel> ComponentCards { get; } = new()
    {
        new()
        {
            Title = "TreeDataGrid",
            Description = "High-performance data grid with flat and hierarchical views, sorting, filtering, and cell editing.",
            NavigationKey = "FlatDataGrid",
            IconData = StreamGeometry.Parse(IconPaths.DataGrid),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A007DF9")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#007DF9"))
        },
        new()
        {
            Title = "Markdown",
            Description = "Native Markdown renderer with syntax highlighting, tables, alerts, and full styling support.",
            NavigationKey = "Markdown",
            IconData = StreamGeometry.Parse(IconPaths.Markdown),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1AEC4899")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#EC4899"))
        },
        new()
        {
            Title = "Media Player",
            Description = "Cross-platform audio and video playback with transport controls and multiple source types.",
            NavigationKey = "MediaPlayer",
            IconData = StreamGeometry.Parse(IconPaths.MediaPlayer),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1AF97316")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#F97316"))
        },
        new()
        {
            Title = "Virtual Keyboard",
            Description = "On-screen keyboard for touch and kiosk scenarios with multi-language and IME support.",
            NavigationKey = "VirtualKeyboard",
            IconData = StreamGeometry.Parse(IconPaths.VirtualKeyboard),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A14B8A6")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#14B8A6"))
        },
        new()
        {
            Title = "WebView",
            Description = "Embedded native web browser using platform rendering engines for web content display.",
            NavigationKey = "WebView",
            IconData = StreamGeometry.Parse(IconPaths.WebView),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A3B82F6")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#3B82F6"))
        },
    };

    public ObservableCollection<DashboardCardViewModel> ToolingCards { get; } = new()
    {
        new()
        {
            Title = "Development Tools",
            Description = "IDE extensions, DevTools, and app packaging to accelerate your development workflow.",
            NavigationKey = "Tooling",
            IconData = StreamGeometry.Parse(IconPaths.DevTools),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A007DF9")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#007DF9"))
        },
    };

    public Action<string>? NavigateRequested { get; set; }

    [RelayCommand]
    private void NavigateToDemo(string navigationKey)
    {
        NavigateRequested?.Invoke(navigationKey);
    }
}
