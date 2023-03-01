using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaBank.Models;

namespace PizzaBank.Pages.Forms
{
    public class IndexModel : PageModel
    {
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
     
        public void OnGet()
        {
        }

        public IActionResult onPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Beef) PizzaPrice += 1;
            if (Pizza.TomatoeSauce) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.MushRoom) PizzaPrice += 3;
            if (Pizza.Tuna) PizzaPrice += 1;

            return RedirectToPage("/checkout/index", new {Pizza.PizzaName, PizzaPrice });

        }
    }
}
