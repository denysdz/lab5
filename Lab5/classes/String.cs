using Lab5.classes.Class2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.classes.InterfaceString;

namespace Lab5.classes.Class1 {
    class StringBase : IString, IComparable, ICloneable {

        protected byte length;
        protected char[] chars;

        public StringBase()
        {
            length = 0;
            chars = new char[0];
        }

        public StringBase(string str)
        {
            length = (byte)str.Length;
            chars = str.ToCharArray();
        }

        public StringBase(char c)
        {
            length = 2;
            chars = new char[1] { c };
        }

        public byte Length
        {
            get { return length; }
        }

        public void Clear()
        {
            length = 0;
            chars = new char[0];
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            StringBase stringObj = obj as StringBase;
            if (stringObj != null)
                return this.length.CompareTo(stringObj.Length);
            else
                throw new ArgumentException("Object is not a StringBase class");
            //throw new NotImplementedException();
        }

        public object Clone()
        {
            return this.Clone();
        }

        public static bool operator >(StringBase first, StringBase second)
        {
            int comparison = String.Compare(first.ToString(), second.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase);
            return comparison > 0;
        }

        public static bool operator <(StringBase first, StringBase second)
        {
            int comparison = String.Compare(first.ToString(), second.ToString(), comparisonType: StringComparison.OrdinalIgnoreCase);
            return comparison < 0;
        }

        public string ToString()
        {
            return null;
        }

    }
}