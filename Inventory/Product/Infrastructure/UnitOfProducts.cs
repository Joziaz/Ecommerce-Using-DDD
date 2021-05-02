using api.Inventory.Domain;

namespace api.Products.Infrastructure.Persistance
{
    public class UnitOfProducts : UnitOfWork
    {
        public readonly IProductRepository ProductRepository;
        public readonly IStockRepository StockRepository;
        
    }
}