using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Downardo.DevKit.ViewModels;

public partial class EncodingViewModel : ObservableRecipient
{
    public EncodingViewModel()
    {
    }

    public IList<EncodingModes> ViewEncodingModes => Enum.GetValues(typeof(EncodingModes)).Cast<EncodingModes>().ToList();
    private EncodingModes _viewEncodingMode = EncodingModes.FromTextToBase; // Default value

    public EncodingModes ViewEncodingMode
    {
        get => _viewEncodingMode;
        set
        {
            if (_viewEncodingMode != value)
            {
                _viewEncodingMode = value;
                Console.WriteLine($"ViewEncodingMode: {value}");
            }
        }
    }

    public enum EncodingModes
    {
        [Display(Name = "Encoding_FromTextToBase")]
        FromTextToBase,
        [Display(Name = "Encoding_FromBaseToText")]
        FromBaseToText,
    }
}

