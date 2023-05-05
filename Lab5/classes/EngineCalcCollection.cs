using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.classes {
    class EngineCalcCollection {
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

    }
}
