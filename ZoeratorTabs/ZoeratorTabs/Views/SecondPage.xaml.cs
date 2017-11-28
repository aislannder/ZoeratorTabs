using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZoeratorTabs.Common;

namespace ZoeratorTabs.Views
{
	
	public partial class SecondPage : ContentPage
	{
        public SecondPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        public void Facebook_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Constants.FacebookUrl));
        }
        public void Youtube_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Constants.YoutubeUrl));
        }
        public void Twitter_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(Constants.TwitterUrl));
        }
        public void Phone_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:+962799892728"));
        }
    }
}