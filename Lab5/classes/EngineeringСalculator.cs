using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.classes {

    class EngineeringСalculator {

        private List<String> operations;
        public string Name { get; set; }

        public EngineeringСalculator(string name) {
            Name = name;
            this.operations = new List<String>();
        }
        public IEnumerator<string> GetOperationsEnumerator() {
            return operations.GetEnumerator();
        }

        public double Add(double a, double b) {
            double result = a + b;
            String record = a.ToString() + "+" + b.ToString() + "=" + result.ToString(); 
            operations.Add(record);
            return result;
        }

        public double Subtract(double a, double b) {
            double result = a - b;
            String record = a.ToString() + "-" + b.ToString() + "=" + result.ToString();
            operations.Add(record);
            return result;
        }

        public double Multiply(double a, double b) {
            double result = a * b;
            String record = a.ToString() + "*" + b.ToString() + "=" + result.ToString();
            operations.Add(record);
            return result;
        }

        public double Divide(double a, double b) {
            double result = a / b;
            String record = a.ToString() + "/" + b.ToString() + "=" + result.ToString();
            operations.Add(record);
            return a / b;
        }

    }

}
