using System;
using Wheel_of_Fortune_Wheel.Slots;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wheel_of_Fortune_Wheel.gameboard;
using System.Runtime.CompilerServices;
using Wheel_of_Fortune_Wheel.Controllers;
using Wheel_of_Fortune_Wheel.Players;

namespace Wheel_of_Fortune_Wheel
{
    public partial class Main : Form
    {
        //Allows the use of the current working directory where the images are then retrieved
        static string livePath = Environment.CurrentDirectory;
        //Utilized in order to create a class of images to use for the spin.
        static Slots.Slots[] slots = new Slots.Slots[24];
        //all the possible  letters to select
        static Letter[] letters = new Letter[35];

         

        GameStart start; //game controller

        //Sets the current slot number to 0.
        static int i = 0;
        //Used to make the spinner start in the non spinning
        //position then trigger once button is pressed.
        static bool spinning = false;
        //Used to control the SpinTheWheel function below.
        static Thread SpinWheel = new Thread(SpinTheWheel);
        //Used to close and open SpinWheel throughtout the code.
        static PictureBox wheel = new PictureBox();
        //Initializes the main program and assigns WOF_Wheel to wheel.
        static PictureBox[] letterHolders;

        public static PictureBox[] puzzleHolder;

        static Player[] players = new Player[3]; //list of players

        static Label[] moneyLabels;// array that holds all the money

        static int playerTurn; //player who is up

        static bool clickable;

        private Form form; //main menu form to close 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        /// <param name="form"></param>
        public Main(string player1, string player2 = "player 2", string player3 = "player 3", Form form = null)
        {
            InitializeComponent();
            wheel = WOF_Wheel;
            slots = SlotFactory.GetSlots();
            letters = LetterFactory.GetLetters();
            letterHolders = new PictureBox[]
            {
                aButton, bButton, cButton, dButton, eButton,
                fButton, gButton, hButton, iButton, jButton,
                kButton,lButton,mButton,nButton,oButton,pButton,
                qButton,rButton,sButton,tButton, uButton, vButton,
                wButton,xButton,yButton,zButton
            };
            moneyLabels = new Label[] {
                playerOneMoney, playerTwoMoney, playerThreeMoney,
            };

            puzzleHolder = new PictureBox[]
            {
                letter1, letter2, letter3, letter4, letter5, letter6, letter7, letter8,
                letter9, letter10, letter11, letter12, letter13, letter14, letter15, letter16, letter17, letter18, letter19, letter20, letter21, letter22, letter23, letter24, letter25, letter26,
                letter27, letter28, letter29, letter30, letter31, letter32, letter33, letter34, letter35, letter36,
                letter37, letter38, letter39, letter40, letter41, letter42, letter43, letter44, letter45, letter46,
                letter47, letter48, letter49, letter50, letter51,letter52
            };

            SetPlayerOptions();
            clickable= false;

            this.form = form;
            CreatePlayers(player1,player2,player3);
            playerOneLabel.Text= player1;
            playerTwoLabel.Text= player2;
            playerThreeLabel.Text= player3;
            
        }

        /// <summary>
        /// Sets the  next player that is up to being up.
        /// </summary>
        static void GetNextTurn()
        {
            if (playerTurn >= players.Length - 1)
            {
                playerTurn = 0;
            }
            else
            {
                playerTurn++;
            }
        }


        /// <summary>
        /// Creates the player objects so we can keep track of players
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <param name="player3"></param>
        static void CreatePlayers(string player1, string player2, string player3)
        {
            string[] names  = new string[] {player1,player2, player3 };
            for(int i = 0; i < 3; i++)
            {
                Player player = new Player(names[i]);
                players[i] = player;
            }
            playerTurn = 0;
        }

        /// <summary>
        /// Sets the letter options for the player
        /// </summary>
        static void SetPlayerOptions()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for(int i = 0; i < letterHolders.Length; i++)
            {
                letterHolders[i].Image = Image.FromFile(livePath + $"\\Resources\\Letters\\{alpha[i]}.jpg");
            }
        }

