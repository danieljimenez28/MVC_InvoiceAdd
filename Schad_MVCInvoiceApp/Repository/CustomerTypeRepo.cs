using Schad_MVCInvoiceApp.Entitades;
using Schad_MVCInvoiceApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Repository
{
    public class CustomerTypeRepo : ICustomerType
    {
        public List<CustomerType> ObtenerLosCustomersType()
        {
            using (var db = new ApplicationDBContext())
            {
                return db.CustomerTypes.ToList();
            }
        }
        public async Task<CustomerType> ObtenerCustomerType(int Id)
        {
            using (var db = new ApplicationDBContext())
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                return db.CustomerTypes.FirstOrDefault(x => x.Id == Id);
            }
        }

        public void GuardarCustomerType(CustomerType model)
        {
            using (var db = new ApplicationDBContext())
            {
                db.CustomerTypes.Add(new CustomerType
                {
                    Description = model.Description
                });

                db.SaveChanges();
            }
        }
    }
}
