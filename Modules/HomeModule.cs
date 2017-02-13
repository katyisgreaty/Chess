
using Nancy;
using System;
using System.Collections.Generic;
using Chess1.Objects;

namespace ChessApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/output"] = _ => {
        Chess coordinates = new Chess(Request.Form["qx-coord"], Request.Form["qy-coord"], Request.Form["px-coord"], Request.Form["py-coord"]);
        bool result = coordinates.CanAttack();
        return View["output.cshtml", result];
      };
    }
  }
}
