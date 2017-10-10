using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtmTransaction.Models
{
    public class UserData
    {
        public int id { get; set; }
        public int card_number { get; set; }
        public int pinNumber { get; set; }
        public int balance { get; set; }
    }
}