﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public int Number {
            get { return this.number; }
            set { this.number = value; }
        }
        public string Name {
            get { return this.name; }
            set { this.name =value; }
        }
        public string Type {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Cars {
            get { return this.cars; }
            set { this.cars = value; }
        }
        //constriction
        public Train(int num, string name, string type, int cars) {
            this.Number = num;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }
        public override string ToString()
        {
            return String.Format($"{number} {name} {type} {cars}");
        }

    }
}
