using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppStoreTupinikim.Models;

namespace AppStoreTupinikim.Controllers
{
    public class Produto : Controller
    {
        private static Produtos _produtos = new Produtos();
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }
    }
}
