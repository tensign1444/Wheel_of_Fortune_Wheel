using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Controllers.Catagories
{
    public class AroundTheHouse : Catagories
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AroundTheHouse()
        {
            this.catagory = "AROUND THE HOUSE";
            this.phrases = new string[]
            {
                "A CANDLE IN THE WINDOW",
                "A CANVAS BACKPACK",
                "A PILE OF COATS",
                "BOX OF OLD CLOTHES",
                "BUNK BEDS",
                "COAT CLOSET",
                "TOOTHBRUSH"
            };
        }
    }
}
