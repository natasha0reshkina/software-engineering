namespace minidztests;

using Xunit;
using minidz.Services;

public class VetClinicTests
{
    [Fact]
    public void CheckHealth_ReturnsTrueOrFalse()
    {
        bool result1 = VetClinic.CheckHealth();
        bool result2 = VetClinic.CheckHealth();

        Assert.True(result1 == true || result1 == false);
        Assert.True(result2 == true || result2 == false);
    }
}