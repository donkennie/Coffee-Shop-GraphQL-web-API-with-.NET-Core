using CoffeeShopGraphqlAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Interfaces
{
    public interface ISubMenu
    {

        List<SubMenu> GetSubMenus();

        List<SubMenu> GetSubMenus(int Id);

        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
