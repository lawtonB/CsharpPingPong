using Nancy;
using System.Collections.Generic;
using PingPong;

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
      PingPonger pingObject = new PingPonger(input);
      return View["printout.cshtml", pingObject];
    };
   }
  }
}
