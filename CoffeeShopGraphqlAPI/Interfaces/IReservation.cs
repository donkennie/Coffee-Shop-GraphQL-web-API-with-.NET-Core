using CoffeeShopGraphqlAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Interfaces
{
    public interface IReservation
    {

        List<Reservation> GetReservations();

        Reservation AddReservation(Reservation reservation);
    }
}
