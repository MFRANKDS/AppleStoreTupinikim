using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppStoreTupinikim.Models;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace AppStoreTupinikim.Controllers
{
    public class ProdutoController : Controller
    {
        IFirebaseClient client;

        public ProdutoController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "5ae22afff90f6b5dcb8b10bbfa21234e68844f7c",
                BasePath = "https://appstoretupinikim-default-rtdb.firebaseio.com/"
            };

            client = new FirebaseClient(config);
        }
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

        [HttpPost]
        public IActionResult CadastrarProduto(ProdutoModel produtomodel) 
        {
            string idProduto = Guid.NewGuid().ToString("N");

            SetResponse response = client.Set("produtos/" + idProduto, produtomodel);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
