using Newtonsoft.Json;
using System.Threading;

namespace ml_rzutkostka
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 6);
            btnn.IsEnabled = false;
            animatedImage.Source = $"d{i}.gif";
            animatedImage.IsAnimationPlaying = true;
            await Task.Delay(6000);
            animatedImage.IsAnimationPlaying = false;
            btnn.IsEnabled = true;
            App.rzuty.Add(i);
            Preferences.Set("dane", JsonConvert.SerializeObject(App.rzuty));

        }
    }
}