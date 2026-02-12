namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.Iml_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 28);
            this.Mnu_Principal.TabIndex = 0;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorToolStripMenuItem,
            this.máscaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.valídaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.DemonstracaoKey_Imagem;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorToolStripMenuItem
            // 
            this.helloWorToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.HelloWorld_Imagem;
            this.helloWorToolStripMenuItem.Name = "helloWorToolStripMenuItem";
            this.helloWorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.helloWorToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.helloWorToolStripMenuItem.Text = "Hello &Wolrd";
            this.helloWorToolStripMenuItem.Click += new System.EventHandler(this.helloWorToolStripMenuItem_Click);
            // 
            // máscaraToolStripMenuItem
            // 
            this.máscaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Mascara_Imagem;
            this.máscaraToolStripMenuItem.Name = "máscaraToolStripMenuItem";
            this.máscaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscaraToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.máscaraToolStripMenuItem.Text = "&Máscara";
            this.máscaraToolStripMenuItem.Click += new System.EventHandler(this.máscaraToolStripMenuItem_Click);
            // 
            // validaCPFToolStripMenuItem
            // 
            this.validaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.ValidaCPF_Imagem;
            this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.validaCPFToolStripMenuItem.Text = "Valida &CPF";
            this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
            // 
            // validaCPF2ToolStripMenuItem
            // 
            this.validaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.ValidaCPF2_Imagem;
            this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            this.validaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.validaCPF2ToolStripMenuItem.Text = "Valída C&PF2";
            this.validaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF2ToolStripMenuItem_Click);
            // 
            // valídaSenhaToolStripMenuItem
            // 
            this.valídaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.ValidaSenha_Imagem;
            this.valídaSenhaToolStripMenuItem.Name = "valídaSenhaToolStripMenuItem";
            this.valídaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.valídaSenhaToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.valídaSenhaToolStripMenuItem.Text = "Valída &Senha";
            this.valídaSenhaToolStripMenuItem.Click += new System.EventHandler(this.valídaSenhaToolStripMenuItem_Click);
            // 
            // apagarAbaToolStripMenuItem
            // 
            this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.ImageList = this.Iml_Imagens;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 28);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(800, 422);
            this.Tbc_Aplicacoes.TabIndex = 1;
            this.Tbc_Aplicacoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tbc_Aplicacoes_MouseClick);
            // 
            // Iml_Imagens
            // 
            this.Iml_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_Imagens.ImageStream")));
            this.Iml_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Iml_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.Iml_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.Iml_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            this.Iml_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.Iml_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.Iml_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            // 
            // Frm_Principal_Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Mnu_Principal);
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_Principal_Menu_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaSenhaToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList Iml_Imagens;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaToolStripMenuItem;
    }
}