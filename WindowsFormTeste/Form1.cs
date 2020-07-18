using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTeste
{
    public partial class Nome : Form
    {
        public Nome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string ano = textBox6.Text;

            //if (nome.Length > 0 && ano.Length > 0)
            {                                                        
                string mensagem = string.Format("Olá {0}, o ano informado foi {1}", nome, ano);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox2.Text);
            int n2 = Convert.ToInt32(textBox3.Text);

            decimal media = (n1 + n2) / 2M;

            MessageBox.Show("A sua média é: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            int ano = Convert.ToInt32(textBox6.Text);

            int idade = DateTime.Today.Year - ano;

            MessageBox.Show($"Sua idade é {idade}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        

        }
    }
}
