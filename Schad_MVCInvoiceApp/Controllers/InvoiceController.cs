using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Schad_MVCInvoiceApp.Entitades;
using Schad_MVCInvoiceApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ICustomer repositorio;
        private readonly IInvoice invRepositorio;
        public static Invoice InvoiceHeader;
        public static InvoiceDetail_VM Invoice_VM;
        public static List<InvoiceDetail> InvDetail = new List<InvoiceDetail>();

        //public InvoiceController(ICustomer repositorio)
        //{
        //    this.repositorio = repositorio;
        //}
        public InvoiceController(ICustomer repositorio, IInvoice invRepositorio)
        {
            this.repositorio = repositorio;
            this.invRepositorio = invRepositorio;
        }
        public IActionResult Index()
        {
            var salesDetail = this.invRepositorio.ObtenerSalesDetail();
            ViewBag.Total = salesDetail.Count();
            return View(salesDetail);
        }
        public ActionResult Create()
        {
            List<SelectListItem> customerSelectList = new List<SelectListItem>();

            var result = this.repositorio.ObtenerLosCustomers(true);
            result.ForEach(v =>
            {
                customerSelectList.Add(new SelectListItem { Text = v.CustName, Value = v.Id.ToString() });
            });

            Invoice_VM = new InvoiceDetail_VM();
            Invoice_VM.CustomerListHeader = customerSelectList;

            return View(Invoice_VM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entitades.InvoiceDetail_VM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (InvoiceHeader == null)
                    {
                        InvoiceHeader = new Invoice
                        {
                            CustomerId = model.CustomerId_Header,
                            InvoiceNo = this.invRepositorio.ObtenerNextInvoice()
                        };
                    }

                    if (InvoiceHeader.ItemDetails == null)
                    {
                        InvoiceHeader.ItemDetails = new List<InvoiceDetail>();
                    }

                    InvoiceHeader.ItemDetails.Add(new InvoiceDetail
                    {
                        InvoiceId = model.InvoiceId,
                        ItemDescription = model.ItemDescription,
                        Qty = model.Qty,
                        Price = model.Price,
                        TotalItbis = 0,
                        SubTotal = (model.Qty * model.Price),
                        Total = (model.Qty * model.Price)
                    });

                    ViewBag.TempDetail = InvoiceHeader.ItemDetails;

                    double total = InvoiceHeader.ItemDetails.Sum(x => x.Total);

                    InvoiceHeader.SubTotal = total;
                    InvoiceHeader.Total = total;
                    ViewBag.SubTotal_Header = total;

                    if (model.CustomerListHeader == null)
                        model.CustomerListHeader = Invoice_VM.CustomerListHeader;
                }

                return View("Create", model);
            }
            catch
            {
                return View("Create", model);
            }
        }
        public ActionResult SaveInvoice()
        {
            if (InvoiceHeader != null)
            {
                if (InvoiceHeader.ItemDetails != null && InvoiceHeader.ItemDetails.Count > 0)
                {
                    this.invRepositorio.GuardarInvoice(InvoiceHeader);
                }
            }

            var salesDetail = this.invRepositorio.ObtenerSalesDetail();
            ViewBag.Total = salesDetail.Count();
            return View("Index", salesDetail);
        }
    }
}
