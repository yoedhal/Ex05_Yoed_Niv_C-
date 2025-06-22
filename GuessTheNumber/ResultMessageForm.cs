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
    public partial class ResultMessageForm : Form
    {
        private readonly bool IfTheUserWon;
        private readonly int r_SecretNumber;
        public ResultMessageForm(bool i_IfTheUserWon, int i_SecretNumber)
        {
            InitializeComponent();
            this.Text = "GuessTheNumber";

            IfTheUserWon = i_IfTheUserWon;
            r_SecretNumber = i_SecretNumber;

            this.printResult();
            this.printSecretNumber();
        }

        private void buttonOfExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printResult() 
        { 
            if (IfTheUserWon)
            {
                this.labelIfUserWon.Text = "YOU WON!";
            }
            else
            {
                this.labelIfUserWon.Text = "YOU LOST!";
            }
            
        }

        private void printSecretNumber()
        {
            this.labelSecretNumber.Text = "THE SECRET NUMBER IS: " + this.r_SecretNumber.ToString();
        }
    }
}
