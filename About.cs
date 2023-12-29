using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleCommandApp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            // Add Command Instructions to TextCommandInstructions Rich Text box
            TextBoxCommandInstructions.Text = "Command Instructions:\n\n";
            TextBoxCommandInstructions.Text += "* To move the turtle forward -> fd\n";
            TextBoxCommandInstructions.Text += "* To move the turtle backward -> bk\n";
            TextBoxCommandInstructions.Text += "* To turn the turtle left -> lt\n";
            TextBoxCommandInstructions.Text += "* To turn the turtle right -> rt\n";
            TextBoxCommandInstructions.Text += "* Begin the command always with 'cs' to clear the screen\n";
            TextBoxCommandInstructions.Text += "* End with go to move the turtle to the desired location\n";
            TextBoxCommandInstructions.Text += "* Add a number with a command to move the turtle multiple times\n";
            TextBoxCommandInstructions.Text += "* Example: cs, fd 2, rt, fd, go\n";

            //disable the TextBoxCommandInstructions Text box
            TextBoxCommandInstructions.Enabled = false;
        }
    }
}
