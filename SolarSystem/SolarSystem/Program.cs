using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> Planets = new List<Planet>();//Laver listen
            Planets.Add(new Planet { Name = "Merkur", Mass = 0.33, Diameter = 4879, Density = 5427, Gravity = 3.7, Rotationperiod = 1407.6, Lengthofday = 4222.6, Distancefromsun = 57.9, Orbitalperiod = 88, Orbitalvelocity = 47.4, Meantemperature = 167, Numberofmoons = 0, Ringsystem = false, });
            Planets.Add(new Planet { Name = "Venus", Mass = 4.87, Diameter = 12104, Density = 5243, Gravity = 8.9, Rotationperiod = -5832.5, Lengthofday = 2802, Distancefromsun = 108.2, Orbitalperiod = 224.7, Orbitalvelocity = 35, Meantemperature = 464, Numberofmoons = 0, Ringsystem = false, });
            Planets.Add(new Planet { Name = "Jorden", Mass = 5.97, Diameter = 12756, Density = 5514, Gravity = 9.8, Rotationperiod = 23.9, Lengthofday = 24, Distancefromsun = 149.6, Orbitalperiod = 365.2, Orbitalvelocity = 29.8, Meantemperature = 15, Numberofmoons = 0, Ringsystem = false, });
            Planets.Add(new Planet { Name = "Mars", Mass = 0.642, Diameter = 6792, Density = 3933, Gravity = 3.7, Rotationperiod = 24.6, Lengthofday = 24.7, Distancefromsun = 227.9, Orbitalperiod = 687, Orbitalvelocity = 24.1, Meantemperature = -65, Numberofmoons = 2, Ringsystem = false, });
            Planets.Add(new Planet { Name = "Jupiter", Mass = 1898, Diameter = 142984, Density = 1326, Gravity = 23.1, Rotationperiod = 9.9, Lengthofday = 9.9, Distancefromsun = 778.6, Orbitalperiod = 4331, Orbitalvelocity = 13.1, Meantemperature = -110, Numberofmoons = 67, Ringsystem = true, });
            Planets.Add(new Planet { Name = "Saturn", Mass = 568, Diameter = 120536, Density = 687, Gravity = 9, Rotationperiod = 10.7, Lengthofday = 10.7, Distancefromsun = 1433.5, Orbitalperiod = 10747, Orbitalvelocity = 9.7, Meantemperature = -140, Numberofmoons = 62, Ringsystem = true, });
            Planets.Add(new Planet { Name = "Uranus", Mass = 86.8, Diameter = 51118, Density = 1271, Gravity = 8.7, Rotationperiod = -17.2, Lengthofday = 17.2, Distancefromsun = 2872.5, Orbitalperiod = 30589, Orbitalvelocity = 6.8, Meantemperature = -195, Numberofmoons = 27, Ringsystem = true, });
            Planets.Add(new Planet { Name = "Neptune", Mass = 102, Diameter = 49528, Density = 1638, Gravity = 11, Rotationperiod = 16.1, Lengthofday = 16.1, Distancefromsun = 4495.1, Orbitalperiod = 59.8, Orbitalvelocity = 5.4, Meantemperature = -200, Numberofmoons = 14, Ringsystem = true, });
            Planets.Add(new Planet { Name = "Pluto", Mass = 0.0146, Diameter = 2370, Density = 2095, Gravity = 0.7, Rotationperiod = -153.3, Lengthofday = 153.3, Distancefromsun = 5906.4, Orbitalperiod = 90.56, Orbitalvelocity = 4.7, Meantemperature = -225, Numberofmoons = 5, Ringsystem = false, });
            //tilføjer planeterne

            foreach (var item in Planets)
            {//udskriver alle planeterne
                Console.WriteLine("Navn: " + item.Name);
                Console.WriteLine("Mass: " + item.Mass);
                Console.WriteLine("Diameter: "+ item.Diameter);
                Console.WriteLine("Density: "+ item.Density);
                Console.WriteLine("Gravity: "+ item.Gravity);
                Console.WriteLine("Rotation Period: "+ item.Rotationperiod);
                Console.WriteLine("Length of Day: "+ item.Lengthofday);
                Console.WriteLine("Distance from Sun: "+item.Distancefromsun);
                Console.WriteLine("Orbital Period: "+ item.Orbitalperiod);
                Console.WriteLine("Orbital Velocity:"+ item.Orbitalvelocity);
                Console.WriteLine("Mean Temperature: "+ item.Meantemperature);
                Console.WriteLine("Number of Moons: "+ item.Numberofmoons);
                Console.WriteLine("Ring System? "+ item.Ringsystem);
                Console.WriteLine("\n \n____________________________________________");

            }

            foreach (var item in Planets)//kigger igennem alle items i listen for at finde pluto
            {
                if (item.Name == "Pluto") //hvis navnet er pluto
                {
                    Planets.Remove(item); //så fjerne den det
                    break;//og slutter loopet
                }
            }
            Planets.Add(new Planet { Name = "Pluto", Mass = 0.0146, Diameter = 2370, Density = 2095, Gravity = 0.7, Rotationperiod = -153.3, Lengthofday = 153.3, Distancefromsun = 5906.4, Orbitalperiod = 90.56, Orbitalvelocity = 4.7, Meantemperature = -225, Numberofmoons = 5, Ringsystem = false, });
            Console.WriteLine(Planets.Count);//udskriver hvor mange planeter der der 



            List<Planet> CoolPlanets = new List<Planet>();
            IEnumerable<Planet> tempQuery =//laver en query for at finde temperaturen i listen
                from Planet in Planets
                where Planet.Meantemperature < 0
                select Planet;
            foreach (var item in tempQuery)//udskriver alle items i tempquery
            {
                Console.WriteLine(item.Name);
                CoolPlanets.Add(item);//tilføjer den til listen
            }
            Console.WriteLine("Planets Diameter");
            List<Planet> thickPlanets = new List<Planet>();
            IEnumerable<Planet> thicknesQuery =
                from Planet in Planets
                where Planet.Diameter > 10000//hvis den er større end 10000
                where Planet.Diameter < 50000//hvis den er mindre end 50000 
                select Planet;
            foreach (var item in thicknesQuery)
            {
                Console.WriteLine(item.Name);
                thickPlanets.Add(item);
            }
            Console.WriteLine("Fjerner alle planeter");
            
            Planets.Clear();
            Console.ReadLine();

        }
    }
}



