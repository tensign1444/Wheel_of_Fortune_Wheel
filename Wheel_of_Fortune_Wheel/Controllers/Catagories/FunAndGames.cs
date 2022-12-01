using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Controllers.Catagories
{
    public class FunAndGames : Catagories
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FunAndGames() 
        {
            this.catagory = "FUN AND GAMES";
            this.phrases = new string[]
            {
                "BOOGIE BOARDING",
                "DODGEBALL",
                "GUITAR HERO",
                "MUSICAL CHAIRS",
                "PLAYING POKER",
                "RUGBY",
                "ZOOMING AROUND ON A JET SKI"
            };
        }

    }
}
