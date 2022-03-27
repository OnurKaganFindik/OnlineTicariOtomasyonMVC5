using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set;}


        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public Invoice Invoice { get; set; }
    }
}