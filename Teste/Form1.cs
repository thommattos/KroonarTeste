using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Porta porta = new Porta();

            label1.Text = "Porta " + porta.Status +
".\n Consiga uma chave para destrancar.";
        }


        private void btnChaveiro_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Você pegou o chaveiro.\n" +
                "Agora escolha a chave 2, ela que coincide com a tranca.";

            btnEscolherChave.Visible = true;
            btnEscolherChave.Enabled = true;

            // Hidden
            lblEscolher.Visible = false;

            btnDestrancar.Enabled = false;
            btnDestrancar.Visible = false;

            lblDestrancar.Visible = false;
        }

        private void btnEscolherChave_Click(object sender, EventArgs e)
        {
            Random randomico = new Random();

            int numero = randomico.Next(0, 5);
            //Console.WriteLine(randomico.Next(0,5));

            lblEscolher.Text = "Você escolheu a chave " + numero;
            lblEscolher.Visible = true;

            if (numero == 2)
            {
                lblEscolher.Text += "\nVocê escolheu a chave certa. Agora, destranque !";
                lblEscolher.ForeColor = Color.Green;

                btnEscolherChave.Enabled = false;

                btnDestrancar.Enabled = true;
                btnDestrancar.Visible = true;
            }
            else
            {
                btnDestrancar.Enabled = false;
                btnDestrancar.Visible = false;

                lblDestrancar.Visible = false;


                lblEscolher.Text += ".\nEla não é a correta. Escolha outra!";
                lblEscolher.ForeColor = Color.Red;
            }
        }

        private void btnDestrancar_Click(object sender, EventArgs e)
        {
            lblDestrancar.Text = "A porta está destrancada e aberta. \nParabéns!";
            lblDestrancar.Visible = true;
            lblDestrancar.ForeColor = Color.Green;
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.github.com/thommattos");
            }
            catch {
                MessageBox.Show("Não foi possivel acessar a pagina github.com/thommattos","Alerta");
            }
            
        }
    }
}
