using PingPongTest;

namespace PingPong
{
  public class PingPongClass
  {
    public object PingPonger(int input)
    {

        if (input % 15 == 0)
        {
          return "ping-pong";
        }
        else if (input % 5 == 0)
        {
          return "pong";
        }
        else if (input % 3 == 0)
        {
          return "ping";
        }
        else
        {
          return input;
        }
    }
  }
}
