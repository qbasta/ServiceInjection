using ServiceInjection.Data;
using ServiceInjection.Interfaces;
using ServiceInjection.Models;

namespace ServiceInjection.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PeopleContext _context;
        public UserRepository(PeopleContext context)
        {
            _context = context;
        }

        public void Insert(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public IQueryable<User> GetPeople()
        {
            return _context.User;
        }

        public IQueryable<User> GetTodayPeople()
        {
            return _context.User.Where(p => p.CreatedTime.Date == DateTime.Now.Date);
        }
    }
}
