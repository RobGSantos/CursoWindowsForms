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
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey++;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();

            TabPage TB = new TabPage
            {
                Name = "UC_DemonstracaoKey",
                Text = $"Demonstração Key {ControleDemonstracaoKey}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 0;
            Tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void helloWorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld ++;
            // Formulario Tipo UserControl
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();

            // TabPage
            TabPage TB = new TabPage
            {
                Name = "TP_HelloWorld",
                Text = $"Hello World {ControleHelloWorld}"
            };

            //Adiciona na TabPage o Formulario UserControl
            TB.Controls.Add(U);

            // Adiciona a imagem que esta na Lista de Imagens
            TB.ImageIndex = 1;

            //Adiciona a TabPage no TabControls
            Tbc_Aplicacoes.TabPages.Add(TB);

            
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara++;
            Frm_Mascara_UC U = new Frm_Mascara_UC();

            TabPage TB = new TabPage
            {
                Name = "UC_Mascara",
                Text = $"Máscara {ControleMascara}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 2;
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF++;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();

            TabPage TB = new TabPage
            {
                Name = "UC_ValidaCPF",
                Text = $"Valída CPF {ControleValidaCPF}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 3;
            Tbc_Aplicacoes.TabPages.Add(TB);
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

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
        }
    }
}
