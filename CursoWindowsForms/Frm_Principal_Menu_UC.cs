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
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
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
            ControleValidaCPF2++;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();

            TabPage TB = new TabPage
            {
                Name = "UC_ValidaCPF2",
                Text = $"Valída CPF2 {ControleValidaCPF2}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 4;
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha++;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();

            TabPage TB = new TabPage
            {
                Name = "UC_ValidaSenha",
                Text = $"Valída Senha {ControleValidaSenha}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 5;
            Tbc_Aplicacoes.TabPages.Add(TB);
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

        private void Tbc_Aplicacoes_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
            {
                if(!(Tbc_Aplicacoes.SelectedTab == null))
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }
    }
}
