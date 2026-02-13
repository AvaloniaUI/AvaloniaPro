using System;
using System.Collections.ObjectModel;
using AccelerateDemo.Models;

namespace AccelerateDemo.Services;

public static class SampleDataService
{
    public static ObservableCollection<Person> GetPeople()
    {
        return new ObservableCollection<Person>
        {
            new() { FirstName = "Eleanor", LastName = "Pope", Age = 32, Email = "eleanor.pope@example.com", Department = "Engineering" },
            new() { FirstName = "Jeremy", LastName = "Navarro", Age = 74, Email = "jeremy.n@example.com", Department = "Management" },
            new() { FirstName = "Lailah", LastName = "Velazquez", Age = 16, Email = "lailah.v@example.com", Department = "Intern" },
            new() { FirstName = "Jazmine", LastName = "Schroeder", Age = 52, Email = "jazmine.s@example.com", Department = "Design" },
            new() { FirstName = "Marcus", LastName = "Chen", Age = 28, Email = "marcus.c@example.com", Department = "Engineering" },
            new() { FirstName = "Sophia", LastName = "Williams", Age = 41, Email = "sophia.w@example.com", Department = "Marketing" },
            new() { FirstName = "Ethan", LastName = "Brown", Age = 35, Email = "ethan.b@example.com", Department = "Engineering" },
            new() { FirstName = "Olivia", LastName = "Martinez", Age = 29, Email = "olivia.m@example.com", Department = "Design" },
            new() { FirstName = "Noah", LastName = "Johnson", Age = 45, Email = "noah.j@example.com", Department = "Management" },
            new() { FirstName = "Emma", LastName = "Davis", Age = 38, Email = "emma.d@example.com", Department = "Marketing" },
            new() { FirstName = "Liam", LastName = "Garcia", Age = 55, Email = "liam.g@example.com", Department = "Engineering" },
            new() { FirstName = "Ava", LastName = "Rodriguez", Age = 23, Email = "ava.r@example.com", Department = "Design" },
            new() { FirstName = "William", LastName = "Lee", Age = 61, Email = "william.l@example.com", Department = "Management" },
            new() { FirstName = "Isabella", LastName = "Walker", Age = 33, Email = "isabella.w@example.com", Department = "Marketing" },
            new() { FirstName = "James", LastName = "Hall", Age = 27, Email = "james.h@example.com", Department = "Engineering" },
            new() { FirstName = "Mia", LastName = "Allen", Age = 44, Email = "mia.a@example.com", Department = "Design" },
            new() { FirstName = "Benjamin", LastName = "Young", Age = 36, Email = "benjamin.y@example.com", Department = "Engineering" },
            new() { FirstName = "Charlotte", LastName = "King", Age = 50, Email = "charlotte.k@example.com", Department = "Management" },
            new() { FirstName = "Lucas", LastName = "Wright", Age = 22, Email = "lucas.w@example.com", Department = "Intern" },
            new() { FirstName = "Amelia", LastName = "Scott", Age = 39, Email = "amelia.s@example.com", Department = "Marketing" },
        };
    }

