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
    public partial class AtualizarPage : UserControl
    {
        Guest guest;
        ServerConnection server;

        public AtualizarPage()
        {
            InitializeComponent();
            guest = new Guest();
            server = new ServerConnection();


            server.atualizarResult += Server_atualizarResult;
        }

        private void Server_atualizarResult(string result)
        {
            MessageBox.Show(result, "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //atualiza informações do hóspede
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            guest = new Guest(txtNome.Text, mbCpf.Text, mbTelefone.Text, txtEmail.Text);
            server.atualizarGuest(guest);
        }

        //metodo pesquisa um hóspede com base no cpf e carrega a página com os dados do mesmo
        private void AtualizarPage_Load(object sender, EventArgs e)
        {
            guest = server.buscarGuest(AtualizarPreviewPage.cpf);

            txtNome.Text = guest.Nome;
            mbCpf.Text = guest.Cpf;
            mbTelefone.Text = guest.Telefone;
            txtEmail.Text = guest.Email;
        }

    }
}
