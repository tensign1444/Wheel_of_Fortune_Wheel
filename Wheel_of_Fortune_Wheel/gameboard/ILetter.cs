using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.gameboard
{
    public interface ILetter
    {
        char letter { get; set; } //letter of the letter
        Image img { get; set; } //image for the letter

        bool Equals(Object obj);
    }
}
