using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela1 form = new Tela1();
            form.Show();
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tela1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Tela1 form = new Tela1();
            form.MdiParent = this;
            form.Show();
            this.toolStripStatusLabel1.Text = "Tela 1";
        }

        private void tela2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Tela2 form = new Tela2();
            form.MdiParent = this;
            form.Show();
            this.toolStripStatusLabel1.Text = "Tela 2";

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
