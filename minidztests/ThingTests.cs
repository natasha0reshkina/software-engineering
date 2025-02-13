using Xunit;
using minidz.Models.Things;

namespace minidz.Tests.Models
{
    public class ThingTests1
    {
        [Fact]
        public void Table_HasCorrectProperties()
        {
            var table = new Table(101);

            Assert.Equal("Стол", table.Name);
            Assert.Equal(101, table.Number);
        }

        [Fact]
        public void Computer_HasCorrectProperties()
        {
            var computer = new Computer(102);

            Assert.Equal("Компьютер", computer.Name);
            Assert.Equal(102, computer.Number);
        }
    }
    
}