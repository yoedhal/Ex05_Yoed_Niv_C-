using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MasterMindStart = Ex05.MasterMindWin.StartForm;
using GuessNumberStart = GuessTheNumber.StartForm;

namespace GameHub
{
    public partial class GameHubForm : Form
    {
        private Label titleLabel;
        private Label subtitleLabel;
        private Button mastermindButton;
        private Button guessNumberButton;

        public GameHubForm()
        {
            InitializeComponent();
        }

        private void MastermindButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MasterMindStart mastermindForm = new MasterMindStart();
            mastermindForm.ShowDialog();

            this.Close();

        }

        private void GuessNumberButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            GuessNumberStart GuessTheNumberForm = new GuessNumberStart();
            GuessTheNumberForm.ShowDialog();

            this.Close();

        }

        private void GameHubForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // מרכוז טקסטים
            titleLabel.Width = this.ClientSize.Width;
            subtitleLabel.Width = this.ClientSize.Width;

            // מיקום הכפתורים במרכז
            mastermindButton.Location = new Point(
                (this.ClientSize.Width - mastermindButton.Width) / 2,
                110
            );

            guessNumberButton.Location = new Point(
                (this.ClientSize.Width - guessNumberButton.Width) / 2,
                160
            );
        }
    }
}
