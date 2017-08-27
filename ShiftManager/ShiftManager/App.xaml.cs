using ShiftManager.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShiftManager
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

        public static void SetMainPage() => Current.MainPage = new TabbedPage
        {
            Children =
                {
                    new NavigationPage(new CalendarPage())
                    {
                        Title = "Shift",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Work",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                    new NavigationPage(new SalaryHistory())
                    {
                        Title = "Salary",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                    new NavigationPage(new Feedback())
                    {
                        Title = "Feedback",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                    new NavigationPage(new Settings())
                    {
                        Title = "Settings",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                }
        };
    }
}
