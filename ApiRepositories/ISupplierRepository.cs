

namespace ApiRepositories
{
    using ApiModels;
    using System.Collections.Generic;

    public interface ISupplierRepository:IRepository<Supplier>
    {
        IEnumerable<Supplier> SupplierPagedList(int page, int rows);
    }
}
