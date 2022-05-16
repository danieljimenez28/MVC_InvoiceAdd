using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Entitades
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        public string ItemDescription { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double TotalItbis { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }

    }
}
