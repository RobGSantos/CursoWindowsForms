using CursoWindowsForms.Properties;
using CursoWindowsFormsBibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        int ControlArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey++;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();

            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_DemonstracaoKey_{ControleDemonstracaoKey}",
                Text = $"Demonstração Key {ControleDemonstracaoKey}"
            };

            TB.Controls.Add(U);
            TB.ImageIndex = 0;
            Tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void helloWorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld++;
            // Formulario Tipo UserControl
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();

            U.Dock = DockStyle.Fill;

            // TabPage
            TabPage TB = new TabPage
            {
                Name = $"TP_HelloWorld_{ControleHelloWorld}",
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

            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_Mascara_{ControleMascara}",
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
            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_ValidaCPF_{ControleValidaCPF}",
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

            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_ValidaCPF2_{ControleValidaCPF2}",
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

            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_ValidaSenha_{ControleValidaSenha}",
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
            if (!(Tbc_Aplicacoes.SelectedTab == null))
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
        }

        private void Tbc_Aplicacoes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (!(Tbc_Aplicacoes.SelectedTab == null))
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog()
            {
                InitialDirectory = "C:\\Users\\d918383\\OneDrive - rede.sp\\Documentos\\source\\repos\\CursoWindowsForms\\CursoWindowsForms\\Imagens",
                Filter = "PNG|*.PNG",
                Title = "Escolha a imagem"
            };

            if (!(Db.ShowDialog() == DialogResult.OK)) return;


            string nomeArquivoImagem = Db.FileName;

            ControlArquivoImagem++;
            Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);

            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage
            {
                Name = $"UC_ArquivoImagem_{ControlArquivoImagem}",
                Text = $"Arquivo de Imagem {ControlArquivoImagem}"
            };


            TB.Controls.Add(U);
            TB.ImageIndex = 6;
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (!(F.DialogResult == DialogResult.OK)) return;

            string senha = F.senha;
            string login = F.login;

            if (Cls_Uteis.ValidaSenhaLogin(senha) == false)
            {
                MessageBox.Show($"Senha inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            novoToolStripMenuItem.Enabled = true;
            apagarAbaToolStripMenuItem.Enabled = true;
            abirImagemToolStripMenuItem.Enabled = true;
            conectarToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = true;

            MessageBox.Show($"Bem vindo {login}!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao f = new Frm_Questao("Ponto_de_Interrogacao_Imagem", "Você quer realmente se desconectar?");
            f.ShowDialog();

            if (!(f.DialogResult == DialogResult.Yes)) return;

            Tbc_Aplicacoes.TabPages.Clear();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abirImagemToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;

            
        }
    }
}