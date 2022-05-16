using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Schad_MVCInvoiceApp.Entitades;
using Schad_MVCInvoiceApp.Interface;
using Schad_MVCInvoiceApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer repositorio;
        private readonly ICustomerType repositorioType;

        public CustomerController(ICustomer repositorio, ICustomerType repositorio_2)
        {
            this.repositorio = repositorio;
            this.repositorioType = repositorio_2;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var res = this.repositorio.ObtenerLosCustomers();
            ViewBag.Total = res.Count();
            return View(res);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            List<SelectListItem> customerSelectList = new List<SelectListItem>();

            var result = this.repositorioType.ObtenerLosCustomersType();
            result.ForEach(v =>
            {
                customerSelectList.Add(new SelectListItem { Text = v.Description, Value = v.Id.ToString() });
            });

            //Customer client = new Customer();
            ViewBag.CustomerTypeList = customerSelectList;

            return View();
        }
        
        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entitades.Customer model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.repositorio.GuardarCustomer(model);
                    var res = this.repositorio.ObtenerLosCustomers();
                    return View("Index", res);
                }
                else
                    return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ActivarDesActivar(int id = 0)
        {
            var result = this.repositorio.ObtenerCustomer(id);
            if (result != null)
            {
                result.Status = (!result.Status);
                this.repositorio.ActualizarEstado(result);
                //ViewBag.mensaje = $"Cliente No. {id} Activado";
            }

            var resultAll = this.repositorio.ObtenerLosCustomers();
            ViewBag.Total = resultAll.Count();
            return View("Index", resultAll);
        }
    }
}
