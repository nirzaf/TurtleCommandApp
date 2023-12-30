using Timer = System.Threading.Timer;

namespace TurtleCommandApp
{
    public partial class Form1 : Form
    {
        private static string _imagePosition = "Top";
        private static (int, int) _carPosition;
        private static (int, int) _treePosition;
        private static (int, int) _cakePosition;
        private static (int, int) _poolPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            TurtleBoard.Controls.Add(PBTurtle, 0, 3);
            TurtleBoard.BackColor = Color.Black;
            TurtleBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            LabelTurtlePosition.Visible = false;
            ShufflePictureBoxes();
        }

        private void ShufflePictureBoxes()
        {
            // Place the PictureBoxes PbPool, PbCar, PbTree, PbCake in random positions on the table layout panel TurtleBoard
            Random random = new();
            int[] positions = { 0, 1, 2, 3 };
            PictureBox[] pictureBoxes = { PbPool, PbCar, PbTree, PbCake };
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                int randomRow;
                int randomColumn;
                do
                {
                    randomRow = random.Next(positions.Length);
                    randomColumn = random.Next(positions.Length);
                } while (randomColumn == 0 && randomRow == 3); // Repeat if the position is column 0, row 3

                TurtleBoard.SetRow(pictureBox, randomRow);
                TurtleBoard.SetColumn(pictureBox, randomColumn);
            }

            //fetch the position of the PictureBoxes PbPool, PbCar, PbTree, PbCake in the table layout panel TurtleBoard x and y coordinates
            int poolColumn = TurtleBoard.GetColumn(PbPool);
            int poolRow = TurtleBoard.GetRow(PbPool);
            int carColumn = TurtleBoard.GetColumn(PbCar);
            int carRow = TurtleBoard.GetRow(PbCar);
            int treeColumn = TurtleBoard.GetColumn(PbTree);
            int treeRow = TurtleBoard.GetRow(PbTree);
            int cakeColumn = TurtleBoard.GetColumn(PbCake);
            int cakeRow = TurtleBoard.GetRow(PbCake);

            _poolPosition = (poolColumn, poolRow);
            _carPosition = (carColumn, carRow);
            _treePosition = (treeColumn, treeRow);
            _cakePosition = (cakeColumn, cakeRow);
        }
        
                
        private void OnTimerColumnTickPlus(object? o, EventArgs eventArgs, int column, System.Windows.Forms.Timer timer1)
        {
            timer1.Interval = 500;
            TurtleBoard.SetColumn(PBTurtle, column + 1);
            timer1.Stop();
        }
        
        private void OnTimerRowTickPlus(object? o, EventArgs eventArgs, int row, System.Windows.Forms.Timer timer1)
        {
            timer1.Interval = 500;
            TurtleBoard.SetRow(PBTurtle, row + 1);
            timer1.Stop();
        }
        
        private void OnTimerColumnTickMinus(object? o, EventArgs eventArgs, int column, System.Windows.Forms.Timer timer1)
        {
            timer1.Interval = 500;
            TurtleBoard.SetColumn(PBTurtle, column - 1);
            timer1.Stop();
        }
        
        private void OnTimerRowTickMinus(object? o, EventArgs eventArgs, int row, System.Windows.Forms.Timer timer1)
        {
            timer1.Interval = 500;
            TurtleBoard.SetRow(PBTurtle, row - 1);
            timer1.Stop();
        }

        private void BtnRightArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int column = TurtleBoard.GetColumn(PBTurtle);
            int row = TurtleBoard.GetRow(PBTurtle);
            if (column >= 3) return;
            //check if next position of column has a picture box using the _carPosition, _treePosition, _cakePosition, _poolPosition
            if (_carPosition != (column + 1, row) && _treePosition != (column + 1, row) && _cakePosition != (column + 1, row) && _poolPosition != (column + 1, row))
            {
                System.Windows.Forms.Timer timer1 = new();
                timer1.Tick += (s, args) => OnTimerColumnTickPlus(s, args, column, timer1);
                timer1.Start();
            }
            else
            {
                if (_carPosition == (column + 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the car");
                }
                else if (_treePosition == (column + 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the tree");
                }
                else if (_cakePosition == (column + 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the cake");
                }
                else if (_poolPosition == (column + 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the pool");
                }
            }
        }

        private void BtnDownArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int column = TurtleBoard.GetColumn(PBTurtle);
            int row = TurtleBoard.GetRow(PBTurtle);

            if (row >= 3) return;
            //check if next position of row has a picture box using the _carPosition, _treePosition, _cakePosition, _poolPosition
            if (_carPosition != (column, row + 1) && _treePosition != (column, row + 1) &&
                _cakePosition != (column, row + 1) && _poolPosition != (column, row + 1))
            {
                // TurtleBoard.SetRow(PBTurtle, row + 1);
                System.Windows.Forms.Timer timer1 = new();
                timer1.Tick += (s, args) => OnTimerRowTickPlus(s, args, row, timer1);
                timer1.Start();
            }
            else
            {
                if (_carPosition == (column, row + 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the car");
                }
                else if (_treePosition == (column, row + 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the tree");
                }
                else if (_cakePosition == (column, row + 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the cake");
                }
                else if (_poolPosition == (column, row + 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the pool");
                }
            }
        }

        private void BtnLeftArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int column = TurtleBoard.GetColumn(PBTurtle);
            int row = TurtleBoard.GetRow(PBTurtle);
            if (column <= 0) return;
            //check if previous position of column has a picture box using the _carPosition, _treePosition, _cakePosition, _poolPosition
            if (_carPosition != (column - 1, row) && _treePosition != (column - 1, row) && _cakePosition != (column - 1, row) && _poolPosition != (column - 1, row))
            {
                // TurtleBoard.SetColumn(PBTurtle, column - 1);
                System.Windows.Forms.Timer timer1 = new();
                timer1.Tick += (s, args) => OnTimerColumnTickMinus(s, args, column, timer1);
                timer1.Start();
            }
            else
            {
                if (_carPosition == (column - 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the car");
                }
                else if (_treePosition == (column - 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the tree");
                }
                else if (_cakePosition == (column - 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the cake");
                }
                else if (_poolPosition == (column - 1, row))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the pool");
                }
            }
        }

        private void BtnUpArrow_Click(object sender, EventArgs e)
        {
            // fetch the current position of the PBTurtle picture box in the table layout panel TurtleBoard x and y coordinates
            int column = TurtleBoard.GetColumn(PBTurtle);
            int row = TurtleBoard.GetRow(PBTurtle);
            if (row <= 0) return;
            //check if previous position of row has a picture box using the _carPosition, _treePosition, _cakePosition, _poolPosition
            if (_carPosition != (column, row - 1) && _treePosition != (column, row - 1) && _cakePosition != (column, row - 1) && _poolPosition != (column, row - 1))
            {
                // TurtleBoard.SetRow(PBTurtle, row - 1);
                System.Windows.Forms.Timer timer1 = new();
                timer1.Tick += (s, args) => OnTimerRowTickMinus(s, args, row, timer1);
                timer1.Start();
            }
            else
            {
                if (_carPosition == (column, row - 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the car");
                }
                else if (_treePosition == (column, row - 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the tree");
                }
                else if (_cakePosition == (column, row - 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the cake");
                }
                else if (_poolPosition == (column, row - 1))
                {
                    TurtleBoard.Controls.Remove(PBTurtle);
                    MessageBox.Show(@"You got the pool");
                }
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
            NewGame();

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

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}