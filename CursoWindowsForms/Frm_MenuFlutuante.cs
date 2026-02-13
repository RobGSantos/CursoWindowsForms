using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Right)) return;
            
            //var posicaoX = e.X;
            //var posicaoY = e.Y;

            //MessageBox.Show($"Cliquei no botão {e.Button} na coordenada {posicaoX},{posicaoY}");
        
            var ContextMenu = new ContextMenuStrip();
            //var vToolTip001 = new ToolStripMenuItem();
            //vToolTip001.Text = "Item do Menu 1";

            //var vToolTip002 = new ToolStripMenuItem();
            //vToolTip002.Text = "Item do Menu 2";
            var vToolTip001 = DesenhaItemMenu("Item do Menu 1", "Chave");
            vToolTip001.Click += new EventHandler(vToolTip001_Click);
            var vToolTip002 = DesenhaItemMenu("Item do Menu 2", "Chave");
            vToolTip002.Click += new EventHandler(vToolTip001_Click);
            ContextMenu.Items.Add(vToolTip001);
            ContextMenu.Items.Add(vToolTip002);


            ContextMenu.Show(this, e.Location);
        
        }

        void vToolTip001_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Menu {sender} clicado.");
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagem);
            var vToolTip = new ToolStripMenuItem()
            {
               Text = text,
               Image = MyImage
               
               
            };

            return vToolTip;
        }


    }
}
