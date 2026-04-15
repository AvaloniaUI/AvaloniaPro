using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
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
            .WithTextColumn("First Name", x => x.FirstName, options: o => o.Width = new GridLength(1, GridUnitType.Star))
            .WithTextColumn("Last Name", x => x.LastName, options: o => o.Width = new GridLength(1, GridUnitType.Star))
            .WithTextColumn("Age", x => x.Age, options: o => o.Width = new GridLength(80))
            .WithTextColumn("Email", x => x.Email, options: o => o.Width = new GridLength(1.5, GridUnitType.Star))
            .WithTextColumn("Department", x => x.Department, options: o => o.Width = new GridLength(1, GridUnitType.Star));
        source.RowSelection!.SingleSelect = false;
        return source;
    }
}
