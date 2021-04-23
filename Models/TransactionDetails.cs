using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegalSystem.Models
{
    public class TransactionDetails
    {
        //Documentation located in the following link
        //https://developers.payfast.co.za/docs#step_1_form_fields

        public string M_Payment_Id { get; set; }

        public string Amount { get; set; }

        public string Item_Name { get; set; }

        public string Item_Description{ get; set; }
    }
}
