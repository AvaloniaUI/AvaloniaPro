using Avalonia.Controls;
using Avalonia.Controls.Templates;
using VM = AccelerateDemo.ViewModels;
using View = AccelerateDemo.Views;

namespace AccelerateDemo;

// See https://docs.avaloniaui.net/docs/concepts/view-locator#pattern-matching
public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        return param switch
        {
            VM.DashboardViewModel => new View.DashboardView(),
            VM.MainWindowViewModel => new View.MainWindow(),
            VM.DataGrid.EditableDataGridViewModel => new View.DataGrid.EditableDataGridView(),
            VM.DataGrid.FlatDataGridViewModel => new View.DataGrid.FlatDataGridView(),
            VM.DataGrid.HierarchicalDataGridViewModel => new View.DataGrid.HierarchicalDataGridView(),
            VM.Markdown.MarkdownDemoViewModel => new View.Markdown.MarkdownDemoView(),
            VM.MediaPlayer.MediaPlayerViewModel => new View.MediaPlayer.MediaPlayerView(),
            VM.Tooling.ToolingOverviewViewModel => new View.Tooling.ToolingOverviewView(),
            VM.VirtualKeyboard.VirtualKeyboardDemoViewModel => new View.VirtualKeyboard.VirtualKeyboardDemoView(),
            VM.WebView.WebViewDemoViewModel => new View.WebView.WebViewDemoView(),
            _ => new TextBlock { Text = "Not Found: " + param?.GetType().Name }
        };
    }

    public bool Match(object? data)
    {
        return data is VM.ViewModelBase;
    }
}