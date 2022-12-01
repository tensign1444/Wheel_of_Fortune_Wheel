using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.gameboard
{
    /// <summary>
    /// Letter object class
    /// </summary>
    public class Letter : ILetter
    {
        public char letter { get; set; } //character of the letter
        public Image img { get; set; } //image for the letter

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="img"></param>
        public Letter(char letter, Image img)
        {
            this.letter = letter;
            this.img = img;
        }

        /// <summary>
        /// Checks if two Letters are equal. returns true if they are, false if otherwise.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        /// <exception cref="ArgumentNullException">thrown if object is null</exception>
        /// <exception cref="Exception">Thrown if object isn't of type letter</exception>
        public override bool Equals(Object obj)
        {
            if(obj == null) 
                throw new ArgumentNullException(nameof(obj));
            else if(!(obj is Letter)) 
                throw new Exception("Object is not of type Letter");
            
            return (this.letter == ((Letter)obj).letter);
           
        }
    }
}
