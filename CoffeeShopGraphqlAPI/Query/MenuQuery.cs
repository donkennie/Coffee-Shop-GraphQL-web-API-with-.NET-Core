using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Query
{
    public class MenuQuery: ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menu", resolve: context => { return menuService.GetMenus(); });

        }
    }
}
