using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building SeseameStreet = new Building("123 Lame Jon Ave");
            Building MainStreet = new Building("982 Main Street");

            // Give each building a width, height, and number of stories.
            FiveOneTwoEigth.Width = 500;
            FiveOneTwoEigth.Depth = 600;
            FiveOneTwoEigth.Stories = 3;

            SeseameStreet.Width = 500;
            SeseameStreet.Depth = 500;
            SeseameStreet.Stories = 5;

            MainStreet.Width = 800;
            MainStreet.Depth = 800;
            MainStreet.Stories = 6;

            // Construct each building
            FiveOneTwoEigth.Construct();
            SeseameStreet.Construct();
            MainStreet.Construct();

            // Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchase("Jameka Echols");
            SeseameStreet.Purchase("Chaffin Schafer");
            MainStreet.Purchase("Ben Echols");

            List<Building> bldgs = new List<Building>(){
                FiveOneTwoEigth, SeseameStreet, MainStreet
            };
            // console writeline 
            foreach(Building bldg in bldgs){
                Console.WriteLine(bldg.bldingAddress());
                Console.WriteLine("----------------------");
                Console.WriteLine($"Designed by: {bldg.designer()}");
                Console.WriteLine($"Constructed on {bldg.Constructed()}");
                Console.WriteLine($"Owned by {bldg.owner()}");
                Console.WriteLine($"{bldg.Volume} cubic meters of space");
                Console.WriteLine(" ");
            }

        }
    }
}
