using CoffeeShopGraphqlAPI.Data;
using CoffeeShopGraphqlAPI.Interfaces;
using CoffeeShopGraphqlAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopGraphqlAPI.Services
{
    public class MenuService : IMenu
    {

        private GraphQLDbContext _dbContext;

        public MenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Menu AddMenu(Menu menu)
        {
            _dbContext.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        /*public List<Menu> GetMenus()
        {
            throw new NotImplementedException();
        }*/

        /* public Menu AddMenuById(int id)
         {
             throw new NotImplementedException();
         }*/

        /*public void DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }*/

        public List<Menu> GetMenus()
        {
            return _dbContext.Menus.ToList();
        }

      /*  public Menu UpdateMenu(int id, Menu menu)
        {
            throw new NotImplementedException();
        }*/
    }
}
