using System;
using System.Collections.Generic;

namespace OOPListsAndObjects
{
    class Program
    {
        class Planet
        {
            string name;
            int mass;
        
            public Planet(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name
            {
                get { return name; }
            }

            public int Mass
            {
                get { return mass; }
            }
        }

        class ListOfPlanets
        {
            List<Planet> planets;
            int totalMass;

            public ListOfPlanets()
            {
                planets = new List<Planet>();
                totalMass = 0;
            }

            public void AddPlanetToList(string planetName, int planetMass)
            {
                Planet newPlanet = new Planet(planetName, planetMass);
                planets.Add(newPlanet);
            }
            
            public void PrintPlanets()
            {
                foreach(Planet planetFromList in planets)
                {
                    Console.WriteLine("Planet name: " + planetFromList.Name + " | Mass: " + planetFromList.Mass);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
