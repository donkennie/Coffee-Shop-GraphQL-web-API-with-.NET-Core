using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Types
{
    public class MenuType: ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService) 
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("subMenu", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });

        }
    }
}
