namespace TurtleCommandApp
{
    public partial class Form1 : Form
    {
        private static string _imagePosition = "Top";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TurtleBoard.Controls.Add(PBTurtle, 0, 3);
            TurtleBoard.BackColor = Color.Black;
            TurtleBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // LabelTurtlePosition make it invisible
            LabelTurtlePosition.Visible = false;
        }

        private void BtnDownArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int y = TurtleBoard.GetRow(PBTurtle);

            // move the turtle down one row
            if (y < 3)
            {
                TurtleBoard.SetRow(PBTurtle, y + 1);
            }
        }

        private void BtnRightArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int x = TurtleBoard.GetColumn(PBTurtle);
            if (x < 3)
            {
                TurtleBoard.SetColumn(PBTurtle, x + 1);
            }
        }

        private void BtnLeftArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int x = TurtleBoard.GetColumn(PBTurtle);
            if (x > 0)
            {
                TurtleBoard.SetColumn(PBTurtle, x - 1);
            }
        }

        private void BtnUpArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int y = TurtleBoard.GetRow(PBTurtle);

            // move the turtle down one row
            if (y > 0)
            {
                TurtleBoard.SetRow(PBTurtle, y - 1);
            }
        }

        private void BtnRotateClockwise_Click(object sender, EventArgs e)
        {
            PBTurtle.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            _imagePosition = _imagePosition switch
            {
                "Top" => "Right",
                "Right" => "Bottom",
                "Bottom" => "Left",
                "Left" => "Top",
                _ => _imagePosition
            };

            LabelTurtlePosition.Text = _imagePosition;
            PBTurtle.Refresh();
        }

        private void BtnRotateAntiClockWise_Click(object sender, EventArgs e)
        {
            PBTurtle.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            _imagePosition = _imagePosition switch
            {
                "Top" => "Left",
                "Right" => "Top",
                "Bottom" => "Right",
                "Left" => "Bottom",
                _ => _imagePosition
            };

            LabelTurtlePosition.Text = _imagePosition;
            PBTurtle.Refresh();
        }

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void BtnExecuteCommand_Click(object sender, EventArgs e)
        {
            /*
             Fetch the command text From TextBoxCommandInstructions.Text

            Begin the command always with 'cs' to clear the screen

            To move the turtle forward by 1 step command should be 'fd'

            To move the turtle backward by 1 step command should be 'bk'

            To turn the turtle left direction command should be 'lt'

            To turn the turtle right direction command should be 'rt'

            Complete the command with 'go' command click the BtnExecuteCommand to move the turtle to the desired location

            Add a number with a command to move the turtle multiple times

            PBTurtle direction can be detected by _imagePosition variable

            Example: cs, fd 2, rt, fd 3, go

            if no number added along with the command it should move only a step

            Use the buttons BtnUpArrow, BtnRightArrow, BtnDownArrow, BtnLeftArrow to move the button


             */

            string commandText = TextBoxCommandInstructions.Text;
            string[] commands = commandText.Split(',');

            foreach (string command in commands)
            {
                string trimmedCommand = command.Trim();
                string[] parts = trimmedCommand.Split(' ');
                string action = parts[0].Trim();
                int steps = parts.Length > 1 ? int.Parse(parts[1].Trim()) : 1;

                if (action == "cs")
                {
                    TurtleBoard.SetRow(PBTurtle, 3);
                    TurtleBoard.SetColumn(PBTurtle, 0);
                }
                else if (action == "fd")
                {
                    if (_imagePosition == "Top")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnUpArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Right")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnRightArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Bottom")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnDownArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Left")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnLeftArrow_Click(sender, e);
                        }
                    }
                }
                else if (action == "bk")
                {
                    if (_imagePosition == "Top")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnDownArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Right")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnLeftArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Bottom")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnUpArrow_Click(sender, e);
                        }
                    }
                    else if (_imagePosition == "Left")
                    {
                        for (int i = 0; i < steps; i++)
                        {
                            BtnRightArrow_Click(sender, e);
                        }
                    }
                }
                else if (action == "lt")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        BtnRotateAntiClockWise_Click(sender, e);
                    }
                }
                else if (action == "rt")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        BtnRotateClockwise_Click(sender, e);
                    }
                }
                else if (action == "go")
                {
                    break;
                }
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurtleBoard.SetRow(PBTurtle, 3);
            TurtleBoard.SetColumn(PBTurtle, 0);

            switch (_imagePosition)
            {
                // reset the image position
                case "Right":
                    BtnRotateAntiClockWise_Click(sender, e);
                    break;
                case "Bottom":
                    BtnRotateAntiClockWise_Click(sender, e);
                    BtnRotateAntiClockWise_Click(sender, e);
                    break;
                case "Left":
                    BtnRotateClockwise_Click(sender, e);
                    break;
            }
            
            TextBoxCommandInstructions.Text = "";
            TextBoxCommandInstructions.Focus();
        }
    }
}