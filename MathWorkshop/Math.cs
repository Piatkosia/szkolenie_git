using System;
using MSMath = System.Math; 
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
            return this;
            }
        }

  public Math Sub (int ValueToSubstract) 
        {
        checked{
            Value -= ValueToSubstract;
            return this;
            }
        }

        public Math () {

        }
    }
}