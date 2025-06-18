using System.Drawing;
using System.Windows.Forms;

namespace Ex05.MasterMindWin
{
    partial class Instructions
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
            this.Text = "Instructions";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // ביטול שינוי גודל
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(700, 400);
            this.BackColor = Color.WhiteSmoke;

            // 🟨 טקסט ההוראות
            instructionsLabel = new Label();
            instructionsLabel.Text =
                "🎯 MasterMind Game Instructions\n\n" +
                "Your goal is to guess the secret color code chosen by the computer.\n" +
                "The code consists of 4 to 6 colored pegs.\n\n" +
                "🧩 How to Play:\n" +
                "1. Select a color for each guess.\n" +
                "2. Click the 'Submit' button to check your guess.\n" +
                "3. Red peg = correct color & position\n" +
                "   White peg = correct color only\n\n" +
                "🖱️ Start Menu Buttons:\n" +
                "- Start: Start a new game\n" +
                "- Instructions: Show this screen\n" +
                "- Exit: Close the application";

            instructionsLabel.Font = new Font("Segoe UI", 10F);
            instructionsLabel.AutoSize = false;
            instructionsLabel.Size = new Size(600, 250);
            instructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            instructionsLabel.Location = new Point((this.ClientSize.Width - instructionsLabel.Width) / 2, 40);

            // 🟩 כפתור חזור
            backButton = new Button();
            backButton.Text = "Back to start menu";
            backButton.Size = new Size(200, 40);
            backButton.Location = new Point((this.ClientSize.Width - backButton.Width) / 2, 320);
            backButton.BackColor = Color.BurlyWood;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Click += BackButton_Click;

            this.Controls.Add(instructionsLabel);
            this.Controls.Add(backButton);
        }


        #endregion

        //private System.Windows.Forms.Button buttonBack;
        //private System.Windows.Forms.TextBox textBox1;
    }
}