    public static ObservableCollection<FileSystemNode> GetFileSystem()
    {
        return new ObservableCollection<FileSystemNode>
        {
            new()
            {
                Name = "Models", IsFolder = true, Modified = new DateTime(2025, 1, 15),
                Children =
                {
                    new() { Name = "Person.cs", Size = 1024, Modified = new DateTime(2025, 1, 10) },
                    new() { Name = "Country.cs", Size = 896, Modified = new DateTime(2025, 1, 12) },
                    new() { Name = "FileSystemNode.cs", Size = 1280, Modified = new DateTime(2025, 1, 14) },
                }
            },
            new()
            {
                Name = "ViewModels", IsFolder = true, Modified = new DateTime(2025, 1, 16),
                Children =
                {
                    new()
                    {
                        Name = "DataGrid", IsFolder = true, Modified = new DateTime(2025, 1, 16),
                        Children =
                        {
                            new() { Name = "FlatDataGridViewModel.cs", Size = 3072, Modified = new DateTime(2025, 1, 14) },
                            new() { Name = "HierarchicalDataGridViewModel.cs", Size = 2560, Modified = new DateTime(2025, 1, 16) },
                            new() { Name = "EditableDataGridViewModel.cs", Size = 3584, Modified = new DateTime(2025, 1, 13) },
                        }
                    },
                    new() { Name = "MainWindowViewModel.cs", Size = 2048, Modified = new DateTime(2025, 1, 15) },
                    new() { Name = "ViewModelBase.cs", Size = 512, Modified = new DateTime(2025, 1, 2) },
                }
            },
            new()
            {
                Name = "Views", IsFolder = true, Modified = new DateTime(2025, 1, 16),
                Children =
                {
                    new()
                    {
                        Name = "DataGrid", IsFolder = true, Modified = new DateTime(2025, 1, 16),
                        Children =
                        {
                            new() { Name = "FlatDataGridView.axaml", Size = 2048, Modified = new DateTime(2025, 1, 14) },
                            new() { Name = "FlatDataGridView.axaml.cs", Size = 384, Modified = new DateTime(2025, 1, 14) },
                            new() { Name = "HierarchicalDataGridView.axaml", Size = 2304, Modified = new DateTime(2025, 1, 16) },
                            new() { Name = "HierarchicalDataGridView.axaml.cs", Size = 384, Modified = new DateTime(2025, 1, 16) },
                            new() { Name = "EditableDataGridView.axaml", Size = 1792, Modified = new DateTime(2025, 1, 13) },
                            new() { Name = "EditableDataGridView.axaml.cs", Size = 384, Modified = new DateTime(2025, 1, 13) },
                        }
                    },
                    new() { Name = "MainWindow.axaml", Size = 1536, Modified = new DateTime(2025, 1, 15) },
                    new() { Name = "MainWindow.axaml.cs", Size = 512, Modified = new DateTime(2025, 1, 15) },
                }
            },
            new()
            {
                Name = "Services", IsFolder = true, Modified = new DateTime(2025, 1, 13),
                Children =
                {
                    new() { Name = "SampleDataService.cs", Size = 5120, Modified = new DateTime(2025, 1, 13) },
                    new() { Name = "NavigationService.cs", Size = 2048, Modified = new DateTime(2025, 1, 11) },
                }
            },
            new()
            {
                Name = "Assets", IsFolder = true, Modified = new DateTime(2025, 1, 5),
                Children =
                {
                    new() { Name = "avalonia-logo.ico", Size = 15360, Modified = new DateTime(2025, 1, 2) },
                    new() { Name = "Styles.axaml", Size = 4096, Modified = new DateTime(2025, 1, 5) },
                }
            },
            new() { Name = "App.axaml", Size = 1024, Modified = new DateTime(2025, 1, 15) },
            new() { Name = "App.axaml.cs", Size = 768, Modified = new DateTime(2025, 1, 15) },
            new() { Name = "Program.cs", Size = 384, Modified = new DateTime(2025, 1, 2) },
            new() { Name = "AccelerateDemo.csproj", Size = 640, Modified = new DateTime(2025, 1, 10) },
        };
    }

    public static ObservableCollection<Country> GetCountries()
    {
        return new ObservableCollection<Country>
        {
            new() { Name = "United States", Capital = "Washington, D.C.", Population = 331_900_000, Continent = "North America" },
            new() { Name = "Canada", Capital = "Ottawa", Population = 38_250_000, Continent = "North America" },
            new() { Name = "Mexico", Capital = "Mexico City", Population = 128_900_000, Continent = "North America" },
            new() { Name = "Brazil", Capital = "Brasilia", Population = 214_000_000, Continent = "South America" },
            new() { Name = "United Kingdom", Capital = "London", Population = 67_890_000, Continent = "Europe" },
            new() { Name = "Germany", Capital = "Berlin", Population = 83_240_000, Continent = "Europe" },
            new() { Name = "France", Capital = "Paris", Population = 67_750_000, Continent = "Europe" },
            new() { Name = "Japan", Capital = "Tokyo", Population = 125_700_000, Continent = "Asia" },
            new() { Name = "Australia", Capital = "Canberra", Population = 25_690_000, Continent = "Oceania" },
            new() { Name = "India", Capital = "New Delhi", Population = 1_408_000_000, Continent = "Asia" },
            new() { Name = "South Korea", Capital = "Seoul", Population = 51_740_000, Continent = "Asia" },
            new() { Name = "Italy", Capital = "Rome", Population = 59_550_000, Continent = "Europe" },
        };
    }

