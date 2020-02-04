

namespace ApiRepositories
{
    using ApiModels;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICustomerRepository:IRepository<Customer>
    {
        IEnumerable<Customer> CustomerPagedList(int page, int rows);
    }
}
