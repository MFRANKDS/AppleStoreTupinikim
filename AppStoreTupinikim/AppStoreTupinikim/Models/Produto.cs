using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppStoreTupinikim.Models;

namespace AppStoreTupinikim.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? NomeProdudo { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }
    }
}
