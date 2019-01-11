using App4.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTravelPage : ContentPage
	{
		public NewTravelPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            { 
                connection.CreateTable<Post>();
                int rows = connection.Insert(post);
                if (rows > 0)
                    DisplayAlert("Success", "Experience successfully inserted", "Ok");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "Ok");
            }

            
        }
    }
}