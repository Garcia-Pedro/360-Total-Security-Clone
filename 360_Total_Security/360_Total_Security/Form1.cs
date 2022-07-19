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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            new TelaMaximizada().Show();
            this.Hide();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            normal.Visible = false;
        }
        private void minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void verificar_Click(object sender, EventArgs e)
        {

        }
    }
}
