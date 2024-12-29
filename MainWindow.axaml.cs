using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MinhaAppAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void OnButtonClick(object? sender, RoutedEventArgs e)
    {
        var button = sender as Button;
        button!.Content = "Você clicou!";
    }
}