using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiApp1.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class MainPageViewModel 
    {
        Stopwatch stopwatch = new Stopwatch();

        [ObservableProperty]
        string a;

        [ObservableProperty]
        string b;

        [ObservableProperty]
        string lbLSign = "+";

        [ObservableProperty]
        string result;

        [ObservableProperty]
        string timer;

        [RelayCommand]
        void AddBtn()
        {
            stopwatch.Restart();
            LbLSign = "+";
            Result = (Int64.Parse(a) + Int64.Parse(b)).ToString();
            Timer = (stopwatch.Elapsed*1000).ToString();
            stopwatch.Stop();
        }

        [RelayCommand]
        void SubtractBtn()
        {
            stopwatch.Restart();
            LbLSign = "-";
            Result = (Int64.Parse(a) - Int64.Parse(b)).ToString();
            Timer = (stopwatch.Elapsed * 1000).ToString();
            stopwatch.Stop();
        }


    }
}
