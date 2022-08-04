
namespace TestArchitecture.Core.Service
{
    public interface IMembersService
    {
        Task<int> Create(Member newMember);
    }
}
