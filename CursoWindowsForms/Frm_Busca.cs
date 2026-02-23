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
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect {  get; set; }

        public Frm_Busca(List<List<string>> ListaBusca)
        {   
            _ListaBusca = ListaBusca;
            InitializeComponent();
            Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar a seleção";
            PreencherLista();
            Lst_Busca.Sorted = true;

        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();

            for (int i = 0; i < _ListaBusca.Count; i++)
            {
                ItemBox X = new ItemBox
                {
                    Id = _ListaBusca[i][0],
                    Nome = _ListaBusca[i][1]
                };

                Lst_Busca.Items.Add(X);
            }
            
        }

        private void ApagaStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox itemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];
            idSelect = itemSelecionado.Id;
            Close();
        }

        class ItemBox
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
