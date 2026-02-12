using CursoWindowsFormsBibliotecas;
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
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
            Msk_CPF.Focus();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (string.IsNullOrEmpty(vConteudo))
            {
                MessageBox.Show("O campo CPF está vazio! Digite o valor do CPF!", "CAMPO CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Msk_CPF.Focus();
                return;
            }

            if (vConteudo.Length < 11)
            {
                MessageBox.Show("O CPF digitado não contém 11 números! Digite os 11 números do CPF!", "CAMPO CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Msk_CPF.Focus();
                return;
            }

            Frm_Questao Db = new Frm_Questao();
            Db.ShowDialog();

            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

            if (Db.DialogResult == DialogResult.Cancel)
            {
                Msk_CPF.Focus();
                return;
            }

            Msk_CPF.Focus();

            
            bool validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);

            if (validaCPF)
            {
                MessageBox.Show("CPF válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CPF inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
