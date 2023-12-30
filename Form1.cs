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
            string commandText = TextBoxCommandInstructions.Text;
            //if no cs in the beginning of the command, then show in MessageBox as Invalid Command
            if (!commandText.Trim().StartsWith("cs"))
            {
                MessageBox.Show(@"Invalid Command");
                return;
            }
            //if no go in the end of the command, then show in MessageBox as Invalid Command
            if (!commandText.Trim().EndsWith("go"))
            {
                MessageBox.Show(@"Invalid Command");
                return;
            }
            
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
                    switch (_imagePosition)
                    {
                        case "Top":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnUpArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Right":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnRightArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Bottom":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnDownArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Left":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnLeftArrow_Click(sender, e);
                            }

                            break;
                        }
                    }
                }
                else if (action == "bk")
                {
                    switch (_imagePosition)
                    {
                        case "Top":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnDownArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Right":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnLeftArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Bottom":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnUpArrow_Click(sender, e);
                            }

                            break;
                        }
                        case "Left":
                        {
                            for (int i = 0; i < steps; i++)
                            {
                                BtnRightArrow_Click(sender, e);
                            }

                            break;
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