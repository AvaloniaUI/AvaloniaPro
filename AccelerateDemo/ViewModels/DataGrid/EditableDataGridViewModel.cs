using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using AccelerateDemo.Models;
using AccelerateDemo.Services;

namespace AccelerateDemo.ViewModels.DataGrid;

public partial class EditableDataGridViewModel : ViewModelBase
{
    private readonly ObservableCollection<Country> _countries;

    public FlatTreeDataGridSource<Country> Source { get; }

    public EditableDataGridViewModel()
    {
        _countries = SampleDataService.GetCountries();

        Source = new FlatTreeDataGridSource<Country>(_countries)
            .WithCheckBoxColumn(x => x.IsSelected, o => o.Width = new GridLength(40))
            .WithTextColumn("Country", x => x.Name, o =>
            {
                o.Width = new GridLength(1, GridUnitType.Star);
                o.BeginEditGestures = BeginEditGestures.Tap;
            })
            .WithTextColumn("Capital", x => x.Capital, o =>
            {
                o.Width = new GridLength(1, GridUnitType.Star);
                o.BeginEditGestures = BeginEditGestures.Tap;
            })
            .WithTextColumn("Population", x => x.Population, o =>
            {
                o.Width = new GridLength(120);
                o.BeginEditGestures = BeginEditGestures.Tap;
            })
            .WithTextColumn("Continent", x => x.Continent, o =>
            {
                o.Width = new GridLength(1, GridUnitType.Star);
                o.BeginEditGestures = BeginEditGestures.Tap;
            });
    }

    [RelayCommand]
    private void AddRow()
    {
        _countries.Add(new Country
        {
            Name = "New Country",
            Capital = "Capital",
            Population = 0,
            Continent = "Unknown"
        });
    }

    [RelayCommand]
    private void RemoveSelected()
    {
        var toRemove = _countries.Where(c => c.IsSelected).ToList();
        foreach (var country in toRemove)
        {
            _countries.Remove(country);
        }
    }
}
