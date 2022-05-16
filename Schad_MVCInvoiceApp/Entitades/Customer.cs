using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schad_MVCInvoiceApp.Entitades
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustName { get; set; }
        public string Adress { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int CustomerTypeId { get; set; }
        //public List<SelectListItem> CustomerTypeList { get; set; }
    }
}
