using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel_of_Fortune_Wheel.Players
{
    /// <summary>
    /// interface for 
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public long money { get ; set; }

        public Player(string name)
        {
            this.Name = name;
            this.money = 0;
        }


    }
}
