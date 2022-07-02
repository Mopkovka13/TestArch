using TestArchitecture.Core;

namespace TestArchitecture.DA
{
    public class UsersRepository : IUsersRepository
    {
        public void Create(Core.User user)
        {
            throw new NotImplementedException();
        }

        public Core.User[] Get()
        {
			var user = new User
			{
				Id = 1,
				Age = 43,
				Name = "Test"
			};

			return new[] {
				new Core.User
				{
					Name = user.Name,
					Age = user.Age
				}
			};
		}
    }
}