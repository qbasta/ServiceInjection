using ServiceInjection.Models;
using ServiceInjection.ViewModels.User;

namespace ServiceInjection.Interfaces
{
    public interface IUserService
    {
        void Insert(User user);
        ListUserViewModel GetPeople();
        ListUserViewModel GetTodayPeople();
    }
}
