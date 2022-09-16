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
    public partial class ExcluirPage : UserControl
    {
        ServerConnection server;
        public ExcluirPage()
        {
            InitializeComponent();
            server = new ServerConnection();
            server.DeleteResult += Server_DeleteResult;
        }

        private void Server_DeleteResult(string result)
        {
            MessageBox.Show(result, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //pede confirmação do usuário para excluir registro
            DialogResult res = MessageBox.Show("Deseja excluir esse registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                server.excluirGuest(mbCpf.Text);
            }
        }
    }
}
