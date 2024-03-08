using CommunityToolkit.Maui.Views;

namespace MauiApp4;

public partial class MessagePopup : Popup
{
    public MessagePopup()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var popup = new Popup();
        popup.Size = new Size(200, 300);
        popup.Color = Colors.Red;
        popup.Content = new Label { Text = "Second Popup - Hi" };
        await App.Current.MainPage.ShowPopupAsync(popup);
    }
}