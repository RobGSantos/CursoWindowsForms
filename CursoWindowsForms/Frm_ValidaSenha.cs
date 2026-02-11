using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        bool verSenhaTxt = false;
        public Frm_ValidaSenha()
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
            
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;

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
                    Lbl_Resultado.ForeColor= Color.Black;
                    break;

            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Senha.Text)) verSenhaTxt = true;
            if(!verSenhaTxt)
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

    public class ChecaForcaSenha
    {
        public int GeraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 6;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = GeraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }
}
