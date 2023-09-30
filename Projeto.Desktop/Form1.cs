using System;
using System.Windows.Forms;
using Projeto.Model;
using Projeto.Controler;

namespace Projeto.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _cbdUsuario = new CbdUsuario();
            _cbdUsuario.Nome = textBox1.Text;
            _cbdUsuario.Rg = textBox2.Text;
            _cbdUsuario.Cpf = textBox3.Text;
            _cbdUsuario.Endereco = textBox4.Text;
            _cbdUsuario.Telefone = textBox5.Text;

            var adicionarDados = new Usuario();
            if (adicionarDados.AdicionarDados(_cbdUsuario))
            {
                MessageBox.Show("Usuario adicionado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
        }
    }
}
