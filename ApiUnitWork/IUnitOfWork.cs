using ApiRepositories;

namespace ApiUnitWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
    }
}
