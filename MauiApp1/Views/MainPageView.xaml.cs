using MauiApp1.ViewModels;
using System.Diagnostics;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    Stopwatch stopwatch = new Stopwatch();
    MainPageViewModel MainPageViewModel_Object = new MainPageViewModel();
    public MainPage()
	{
		InitializeComponent();
	}

    private void AddBtn_Clicked(object sender, EventArgs e)
    {
        stopwatch.Restart();
        lblResult.Text = MainPageViewModel_Object.Suma(A.Text, B.Text);
        lblSign.Text = "+";
        Timer.Text = "Time: " + (stopwatch.Elapsed * 1000).ToString(); 
        stopwatch.Stop();
    }

    private void SubtractBtn_Clicked(object sender, EventArgs e)
    {
        stopwatch.Restart();
        lblResult.Text = MainPageViewModel_Object.Resta(A.Text, B.Text);
        lblSign.Text =   "-";
        Timer.Text = "Time: " + (stopwatch.Elapsed * 1000).ToString();
        stopwatch.Stop();
    }
}