    public const string SampleMarkdownReadme = """
        # Avalonia Accelerate

        **Avalonia Accelerate** is a suite of premium components for building professional
        desktop, mobile, and web applications with [Avalonia UI](https://avaloniaui.net/).

        ## Features

        - **TreeDataGrid** - High-performance data grid with hierarchical support
        - **Markdown** - Native Markdown rendering with syntax highlighting
        - **MediaPlayer** - Cross-platform audio and video playback
        - **VirtualKeyboard** - On-screen keyboard for touch/kiosk scenarios
        - **WebView** - Embedded native web browser

        ## Getting Started

        ```bash
        dotnet add package Avalonia.Controls.TreeDataGrid
        dotnet add package Avalonia.Controls.Markdown
        dotnet add package Avalonia.Controls.MediaPlayer
        dotnet add package Avalonia.Controls.VirtualKeyboard
        dotnet add package Avalonia.Controls.WebView
        ```

        ## Quick Example

        ```xml
        <TreeDataGrid Source="{Binding Source}" />
        ```

        ```csharp
        var source = new FlatTreeDataGridSource<Person>(people)
        {
            Columns =
            {
                new TextColumn<Person, string>("Name", x => x.Name),
                new TextColumn<Person, int>("Age", x => x.Age),
            }
        };
        ```

        ## License

        Avalonia Accelerate requires a valid license key. Visit [avaloniaui.net](https://avaloniaui.net/)
        for pricing and licensing information.

        > **Note:** A free trial is available for evaluation purposes.
        """;

    public const string SampleMarkdownFeatures = """
        # Markdown Features Demo

        ## Text Formatting

        This is **bold text**, *italic text*, and ~~strikethrough text~~.
        You can also combine **_bold and italic_** together.

        ## Lists

        ### Unordered
        - First item
        - Second item
          - Nested item A
          - Nested item B
        - Third item

        ### Ordered
        1. Step one
        2. Step two
        3. Step three

        ## Blockquotes

        > This is a blockquote.
        > It can span multiple lines.
        >
        > > And even be nested!

        ## Tables

        | Component | Platform | Status |
        |-----------|----------|--------|
        | TreeDataGrid | All | Stable |
        | Markdown | All | Stable |
        | WebView | Desktop | Stable |
        | MediaPlayer | All | Stable |

        ## Alert Blocks

        > [!NOTE]
        > This is a note alert block.

        > [!TIP]
        > This is a helpful tip for users.

        > [!WARNING]
        > This is a warning that needs attention.

        ## Links and Images

        Visit [Avalonia UI](https://avaloniaui.net/) for more information.

        ## Horizontal Rule

        ---

        *End of features demo*
        """;

    public const string SampleMarkdownCode = """
        # Code Examples

        ## Inline Code

        Use `dotnet build` to compile your project.

        ## C# Example

        ```csharp
        public class MainViewModel : ViewModelBase
        {
            private string _greeting = "Hello, World!";

            public string Greeting
            {
                get => _greeting;
                set => SetProperty(ref _greeting, value);
            }

            public void UpdateGreeting(string name)
            {
                Greeting = $"Hello, {name}!";
            }
        }
        ```

        ## XAML Example

        ```xml
        <Window xmlns="https://github.com/avaloniaui"
                xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
            <StackPanel Margin="20">
                <TextBlock Text="{Binding Greeting}"
                           FontSize="24"
                           FontWeight="Bold"/>
                <Button Content="Click Me"
                        Command="{Binding UpdateCommand}"/>
            </StackPanel>
        </Window>
        ```

        ## JSON Configuration

        ```json
        {
            "name": "my-avalonia-app",
            "version": "1.0.0",
            "dependencies": {
                "Avalonia": "11.3.11",
                "Avalonia.Controls.TreeDataGrid": "11.2.3"
            }
        }
        ```
        """;
}
