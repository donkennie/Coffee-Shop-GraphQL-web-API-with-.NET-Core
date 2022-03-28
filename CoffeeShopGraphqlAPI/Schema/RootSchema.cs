using CoffeeShopGraphqlAPI.Query;

using System;
using GraphQL.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CoffeeShopGraphqlAPI.Mutation;

namespace CoffeeShopGraphqlAPI.Schema
{
    public class RootSchema: GraphQL.Types.Schema 
    {
        public RootSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<RootQuery>();
            Mutation = provider.GetRequiredService<RootMutation>();
        }
       
        
    }
}
