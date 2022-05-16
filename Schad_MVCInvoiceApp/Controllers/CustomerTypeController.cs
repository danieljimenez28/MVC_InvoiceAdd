using Microsoft.AspNetCore.Mvc;
using Schad_MVCInvoiceApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Controllers
{
    public class CustomerTypeController : Controller
    {
        private readonly ICustomerType repositorio;

        public CustomerTypeController(ICustomerType repositorio, ApplicationDBContext context)
        {
            this.repositorio = repositorio;
            //this.context = context;
        }
        public IActionResult Index()
        {
            var res = this.repositorio.ObtenerLosCustomersType();
            ViewBag.Total = res.Count();
            return View(res);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Entitades.CustomerType model)
        {
            if (ModelState.IsValid)
            {
                this.repositorio.GuardarCustomerType(model);

                var res = this.repositorio.ObtenerLosCustomersType();
                ViewBag.Total = res.Count();
                return View("Index", res);
            }
            else
                return View(model);
        }
    }
}
