using System.Collections.Generic;

using Xamarin.Forms;

namespace MKSample
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public static IDictionary<string, string> LoginParameters => null;

        public App()
        {
            InitializeComponent();

  
            SetMainPage();
        }

        public static void SetMainPage()
        {
            GoToMainPage();
        }

        public static void GoToMainPage()
        {
            Current.MainPage = new Views.MyPage();
        }
    }
}
