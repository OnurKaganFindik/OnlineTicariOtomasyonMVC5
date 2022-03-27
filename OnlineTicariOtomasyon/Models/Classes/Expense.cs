﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string Description { get; set;}
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}