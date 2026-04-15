using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using AccelerateDemo.Models;
using AccelerateDemo.Services;

namespace AccelerateDemo.ViewModels.DataGrid;

public partial class HierarchicalDataGridViewModel : ViewModelBase
{
    public HierarchicalTreeDataGridSource<FileSystemNode> Source { get; }

    public HierarchicalDataGridViewModel()
    {
        var files = SampleDataService.GetFileSystem();

        Source = new HierarchicalTreeDataGridSource<FileSystemNode>(files)
            .WithHierarchicalExpanderColumn(
                "Name",
                new TreeDataGridTemplateColumn("FileNameCellTemplate")
                {
                    Header = "Name",
                    Width = new GridLength(2, GridUnitType.Star)
                },
                x => x.Children)
            .WithTextColumn("Size", x => x.SizeDisplay, o => o.Width = new GridLength(100))
            .WithTextColumn("Type", x => x.TypeDisplay, o => o.Width = new GridLength(120))
            .WithTextColumn("Modified", x => x.ModifiedDisplay, o => o.Width = new GridLength(120));
    }

    [RelayCommand]
    private void ExpandAll() => Source.ExpandAll();

    [RelayCommand]
    private void CollapseAll() => Source.CollapseAll();
}
