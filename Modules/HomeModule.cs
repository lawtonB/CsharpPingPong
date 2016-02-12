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
        var allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact_added"] = _ => {
        int intPhoneNumber = int.Parse(Request.Form["new-phoneNumber"])
        var newContact = new Contact(Request.Form["new-name"], Request.Form["new-address"],intPhoneNumber);
        var allContacts = Contact.GetAll();
        return View["contact_created.cshtml"];
      };
      Get["/categories/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        var selectedCategory = Category.Find(parameters.id);
        var categoryTasks = selectedCategory.GetTasks();
        model.Add("category", selectedCategory);
        model.Add("tasks", categoryTasks);
        return View["category.cshtml", model];
      };
      Get["/categories/{id}/tasks/new"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(parameters.id);
        List<Task> alltasks = selectedCategory.GetTasks();
        model.Add("category", selectedCategory);
        model.Add("tasks", alltasks);
        return View["category_tasks_form.cshtml", model];
      };
      Post["/tasks"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(Request.Form["category-id"]);
        List<Task> categoryTasks =  selectedCategory.GetTasks();
        string taskDescription = Request.Form["task-description"];
        Task newTask = new Task(taskDescription);
        categoryTasks.Add(newTask);
        model.Add("tasks", categoryTasks);
        model.Add("category", selectedCategory);
        return View["category.cshtml", model];
      };
      Post["/categories/{id}"] = parameters => {
        Category selectedCategory = Category.Find(parameters.id);
        selectedCategory.Clear();
        return View["tasks_deleted.cshtml", selectedCategory];
      };
    }
  }
}
