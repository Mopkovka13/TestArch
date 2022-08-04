using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArchitecture.Core.Repository
{
    public interface IHomeworksRepository
    {
        Task<int> Add(Homework newHomework);
        Task Update(Homework homework);
        Task Delete(int homeworkId);
        Task<List<Homework>> GetAll();
        Task<Homework> Get(int homeworkId);
    }
}
