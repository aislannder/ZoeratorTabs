using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZoeratorTabs.Views;
using Xamarin.Forms;

namespace ZoeratorTabs
{
	public partial class App : Application
	{
		public App ()
		{
			
			//MainPage = new TabPage();
            MainPage = new NavigationPage(new TabPage());

        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
