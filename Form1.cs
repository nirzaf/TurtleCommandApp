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
            TurtleBoard.Controls.Add(PBTurtle, 0, 0);
            TurtleBoard.BackColor = Color.Black;
            TurtleBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
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
            // rotate the turtle clockwise by 90 degrees from the current position
            PBTurtle.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            _imagePosition = _imagePosition switch
            {
                // keep track of the current position of the turtle in _imagePosition variable
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
            // rotate the turtle anti-clockwise by 90 degrees from the current position
            PBTurtle.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            // keep track of the current position of the turtle in _imagePosition variable
            if (_imagePosition == "Top")
            {
                _imagePosition = "Left";
            }
            else if (_imagePosition == "Right")
            {
                _imagePosition = "Top";
            }
            else if (_imagePosition == "Bottom")
            {
                _imagePosition = "Right";
            }
            else if (_imagePosition == "Left")
            {
                _imagePosition = "Bottom";
            }

            LabelTurtlePosition.Text = _imagePosition;
            PBTurtle.Refresh();
        }

        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
