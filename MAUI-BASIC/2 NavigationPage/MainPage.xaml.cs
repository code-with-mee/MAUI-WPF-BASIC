using _2_NavigationPage.Pages;

namespace _2_NavigationPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnNext_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }

}
