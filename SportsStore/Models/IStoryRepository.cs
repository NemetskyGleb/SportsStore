using System.Linq;

namespace SportsStore.Models;

public interface IStoreRepository 
{
    IQueryable<Product> Products { get; }
}
// This interface uses IQueryable<T> to allow a caller to obtain a sequence of Product objects.
// The IQueryable<T> interface is derived from the more familiar IEnumerable<T> interface 
// and represents a collection of objects that can be queried, such as those managed by a database.
