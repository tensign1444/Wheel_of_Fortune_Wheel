using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Controllers.Catagories
{
    /// <summary>
    /// Class that holds and creates the catagory array
    /// </summary>
    public static class CatagoryFactory
    {

        private static Catagories[] catagories = new Catagories[] { new AroundTheHouse(), new FunAndGames()}; //array of catagories

        /// <summary>
        /// Gets the catagories and returns them as an array of catagories
        /// </summary>
        /// <returns>array of catagories</returns>
        public static Catagories[] GetCatagories() { return catagories; }
    }
}
