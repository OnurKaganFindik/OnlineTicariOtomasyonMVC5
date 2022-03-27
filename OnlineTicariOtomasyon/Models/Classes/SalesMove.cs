using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class SalesMove
    {
        [Key]
        public int SalesMoveId { get; set; }

        //Product
        //Customer
        //Employee

        public DateTime Date { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }

        public decimal TotalAmount { get; set; }


    }
}