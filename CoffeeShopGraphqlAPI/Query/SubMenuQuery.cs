using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Query
{
    public class SubMenuQuery: ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("subMenu", resolve: context => { return subMenuService.GetSubMenus(); });

            Field<SubMenuType>("subMenuById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),

                resolve: context =>
                {
                    return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
                });

        }
    }
}
