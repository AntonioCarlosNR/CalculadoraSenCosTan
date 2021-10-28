using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex2SenConsTan.Controlep;


namespace Ex2SenConsTan
{
    public partial class Form1 : Form
    {
        private Controle Meucontrole;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Meucontrole = new Controle(txtAngulo.Text);
            lblResposta.Text = Meucontrole.resposta;
        }
    }
}
