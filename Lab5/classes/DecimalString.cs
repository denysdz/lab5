using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.classes.Class1;

namespace Lab5.classes.Class2 {
    class DecimalString : StringBase {

        public DecimalString(string str) {
            if (IsValidDecimalString(str)) {
                length = (byte)str.Length;
                chars = str.ToCharArray();
            } else {
                length = 0;
                chars = new char[0];
            }
        }
        public DecimalString(int number) : this(number.ToString()) { }

        private static bool IsValidDecimalString(string str) {
            if ((str[0] == '-' || str[0] == '+') && !char.IsDigit(str[1])) {
                return false;
            } else {
                for (int i=1; i < str.Length; i++) {
                    if (!char.IsDigit(str[i])) {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString() {
            return new string(chars);
        }

        public DecimalString Difference(DecimalString other) {
            if (this.length != 0 && other.length != 0)
            {
                int a = int.Parse(this.ToString());
                int b = int.Parse(other.ToString());
                int diff = a - b;
                return new DecimalString(diff.ToString());
            } else
            {
                throw new ArgumentException("Not valid type");
            }
        }


        public static bool operator> (DecimalString first, DecimalString second) {
            int a = int.Parse(first.ToString());
            int b = int.Parse(second.ToString());
            return a > b;
        }

        public static bool operator <(DecimalString first, DecimalString second) {
            int a = int.Parse(first.ToString());
            int b = int.Parse(second.ToString());
            return a < b;
        }

    }
}
