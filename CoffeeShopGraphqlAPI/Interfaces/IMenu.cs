using CoffeeShopGraphqlAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Interfaces
{
    public interface IMenu
    {

        List<Menu> GetMenus();

        Menu AddMenu(Menu menu);

       // Menu UpdateMenu(int id, Menu menu);

       // void DeleteMenu(int id);

       // Menu AddMenuById(int id);
    }
}
