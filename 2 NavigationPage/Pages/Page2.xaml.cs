namespace _2_NavigationPage.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void btnNext_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}