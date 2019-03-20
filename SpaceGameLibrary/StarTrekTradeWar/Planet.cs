﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekTradeWar
{
    class Planet : ILocation
    {
        string _name;
        string _description;

        double _x;
        double _y;
        public double X { get => this._x; set => this._x = value; }
        public double Y { get => this._y; set => this._y = value; }
        public string Name { get => this._name; set => this._name = value; }
        public string Description { get => this._description; set => this._description = value; }


        public Planet(string name, string description, double x, double y)
        {
            this._name = name;
            this._description = description;
            this._x = x;
            this._y = y;
        }

        public double DistanceTo(ILocation otherLocation)
        {
            var left = Math.Pow(this.X - otherLocation.X, 2);
            var right = Math.Pow(this.Y - otherLocation.Y, 2);
            return Math.Sqrt(left + right);
        }
    }
}
