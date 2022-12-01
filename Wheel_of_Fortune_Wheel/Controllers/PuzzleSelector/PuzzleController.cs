using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Controllers.PuzzleSelector
{
    /// <summary>
    /// Controls the selected puzzle
    /// </summary>
    public class PuzzleController
    {
        private Catagories.Catagories[] catagories;
        private Catagories.Catagories catagoryHolder;
        public string catagory;
        public string phrase;

        /// <summary>
        /// Constructor, selects  phrase and catagory
        /// </summary>
        public PuzzleController() 
        {
            this.catagories = Catagories.CatagoryFactory.GetCatagories();
            this.catagoryHolder = selectCatagory();
            this.catagory = this.catagoryHolder.catagory;
            this.phrase = selectPhrase();
        }

        /// <summary>
        /// Selects the catagory
        /// </summary>
        /// <returns>The selected catagory</returns>
        private Catagories.Catagories selectCatagory()
        {
            Random rand = new Random();
            return catagories[rand.Next(catagories.Length)];
        }

        /// <summary>
        /// Selects the phrase
        /// </summary>
        /// <returns>string of the selected phrase</returns>
        private string selectPhrase()
        {
            Random rand = new Random();
            return catagoryHolder.phrases[rand.Next(catagoryHolder.phrases.Length)];
        }
    }
}
