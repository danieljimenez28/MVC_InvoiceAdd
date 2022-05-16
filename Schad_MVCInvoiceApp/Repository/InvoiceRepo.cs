using Schad_MVCInvoiceApp.Entitades;
using Schad_MVCInvoiceApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Repository
{
    public class InvoiceRepo : IInvoice
    {
        public void GuardarInvoice(Invoice model)
        {
            using (var db = new ApplicationDBContext())
            {
                db.Invoices.Add(new Invoice
                {
                    InvoiceNo = model.InvoiceNo,
                    InvoiceDate = DateTime.Now,
                    CustomerId = model.CustomerId,
                    TotalItbis = model.TotalItbis,
                    SubTotal = model.SubTotal,
                    Total = model.Total
                });

                db.SaveChanges();
                int invID = db.Invoices.OrderByDescending(x => x.Id).FirstOrDefault().Id;

                model.ItemDetails.ForEach(x =>
                {
                    db.InvoiceDetails.Add(new InvoiceDetail
                    {
                        InvoiceId = invID,
                        ItemDescription = x.ItemDescription,
                        Qty = x.Qty,
                        Price = x.Price,
                        TotalItbis = x.TotalItbis,
                        SubTotal = x.SubTotal,
                        Total = x.Total
                    });
                });

                db.SaveChanges();
            }
        }

        public string ObtenerNextInvoice()
        {
            using (var db = new ApplicationDBContext())
            {
                var inv = db.Customers.OrderByDescending(x => x.Id).FirstOrDefault();
                if (inv == null)
                {
                    return $"F00000{1}";
                }

                return $"F00000{inv.Id + 1}";
            }
        }

        public IEnumerable<Vw_SalesDetail> ObtenerSalesDetail()
        {
            using (var db = new ApplicationDBContext())
            {
                return db.Vw_SalesDetail.ToList();
            }
        }

    }
}
