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
    public class ReservationMutation : ObjectGraphType
    {

        public ReservationMutation(IReservation reservationService)
        {


            Field<ReservationType>("CreateReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),

                   resolve: context =>
                   {
                       return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
                   });

        }
    }
}
