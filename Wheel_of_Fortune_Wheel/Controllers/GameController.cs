using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheel_of_Fortune_Wheel.gameboard;

namespace Wheel_of_Fortune_Wheel.Controllers
{
    public class GameController
    {
        private Letter[] letters = new Letter[24]; //list of letters
        public char[] phrase { get; set; } //the selected phrase
        public string catagory { get; set; } //the selected catagory
        public bool solved = false; //Tells us if the puzzle has been solved

        private PuzzleSelector.PuzzleController selector; //the puzzle we selected
        public GameController() 
        {
            Regenerate();
        }


        /// <summary>
        /// Deconstructor to save memory when the user solves it.
        /// </summary>
        ~GameController() { Console.WriteLine("Destructor was called."); }

        /// <summary>
        /// Sets a new catagory and phrase
        /// </summary>
        public void Regenerate()
        {
            this.selector = new PuzzleSelector.PuzzleController();
            this.catagory = selector.catagory;
            this.phrase = stringToCharArr(selector.phrase);
            this.letters = LetterFactory.GetLetters();
        }

        /// <summary>
        /// Checks if the letter is even in the phrase
        /// </summary>
        /// <param name="letter"></param>
        /// <returns>true if it is, false if not</returns>
        public bool CheckLetter(char letter)
        {
            if(this.phrase.Contains(letter)) return true;
            return false;
        }

        /// <summary>
        /// Get's all locations of the letter so we know where they go on the board
        /// </summary>
        /// <param name="letter"></param>
        /// <returns>array of all the locations.</returns>
        public int[] GetLocations(char letter)
        {
            List<int> locations = new List<int>();
            for(int i = 0; i < phrase.Length; i++)
            {
                if (this.phrase[i].Equals(letter))
                    locations.Add(i);
            }
            return locations.ToArray();
        }

        /// <summary>
        /// Turns the phrase into a character array
        /// </summary>
        /// <param name="str"></param>
        /// <returns>char array of the phrase</returns>
        private char[] stringToCharArr(string str)
        {
            return str.ToCharArray();
        }


    }
}
