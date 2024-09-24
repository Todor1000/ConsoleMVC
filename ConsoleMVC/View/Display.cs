using ConsoleMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.View
{
    public class Display
    {
        public Double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }
        public Display() 
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();

        }
        private void GetValues()
        {
            Console.WriteLine("Enter amount");
            Amount =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tip Percent");
            Percent = double.Parse(Console.ReadLine());

        }
        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your Tip is{TipAmount}");
            Console.WriteLine($"Your Total is {Total}");
        }
    }
}

