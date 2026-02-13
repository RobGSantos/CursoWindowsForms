using CursoWindowsFormsBibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        private bool verSenhaTxt;

        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        
        private void Btn_Limpa_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
            Txt_Senha.PasswordChar = '*';
            verSenhaTxt = false;
            Btn_VerSenha.Text = "Ver Senha";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {

            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;

            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            
            Lbl_Resultado.Text = forca.ToString();

            switch (Lbl_Resultado.Text)
            {
                case "Inaceitavel":
                case "Fraca":
                    Lbl_Resultado.ForeColor = Color.Red;
                    break;
                case "Aceitavel":
                    Lbl_Resultado.ForeColor = Color.Blue;
                    break;
                case "Forte":
                case "Segura":
                    Lbl_Resultado.ForeColor = Color.Green;
                    break;
                default:
                    Lbl_Resultado.ForeColor = Color.Black;
                    break;

            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Senha.Text)) verSenhaTxt = true;
            if (!verSenhaTxt)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Esconder Senha";
                verSenhaTxt = !verSenhaTxt;
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver Senha";
                verSenhaTxt = !verSenhaTxt;
            }
        }
    }
}
