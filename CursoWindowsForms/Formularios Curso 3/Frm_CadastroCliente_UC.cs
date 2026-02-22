
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.DataBases;
using CursoWindowsFormsBiblioteca;

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Windows.Forms;
namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Grp_Genero.Text = "Gênero";
            Rbt_Feminino.Text = "Feminino";
            Rbt_Masculino.Text = "Masculino";
            Rbt_Outros.Text = "Outros";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_CPF.Text = "CPF";
            Lbl_Cidade.Text = "Cidade";
            Chk_NaoTemPai.Text = "Pai Desconhecido";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir na Base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base de dados";
            Tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";

            LimparDadosFormulario();
            
        }

        private void Chk_NaoTemPai_CheckedChanged(object sender, EventArgs e)
        {
            Txt_NomePai.Enabled = !Chk_NaoTemPai.Checked;
            Lbl_NomePai.Enabled = !Chk_NaoTemPai.Checked;
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();

                Fichario F = new Fichario(@"C:\Users\robso\OneDrive - rede.sp\Documentos\source\repos\CursoWindowsForms\Fichario");

                if (!F.status)
                {
                    MessageBox.Show($"Err: {F.mensagem}",
                    "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string clienteJson = Cliente.SerializedUnit(C);

                F.Incluir(C.Id, clienteJson);

                if (!F.status)
                {
                    MessageBox.Show($"Err: {F.mensagem}",
                    "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"{F.mensagem}",
                    "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Codigo.Text))
            {
                MessageBox.Show("O código do cliente está vazio! Insira o código para abrir o formulário desejado!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fichario F = new Fichario(@"C:\Users\robso\OneDrive - rede.sp\Documentos\source\repos\CursoWindowsForms\Fichario");

            if (!F.status)
            {
                LimparDadosFormulario();
                MessageBox.Show($"Err: {F.mensagem}",
                    "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clienteJson = F.Buscar(Txt_Codigo.Text);

            if (!F.status)
            {
                LimparDadosFormulario();
                MessageBox.Show(F.mensagem, "Byte Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente.Unit C = new Cliente.Unit();
            C = Cliente.DesSerializedUnit(clienteJson);
            EscreveFormulario(C);
        }

        private void EscreveFormulario(Cliente.Unit C)
        {
            LimparDadosFormulario();
            Txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;
            Chk_NaoTemPai.Checked = C.NaoTemPai;
            Txt_NomePai.Text = C.NomePai;
            Txt_CPF.Text = C.CPF;
            Rbt_Masculino.Checked = C.Genero == 0;
            Rbt_Feminino.Checked = C.Genero == 1;
            Rbt_Outros.Checked = C.Genero == 2;
            Txt_CEP.Text = C.CEP;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;

            for (int i = 0; i<= Cmb_Estados.Items.Count - 1; i++)
            {
                if (C.Estado.Equals(Cmb_Estados.Items[i].ToString()))
                {
                    Cmb_Estados.SelectedIndex = i; 
                    break;
                }
            }

            Txt_Telefone.Text = C.Telefone;
            Txt_Profissao.Text = C.Profissao;
            Txt_RendaFamiliar.Text = C.RendaFamiliar.ToString();

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão SALVAR");
        }

        private void ApagaStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão APAGAR");
        }

        private void LimpaStripButton_Click(object sender, EventArgs e)
        {
            LimparDadosFormulario();
            
        }
        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit
            {
                Id = Txt_Codigo.Text,
                Nome = Txt_NomeCliente.Text,
                NomePai = Txt_NomePai.Text,
                NomeMae = Txt_NomeMae.Text,
                NaoTemPai = Chk_NaoTemPai.Checked
            };

            if (Rbt_Masculino.Checked) C.Genero = 0;
            if (Rbt_Feminino.Checked) C.Genero = 1;
            if (Rbt_Outros.Checked) C.Genero = 2;

            C.CPF = Txt_CPF.Text;
            C.CEP = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;

            C.Estado = Cmb_Estados.SelectedIndex < 0 ? "" : Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();

            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            { 
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text); 
                C.RendaFamiliar = vRenda < 0 ? 0 : vRenda;
            }

            return C;
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;

            if (string.IsNullOrEmpty(vCep)) return;
            if( (vCep.Length != 8) || (!Information.IsNumeric(vCep)))
            {
                LimpaDadosEndereco(true);
                return;
            }

            var vJson = Cls_Uteis.GeraJSONCEP(vCep);

            Cep.Unit CEP = Cep.DesSerializedUnit(vJson);

            if (string.IsNullOrEmpty(CEP.estado))
            {
                MessageBox.Show("O número do CEP informado não foi localizado!","CEP ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                LimpaDadosEndereco(false);
                return;
            }

            Txt_Logradouro.Text = CEP.logradouro;
            Txt_Bairro.Text = CEP.bairro;
            Txt_Cidade.Text = CEP.localidade;
            Cmb_Estados.SelectedIndex = -1;
            
            for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
            {
                var item = Cmb_Estados.Items[i].ToString();
                    
                if (!item.Contains(CEP.estado)) continue;
                 
                Cmb_Estados.SelectedIndex = i;
            }
            
        }

        private void LimpaDadosEndereco(bool cepInvalido)
        {
            if (cepInvalido) 
                MessageBox.Show("CEP inválido! Digite apenas os 8 números do CEP!","CEP INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Txt_CEP.Text = string.Empty;
            Txt_Logradouro.Text = string.Empty;
            Txt_Bairro.Text = string.Empty;
            Txt_Cidade.Text = string.Empty;
            Cmb_Estados.SelectedIndex = -1;
            Txt_CEP.Select();
        }

        private void LimparDadosFormulario()
        {
            Txt_Codigo.Text = string.Empty;
            Txt_NomeCliente.Text = string.Empty;
            Txt_NomeMae.Text = string.Empty;
            Txt_NomePai.Text = string.Empty;
            Txt_CPF.Text = string.Empty;
            Chk_NaoTemPai.Checked = false;
            Rbt_Feminino.Checked = true;
            Rbt_Feminino.Checked = false;
            Txt_Profissao.Text = string.Empty;
            Txt_Telefone.Text = string.Empty;
            Txt_RendaFamiliar.Text = string.Empty;
            LimpaDadosEndereco(false);
        }

    }
}
