using Xunit;
using minidz.Models.Animals;

namespace minidz.Tests.Models
{
    public class AnimalTests
    {
        [Fact]
        public void Rabbit_HasCorrectProperties()
        {
            var rabbit = new Rabbit(1, 7);

            Assert.Equal("Кролик", rabbit.Name);
            Assert.Equal(2, rabbit.Food);
            Assert.Equal(1, rabbit.Number);
            Assert.Equal(7, rabbit.KindnessLevel);
        }

        [Fact]
        public void Tiger_HasCorrectProperties()
        {
            var tiger = new Tiger(3);

            Assert.Equal("Тигр", tiger.Name);
            Assert.Equal(10, tiger.Food);
            Assert.Equal(3, tiger.Number);
        }
        public void Tiger_HasCorrectProperties2()
        {
            var tiger = new Tiger(4);

            Assert.Equal("Тигр", tiger.Name);
            Assert.Equal(80, tiger.Food);
            Assert.Equal(3, tiger.Number);
        }
    }
}