using Xunit;
using PingPong;
namespace PingPongTest
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_ForNumberDivisibleBy3_true()
    {
      PingPongClass testPingPongTest = new PingPongClass();
      Assert.Equal("ping", testPingPongTest.PingPonger(3));
    }
    [Fact]
    public void IsPingPong_ForNumberDivisibleBy5_true()
    {
      PingPongClass testPingPongTest = new PingPongClass();
      Assert.Equal("pong", testPingPongTest.PingPonger(5));
    }
    [Fact]
    public void IsPingPong_ForNumberDivisibleBy15_true()
    {
      PingPongClass testPingPongTest = new PingPongClass();
      Assert.Equal("ping-pong", testPingPongTest.PingPonger(15));
    }
    [Fact]
    public void IsPingPong_ForNumberDivisibleBy4_4()
    {
      PingPongClass testPingPongTest = new PingPongClass();
      Assert.Equal(4, testPingPongTest.PingPonger(4));
    }
  }
}
