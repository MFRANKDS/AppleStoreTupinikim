using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppStoreTupinikim.Models;

namespace AppStoreTupinikim.Models
{
    public class Produtos
    {
        public List<Produto> ListaProdutos = new List<Produto>();

        public class Produto()
        {

        }

        public void CriarProduto(Produto GestaoProduto) 
        { 
            ListaProdutos.Add(GestaoProduto);
        }

    }
}
