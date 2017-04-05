using System;

using Xamarin.Forms;

namespace Pages
{
	public class App : Application
	{
		public App()
		{
			//new MasterDetailPage()
			//MainPage = new NavigationPage(new MyNavigationPage());
			//MainPage = new MasterDeta()
			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
