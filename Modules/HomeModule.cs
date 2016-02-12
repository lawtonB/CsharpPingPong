using System;
using Nancy;
using System.Collections.Generic;
using Address.Objects;

namespace Address
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };

      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };

      Post["contacts/added"] = _ => {
        int intPhoneNumber = int.Parse(Request.Form["new-phoneNumber"]);
        Contact newContact = new Contact((Request.Form["new-name"]), (Request.Form["new-address"]),intPhoneNumber);
        return View["contact_created.cshtml", newContact];
      };

      Get["contacts/cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
