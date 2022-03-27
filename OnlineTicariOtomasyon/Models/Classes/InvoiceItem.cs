using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public string Description { get; set;}
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitPrice { get; set; }
    }
}