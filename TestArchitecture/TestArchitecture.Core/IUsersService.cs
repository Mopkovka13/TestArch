namespace TestArchitecture.Core
{
    public interface IUsersService
    {
        void Create(User user);
        User[] Get();
    }
}
