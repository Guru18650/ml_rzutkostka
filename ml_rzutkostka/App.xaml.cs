using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace ml_rzutkostka
{
    public partial class App : Application
    {
        public static ObservableCollection<int> rzuty = new ObservableCollection<int>();
        public App()
        {
            InitializeComponent();
            rzuty = JsonConvert.DeserializeObject<ObservableCollection<int>>(Preferences.Get("dane", "[]"));

            MainPage = new AppShell();
        }
    }
}