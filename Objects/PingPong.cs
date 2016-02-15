// using PingPongTest;
using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongClass
  {
    private List<string> _output = new List<string> {};
    private int _input;

    public void PingPonger(int input)
    {
      _input = input;

      for(int i = 1; i <= input; i++)
      {

        if (i % 15 == 0)
        {
          _output.Add("ping-pong");
        }
        else if (i % 5 == 0)
        {
          _output.Add("pong");
        }
        else if (i % 3 == 0)
        {
          _output.Add("ping");
        }
        else
        {
          _output.Add(i.ToString());
        }
      }
    }
    public List<string> getOutput()
    {
      return _output;
    }

  }
}
