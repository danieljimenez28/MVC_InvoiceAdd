using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Entitades
{
    [Keyless]
    public class InvoiceDetail_VM
    {
        public int CustomerId { get; set; }
        public int CustomerId_Header { get; set; }
        public string CustomerName_Header { get; set; }
        public double TotalItbis_Header { get; set; }
        public double SubTotal_Header { get; set; }
        public double Total_Header { get; set; }
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string ItemDescription { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double TotalItbis { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public List<SelectListItem> CustomerListHeader { get; set; }

    }
}
