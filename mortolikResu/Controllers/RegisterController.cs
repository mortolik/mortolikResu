using Microsoft.AspNetCore.Mvc;
using mortolikResu.BL.Auth;
using mortolikResu.DAL.Auth;
using mortolikResu.ViewMapper;
using mortolikResu.ViewModels;

namespace mortolikResu.Controllers;

public class RegisterController: Controller
{
    private readonly IAuthBL authBl;
    public RegisterController(IAuthBL authBl)
    {
        this.authBl = authBl;
    }

    [HttpGet]
    [Route("/register")]
    public IActionResult Index()
    {
        return View("Index", new RegisterViewModel());
    }
    [HttpPost]
    [Route("/register")]
    public IActionResult IndexSave(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            authBl.CreateUser(AuthMapper.MapRegistrationViewToUserModel(model));
            return Redirect("/");
        }
        return View("Index", model);
    }
    
}