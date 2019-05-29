using System;
using System.Collections.Generic;

namespace Planner{
    class City{
        public City(string cityName){ // C O N S T R U C T O R
            CityName = cityName;
        }

        public string CityName { get; set; }
        public string Mayor { get; set;}
        public int Established { get; set; }
        public List<Building> BuildingList = new List<Building>();
        public void AddBuilding(Building bldgToAdd){
            BuildingList.Add(bldgToAdd);
        }
        public void DisplayCityInfo(){
            foreach(Building building in BuildingList){
                Console.WriteLine("___________________");
                Console.WriteLine($"City Name: {CityName}");
                Console.WriteLine($"Mayor: {Mayor}");
                Console.WriteLine($"Established in {Established}");
                Console.WriteLine("");
            }
        }
    }
}