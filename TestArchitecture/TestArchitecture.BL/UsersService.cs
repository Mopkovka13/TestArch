using TestArchitecture.Core;

namespace TestArchitecture.BL
{
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Create(User user)
        {
            
        }

        public User[] Get()
        {
            var users = _usersRepository.Get();
            return users;
        }
    }
}