using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class InstructionsForm : Form
    {
        private Label instructionsLabel;
        private Button backButton;

        public InstructionsForm()
        {
            // הגדרות טופס
            this.Text = "GuessTheNumber";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // תווית עם ההוראות
            instructionsLabel = new Label();
            instructionsLabel.Text =
                "🎯 Guess the Number\n\n" +
                "1️⃣ Choose a number range (e.g., 1–100).\n" +
                "2️⃣ The game will randomly pick a secret number in that range.\n" +
                "3️⃣ Try to guess the number within a limited number of attempts.\n" +
                "4️⃣ After each guess, you’ll be told whether the number is higher or lower.\n" +
                "5️⃣ If you guess correctly – you win!\n" +
                "6️⃣ If you run out of attempts – the secret number will be revealed.\n\n" +
                "Have fun and good luck! 🍀";

            instructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            instructionsLabel.Dock = DockStyle.Top;
            instructionsLabel.Padding = new Padding(20);
            instructionsLabel.Font = new Font("Segoe UI", 10);
            instructionsLabel.AutoSize = false;
            instructionsLabel.Height = 300;

            // כפתור חזרה לתפריט
            backButton = new Button();
            backButton.Text = "Back to Menu";
            backButton.Width = 150;
            backButton.Height = 40;
            backButton.Font = new Font("Segoe UI", 10);
            backButton.Location = new Point((this.ClientSize.Width - backButton.Width) / 2, 320);
            backButton.Anchor = AnchorStyles.Bottom;
            backButton.Click += BackButton_Click;

            // הוספת הפקדים
            this.Controls.Add(instructionsLabel);
            this.Controls.Add(backButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close(); // סוגר את חלון ההוראות
        }
    }
}