        //Allows the the looping through of all png images, which
        //is what makes it look like the wheel is spinning.
        static void ImageChanger()
        {
            if (i + 1 >= slots.Length)
                i = 0;
            else
                i++;
            //Collects the images from the current resource directory.    
            GC.Collect();
            wheel.Invoke(new Action(() => wheel.BackgroundImage = slots[i].img));
        }
        //Supposed to spin the wheel at random but it is currently not doing so
        //and keeps landing on the same one.
        static void SpinTheWheel()
        {
            Random random = new Random();
            int cycle = 1;

            for (int y = 0; y < 5; y++)
            {
                //spin speed
                int randVar = random.Next(10, 100);
                int spin = random.Next((randVar - ((cycle - 1) * randVar)), (randVar - ((cycle - 1) * randVar)));
                for (int x = 0; x < spin; x++)
                {
                    ImageChanger();
                    Thread.Sleep(10 * cycle);
                }
                cycle++;
            }
            //This is also have troubles working as it will not actually print the wedge that was landed on.
            spinning = false;
            if (slots[i].loseTurn && !slots[i].bankrupt)
            {
                GetNextTurn();
            }
            else if (slots[i].bankrupt)
            {
                players[playerTurn].money = 0;
                updateLabel();
                GetNextTurn();
            }
            else
            {
                players[playerTurn].money += slots[i].value;             
                clickable= true;
                updateLabel();
                GetNextTurn();
            }
            
            SpinWheel.Abort();
        }
        

        /// <summary>
        /// Updates the money labels so we know how much money our users have
        /// </summary>
        static void updateLabel()
        {           
            if (moneyLabels[playerTurn].InvokeRequired)
            {
                moneyLabels[playerTurn].BeginInvoke((MethodInvoker)delegate () { moneyLabels[playerTurn].Text = players[playerTurn].money.ToString(); ; });
            }
            else
            {
                moneyLabels[playerTurn].Text = players[playerTurn].money.ToString(); ;
            }
        }

        /// <summary>
        /// Spin button click event so the wheel can spin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spin_Button_Click(object sender, EventArgs e)
        {
            if (!spinning)
            {
                Thread SpinWheel = new Thread(SpinTheWheel);
                spinning = true;
                SpinWheel.Start();
            }
        }

        /// <summary>
        /// Loads the start of the game so the user can start playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            this.start = new GameStart(this);
            start.Start();
        }

        /// <summary>
        /// Closes the game so there are no processes running on users  computer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form.Close();
        }








        //Letter selection button clicks ______________________________________


        private void aButton_Click(object sender, EventArgs e)
        {
            start.click(letters[0],clickable);
            clickable= false;
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            start.click(letters[1], clickable);
            clickable = false;
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            start.click(letters[2], clickable);
            clickable = false;
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            start.click(letters[3], clickable);
            clickable= false;
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            start.click(letters[4], clickable);
            clickable= false;
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            start.click(letters[5], clickable);
            clickable= false;
        }

        private void gButton_Click(object sender, EventArgs e)
        {
            start.click(letters[6], clickable);
            clickable= false;
        }

        private void hButton_Click(object sender, EventArgs e)
        {
            start.click(letters[7], clickable);
            clickable= false;
        }

        private void iButton_Click(object sender, EventArgs e)
        {
            start.click(letters[8], clickable);
            clickable= false;
        }

        private void jButton_Click(object sender, EventArgs e)
        {
            start.click(letters[9], clickable);
            clickable= false;
        }

        private void kButton_Click(object sender, EventArgs e)
        {
            start.click(letters[10], clickable);
            clickable= false;
        }

        private void lButton_Click(object sender, EventArgs e)
        {
            start.click(letters[11], clickable);
            clickable= false;
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            start.click(letters[12], clickable);
            clickable= false;
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            start.click(letters[13], clickable);
            clickable= false;
        }

        private void oButton_Click(object sender, EventArgs e)
        {
            start.click(letters[14], clickable);
            clickable= false;
        }

        private void pButton_Click(object sender, EventArgs e)
        {
            start.click(letters[15], clickable);
            clickable= false;
        }

        private void qButton_Click(object sender, EventArgs e)
        {
            start.click(letters[16], clickable);
            clickable= false;
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            start.click(letters[17], clickable);
            clickable= false;
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            start.click(letters[18], clickable);
            clickable= false;
        }

        private void tButton_Click(object sender, EventArgs e)
        {
            start.click(letters[19], clickable);
            clickable= false;
        }

        private void uButton_Click(object sender, EventArgs e)
        {
            start.click(letters[20], clickable);
            clickable= false;
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            start.click(letters[21], clickable);
            clickable= false;
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            start.click(letters[22], clickable);
            clickable= false;
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            start.click(letters[23], clickable);
            clickable= false;
        }

        private void yButton_Click(object sender, EventArgs e)
        {
            start.click(letters[24], clickable);
            clickable= false;
        }

        private void zButton_Click(object sender, EventArgs e)
        {
            start.click(letters[25], clickable);
            clickable= false;
        }
    }
}