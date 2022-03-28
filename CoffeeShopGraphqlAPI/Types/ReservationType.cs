using CoffeeShopGraphqlAPI.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Types
{
    public class ReservationType: ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(r => r.Id);
            Field(r => r.Name);
            Field(r => r.Phone);
            Field(r => r.Time);
            Field(r => r.TotalPeople);
            Field(r => r.Date);
            Field(r => r.Email); 

        }
    }
}
