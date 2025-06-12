using System.Drawing;
using System.Windows.Forms;

namespace Ex05.MasterMindWin
{
    partial class GameForm
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
        private void InitializeComponent(int i_NumOfGuesses)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(500, 100 + i_NumOfGuesses * 50);
            this.Text = "MasterMind";

            // יצירת לוח המשחק הדינאמי
            int yOffset = 20;

            for (int row = 0; row < i_NumOfGuesses; row++)
            {
                // כפתורי ניחוש
                for (int col = 0; col < m_CodeCount; col++)
                {
                    Button guessButton = new Button();
                    guessButton.Size = new Size(40, 40);
                    guessButton.Location = new Point(20 + col * 50, yOffset);
                    guessButton.BackColor = Color.Black;
                    guessButton.Click += guessButton_Click;
                    guessButton.Tag = new Point(row, col); // נשמור את מיקום הכפתור

                    this.Controls.Add(guessButton);
                }

                // כפתור חץ לאישור ניחוש
                Button arrowButton = new Button();
                arrowButton.Size = new Size(40, 40);
                arrowButton.Location = new Point(230, yOffset);
                arrowButton.Text = "-->";
                arrowButton.Enabled = false;
                arrowButton.Tag = row;
                arrowButton.Click += arrowButton_Click;

                this.Controls.Add(arrowButton);

                // תוצאות (4 עיגולים קטנים מימין)
                for (int i = 0; i < m_CodeCount; i++)
                {
                    Button resultDot = new Button();
                    resultDot.Size = new Size(15, 15);
                    resultDot.Location = new Point(290 + i * 20, yOffset + 12);
                    resultDot.Enabled = false;
                    resultDot.FlatStyle = FlatStyle.Flat;

                    this.Controls.Add(resultDot);
                }

                yOffset += 50;
            }
        }



        #endregion
    }
}