using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_of_Fortune_Wheel
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            CustomeFont();
            InitializeComponent();
        }

        private void CustomeFont()
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.SF_Fortune_Wheel.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.SF_Fortune_Wheel;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(playerOneText.Text.Length == 0 && playerTwoTxt.Text.Length == 0 && playerThreeTxt.Text.Length == 0 )
            {
                MessageBox.Show("Please Insert at least one player name.");
                return;
            }
            else
            {
                Main game = new Main(playerOneText.Text, playerTwoTxt.Text, playerThreeTxt.Text, this);
                game.Show();
                this.Hide();
            }
        }
    }
}
