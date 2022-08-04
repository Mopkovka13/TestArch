using TestArchitecture.Core;
using TestArchitecture.Core.Repository;
using TestArchitecture.Core.Service;

namespace TestArchitecture.BL
{
    public class HomeworksService : IHomeworksService
    {
        private IHomeworksRepository _homeworksRepository;
        public HomeworksService(IHomeworksRepository homeworksRepository)
        {
            _homeworksRepository = homeworksRepository;
        }

        public async Task<int> Create(Homework homework)
        {
            if(homework is null)
                throw new ArgumentNullException(nameof(homework));

            var isInvalid = homework.Link == null
                || string.IsNullOrWhiteSpace(homework.Title);

            if (isInvalid)
                throw new Exception("Homework is invalid");
            
            var homeworkId = await _homeworksRepository.Add(homework);
            Task.WaitAny();
            return homeworkId;
        }


        public Task<bool> Delete(int homeworkId)
        {
            throw new NotImplementedException();
        }

       
    }
}
