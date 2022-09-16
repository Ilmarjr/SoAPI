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
    public partial class AtualizarPreviewPage : UserControl
    {
        public delegate void EventHandler();
        public event EventHandler Pesquisa;
        public static string cpf;
        public new Form ParentForm { get; set; }
        public AtualizarPreviewPage()
        {
            InitializeComponent();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cpf = mbCpf.Text;
            ParentForm.Invoke(Pesquisa);
        }
    }
}
