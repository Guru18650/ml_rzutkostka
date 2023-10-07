using Newtonsoft.Json;

namespace ml_rzutkostka;

public partial class Historia : ContentPage
{
	public Historia()
	{
		InitializeComponent();
		lv.ItemsSource = App.rzuty;
	}

    private void clr_Clicked(object sender, EventArgs e)
    {
		App.rzuty.Clear();
        Preferences.Set("dane", JsonConvert.SerializeObject(App.rzuty));

    }
}