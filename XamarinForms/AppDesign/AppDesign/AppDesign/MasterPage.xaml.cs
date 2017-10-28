using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();
            
            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HomePage",
                IconSource = "ic_home_black_18dp.png",
                TargetType = typeof(MainPage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Notice",
                IconSource = "ic_notifications_black_24dp.png",
                TargetType = typeof(NoticePage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "Manage",
                IconSource = "ic_settings_black_24dp.png",
                TargetType = typeof(ManagePage)
            });

            listView.ItemsSource = masterPageItem;
        }
    }
}