using Schad_MVCInvoiceApp.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Interface
{
    public interface ICustomer
    {
        Customer ObtenerCustomer(int Id);
        public List<Customer> ObtenerLosCustomers();
        public List<Customer> ObtenerLosCustomers(int type);
        List<Customer> ObtenerLosCustomers(bool active);
        public void GuardarCustomer(Customer model);
        public void ActualizarEstado(Customer model);
    }
}
