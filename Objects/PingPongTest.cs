using Xunit;
namespace PingPongTest
{
  public class PingPongTest
  {
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
