using Downardo.DevKit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Downardo.DevKit.Views;

public sealed partial class HomePage : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public HomePage()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
