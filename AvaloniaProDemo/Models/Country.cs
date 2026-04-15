using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaProDemo.Models;

public class Country : INotifyPropertyChanged
{
    private string _name = "";
    private string _capital = "";
    private long _population;
    private string _continent = "";
    private bool _isSelected;

    public string Name
    {
        get => _name;
        set { _name = value; OnPropertyChanged(); }
    }

    public string Capital
    {
        get => _capital;
        set { _capital = value; OnPropertyChanged(); }
    }

    public long Population
    {
        get => _population;
        set { _population = value; OnPropertyChanged(); }
    }

    public string Continent
    {
        get => _continent;
        set { _continent = value; OnPropertyChanged(); }
    }

    public bool IsSelected
    {
        get => _isSelected;
        set { _isSelected = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
