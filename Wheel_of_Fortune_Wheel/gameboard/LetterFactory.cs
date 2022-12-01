using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheel_of_Fortune_Wheel.Slots;

namespace Wheel_of_Fortune_Wheel.gameboard
{
    public class LetterFactory
    {
        static string livePath = Environment.CurrentDirectory;
        static char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ':,!&-.# ".ToLower().ToCharArray();
        private static Letter[] letters = new Letter[35];

        /// <summary>
        /// constructor
        /// </summary>
        static LetterFactory()
        {
            letters = Intialize();
        }

        /// <summary>
        /// Get's the Letters array
        /// </summary>
        /// <returns>returns the array of letters.</returns>
        public static Letter[] GetLetters()
        {
            return letters;
        }

        private static Letter[] Intialize()
        {

            Letter[] temp = new Letter[35];

            char val = default;
            Image img;
            char letter;
            for (int i = 0; i < alpha.Length; i++)
            {
                letter= alpha[i];

                if(letter.Equals(' '))
                    img = Image.FromFile(livePath + $"\\Resources\\Letters\\blank_side.jpg");
                else if(letter.Equals(':'))
                    img = Image.FromFile(livePath + $"\\Resources\\Letters\\colon.jpg");
                else
                    img = Image.FromFile(livePath + $"\\Resources\\Letters\\{letter}.jpg");

                Letter tmp = new Letter(alpha[i], img);
                temp[i] = tmp;
            }
            return temp;
        }
    }
}
