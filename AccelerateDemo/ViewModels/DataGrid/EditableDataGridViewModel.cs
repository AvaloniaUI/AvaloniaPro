using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
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
        {
            Columns =
            {
                new CheckBoxColumn<Country>("", x => x.IsSelected, (o, v) => o.IsSelected = v, width: new GridLength(40)),
                new TextColumn<Country, string>("Country", x => x.Name, (r, v) => r.Name = v ?? "", width: new GridLength(1, GridUnitType.Star),
                    options: new TextColumnOptions<Country> { BeginEditGestures = BeginEditGestures.Tap }),
                new TextColumn<Country, string>("Capital", x => x.Capital, (r, v) => r.Capital = v ?? "", width: new GridLength(1, GridUnitType.Star),
                    options: new TextColumnOptions<Country> { BeginEditGestures = BeginEditGestures.Tap }),
                new TextColumn<Country, long>("Population", x => x.Population, (r, v) => r.Population = v, width: new GridLength(120),
                    options: new TextColumnOptions<Country> { BeginEditGestures = BeginEditGestures.Tap }),
                new TextColumn<Country, string>("Continent", x => x.Continent, (r, v) => r.Continent = v ?? "", width: new GridLength(1, GridUnitType.Star),
                    options: new TextColumnOptions<Country> { BeginEditGestures = BeginEditGestures.Tap }),
            },
        };
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
