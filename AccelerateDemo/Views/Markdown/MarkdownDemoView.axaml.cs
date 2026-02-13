using System;
using Avalonia.Controls;
using Avalonia.Styling;
using TextMateSharp.Grammars;

namespace AccelerateDemo.Views.Markdown;

public partial class MarkdownDemoView : UserControl
{
    public MarkdownDemoView()
    {
        InitializeComponent();
        ActualThemeVariantChanged += OnActualThemeVariantChanged;
        UpdateHighlighterTheme();
    }

    private void OnActualThemeVariantChanged(object? sender, EventArgs e)
    {
        UpdateHighlighterTheme();
    }

    private void UpdateHighlighterTheme()
    {
        if (Resources.TryGetResource("textMateHighlighter", ActualThemeVariant, out var resource)
            && resource is Avalonia.Controls.TextMateHighlighter highlighter)
        {
            highlighter.Theme = ActualThemeVariant == ThemeVariant.Dark ? ThemeName.DarkPlus : ThemeName.LightPlus;
        }
    }
}
