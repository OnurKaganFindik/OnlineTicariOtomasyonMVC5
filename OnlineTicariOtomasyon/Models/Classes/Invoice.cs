﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public string InvoiceSerialNo { get; set; }
        public int InvoiceRowNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxAdministration { get; set; }
        public string Receiver { get; set; }
        public string Submitter { get; set; }
        public DateTime Time { get; set; }

    }
}