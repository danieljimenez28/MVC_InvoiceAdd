using Schad_MVCInvoiceApp.Entitades;
using Schad_MVCInvoiceApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Repository
{
    public class CustomerRepo : ICustomer
    {
        public List<Customer> ObtenerLosCustomers()
        {
            using (var db = new ApplicationDBContext())
            {
                return db.Customers.ToList();
            }
        }
        public List<Customer> ObtenerLosCustomers(int type)
        {
            using (var db = new ApplicationDBContext())
            {
                return db.Customers.Where(x => x.CustomerTypeId == type).ToList();
            }
        }
        public List<Customer> ObtenerLosCustomers(bool active)
        {
            using (var db = new ApplicationDBContext())
            {
                return db.Customers.Where(x => x.Status == active).ToList();
            }
        }
        public Customer ObtenerCustomer(int Id)
        {
            using (var db = new ApplicationDBContext())
            {
                return db.Customers.FirstOrDefault(x => x.Id == Id);
            }
        }

        public void GuardarCustomer(Customer model)
        {
            using (var db = new ApplicationDBContext())
            {
                db.Customers.Add(new Customer
                {
                    CustName = model.CustName,
                    Adress = model.Adress,
                    Status = model.Status,
                    CustomerTypeId = model.CustomerTypeId
                });

                db.SaveChanges();
            }
        }

        public void ActualizarEstado(Customer model)
        {
            using (var db = new ApplicationDBContext())
            {
                var sel = db.Customers.FirstOrDefault(x => x.Id == model.Id);
                if(sel != null)
                {
                    sel.Status = model.Status;
                }

                db.SaveChanges();
            }
        }
    }
}
