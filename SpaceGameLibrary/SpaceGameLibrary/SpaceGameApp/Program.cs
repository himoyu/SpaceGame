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
            //Call DisplayHeader from Utility class
            Utility forTest = new Utility();
            forTest.DisplayHeader();
            Console.WriteLine("\n\n");

            //Display Quadrant method content
            planet.Quadrant();
            Console.ReadKey();

            int[,] MapGrid = new int[10, 10];
            
        }
    }
}
