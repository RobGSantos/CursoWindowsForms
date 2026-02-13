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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
            Pic_ArquivoImagem.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();

            if(!(CDb.ShowDialog() == DialogResult.OK)) return;

            Lbl_ArquivoImagem.ForeColor = CDb.Color;
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();

            if(!(FDb.ShowDialog(this) == DialogResult.OK) ) return;

            Lbl_ArquivoImagem.Font = FDb.Font;
        }
    }
}
