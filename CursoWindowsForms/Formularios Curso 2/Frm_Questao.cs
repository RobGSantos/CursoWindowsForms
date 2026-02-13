using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();
            Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = MyImage;
            Lbl_Questao.Text = mensagem;
            Pic_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            Width = Lbl_Questao.Width + 50;

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
