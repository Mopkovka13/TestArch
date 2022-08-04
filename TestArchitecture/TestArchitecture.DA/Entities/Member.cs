namespace TestArchitecture.DA.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Guid? GithubAccountId { get; set; }
        public GithubAccount GithubAccount { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
    }
}