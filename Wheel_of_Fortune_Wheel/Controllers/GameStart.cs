using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Wheel_of_Fortune_Wheel.gameboard;

namespace Wheel_of_Fortune_Wheel.Controllers
{
    /// <summary>
    /// Controls the main frame of the game so when the game starts, everything goes through here.
    /// </summary>
    public class GameStart
    {
        private GameController controller;
        private Main main;
        /// <summary>
        /// Constructor
        /// </summary>
        public GameStart(Main main)
        {
            this.main = main;
            controller= new GameController();
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void Start()
        {
            SetCatagoryLabel();
        }

        /// <summary>
        /// Sets the catagory label so our user knows what catagory
        /// </summary>
        public void SetCatagoryLabel()
        {
            main.catagoryLabel.Text = controller.catagory; 
        }

        /// <summary>
        /// Standard click even to make it easy instead of making multiple for each letter
        /// </summary>
        /// <param name="letter"></param>
        public void click(Letter letter,bool clickable)
        {
            if (clickable)
            {
                if (controller.CheckLetter(letter.letter))
                {
                    int[] locs = controller.GetLocations(letter.letter);
                    for (int i = 0; i < locs.Length; i++)
                    {
                        Main.puzzleHolder[locs[i]].Image = letter.img;
                    }
                }
            }
        }
    }
}
