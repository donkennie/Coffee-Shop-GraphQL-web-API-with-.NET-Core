using CoffeeShopGraphqlAPI.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Types
{
    public class SubMenuType: ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(s => s.Id);
            Field(s => s.ImageUrl);
            Field(s => s.MenuId);
            Field(s => s.Name);
            Field(s => s.Price);
            Field(s => s.Description);

        }
    }
}
