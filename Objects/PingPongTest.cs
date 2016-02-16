using Xunit;
using System;
using System.Collections.Generic;
using PingPong;

namespace PingPongTest
{
  public class PingPongTester
  {
    [Fact]
    public void ListOfNumbersUpToThree()
    {
    //arrange
    int userint = 3;
    PingPongClass example = new PingPongClass(userint);
    List<string> userlist = example.getOutput();

    //act
    List<string> testlist = new List<string>{"1","2","ping"};

    //assert
    Assert.Equal(testlist, userlist);
    }
  }
}
