using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Slots
{
    public interface ISlot
    {
        int value { get; set; } //tells us the value is worth

        bool bankrupt { get; set; } //tells  us if value is bankrupt

        bool loseTurn { get; set; } //tells us if value is lose a turn

        Image img { get; set; }
    }
}
