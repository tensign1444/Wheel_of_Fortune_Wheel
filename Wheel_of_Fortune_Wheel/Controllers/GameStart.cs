using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Start()
        {
            SetCatagoryLabel();
        }

        public void SetCatagoryLabel()
        {
            main.catagoryLabel.Text = controller.catagory; 
        }
    }
}
