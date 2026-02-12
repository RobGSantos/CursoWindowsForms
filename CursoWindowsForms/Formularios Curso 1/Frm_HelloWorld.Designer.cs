namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModificalLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(263, 24);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sair.Location = new System.Drawing.Point(248, 257);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar o formulário";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModificalLabel
            // 
            this.Btn_ModificalLabel.Location = new System.Drawing.Point(34, 66);
            this.Btn_ModificalLabel.Name = "Btn_ModificalLabel";
            this.Btn_ModificalLabel.Size = new System.Drawing.Size(259, 23);
            this.Btn_ModificalLabel.TabIndex = 2;
            this.Btn_ModificalLabel.Text = "Modifical Texto do Label";
            this.Btn_ModificalLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificalLabel.Click += new System.EventHandler(this.Btn_ModificalLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 104);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(321, 22);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 292);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificalLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hellow World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModificalLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

