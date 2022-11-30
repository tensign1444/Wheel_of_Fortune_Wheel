using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Slots
{
    public class Slots : ISlot
    {
        public int value { get; set; }
        public bool bankrupt { get ; set; }
        public bool loseTurn { get; set; }
        public Image img { get; set; }

        public Slots(int value, bool bankrupt, bool loseTurn, Image img)
        {
            this.value = value;
            this.bankrupt = bankrupt;
            this.loseTurn = loseTurn;
            this.img = img;
        }
    }
}
