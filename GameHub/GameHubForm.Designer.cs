using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class GameHubForm
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
            // הגדרות בסיסיות של הטופס
            this.Text = "Game Hub";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(50, 50, 70); // צבע רקע כהה

            // כותרת ראשית
            titleLabel = new Label();
            titleLabel.Text = "GameHub";
            titleLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Size = new Size(400, 50);
            titleLabel.Location = new Point(0, 10); // מעט מרווח מהקצה העליון

            // תת כותרת
            subtitleLabel = new Label();
            subtitleLabel.Text = "Please choose a game";
            subtitleLabel.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            subtitleLabel.ForeColor = Color.LightGray;
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subtitleLabel.Size = new Size(400, 30);
            subtitleLabel.Location = new Point(0, 60); // מופיע מתחת ל-title

            // כפתור Mastermind
            mastermindButton = new Button();
            mastermindButton.Text = "Mastermind";
            mastermindButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            mastermindButton.Size = new Size(150, 40);
            mastermindButton.BackColor = Color.FromArgb(70, 130, 180);
            mastermindButton.ForeColor = Color.White;
            mastermindButton.FlatStyle = FlatStyle.Flat;
            mastermindButton.Location = new Point((this.ClientSize.Width - mastermindButton.Width) / 2, 110);
            mastermindButton.Click += MastermindButton_Click;

            // כפתור Guess the Number
            guessNumberButton = new Button();
            guessNumberButton.Text = "Guess the Number";
            guessNumberButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            guessNumberButton.Size = new Size(150, 40);
            guessNumberButton.BackColor = Color.FromArgb(46, 139, 87);
            guessNumberButton.ForeColor = Color.White;
            guessNumberButton.FlatStyle = FlatStyle.Flat;
            guessNumberButton.Location = new Point((this.ClientSize.Width - guessNumberButton.Width) / 2, 160);
            guessNumberButton.Click += GuessNumberButton_Click;

            // הוספה לטופס
            this.Controls.Add(titleLabel);
            this.Controls.Add(subtitleLabel);
            this.Controls.Add(mastermindButton);
            this.Controls.Add(guessNumberButton);

            this.Resize += GameHubForm_Resize;
            CenterControls();
        }



    }

    #endregion

}
