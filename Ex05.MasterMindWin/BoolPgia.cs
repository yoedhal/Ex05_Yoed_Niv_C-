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
    public partial class BoolPgia : Form
    {
        private int m_NumberOfChances = 4;
        public BoolPgia()
        {
            InitializeComponent();
            buttonOfChances.Text = "Number of chances: " + m_NumberOfChances;
        }

        private void buttonOfChances_Click(object sender, EventArgs e)
        {
            m_NumberOfChances++;

            if(m_NumberOfChances == 11)
            {
                m_NumberOfChances = 4;
            }

            buttonOfChances.Text = "Number of chances: " + m_NumberOfChances;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
