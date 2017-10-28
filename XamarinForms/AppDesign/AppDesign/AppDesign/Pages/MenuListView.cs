using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDesign.Pages
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(MenuCells));
            cell.SetBinding(MenuCells.TextProperty, "Title");
            cell.SetBinding(ImageCell.ImageSourceProperty, new Binding("Icon", BindingMode.OneWay));
            ItemTemplate = cell;
        }
    }
}
