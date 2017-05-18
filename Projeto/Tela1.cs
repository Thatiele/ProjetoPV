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
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((txtID.Text == "2215204679") && (txtSenha.Text == "0000"))
            {
                Tela2 tela = new Tela2();
                tela.Show();
            }
            else if((txtID.Text == "2215105592") && (txtSenha.Text =="0001"))
            {
                Tela2 tela = new Tela2();
                tela.Show();
            }
            else
            {
                MessageBox.Show("Dados Inválidos"); 
            }

            txtID.Clear();
            txtSenha.Clear();

        }
    }
}
