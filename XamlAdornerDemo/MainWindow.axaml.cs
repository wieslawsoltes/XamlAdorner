using Avalonia.Controls;
using Avalonia.Interactivity;
using XamlAdorner;

namespace XamlAdornerDemo;

public partial class MainWindow : Window
{
    private Control? _adorner;

    public MainWindow()
    {
        InitializeComponent();
    }
        
    private void RemoveAdorner_OnClick(object? sender, RoutedEventArgs e)
    {
        var adornerButton = this.FindControl<Button>("AdornerButton");
        if (adornerButton is { })
        {
            var adorner = XamlAdornerLayer.GetAdorner(adornerButton);
            if (adorner is { })
            {
                _adorner = adorner;
            }
            XamlAdornerLayer.SetAdorner(adornerButton, null);
        }
    }

    private void AddAdorner_OnClick(object? sender, RoutedEventArgs e)
    {
        var adornerButton = this.FindControl<Button>("AdornerButton");
        if (adornerButton is { })
        {
            if (_adorner is { })
            {
                XamlAdornerLayer.SetAdorner(adornerButton, _adorner);
            }
        }
    }
}
