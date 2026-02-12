
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_ModificalLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;

        }
    }
}
