

namespace ApiUnitWork
{
    using ApiRepositories;
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
        IUserRepository User { get; }
        ISupplierRepository Supplier { get; }
    }
}
