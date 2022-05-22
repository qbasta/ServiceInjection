using ServiceInjection.Models;

namespace ServiceInjection.Interfaces
{
    public interface IUserRepository
    {
        void Insert(User user);
        IQueryable<User> GetPeople();
        IQueryable<User> GetTodayPeople();
    }
}
