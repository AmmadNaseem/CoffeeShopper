using API.Models;

namespace API.Services
{
    public interface ICoffeeShopService
    {
        Task<List<CoffeShopModel>> List();
    }
}
