using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class MainPageViewModel 
    {
        [ObservableProperty]
        string a;

        [ObservableProperty]
        string b;

        [ObservableProperty]
        string lbLSign = "+";

        [ObservableProperty]
        string result;

        [RelayCommand]
        void AddBtn()
        {
            LbLSign = "+";
            Result = (Int64.Parse(a) + Int64.Parse(b)).ToString();
        }

        [RelayCommand]
        void SubtractBtn()
        {
            LbLSign = "-";
            Result = (Int64.Parse(a) - Int64.Parse(b)).ToString();
        }


    }
}
