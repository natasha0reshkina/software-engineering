using Xunit;
using minidz.Models.Animals;
namespace minidz.Tests.Models.Animals
{
    public class MonkeyTests
    {
        [Fact]
        public void Monkey_HasCorrectProperties()
        {
            var monkey = new Monkey(2, 3);
            
            Assert.Equal("Обезьяна", monkey.Name);
            Assert.Equal(5, monkey.Food);
            Assert.Equal(2, monkey.Number);
        }
    }
}