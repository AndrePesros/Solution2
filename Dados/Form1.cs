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
            x.Resultado();
            x.vitoria();
            x.derrota();
            x.JogadaJogador1 = int.Parse(textJogador1.Text);
            textBox1.Text = x.Jogada1.ToString();
            textBox2.Text = x.Jogada2.ToString();
            textComputador.Text = x.Computador.ToString();

             

            MessageBox.Show($"\n Vitoria: {x.Vitoria: f2} \n \n Derrota: {x.Derrota: f2}\n");
        }
    }
}
