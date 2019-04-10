using System;
using System.Collections.Generic;
/*
Name of the city.
The mayor of the city.
Year the city was established.
A collection of all of the Buildings in the city.
A method to add a building to the city. */

namespace Planner
{
    public class City {
        private string cityName;
        private string mayor;
        private int established;

//constructor
        public City (string cityNameInput, string mayorInput, int establishedInput) {
        cityName = cityNameInput;
        mayor = mayorInput;
        established = establishedInput;
        }

        //List to hold the Buildings for the city
        public List<Building> Buildings{get; set;} = new List<Building>();

        //method to add building to the list
        public void AddBuilding(Building building){
            Buildings.Add(building);
        }

     public void Print(){
            Console.WriteLine(
                $@"
The Mayor of {cityName} is {mayor}. The city was
established in {established} and all buildings are
dispalyed below.");

        }
    }
}