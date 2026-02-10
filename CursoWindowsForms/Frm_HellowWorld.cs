
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HellowWorld : Form
    {
        public Frm_HellowWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ModificalLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;

        }
    }
}
