using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaProDemo.Views.Tooling;

public partial class ToolingOverviewView : UserControl
{
    public ToolingOverviewView()
    {
        InitializeComponent();
    }

    private void LearnMore_Tapped(object? sender, TappedEventArgs e)
    {
        if (sender is TextBlock { Tag: string url } && !string.IsNullOrEmpty(url))
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
