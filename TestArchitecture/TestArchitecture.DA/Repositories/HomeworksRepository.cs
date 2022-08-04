using TestArchitecture.Core.Repository;

namespace TestArchitecture.DA.Repositories
{
    public class HomeworksRepository : IHomeworksRepository
    {
        public async Task<int> Add(Core.Homework newHomework)
        {   
            return 5;
        }

        public void Create(Core.Homework homework)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int homeworkId)
        {
            throw new NotImplementedException();
        }

        public Core.Homework[] Get()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Homework> Get(int homeworkId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Core.Homework>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Core.Homework homework)
        {
            throw new NotImplementedException();
        }
    }
}
