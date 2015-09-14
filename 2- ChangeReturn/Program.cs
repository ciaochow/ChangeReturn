using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__ChangeReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a (break-proof) change return progam that I created that returns the correct 
            // amount of change (example: dollars/quarters/dimes/nickels/cents) when paying for 
            // an item.
            
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("---------- Change Return Program ----------");
                Playgame Playgame = new Playgame();
                Playgame.BuyItem();
                loop = Playgame.BuyAnother();
            }
        }
    }
}
