using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.MasterMindWin
{
    public partial class ColorForm : Form
    {
        private Color m_Color;
        public ColorForm()
        {
            InitializeComponent();
            this.SetCustomLocation();
        }

        private void SetCustomLocation()
        {
            this.StartPosition = FormStartPosition.Manual;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            int leftOffset = 100;

            int centerY = (screen.Height - this.Height) / 2;

            this.Location = new Point(screen.Left + leftOffset, centerY);
        }


        private void color_button_Click(object sender, EventArgs e)
        {
            m_Color = (sender as Button).BackColor;
            this.Close();
        }

        public Color Color
        {
            get
            {
                return m_Color;
            }
        }
    }
}
