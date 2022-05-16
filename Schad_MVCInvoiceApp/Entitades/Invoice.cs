using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Entitades
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string InvoiceNo { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double TotalItbis { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public List<InvoiceDetail> ItemDetails { get; set; }

    }
}
