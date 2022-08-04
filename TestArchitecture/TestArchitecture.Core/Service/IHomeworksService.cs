using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArchitecture.Core.Service
{
    public interface IHomeworksService
    {
        Task<int> Create(Homework homework);
        Task<bool> Delete(int homeworkId);
        //Homework[] Get();
    }
}
