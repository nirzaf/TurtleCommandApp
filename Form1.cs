namespace TurtleCommandApp;

public partial class Form1 : Form
{
    private static string _imagePosition = "Top";
    private static (int, int) _carPosition;
    private static (int, int) _treePosition;
    private static (int, int) _cakePosition;
    private static (int, int) _poolPosition;
    private static string[] _gameTargets = new string[4];
    private static string _currentTarget = "";
    private static (int, int) _currentTargetPosition;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _gameTargets = ["Go to the pool", "Go to the car", "Go to the tree", "Go to the cake"];
        NewGame();
    }

    private void NewGame()
    {
        TurtleBoard.Controls.Add(PBTurtle, 0, 3);
        TurtleBoard.BackColor = Color.Black;
        TurtleBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        LabelTurtlePosition.Visible = false;

        //find the random target from _gameTargets
        Random random = new();
        int randomIndex = random.Next(_gameTargets.Length);
        string randomTarget = _gameTargets[randomIndex];
        LabelGameTarget.Text = randomTarget;
        _currentTarget = randomTarget;
        ShufflePictureBoxes();
    }

    private void ShufflePictureBoxes()
    {
        Random random = new();
        int[] positions = [0, 1, 2, 3];
        PictureBox[] pictureBoxes = [PbPool, PbCar, PbTree, PbCake];
        foreach (PictureBox pictureBox in pictureBoxes)
        {
            int randomRow = random.Next(positions.Length);
            int randomColumn = random.Next(positions.Length);

            if (randomRow == 3 && randomColumn == 0)
            {
                randomRow = random.Next(positions.Length);
                randomColumn = random.Next(positions.Length);
            }

            if (randomRow == 3 && randomColumn == 0)
            {
                randomRow = random.Next(positions.Length);
                randomColumn = random.Next(positions.Length);
            }

            TurtleBoard.SetColumn(pictureBox, randomColumn);
            TurtleBoard.SetRow(pictureBox, randomRow);
        }

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

        _currentTargetPosition = _currentTarget switch
        {
            "Go to the pool" => _poolPosition,
            "Go to the car" => _carPosition,
            "Go to the tree" => _treePosition,
            "Go to the cake" => _cakePosition,
            _ => _currentTargetPosition
        };
    }


    private void BtnRightArrow_Click(object sender, EventArgs e)
    {
        int column = TurtleBoard.GetColumn(PBTurtle);
        int row = TurtleBoard.GetRow(PBTurtle);
        if (column >= 3) return;

        if (_carPosition != (column + 1, row) && _treePosition != (column + 1, row)
                                              && _cakePosition != (column + 1, row) &&
                                              _poolPosition != (column + 1, row))
        {
            Thread.Sleep(750);
            TurtleBoard.SetColumn(PBTurtle, column + 1);
        }
        else
        {
            if (_carPosition == (column + 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _carPosition)
                {
                    MessageBox.Show(@"You reached the car successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_treePosition == (column + 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _treePosition)
                {
                    MessageBox.Show(@"You reached the tree successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_cakePosition == (column + 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _cakePosition)
                {
                    MessageBox.Show(@"You reached the cake successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_poolPosition == (column + 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _poolPosition)
                {
                    MessageBox.Show(@"You reached the pool successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
        }
    }

    private void BtnDownArrow_Click(object sender, EventArgs e)
    {
        int column = TurtleBoard.GetColumn(PBTurtle);
        int row = TurtleBoard.GetRow(PBTurtle);

        if (row >= 3) return;

        if (_carPosition != (column, row + 1) && _treePosition != (column, row + 1) &&
            _cakePosition != (column, row + 1) && _poolPosition != (column, row + 1))
        {
            Thread.Sleep(750);
            TurtleBoard.SetRow(PBTurtle, row + 1);
        }
        else
        {
            if (_carPosition == (column, row + 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _carPosition)
                {
                    MessageBox.Show(@"You reached the car successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_treePosition == (column, row + 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _treePosition)
                {
                    MessageBox.Show(@"You reached the tree successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_cakePosition == (column, row + 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _cakePosition)
                {
                    MessageBox.Show(@"You reached the cake successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_poolPosition == (column, row + 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _poolPosition)
                {
                    MessageBox.Show(@"You reached the pool successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
        }
    }

    private void BtnLeftArrow_Click(object sender, EventArgs e)
    {
        int column = TurtleBoard.GetColumn(PBTurtle);
        int row = TurtleBoard.GetRow(PBTurtle);
        if (column <= 0) return;

        if (_carPosition != (column - 1, row) && _treePosition != (column - 1, row)
                                              && _cakePosition != (column - 1, row) &&
                                              _poolPosition != (column - 1, row))
        {
            Thread.Sleep(750);
            TurtleBoard.SetColumn(PBTurtle, column - 1);
        }
        else
        {
            if (_carPosition == (column - 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _carPosition)
                {
                    MessageBox.Show(@"You reached the car successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_treePosition == (column - 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _treePosition)
                {
                    MessageBox.Show(@"You reached the tree successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_cakePosition == (column - 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _cakePosition)
                {
                    MessageBox.Show(@"You reached the cake successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_poolPosition == (column - 1, row))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _poolPosition)
                {
                    MessageBox.Show(@"You reached the pool successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
        }
    }

    private void BtnUpArrow_Click(object sender, EventArgs e)
    {
        int column = TurtleBoard.GetColumn(PBTurtle);
        int row = TurtleBoard.GetRow(PBTurtle);
        if (row <= 0) return;
        if (_carPosition != (column, row - 1) && _treePosition != (column, row - 1)
                                              && _cakePosition != (column, row - 1) &&
                                              _poolPosition != (column, row - 1))
        {
            Thread.Sleep(500);
            TurtleBoard.SetRow(PBTurtle, row - 1);
        }
        else
        {
            if (_carPosition == (column, row - 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _carPosition)
                {
                    MessageBox.Show(@"You reached the car successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_treePosition == (column, row - 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _treePosition)
                {
                    MessageBox.Show(@"You reached the tree successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_cakePosition == (column, row - 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _cakePosition)
                {
                    MessageBox.Show(@"You reached the cake successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            else if (_poolPosition == (column, row - 1))
            {
                TurtleBoard.Controls.Remove(PBTurtle);
                if (_currentTargetPosition == _poolPosition)
                {
                    MessageBox.Show(@"You reached the pool successfully, Congratulations");
                    NewGame();
                }
                else
                {
                    DialogResult result = MessageBox.Show(@"You have reached the wrong target. Try again.",
                        @"Wrong Target", MessageBoxButtons.RetryCancel);
                    switch (result)
                    {
                        case DialogResult.Retry:
                            NewGame();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
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

        if (!commandText.Trim().StartsWith("cs"))
        {
            MessageBox.Show(@"Invalid Command");
            return;
        }

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

            if (action != "cs" && action != "fd" && action != "lt" && action != "rt" && action != "bk" &&
                action != "go")
            {
                MessageBox.Show(@"Invalid Command");
                return;
            }

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
}