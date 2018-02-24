using System;

namespace MathWorkshop {
    public class Math {
        public int Value { get; set; }
        public Math (int value) {
            Value = value;
        }
        public Math Add (int ValueToAdd) 
        {
        checked{
            Value += ValueToAdd;
            return this;}
        }

        public Math () {

        }
    }
}