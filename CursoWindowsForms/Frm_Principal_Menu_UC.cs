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
    public partial class Frm_Principal_Menu_UC : Form
    {
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstacaoKey f = new Frm_DemonstacaoKey();
            f.ShowDialog();
        }

        private void helloWorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Formulario Tipo UserControl
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();

            // TabPage
            TabPage TB = new TabPage
            {
                Name = "TP_HelloWorld",
                Text = "Hello World"
            };
            //Adiciona na TabPage o Formulario UserControl
            TB.Controls.Add(U);

            //Adiciona a TabPage no TabControls
            Tbc_Aplicacoes.TabPages.Add(TB);
            
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
