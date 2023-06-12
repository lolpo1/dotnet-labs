using Facade.classes.Meal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes
{
    public class BigMacMenu
    {
        private Burger burger;
        private Fries fries;
        private Cola drink;
        private Packaging packaging;
        private Napkin napkin;

        public BigMacMenu()
        { 
            burger = new Burger();
            fries = new Fries();
            drink = new Cola();
            packaging = new Packaging();
            napkin = new Napkin();
        }

        public double GetTotalPrice()
        {
            return burger.Price + fries.Price + drink.Price + packaging.Price + napkin.Price;
            
        }

        public void ShowMenu()
        {
            Console.WriteLine($"Preparing Big Mac Menu:");
            Console.WriteLine($"- {burger.Name} (${burger.Price})");
            Console.WriteLine($"- {fries.Name} (${fries.Price})");
            Console.WriteLine($"- {drink.Name} (${drink.Price})");
            Console.WriteLine($"- {packaging.Name} (${packaging.Price})");
            Console.WriteLine($"- {napkin.Name} (${napkin.Price})");
        }
    }
}
