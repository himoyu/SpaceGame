﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceGameLibrary;

namespace SpaceGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet();
            Console.WriteLine("\n\n");
            //Call DisplayHeader from Planet class
            planet.DisplayHeader();
            Console.WriteLine("\n\n");

            //Display Quadrant method content
            planet.Quadrant();
            Console.ReadKey();
        }
    }
}
