using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ZoeratorTabs.Views
{
	
	public partial class FirstPage : ContentPage
	{

        List<ListViewCategory> Categorias;

        public FirstPage ()
		{
			InitializeComponent ();
            InitialiseList();
        }

        private void InitialiseList()
        {
            Categorias = new List<ListViewCategory>
            {
                new ListViewCategory
                {
                    Name = "Corno",
                    Content = "O conor é bixo doido"
                },
                new ListViewCategory
                {
                    Name = "bebados",
                    Content = "O bebado é bixo doido"
                },
                new ListViewCategory
                {
                    Name = "Papagaio",
                    Content = "O papagaio é bixo doido"
                },
                new ListViewCategory
                {
                    Name = "Português",
                    Content = "O português é bixo doido"
                }
            };

            listaCategorias.ItemsSource = Categorias;
            listaCategorias.ItemTapped += ListaCategoriasSelecionado;
        }

        private void ListaCategoriasSelecionado(object sender, ItemTappedEventArgs e)
        {
            ListViewCategory category = (ListViewCategory)e.Item;
            Navigation.PushAsync(new JokeContent(category));
        }

        public class ListViewCategory
        {
            public string Name { get; set; }
            public string Content { get; set; }
        }
    }
}