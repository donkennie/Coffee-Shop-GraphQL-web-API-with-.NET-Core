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
    public class MenuMutation :ObjectGraphType
    {

        public MenuMutation(IMenu menuService)
        {


            Field<MenuType>("CreateMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),

                   resolve: context =>
                   {
                       return menuService.AddMenu(context.GetArgument<Menu>("menu"));
                   });

        }
    }
}
