using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeShopService:ICoffeeShopService
    {
        private readonly ApplicationDbContext dbContext;

        public CoffeShopService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<List<CoffeShopModel>> List()
        {
            var coffeeShops= await (from shop in dbContext.CoffeeShops
                                    select new CoffeShopModel()
                                    {
                                        Id= shop.Id,
                                        Name= shop.Name,
                                        OpeningHours= shop.OpeningHours,
                                        Address= shop.Address
                                    }).ToListAsync();
            return coffeeShops;
        }
    }
}
