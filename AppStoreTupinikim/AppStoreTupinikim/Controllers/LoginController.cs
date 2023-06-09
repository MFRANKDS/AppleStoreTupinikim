using Microsoft.AspNetCore.Mvc;
using AppStoreTupinikim.Models;

namespace AppStoreTupinikim.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "eva@eva" && loginModel.Senha == "eva123") 
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["MessagemErro"] = $"Usuário e(ou) senha invalido(s).Tente novamente!";
                }
                return View("Index");
            }
            catch (Exception erro) 
            {
                TempData["MessagemErro"] = $"Ops, não conseguimos realizar seu login tente novamente: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
