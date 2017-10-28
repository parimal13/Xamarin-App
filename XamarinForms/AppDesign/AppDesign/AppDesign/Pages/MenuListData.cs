using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesign.Pages
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            
            this.Add(new MenuItem()
            {
                Icon = "ic_home_black_24dp.png",
                Title = "Home",
                TargetType = typeof(MainPage)
            });

            this.Add(new MenuItem() {
                Icon = "ic_notifications_black_24dp.png",
                Title = "Notice",
                TargetType = typeof(NoticePage)
            });

            this.Add(new MenuItem()
            {
                Icon = "ic_menu_black_24dp.png",
                Title = "Mange",
                TargetType = typeof(ManagePage)
            });
        }
    }
}
