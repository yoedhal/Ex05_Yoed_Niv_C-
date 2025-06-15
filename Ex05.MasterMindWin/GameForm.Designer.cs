using System.Collections.Generic;
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
            int formWidth = 300;
            this.ClientSize = new Size(formWidth, 100 + i_NumOfGuesses * 60);
            this.Text = "MasterMind";
            this.BackColor = Color.LightGray;

            int buttonSize = 40;
            int spacing = 5;
            int buttonsTotalWidth = 4 * buttonSize + 3 * spacing;
            int startX = 10;

            // 🔵 שורת קוד סודי
            for (int i = 0; i < 4; i++)
            {
                Button secretButton = new Button();
                secretButton.Size = new Size(buttonSize, buttonSize);
                secretButton.Location = new Point(startX + i * (buttonSize + spacing), 10);
                secretButton.BackColor = Color.Black;
                secretButton.Enabled = false;
                secretButton.Anchor = AnchorStyles.None;
                r_SecretButtons.Add(secretButton);

                this.Controls.Add(secretButton);
            }

            int baseY = 70;

            for (int row = 0; row < i_NumOfGuesses; row++)
            {
                int currentY = baseY + (row * 60);

                // 4 כפתורי ניחוש
                for (int col = 0; col < 4; col++)
                {
                    Button guessButton = new Button();
                    guessButton.Size = new Size(buttonSize, buttonSize);
                    guessButton.Location = new Point(startX + col * (buttonSize + spacing), currentY);
                    guessButton.BackColor = SystemColors.ActiveBorder;
                    guessButton.Enabled = row == 0;
                    guessButton.Tag = col;
                    guessButton.Click += guessButton_Click;
                    guessButton.Anchor = AnchorStyles.None;
                    guessButton.Enabled = false;

                    this.Controls.Add(guessButton);
                    r_GuessesButtons.Add(guessButton);
                }

                // כפתור חץ
                Button arrowButton = new Button();
                arrowButton.Size = new Size(50, 20);
                arrowButton.Location = new Point(startX + 4 * (buttonSize + spacing) + 10, currentY + 10);
                arrowButton.Text = "-->>";
                arrowButton.Enabled = false;
                arrowButton.Tag = row;
                arrowButton.Click += arrowButton_Click;
                arrowButton.Anchor = AnchorStyles.None;
                arrowButton.Enabled = false;

                this.Controls.Add(arrowButton);
                r_ArrowButtons.Add(arrowButton);

                // כפתורי תוצאה (2x2)
                for (int i = 0; i < 4; i++)
                {
                    Button resultButton = new Button();
                    resultButton.Size = new Size(14, 14);
                    int dx = (i % 2) * 18;
                    int dy = (i / 2) * 18;
                    resultButton.Location = new Point(startX + 4 * (buttonSize + spacing) + 70 + dx, currentY + dy);
                    resultButton.Enabled = false;
                    resultButton.BackColor = SystemColors.ActiveBorder;
                    resultButton.Anchor = AnchorStyles.None;
                    resultButton.Enabled = false;

                    this.Controls.Add(resultButton);
                    r_ComperingButtons.Add(resultButton);
                }
            }
        }



        #endregion
    }
}