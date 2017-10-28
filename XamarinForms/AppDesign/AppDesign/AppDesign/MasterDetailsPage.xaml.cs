using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDesign
{
    public partial class MasterDetailsPage : MasterDetailPage
    {
        public MasterDetailsPage()
        {
            InitializeComponent();

            masterPage.ListView.ItemSelected += OnItem_ItemSelected;

        }

        private void OnItem_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            Detail = new MainPage();

            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}