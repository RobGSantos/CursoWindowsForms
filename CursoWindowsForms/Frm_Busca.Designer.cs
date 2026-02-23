namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagaStripButton = new System.Windows.Forms.ToolStripButton();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.ApagaStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(515, 27);
            this.Tls_Principal.TabIndex = 5;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 404);
            this.listBox1.TabIndex = 6;
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // ApagaStripButton
            // 
            this.ApagaStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagaStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagaStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagaStripButton.Name = "ApagaStripButton";
            this.ApagaStripButton.Size = new System.Drawing.Size(29, 24);
            this.ApagaStripButton.Text = "toolTipStrip1";
            this.ApagaStripButton.Click += new System.EventHandler(this.ApagaStripButton_Click);
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 479);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.Text = "Frm_Busca";
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagaStripButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}