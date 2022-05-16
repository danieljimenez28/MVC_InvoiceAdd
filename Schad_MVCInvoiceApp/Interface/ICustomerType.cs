using Schad_MVCInvoiceApp.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Interface
{
    public interface ICustomerType
    {
        Task<CustomerType> ObtenerCustomerType(int Id);
        List<CustomerType> ObtenerLosCustomersType();
        void GuardarCustomerType(CustomerType model);
    }
}
