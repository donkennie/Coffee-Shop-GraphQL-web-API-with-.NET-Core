using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Model;
using CoffeeShopGraphqlAPI.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Mutation
{
    public class SubMenuMutation :ObjectGraphType
    {

        public SubMenuMutation(ISubMenu subMenuService)
        {


            Field<SubMenuType>("CreateSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),

                   resolve: context =>
                   {
                       return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
                   });

        }
    }
}
