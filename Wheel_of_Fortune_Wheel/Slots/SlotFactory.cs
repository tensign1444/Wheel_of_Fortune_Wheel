using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Wheel_of_Fortune_Wheel.Slots
{
    public static class SlotFactory
    {
        static string livePath = Environment.CurrentDirectory;
        private static Slots[] slots = new Slots[24];
        private static int[] vals = new int[] { 3500, 0, 6500, 1000, 3000, 1, 7500, 1250, 3500, 2000, 5000, 0, 20000, 1500, 4000, 1750, 1000, 2000, 1250, 5000, 2500, 7500, 10000, 4500 };

        /// <summary>
        /// Static Constructor
        /// </summary>
        static SlotFactory() { slots = Intialize(); }

        /// <summary>
        /// Get's slots so our controller can have the slots array.
        /// </summary>
        /// <returns></returns>
        public static Slots[] GetSlots()
        {
            return slots;
        }
        /// <summary>
        /// Private intializer so we can create our slots array to keep track of all our slots on the wheel.
        /// </summary>
        /// <returns>Slots array</returns>
        private static Slots[] Intialize()
        {
            Slots[] temp = new Slots[24];

            int value;
            bool isBankrupt, loseTurn = false;

            for (int i= 0; i < temp.Length; i++)
            {
                value = vals[i];
                if(value == 0)
                {
                    isBankrupt = true;
                    loseTurn= true;
                }                    
                else if(value == 1)
                {
                    isBankrupt = false;
                    loseTurn = true;
                }
                else
                {
                    isBankrupt = false;
                    loseTurn = false;
                }
                Image img = Image.FromFile(livePath + "\\Resources\\Slots\\Slot " + (i + 1) + " active.png");
                Slots tmp = new Slots(vals[i],isBankrupt, loseTurn, img);
                temp[i] = tmp;
            }
            return temp;
        }
    }
}
