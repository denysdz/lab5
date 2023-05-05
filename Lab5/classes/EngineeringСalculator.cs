﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.classes {

    class EngineeringСalculator {
        public int Id { get; set; }
        public string Name { get; set; }

        public EngineeringСalculator(int id, string name) {
            Id = id;
            Name = name;
        }

        public double Add(double a, double b) {
            return a + b;
        }

        public double Subtract(double a, double b) {
            return a - b;
        }

        public double Multiply(double a, double b) {
            return a * b;
        }

        public double Divide(double a, double b) {
            return a / b;
        }

    }

}
