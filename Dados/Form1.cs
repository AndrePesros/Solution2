using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jogando x = new Jogando();

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            x.JogadaJogador1 = int.Parse(textJogador1.Text);
        }
    }
}
