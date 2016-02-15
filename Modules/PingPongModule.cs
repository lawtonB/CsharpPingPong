using Nancy;
using System.Collections.Generic;
using PingPong;
using System;

namespace PingPongModule
{
  public class PingPong : NancyModule
  {
    public PingPong()
    {
    Get["/"] = _ =>
    {
      return View["index.cshtml"];
    };

    Post["/printout"] = _ =>
    {
      var input = Request.Form["inputNumber"];
      PingPongClass pingObject = new PingPongClass();
      pingObject.PingPonger(input);
      List<string> newString = pingObject.getOutput();
      return View["printout.cshtml", newString];
    };
   }
  }
}
