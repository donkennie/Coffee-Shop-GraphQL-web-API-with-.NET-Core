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
    public class ReservationQuery: ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservation", resolve: context => { return reservationService.GetReservations(); });

            

        }
    }
}
