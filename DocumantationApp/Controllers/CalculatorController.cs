using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace DocumantationApp.Controllers;

public class CalculatorController : Controller{
    [HttpGet]
    public IActionResult Index(){
        return View(new CalculatorModel());
    }
    [HttpPost]
    public IActionResult Index(CalculatorModel model){
        switch(model.Operation){
            case "+":
                model.Result = model.Number1 + model.Number2;
                break;
            case "-":
                model.Result = model.Number1 - model.Number2;
                break;
            case "*":
                model.Result = model.Number1 * model.Number2;
                break;
            case "/":
                if(model.Number2 == 0)
                {
                    ModelState.AddModelError("Number2", "Number2 cannot be 0");
                    return View(model);
                }
                model.Result = model.Number1 / model.Number2;
                break;
        }
        return View(model);

    }
}