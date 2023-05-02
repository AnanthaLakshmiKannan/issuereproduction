

namespace MauiApp3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Scrollv.ScrollToAsync(label20, ScrollToPosition.Start, true);
    }
}

