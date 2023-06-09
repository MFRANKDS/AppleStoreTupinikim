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

namespace AppStoreTupinikim.Models
{
    public class ProdutoModel
    {
        public string? Codigo { get; set; }
        public string? NomeProdudo { get; set; }

        public string? Preco { get; set; }

        public string? Quantidade { get; set; }

    }
}
