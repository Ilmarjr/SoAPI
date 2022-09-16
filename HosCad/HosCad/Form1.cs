using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosCad
{
    public partial class Form1 : Form
    {
        Guest guest;
        ServerConnection server;
        public Form1()
        {
            InitializeComponent();
            server = new ServerConnection();
            server.ParentForm = this;
            
            server.cadastroResult += Server_cadastroResult;
            
            atualizarPreviewPage1.ParentForm = this;

            //páginas da aplicação
            atualizarPreviewPage1.Hide();
            atualizarPage1.Hide();
            excluirPage1.Hide();

            //evento desparado ao pesquisar o hóspede na pagina de atualização
            atualizarPreviewPage1.Pesquisa += AtualizarPreviewPage1_Pesquisa;
        }

        private void AtualizarPreviewPage1_Pesquisa()
        {
            atualizarPreviewPage1.Hide();
            atualizarPage1.Show();
        }

        private void Server_cadastroResult(string result)
        {
            MessageBox.Show(result,"Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //evento disparado ao clique do botão
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            guest = new Guest(txtNome.Text, mbCpf.Text, mbTelefone.Text, txtEmail.Text);
            server.cadastrar(guest);
        }

        //evento disparado ao clique do botão
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir esse registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                server.excluirGuest(mbCpf.Text);
            }

        }

        //evento disparado ao clique do botão 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //evento disparado ao clique do botão
        private void btnCadastrarPage_Click(object sender, EventArgs e)
        {
            atualizarPage1.Hide();
            excluirPage1.Hide();
            atualizarPreviewPage1.Hide();

        }

        //evento disparado ao clique do botão
        private void btnAtualizarPage_Click(object sender, EventArgs e)
        {
            atualizarPreviewPage1.Show();
            excluirPage1.Hide();
        }

        //evento disparado ao clique do botão
        private void btnExcluirPage_Click(object sender, EventArgs e)
        {
            atualizarPreviewPage1.Hide();
            atualizarPage1.Hide();
            excluirPage1.Show();
        }
    }
}
