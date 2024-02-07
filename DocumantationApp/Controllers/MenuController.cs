using DocumantationApp.Data;
using DocumantationApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Add this line

namespace DocumantationApp.Controllers;

public class MenuController : Controller
{
    public ActionResult Menu()
{
    List<DrinkModel> drinks = MenuData.GetDrinksMenu();
    List<DessertModel> desserts = MenuData.GetDessertsMenu();
    List<SandwichModel> sandwiches = MenuData.GetSandwichesMenu();

    ViewBag.Drinks = drinks;
    ViewBag.Desserts = desserts;
    ViewBag.Sandwiches = sandwiches;

    return View();
}
}