using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
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
        {
            Columns =
            {
                new HierarchicalExpanderColumn<FileSystemNode>(
                    new TemplateColumn<FileSystemNode>("Name", "FileNameCellTemplate", null, new GridLength(2, GridUnitType.Star)),
                    x => x.Children),
                new TextColumn<FileSystemNode, string>("Size", x => x.SizeDisplay, width: new GridLength(100)),
                new TextColumn<FileSystemNode, string>("Type", x => x.TypeDisplay, width: new GridLength(120)),
                new TextColumn<FileSystemNode, string>("Modified", x => x.ModifiedDisplay, width: new GridLength(120)),
            },
        };
    }

    [RelayCommand]
    private void ExpandAll() => Source.ExpandAll();

    [RelayCommand]
    private void CollapseAll() => Source.CollapseAll();
}
