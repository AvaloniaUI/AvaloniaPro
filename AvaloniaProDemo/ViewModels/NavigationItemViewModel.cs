using System;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaProDemo.ViewModels;

public partial class NavigationItemViewModel : ViewModelBase
{
    public string Title { get; init; } = "";
    public bool IsCategory { get; init; }
    public bool IsSubItem { get; init; }
    public Geometry? IconData { get; init; }
    public Func<ViewModelBase>? PageFactory { get; init; }
}
