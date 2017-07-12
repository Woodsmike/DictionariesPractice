using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionaries - each key has to be unique....the value can be the same
            //for different keys.  Key Value Pair.
            //syntax:  Dictionary<string, string> snackMachine = new Dictionay<string, string>() 
            /*Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Twix" },
                {"A2", "Twizzlers" },
                {"A3", "Reeses" },
                {"A4", "Sour Patch Kids" }
            };
            foreach (KeyValuePair<string, string> item in snackMachine)
            {
                Console.WriteLine(item);
            } */
            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Mountain Dew");
            drinkMachine.Add(13, "Orange Juice");
            drinkMachine.Add(14, "Fruit Punch");

            Console.WriteLine(drinkMachine.Count);
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }
        }
    }
}
