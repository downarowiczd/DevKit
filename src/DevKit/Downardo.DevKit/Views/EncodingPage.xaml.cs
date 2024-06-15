using Downardo.DevKit.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Downardo.DevKit.Views;

public sealed partial class EncodingPage : Page
{
    public EncodingViewModel ViewModel
    {
        get;
    }

    public EncodingPage()
    {
        ViewModel = App.GetService<EncodingViewModel>();
        InitializeComponent();
    }
}
