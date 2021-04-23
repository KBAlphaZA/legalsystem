using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegalSystem.Models
{
    public class Payments
    {
        public double Amount { get; set; }

        public string Item_Name { get; set; }

        public string Merchant_Id { get; set; }

        public string Merchant_Key { get; set; }
    }
}
