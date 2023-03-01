using System;
namespace PizzaBank.Models
{
	public class PizzasModel
	{
		public string ImageTitle { get; set; }
		public string PizzaName { get; set; }
		public float BasePrice { get; set; }

		public bool TomatoeSauce { get; set; }

        public bool Beef { get; set; }
        public bool Peperoni { get; set; }
        public bool MushRoom { get; set; }
        public bool Tuna { get; set; }
		public bool Pineapple { get; set; }

		public float TotalPrice { get; set; }

    
    }
}

