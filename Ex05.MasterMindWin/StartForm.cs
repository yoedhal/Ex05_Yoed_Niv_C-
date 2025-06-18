using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.MasterMindWin
{
    public partial class StartForm : Form
    {
        private const int k_MinGuesses = 4;
        private const int k_MaxGuesses = 10;
        private const int k_MaxLengthOfCode = 6;
        private int m_NumberOfChances = 4;
        private int m_NumberOfColursInCode = 4;
        private Panel panelButtons;

        public StartForm()
        {
            InitializeComponent();
            buttonOfChances.Text = "Number of chances: " + m_NumberOfChances;
            buttonlength.Text = "Length of code: " + m_NumberOfColursInCode;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonOfChances_Click(object sender, EventArgs e)
        {
            m_NumberOfChances++;

            if(m_NumberOfChances > k_MaxGuesses)
            {
                m_NumberOfChances = k_MinGuesses;
            }

            buttonOfChances.Text = "Number of chances: " + m_NumberOfChances;
        }

        private void buttonOfLengthOfCode_Click(object sender, EventArgs e)
        {
            m_NumberOfColursInCode++;

            if (m_NumberOfColursInCode > k_MaxLengthOfCode)
            {
                m_NumberOfColursInCode = k_MinGuesses;
            }

            buttonlength.Text = "Length of code: " + m_NumberOfColursInCode;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm(m_NumberOfChances, m_NumberOfColursInCode);
            this.Hide();  
            gf.ShowDialog();
            this.Close(); 

        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
           this.Hide();

           Instructions instructions = new Instructions();
           instructions.ShowDialog();

            this.Show();


        }
    }
}
