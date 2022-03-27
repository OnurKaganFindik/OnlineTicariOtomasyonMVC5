using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Password { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public int Authorization { get; set; }


    }
}