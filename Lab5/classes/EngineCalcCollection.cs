using Lab5.classes.Class2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.classes {
    class EngineCalcCollection : IEnumerable<EngineeringСalculator> {
       
        private SortedList nonGenericCollection;
        private SortedList<int, EngineeringСalculator> genericCollection;

        public EngineCalcCollection() {
            nonGenericCollection = new SortedList();
            genericCollection = new SortedList<int, EngineeringСalculator>();
        }

        public void AddToGenericCollection(int key, EngineeringСalculator item) {
            genericCollection.Add(key, item);
        }

        public void AddToNonGenericCollection(int key, EngineeringСalculator item) {
            nonGenericCollection.Add(key, item);
        }

        public IEnumerator<EngineeringСalculator> GetEnumerator() {
            return genericCollection.Values.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return nonGenericCollection.GetEnumerator();
        }

        public int GetLastGenereticKey() {
            if (genericCollection.Count > 0) {
                return genericCollection.Keys[genericCollection.Count - 1];
            }
            else {
                return 0;
            }
        }

        public int GetLastNonGenereticKey() {
            if (nonGenericCollection.Count > 0) {
                return (int)nonGenericCollection.GetKey(nonGenericCollection.Count - 1);
            }
            else {
                return 0;
            }
        }


    }
}
