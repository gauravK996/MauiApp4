using CommunityToolkit.Maui.Views;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var popup = new MessagePopup();
            await this.ShowPopupAsync(popup);

        }
    }

}
