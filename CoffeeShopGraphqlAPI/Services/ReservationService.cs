using CoffeeShopGraphqlAPI.Data;
using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Services
{
    public class ReservationService : IReservation
    {
        private GraphQLDbContext _dbContext;

        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
           return _dbContext.Reservations.ToList();
        }
    }
}
