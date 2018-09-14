using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();

            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if (!pnAgenda.Inserir(p))
            {
                MessageBox.Show("Erro ao tentar inserir contato!");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p = pnAgenda.Pesquisar(txtEmail.Text);

            if(p != null)
            {
                txtEmail.Text = p.Email;
                txtIdade.Text = p.Idade.ToString();
                txtNome.Text = p.Nome;
            }
            else
            {
                MessageBox.Show("E-mail não localizado nos cadastros!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if(MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnAgenda.Excluir(p);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Email = txtEmail.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            p.Nome = txtNome.Text;

            if (!pnAgenda.Alterar(p))
            {
                MessageBox.Show("Erro ao tentar alterar contato! Verifique se ele realmente esta cadastrado!");
            }
        }
    }
}
