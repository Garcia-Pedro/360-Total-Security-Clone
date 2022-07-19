using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _360_Total_Security
{
    public partial class TelaMaximizada : Form
    {
        public TelaMaximizada()
        {
            InitializeComponent();
        }
        private void conteudo_Paint_1(object sender, PaintEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                maximizar.Visible = false;
                minimizar.Visible = true;
                linha1.Width = 1055;
                linha2.Width = 1055;
                linha3.Width = 1055;
                linha4.Width = 1055;
                button1.Width = 180;
            }
        }

        private void normal_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
