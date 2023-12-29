namespace TurtleCommandApp
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBoxCommandInstructions = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(TextBoxCommandInstructions, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(780, 527);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxCommandInstructions
            // 
            TextBoxCommandInstructions.BackColor = Color.White;
            TextBoxCommandInstructions.BorderStyle = BorderStyle.None;
            TextBoxCommandInstructions.Dock = DockStyle.Fill;
            TextBoxCommandInstructions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBoxCommandInstructions.Location = new Point(3, 3);
            TextBoxCommandInstructions.Name = "TextBoxCommandInstructions";
            TextBoxCommandInstructions.Size = new Size(774, 521);
            TextBoxCommandInstructions.TabIndex = 4;
            TextBoxCommandInstructions.Text = "";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 527);
            Controls.Add(tableLayoutPanel1);
            Name = "About";
            Text = "About";
            Load += About_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox TextBoxCommandInstructions;
    }
}