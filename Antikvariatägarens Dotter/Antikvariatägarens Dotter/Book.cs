using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_Dotter
{
    class Book
    {
        public int Price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        static Random Generator = new Random(); 

        public Book()
        {
            actualValue = Generator.Next(1001);
            rarity = Generator.Next(11);
            //cursed = Generator.Next();  Detta tog väldigt lång tid för mig att fösöka lista ut, måste träna

            List<string> chooseCategory = new List<string>() { "PocketBook", "HugeBook", "ThinBook", "CoolBook" };
            List<string> chooseName = new List<string>() { "LifeBook", "DeathBook", "SadBook", "HappyBook" };  // Måste träna på listor och hur man framkallar objekt ur listan
            int category = Generator.Next(chooseCategory.Count);
            int name = Generator.Next(chooseName.Count);
            
        }
        public void PrintInfo()
        {
            Price = actualValue;
            Console.WriteLine(category);
            Console.WriteLine(name);
            Console.WriteLine(rarity);
            Console.WriteLine(Price);
        }
        public int Evaluate ()
        {
            int rightPrice = Price * rarity;
            int randomprice = Generator.Next(50, 151);
            rightPrice = randomprice / Price;
            int evaluatedPrice = rightPrice * Price;

            return evaluatedPrice;
        }

        public string GetCategory()

        {

        }

    }
}
