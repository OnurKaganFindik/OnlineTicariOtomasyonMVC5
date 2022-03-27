using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeLastname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string EmployeeImgUrl { get; set; }

        public SalesMove SalesMove { get; set; }

    }
}