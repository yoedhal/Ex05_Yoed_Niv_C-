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
        private int m_NumberOfChances = 4;
        public StartForm()
        {
            InitializeComponent();
            buttonOfChances.Text = "Number of chances: " + m_NumberOfChances;
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

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GameForm GF = new GameForm(m_NumberOfChances);
            GF.ShowDialog();
        }
    }
}
