namespace TurtleCommandApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            NewGameToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            InstructionsToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            TurtleBoard = new TableLayoutPanel();
            PBTurtle = new PictureBox();
            PbPool = new PictureBox();
            PbCake = new PictureBox();
            PbCar = new PictureBox();
            PbTree = new PictureBox();
            LabelTurtlePosition = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnUpArrow = new Button();
            BtnDownArrow = new Button();
            BtnRightArrow = new Button();
            BtnLeftArrow = new Button();
            BtnRotateClockwise = new Button();
            BtnRotateAntiClockWise = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            TextBoxCommandInstructions = new TextBox();
            BtnExecuteCommand = new Button();
            Timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TurtleBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBTurtle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbCake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbTree).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1165, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { NewGameToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // NewGameToolStripMenuItem
            // 
            NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            NewGameToolStripMenuItem.Size = new Size(132, 22);
            NewGameToolStripMenuItem.Text = "New Game";
            NewGameToolStripMenuItem.Click += NewGameToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InstructionsToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // InstructionsToolStripMenuItem
            // 
            InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem";
            InstructionsToolStripMenuItem.Size = new Size(136, 22);
            InstructionsToolStripMenuItem.Text = "Instructions";
            InstructionsToolStripMenuItem.Click += InstructionsToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.923105F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.3874054F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.68949127F));
            tableLayoutPanel1.Controls.Add(TurtleBoard, 1, 1);
            tableLayoutPanel1.Controls.Add(LabelTurtlePosition, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(1165, 746);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TurtleBoard
            // 
            TurtleBoard.ColumnCount = 4;
            TurtleBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TurtleBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TurtleBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TurtleBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TurtleBoard.Controls.Add(PBTurtle, 0, 3);
            TurtleBoard.Controls.Add(PbPool, 0, 0);
            TurtleBoard.Controls.Add(PbCake, 3, 0);
            TurtleBoard.Controls.Add(PbCar, 3, 3);
            TurtleBoard.Controls.Add(PbTree, 2, 1);
            TurtleBoard.Dock = DockStyle.Fill;
            TurtleBoard.Location = new Point(118, 226);
            TurtleBoard.Name = "TurtleBoard";
            TurtleBoard.RowCount = 4;
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.Size = new Size(953, 517);
            TurtleBoard.TabIndex = 0;
            // 
            // PBTurtle
            // 
            PBTurtle.BackColor = SystemColors.ButtonHighlight;
            PBTurtle.BorderStyle = BorderStyle.FixedSingle;
            PBTurtle.ErrorImage = Properties.Resources.turtle;
            PBTurtle.Image = Properties.Resources.turtle;
            PBTurtle.InitialImage = Properties.Resources.turtle;
            PBTurtle.Location = new Point(3, 390);
            PBTurtle.Name = "PBTurtle";
            PBTurtle.Size = new Size(232, 123);
            PBTurtle.SizeMode = PictureBoxSizeMode.Zoom;
            PBTurtle.TabIndex = 0;
            PBTurtle.TabStop = false;
            PBTurtle.WaitOnLoad = true;
            // 
            // PbPool
            // 
            PbPool.Image = (Image)resources.GetObject("PbPool.Image");
            PbPool.Location = new Point(3, 3);
            PbPool.Name = "PbPool";
            PbPool.Size = new Size(232, 123);
            PbPool.SizeMode = PictureBoxSizeMode.Zoom;
            PbPool.TabIndex = 1;
            PbPool.TabStop = false;
            // 
            // PbCake
            // 
            PbCake.Image = (Image)resources.GetObject("PbCake.Image");
            PbCake.Location = new Point(717, 3);
            PbCake.Name = "PbCake";
            PbCake.Size = new Size(233, 123);
            PbCake.SizeMode = PictureBoxSizeMode.Zoom;
            PbCake.TabIndex = 2;
            PbCake.TabStop = false;
            // 
            // PbCar
            // 
            PbCar.Image = (Image)resources.GetObject("PbCar.Image");
            PbCar.Location = new Point(717, 390);
            PbCar.Name = "PbCar";
            PbCar.Size = new Size(233, 124);
            PbCar.SizeMode = PictureBoxSizeMode.Zoom;
            PbCar.TabIndex = 3;
            PbCar.TabStop = false;
            // 
            // PbTree
            // 
            PbTree.Image = (Image)resources.GetObject("PbTree.Image");
            PbTree.Location = new Point(479, 132);
            PbTree.Name = "PbTree";
            PbTree.Size = new Size(232, 123);
            PbTree.SizeMode = PictureBoxSizeMode.Zoom;
            PbTree.TabIndex = 4;
            PbTree.TabStop = false;
            // 
            // LabelTurtlePosition
            // 
            LabelTurtlePosition.AutoSize = true;
            LabelTurtlePosition.Location = new Point(3, 223);
            LabelTurtlePosition.Name = "LabelTurtlePosition";
            LabelTurtlePosition.Size = new Size(83, 15);
            LabelTurtlePosition.TabIndex = 2;
            LabelTurtlePosition.Text = "Turtle Position";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(118, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(953, 217);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(BtnUpArrow, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnDownArrow, 1, 2);
            tableLayoutPanel2.Controls.Add(BtnRightArrow, 2, 1);
            tableLayoutPanel2.Controls.Add(BtnLeftArrow, 0, 1);
            tableLayoutPanel2.Controls.Add(BtnRotateClockwise, 3, 0);
            tableLayoutPanel2.Controls.Add(BtnRotateAntiClockWise, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(279, 211);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnUpArrow
            // 
            BtnUpArrow.Image = (Image)resources.GetObject("BtnUpArrow.Image");
            BtnUpArrow.Location = new Point(72, 3);
            BtnUpArrow.Name = "BtnUpArrow";
            BtnUpArrow.Size = new Size(63, 64);
            BtnUpArrow.TabIndex = 0;
            BtnUpArrow.UseVisualStyleBackColor = true;
            BtnUpArrow.Click += BtnUpArrow_Click;
            // 
            // BtnDownArrow
            // 
            BtnDownArrow.Image = (Image)resources.GetObject("BtnDownArrow.Image");
            BtnDownArrow.Location = new Point(72, 143);
            BtnDownArrow.Name = "BtnDownArrow";
            BtnDownArrow.Size = new Size(63, 65);
            BtnDownArrow.TabIndex = 1;
            BtnDownArrow.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDownArrow.UseVisualStyleBackColor = true;
            BtnDownArrow.Click += BtnDownArrow_Click;
            // 
            // BtnRightArrow
            // 
            BtnRightArrow.Image = (Image)resources.GetObject("BtnRightArrow.Image");
            BtnRightArrow.Location = new Point(141, 73);
            BtnRightArrow.Name = "BtnRightArrow";
            BtnRightArrow.Size = new Size(63, 64);
            BtnRightArrow.TabIndex = 2;
            BtnRightArrow.UseVisualStyleBackColor = true;
            BtnRightArrow.Click += BtnRightArrow_Click;
            // 
            // BtnLeftArrow
            // 
            BtnLeftArrow.Image = (Image)resources.GetObject("BtnLeftArrow.Image");
            BtnLeftArrow.Location = new Point(3, 73);
            BtnLeftArrow.Name = "BtnLeftArrow";
            BtnLeftArrow.Size = new Size(63, 64);
            BtnLeftArrow.TabIndex = 3;
            BtnLeftArrow.UseVisualStyleBackColor = true;
            BtnLeftArrow.Click += BtnLeftArrow_Click;
            // 
            // BtnRotateClockwise
            // 
            BtnRotateClockwise.Image = (Image)resources.GetObject("BtnRotateClockwise.Image");
            BtnRotateClockwise.Location = new Point(210, 3);
            BtnRotateClockwise.Name = "BtnRotateClockwise";
            BtnRotateClockwise.Size = new Size(66, 64);
            BtnRotateClockwise.TabIndex = 4;
            BtnRotateClockwise.UseVisualStyleBackColor = true;
            BtnRotateClockwise.Click += BtnRotateClockwise_Click;
            // 
            // BtnRotateAntiClockWise
            // 
            BtnRotateAntiClockWise.Image = (Image)resources.GetObject("BtnRotateAntiClockWise.Image");
            BtnRotateAntiClockWise.Location = new Point(210, 143);
            BtnRotateAntiClockWise.Name = "BtnRotateAntiClockWise";
            BtnRotateAntiClockWise.Size = new Size(66, 65);
            BtnRotateAntiClockWise.TabIndex = 5;
            BtnRotateAntiClockWise.UseVisualStyleBackColor = true;
            BtnRotateAntiClockWise.Click += BtnRotateAntiClockWise_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(TextBoxCommandInstructions, 0, 1);
            tableLayoutPanel4.Controls.Add(BtnExecuteCommand, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(288, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(662, 211);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(656, 42);
            label1.TabIndex = 0;
            label1.Text = "Enter your command below";
            // 
            // TextBoxCommandInstructions
            // 
            TextBoxCommandInstructions.Dock = DockStyle.Fill;
            TextBoxCommandInstructions.Location = new Point(3, 45);
            TextBoxCommandInstructions.Multiline = true;
            TextBoxCommandInstructions.Name = "TextBoxCommandInstructions";
            TextBoxCommandInstructions.Size = new Size(656, 36);
            TextBoxCommandInstructions.TabIndex = 1;
            // 
            // BtnExecuteCommand
            // 
            BtnExecuteCommand.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExecuteCommand.Location = new Point(3, 87);
            BtnExecuteCommand.Name = "BtnExecuteCommand";
            BtnExecuteCommand.Size = new Size(175, 36);
            BtnExecuteCommand.TabIndex = 2;
            BtnExecuteCommand.Text = "Execute Command";
            BtnExecuteCommand.UseVisualStyleBackColor = true;
            BtnExecuteCommand.Click += BtnExecuteCommand_Click;
            // 

            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 770);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Floor Turtle Command";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TurtleBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBTurtle).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPool).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbCake).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbTree).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem NewGameToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel TurtleBoard;
        private PictureBox PBTurtle;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnDownArrow;
        private Button BtnUpArrow;
        private Button BtnRightArrow;
        private Button BtnLeftArrow;
        private Button BtnRotateClockwise;
        private Button BtnRotateAntiClockWise;
        private Label LabelTurtlePosition;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TextBox TextBoxCommandInstructions;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem InstructionsToolStripMenuItem;
        private Button BtnExecuteCommand;
        private PictureBox PbPool;
        private PictureBox PbCake;
        private PictureBox PbCar;
        private PictureBox PbTree;
        private System.Windows.Forms.Timer Timer1;
    }
}
