using Avalonia.Controls;
using Ursa.Controls;
using UrsaAvaloniaTest1.ViewModels;

namespace UrsaAvaloniaTest1.Views;

public partial class MainWindow : UrsaWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}