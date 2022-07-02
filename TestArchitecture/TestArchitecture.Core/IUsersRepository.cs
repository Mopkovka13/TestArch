using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArchitecture.Core
{
    public interface IUsersRepository
    {
        void Create(User user);
        User[] Get();
    }
}
