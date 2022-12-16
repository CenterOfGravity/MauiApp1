using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    MainPageViewModel MainPageViewModel_Object = new MainPageViewModel();
    public MainPage()
	{
		InitializeComponent();
	}

    private void AddBtn_Clicked(object sender, EventArgs e)
    {
        lblResult.Text = MainPageViewModel_Object.Suma(A.Text, B.Text);
        lblSign.Text = "+";
    }

    private void SubtractBtn_Clicked(object sender, EventArgs e)
    {
        lblResult.Text = MainPageViewModel_Object.Resta(A.Text, B.Text);
        lblSign.Text = "-";
    }
}

