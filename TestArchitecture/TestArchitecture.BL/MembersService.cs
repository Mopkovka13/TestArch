using TestArchitecture.Core;
using TestArchitecture.Core.Repository;
using TestArchitecture.Core.Service;

namespace TestArchitecture.BL
{
    public class MembersService : IMembersService
    {
        private IMembersRepository _membersRepository;

        public MembersService(IMembersRepository membersRepository)
        {
            _membersRepository = membersRepository;
        }

        public async Task<int> Create(Member newMember)
        {
            if (newMember is null)
                throw new ArgumentNullException(nameof(newMember));

            if (newMember.Id != default)
                throw new ArgumentException("To create new member you shouldn't pass Id");

            if (string.IsNullOrWhiteSpace(newMember.Name))
                throw new ArgumentException("To create new member cannot be null or whitespace", nameof(newMember.Name));

            return await _membersRepository.Add(newMember);
        }
    }
}  
