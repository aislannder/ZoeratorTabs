using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZoeratorTabs.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class JokeContent : ContentPage
	{
		public JokeContent (FirstPage.ListViewCategory content)
		{
			InitializeComponent ();
            conteudoPiada.Text = content.Content;
        }
	}
}