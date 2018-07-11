using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   /// <summary>
    /// Represents an individual 6 sided die
    /// </summary>
    class Die
    {
        // This static field is shared across all instances of the die class
        private static Random rand = new Random();

        /// <summary>
        /// Creates a die with an initial random value
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// IsHeld = true if a die is held, false if not held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Value = what the die is representing
        /// </summary>
        public byte Value { get; private set; }
        // make set private, and force the class to generate random die values.

        /// <summary>
        /// Rolls the die if it is not held and sets the number between 1 and 6 inclusive
        /// </summary>
        public void Roll()
        {
            if (!IsHeld)
            {
                int randValue = rand.Next(1, 7);
                this.Value = Convert.ToByte(randValue);
            }
            
        } 
    }
}
