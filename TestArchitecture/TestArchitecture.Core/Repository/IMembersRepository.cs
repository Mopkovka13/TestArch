using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArchitecture.Core.Repository
{
    public interface IMembersRepository
    {
        Task<int> Add(Member newMember);
    }
}
