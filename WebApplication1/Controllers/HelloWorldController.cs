﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorldaa/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}