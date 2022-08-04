using AutoFixture;
using FluentAssertions;
using Xunit;

namespace Ships_BL_Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void Get_ShipsIsInvalid_ShouldThrowException(int Id)
        {
            //arrange
            var fixture = new Fixture();
            bool result = false;

            //act
            var intNumber = fixture.Create<int>();
            if (Id % 2 == 0)
                result = true;

            //assert
            result.Should().BeTrue();
        }
    }
}