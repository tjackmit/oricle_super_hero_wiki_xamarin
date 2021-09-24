using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace oricle_super_hero_wiki
{
    public partial class MainPage : ContentPage
    {
        string searchValue = "";

        public MainPage()
        {
            InitializeComponent();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Console.WriteLine("Search button pressed....");

            if (searchValue != "")
            {
                Console.WriteLine("searchValue: " + searchValue);

                if (IsDigitsOnly(searchValue))
                {
                    Console.WriteLine("search for single result....");
                }

                else
                {
                    Console.WriteLine("search for multiple results....");
                }

            }
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var oldText = e.OldTextValue;
            //Console.WriteLine("oldText: " + oldText);
            //var newText = e.NewTextValue;
            //Console.WriteLine("newText: " + newText);
            searchValue = e.NewTextValue;
        }
    }
}
