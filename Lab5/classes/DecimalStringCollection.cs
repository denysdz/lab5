using Lab5.classes.Class2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.classes {
    class DecimalStringCollection : IEnumerable<DecimalString>, IEnumerable {
       
        private List<DecimalString> genericCollection;
        private ArrayList nonGenericCollection;

        public DecimalStringCollection() {
            genericCollection = new List<DecimalString>();
            nonGenericCollection = new ArrayList();
        }

        public void AddToGenericCollection(DecimalString item) {
            genericCollection.Add(item);
        }

        public void AddToNonGenericCollection(DecimalString item) {
            nonGenericCollection.Add(item);
        }

        public void DisplayElementInfo(int index) {
            if (index >= 0 && index < genericCollection.Count) {
                DecimalString element = genericCollection[index];
                Console.WriteLine($"Element at index {index}: {element.ToString()}");
            }
            else {
                Console.WriteLine("Index is out of range.");
            }
        }

        public IEnumerator<DecimalString> GetEnumerator() {
            return genericCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return nonGenericCollection.GetEnumerator();
        }

    }
}
