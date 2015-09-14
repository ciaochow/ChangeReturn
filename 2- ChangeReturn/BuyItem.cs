using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__ChangeReturn
{
    public class Playgame
    {
        public void BuyItem()
        {
            Console.WriteLine();
            decimal[] menu = new decimal[] { 1.25M, 1.20M, 2.00M, 1.25M, 1.50M, 2.00M, 1.89M };
            Console.WriteLine("Junk Food - List of Items to Buy:");
            Console.WriteLine("1. Bag of Potato Chips        ${0:F}", menu[0]);
            Console.WriteLine("2. Snickers Candy Bar         ${0:F}", menu[1]);
            Console.WriteLine("3. Pack of Spearmint Gum      ${0:F}", menu[2]);
            Console.WriteLine("4. Little Debbies snack cake  ${0:F}", menu[3]);
            Console.WriteLine("5. Large Bottle of soda       ${0:F}", menu[4]);
            Console.WriteLine("6. Mini-box of small donuts   ${0:F}", menu[5]);
            Console.WriteLine("7. Bottle of juice            ${0:F}", menu[6]);
            Console.WriteLine();
            bool _isValidChoice = false;
            int parsedinput;
            do // Test for correct input.
            {
                string input = "";
                bool check = false;
                int numcheck;
                while (check == false)
                {
                    Console.Write("Which item would you like to buy(1-7)? ");
                    input = Console.ReadLine();
                    bool intcheck = int.TryParse(input, out numcheck);
                    if (intcheck)
                        check = true;
                }
                parsedinput = int.Parse(input);
                if (parsedinput >= 1 && parsedinput <= 7)
                {
                    _isValidChoice = true;
                }
            } while (_isValidChoice == false);

            decimal cost = menu[parsedinput - 1];
            Console.WriteLine();
            Console.WriteLine("That costs ${0:F}.", cost);
            string money = "";
            bool prompt = false;
            decimal num;
            while (prompt == false)
            {
                Console.Write("How much money are you paying with? (ex: 2.50): ");
                money = Console.ReadLine();
                bool test = decimal.TryParse(money, out num);
                if (test)
                    prompt = true;
            }

            decimal total = decimal.Parse(money);
            decimal change = total - cost;
            Console.WriteLine("Your change is ${0:F} .", change);
            decimal dollars =  Math.Floor(change);
            if (dollars >= 1)
            {
                if (dollars > 1)
                    Console.WriteLine("{0} dollars", dollars);
                else Console.WriteLine("1 dollar");
            }
            decimal remainder = (change - dollars);
            //decimal remainder; // change under 1 dollar.
            decimal quarters = Math.Floor(remainder / .25M);
            if (quarters >= 1)
            {
                if (quarters > 1)
                    Console.WriteLine("{0} quarters", quarters);
                else Console.WriteLine("1 quarter");
            }
            remainder -= quarters * .25M;
            decimal dimes = Math.Floor(remainder / .10M);
            if (dimes >= 1)
            {
                if (dimes > 1)
                    Console.WriteLine("{0} dimes", dimes);
                else Console.WriteLine("1 dime");
            }
            remainder -= dimes * .10M;
            decimal nickels = Math.Floor(remainder / .05M);
            if (nickels >= 1)
            {
                if (nickels > 1)
                    Console.WriteLine("{0} nickels", nickels);
                else Console.WriteLine("1 nickel");
            }
            remainder -= nickels * .05M;
            decimal cents = Math.Floor(remainder / .01M);
            if (cents >= 1)
            {
                if (cents > 1)
                    Console.WriteLine("{0} cents", cents);
                else Console.WriteLine("1 cent");
            }
        }

        public bool BuyAnother()
        {
            bool prompt = false;
            string newgame = "";
            while (prompt == false)
            {
                Console.Write("Buy another item(y/n)? ");
                newgame = Console.ReadLine();
                if (newgame.ToUpper() == "Y" || newgame.ToUpper() == "YES"
                    || newgame.ToUpper() == "N" || newgame.ToUpper() == "NO")
                    prompt = true;
            }
            if (newgame.ToUpper() == "Y" || newgame.ToUpper() == "YES")
                return true;
            return false;
        }
    }
}
