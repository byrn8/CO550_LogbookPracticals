using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LB1.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        public int amount;
        public const double rate = 1.09;
        public double result;

        public void OnPost()
        {
            this.amount = Convert.ToInt32(Request.Form["amount"]);
            this.result = amount * rate;
        }
    }
}