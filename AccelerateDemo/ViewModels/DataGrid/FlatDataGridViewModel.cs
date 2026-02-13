using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
using CommunityToolkit.Mvvm.ComponentModel;
using AccelerateDemo.Models;
using AccelerateDemo.Services;

namespace AccelerateDemo.ViewModels.DataGrid;

public partial class FlatDataGridViewModel : ViewModelBase
{
    private readonly ObservableCollection<Person> _allPeople;
    private ObservableCollection<Person> _filteredPeople;

    [ObservableProperty]
    private string _searchText = "";

    [ObservableProperty]
    private FlatTreeDataGridSource<Person> _source;

    public FlatDataGridViewModel()
    {
        _allPeople = SampleDataService.GetPeople();
        _filteredPeople = new ObservableCollection<Person>(_allPeople);
        _source = CreateSource(_filteredPeople);
    }

    partial void OnSearchTextChanged(string value)
    {
        _filteredPeople.Clear();

        var items = string.IsNullOrWhiteSpace(value)
            ? _allPeople
            : _allPeople.Where(p =>
                p.FirstName.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                p.LastName.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                p.Email.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                p.Department.Contains(value, StringComparison.OrdinalIgnoreCase));

        foreach (var item in items)
        {
            _filteredPeople.Add(item);
        }
    }

    private static FlatTreeDataGridSource<Person> CreateSource(ObservableCollection<Person> items)
    {
        var source = new FlatTreeDataGridSource<Person>(items)
        {
            Columns =
            {
                new TextColumn<Person, string>("First Name", x => x.FirstName, width: new GridLength(1, GridUnitType.Star)),
                new TextColumn<Person, string>("Last Name", x => x.LastName, width: new GridLength(1, GridUnitType.Star)),
                new TextColumn<Person, int>("Age", x => x.Age, width: new GridLength(80)),
                new TextColumn<Person, string>("Email", x => x.Email, width: new GridLength(1.5, GridUnitType.Star)),
                new TextColumn<Person, string>("Department", x => x.Department, width: new GridLength(1, GridUnitType.Star)),
            },
        };
        source.RowSelection!.SingleSelect = false;
        return source;
    }
}
