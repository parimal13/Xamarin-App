using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDesign
{
    public partial class MainPage : ContentPage
    {
        private void NoticeIcon_Tapped(object sender, EventArgs e)
        {
            var page = new NoticePage();
            PlaceHolder.Content = page.Content;
        }

        private void ManageIcon_Tapped(object sender, EventArgs e)
        {
            var page = new ManagePage();
            PlaceHolder.Content = page.Content;
        }

        private void BuyIcon_Tapped(object sender, EventArgs e)
        {
            var page = new BuyPage();
            PlaceHolder.Content = page.Content;
        }

        private void OrderIcon_Tapped(object sender, EventArgs e)
        {
            var page = new OrderPage();
            PlaceHolder.Content = page.Content;

        }

        public MainPage()
        {
            InitializeComponent();
            //var page = new NoticePage();
            
            //PlaceHolder.Content = page.Content;
        }
    }
}
