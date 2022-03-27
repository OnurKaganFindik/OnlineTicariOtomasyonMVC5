using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerLastname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CustomerCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerMail { get; set; }

        public SalesMove SalesMove { get; set; }
        public Department Department { get; set; }

    }
}