using CommunityToolkit.Maui.Views;

namespace PopupPickers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public void DisplayPopup(object sender, EventArgs e)
        {
            var popup = new PopupWithPicker();
            this.ShowPopup(popup);
        }
    }
}