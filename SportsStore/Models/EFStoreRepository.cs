using System.Linq;

namespace SportsStore.Models;
public class EFStoreRepository : IStoreRepository
{
    private StoreDbContext context;

    public EFStoreRepository(StoreDbContext ctx)
    {
        context =  ctx;
    }
    public IQueryable<Product> Products => context.Products;
}
// The Products property in the context class returns a DbSet<Product> object, 
// which implements the IQueryable<T> interface and makes it easy
// to implement the repository interface when using Entity Framework Core.