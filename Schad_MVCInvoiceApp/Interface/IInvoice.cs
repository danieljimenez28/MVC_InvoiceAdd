using Schad_MVCInvoiceApp.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Interface
{
    public interface IInvoice
    {
        public void GuardarInvoice(Invoice model);
        IEnumerable<Vw_SalesDetail> ObtenerSalesDetail();
        string ObtenerNextInvoice();
    }
}
