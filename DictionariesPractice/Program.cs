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

            /*Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Mountain Dew");
            drinkMachine.Add(13, "Orange Juice");
            drinkMachine.Add(14, "Fruit Punch");

            //Console.WriteLine(drinkMachine.Count);
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }*/

            //create a dictionary for a theatre coat check with 10 elements
            //key number, value will be the coat style

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(1, "Black Leather Jacket");
            coatCheck.Add(2, "Long Rain Coat");
            coatCheck.Add(3, "Fur Coat");
            coatCheck.Add(4, "Bomber Jacket");
            coatCheck.Add(5, "Black Leather Jacket");
            coatCheck.Add(6, "Business Suit Jacket");
            coatCheck.Add(7, "Blazer");
            coatCheck.Add(8, "Long Rain Coat");
            coatCheck.Add(9, "Black Leather Jacket");
            coatCheck.Add(10, "Long Rain Coat");

            foreach(KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat);
            }
            Console.WriteLine("\n");
            //Car valet with 10 cars, the key will be a customer last name and the 
            //value will be the car make.  Print all elements to the console.

            Dictionary<string, string> carValet = new Dictionary<string, string>();

            carValet.Add("Smith", "Mustang");
            carValet.Add("Smith2", "Corvette");
            carValet.Add("King", "Suzuki");
            carValet.Add("Woods", "Ferrari");
            carValet.Add("Lewis", "Smart Car");
            carValet.Add("Johnson", "Limo");
            carValet.Add("Vivacqua", "Camaro SS");
            carValet.Add("Batman", "Batmobile");
            carValet.Add("Turner", "Mercedes 500");
            carValet.Add("Holloway", "BMW M5");

            foreach (KeyValuePair<string, string> car in carValet)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n");
            //Create a dictionary of 10 zoo animals.  The key will be the animal type.
            //The value will be the number of animals.
            //Print the animal with the highest quantity to the console.
            //Remove the zoo animal with the lowest quantity using the remove()

            Dictionary<string, int> zooAnimal = new Dictionary<string, int>();

            zooAnimal.Add("Zebras", 5);
            zooAnimal.Add("Giraffes", 4);
            zooAnimal.Add("Lions", 3);
            zooAnimal.Add("Koala Bears", 2);
            zooAnimal.Add("Apes", 2);
            zooAnimal.Add("Monkies", 6);
            zooAnimal.Add("King Cobras", 2);
            zooAnimal.Add("Elephants", 4);
            zooAnimal.Add("Birds", 20);
            zooAnimal.Add("Polar Bears", 1);

            //var sortedDict = from entry in zooAnimal orderby entry.Value ascending select entry;
            Dictionary<string, int> sortedDict = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> item in zooAnimal.OrderBy(key => key.Value))
            {
                sortedDict.Add(item.Key,item.Value);
            }
            Console.WriteLine(sortedDict.Last());
        }
    }
}
