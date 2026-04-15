using System.Collections.ObjectModel;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AccelerateDemo.ViewModels.Tooling;

public class ToolCardViewModel
{
    public string Title { get; init; } = "";
    public string Description { get; init; } = "";
    public string LearnMoreUrl { get; init; } = "";
    public Geometry? IconData { get; init; }
    public IBrush BadgeBackground { get; init; } = Brushes.Transparent;
    public IBrush BadgeForeground { get; init; } = Brushes.Black;
}

public partial class ToolingOverviewViewModel : ViewModelBase
{
    public ObservableCollection<ToolCardViewModel> Tools { get; } = new()
    {
        new()
        {
            Title = "Avalonia for Visual Studio",
            Description = "Full-featured Visual Studio extension with XAML designer, IntelliSense, live preview, and project templates. Build Avalonia applications with the familiar Visual Studio workflow.",
            LearnMoreUrl = "https://avaloniaui.net/visual-studio",
            IconData = StreamGeometry.Parse(IconPaths.AvaloniaVS),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A007DF9")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#007DF9")),
        },
        new()
        {
            Title = "DevTools",
            Description = "Inspect and debug your running Avalonia application in real-time. Explore the visual tree, view properties, modify styles, and diagnose layout issues on the fly.",
            LearnMoreUrl = "https://avaloniaui.net/devtools",
            IconData = StreamGeometry.Parse(IconPaths.DevTools),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1AF97316")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#F97316")),
        },
        new()
        {
            Title = "Parcel",
            Description = "Application packaging solution for Avalonia apps. Package, sign, and distribute your applications across Windows, macOS, and Linux with streamlined build and deployment workflows.",
            LearnMoreUrl = "https://avaloniaui.net/parcel",
            IconData = StreamGeometry.Parse(IconPaths.Parcel),
            BadgeBackground = new SolidColorBrush(Color.Parse("#1A10B981")),
            BadgeForeground = new SolidColorBrush(Color.Parse("#10B981")),
        },
    };
}
