using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSerialNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceRowNo { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxAdministration { get; set; }

        public DateTime Time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Submitter { get; set; }


        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}