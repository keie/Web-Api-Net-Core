

namespace ApiRepositories
{
    using ApiModels;
    public interface IUserRepository:IRepository<User> 
    {
        User ValidateUser(string email, string password); //lo que ejecutara el sp
    }
}
