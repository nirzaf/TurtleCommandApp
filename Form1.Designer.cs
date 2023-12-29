﻿namespace TurtleCommandApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            TurtleBoard = new TableLayoutPanel();
            PBTurtle = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnUpArrow = new Button();
            BtnDownArrow = new Button();
            BtnRightArrow = new Button();
            BtnLeftArrow = new Button();
            BtnRotateClockwise = new Button();
            BtnRotateAntiClockWise = new Button();
            LabelTurtlePosition = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            TxtCommand = new TextBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TurtleBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBTurtle).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1165, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(132, 22);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.71429F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.76190472F));
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
            TurtleBoard.Controls.Add(PBTurtle, 0, 2);
            TurtleBoard.Dock = DockStyle.Fill;
            TurtleBoard.Location = new Point(113, 226);
            TurtleBoard.Name = "TurtleBoard";
            TurtleBoard.RowCount = 4;
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TurtleBoard.Size = new Size(992, 517);
            TurtleBoard.TabIndex = 0;
            // 
            // PBTurtle
            // 
            PBTurtle.BackColor = SystemColors.ButtonHighlight;
            PBTurtle.BorderStyle = BorderStyle.FixedSingle;
            PBTurtle.ErrorImage = Properties.Resources.turtle;
            PBTurtle.Image = Properties.Resources.turtle;
            PBTurtle.InitialImage = Properties.Resources.turtle;
            PBTurtle.Location = new Point(3, 261);
            PBTurtle.Name = "PBTurtle";
            PBTurtle.Size = new Size(242, 123);
            PBTurtle.SizeMode = PictureBoxSizeMode.Zoom;
            PBTurtle.TabIndex = 0;
            PBTurtle.TabStop = false;
            PBTurtle.WaitOnLoad = true;
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
            tableLayoutPanel2.Size = new Size(324, 211);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnUpArrow
            // 
            BtnUpArrow.Image = (Image)resources.GetObject("BtnUpArrow.Image");
            BtnUpArrow.Location = new Point(84, 3);
            BtnUpArrow.Name = "BtnUpArrow";
            BtnUpArrow.Size = new Size(70, 64);
            BtnUpArrow.TabIndex = 0;
            BtnUpArrow.UseVisualStyleBackColor = true;
            BtnUpArrow.Click += BtnUpArrow_Click;
            // 
            // BtnDownArrow
            // 
            BtnDownArrow.Image = (Image)resources.GetObject("BtnDownArrow.Image");
            BtnDownArrow.Location = new Point(84, 143);
            BtnDownArrow.Name = "BtnDownArrow";
            BtnDownArrow.Size = new Size(70, 65);
            BtnDownArrow.TabIndex = 1;
            BtnDownArrow.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDownArrow.UseVisualStyleBackColor = true;
            BtnDownArrow.Click += BtnDownArrow_Click;
            // 
            // BtnRightArrow
            // 
            BtnRightArrow.Image = (Image)resources.GetObject("BtnRightArrow.Image");
            BtnRightArrow.Location = new Point(165, 73);
            BtnRightArrow.Name = "BtnRightArrow";
            BtnRightArrow.Size = new Size(70, 64);
            BtnRightArrow.TabIndex = 2;
            BtnRightArrow.UseVisualStyleBackColor = true;
            BtnRightArrow.Click += BtnRightArrow_Click;
            // 
            // BtnLeftArrow
            // 
            BtnLeftArrow.Image = (Image)resources.GetObject("BtnLeftArrow.Image");
            BtnLeftArrow.Location = new Point(3, 73);
            BtnLeftArrow.Name = "BtnLeftArrow";
            BtnLeftArrow.Size = new Size(70, 64);
            BtnLeftArrow.TabIndex = 3;
            BtnLeftArrow.UseVisualStyleBackColor = true;
            BtnLeftArrow.Click += BtnLeftArrow_Click;
            // 
            // BtnRotateClockwise
            // 
            BtnRotateClockwise.Image = (Image)resources.GetObject("BtnRotateClockwise.Image");
            BtnRotateClockwise.Location = new Point(246, 3);
            BtnRotateClockwise.Name = "BtnRotateClockwise";
            BtnRotateClockwise.Size = new Size(70, 64);
            BtnRotateClockwise.TabIndex = 4;
            BtnRotateClockwise.UseVisualStyleBackColor = true;
            BtnRotateClockwise.Click += BtnRotateClockwise_Click;
            // 
            // BtnRotateAntiClockWise
            // 
            BtnRotateAntiClockWise.Image = (Image)resources.GetObject("BtnRotateAntiClockWise.Image");
            BtnRotateAntiClockWise.Location = new Point(246, 143);
            BtnRotateAntiClockWise.Name = "BtnRotateAntiClockWise";
            BtnRotateAntiClockWise.Size = new Size(70, 65);
            BtnRotateAntiClockWise.TabIndex = 5;
            BtnRotateAntiClockWise.UseVisualStyleBackColor = true;
            BtnRotateAntiClockWise.Click += BtnRotateAntiClockWise_Click;
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
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(113, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(992, 217);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(TxtCommand, 0, 1);
            tableLayoutPanel4.Location = new Point(333, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(324, 211);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 42);
            label1.TabIndex = 0;
            label1.Text = "Enter your command below";
            // 
            // TxtCommand
            // 
            TxtCommand.Location = new Point(3, 45);
            TxtCommand.Name = "TxtCommand";
            TxtCommand.Size = new Size(318, 23);
            TxtCommand.TabIndex = 1;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem;
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
        private TextBox TxtCommand;
    }
}
