using AutoFixture;
using Moq;
using TestArchitecture.Core;
using TestArchitecture.Core.Repository;

namespace TestArchitecture.BL.xTests
{
    public class MembersServiceTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<IMembersRepository> _membersRepositoryMock;
        private readonly new MembersService _service;
        public MembersServiceTests()
        {
            _fixture = new Fixture();
            _membersRepositoryMock = new Mock<IMembersRepository>();
            _service = new MembersService(_membersRepositoryMock.Object);
        }



        [Fact]
        public async Task Create_ValidMember_ShouldReturnCreatedMemberId() //передаём валидный
        {
            // arrange

            var expectedMemberId = _fixture.Create<int>(); //Создаём всегда положительные числа

            var member = new Member
            {

            };

            _membersRepositoryMock
                .Setup(x => x.Add(member))
                .ReturnsAsync(expectedMemberId);

            // act
            var memberId = await _service.Create(member);

            // assert
            Assert.Equal(expectedMemberId, memberId);

            _membersRepositoryMock.Verify(x => x.Add(member), Times.Once);

        }
        [Fact]
        public async Task Create_MemberIsNull_ShouldThrowArgumentNullException() //передаём null
        {
            // arrange
            // act
            await Assert.ThrowsAsync<ArgumentNullException>(()=> _service.Create(null));

            // assert
            _membersRepositoryMock.Verify(x => x.Add(It.IsAny<Member>()), Times.Never); //С любым параметром не должен вызваться метод Add 
        }

        [Theory]
        [InlineData(0, )]
        public async Task Create_InvalidMember_ShouldThrowArgumentNullException(int id, string name, string youtubeUserId) //передаём невалидный
        {
            // arrange
            var member = new Member
            {
                Id = id,
                Name = name,
                YouTubeUserId = youtubeUserId
            };
            // act
            await Assert.ThrowsAsync<ArgumentNullException>(() => _service.Create(member));

            // assert
            _membersRepositoryMock.Verify(x => x.Add(It.IsAny<Member>()), Times.Never);         
        }


    }
}