namespace CursoWindowsForms
{
    partial class Frm_Princial
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
            this.Btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.Btn_HelloWorld = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DemonstracaoKey
            // 
            this.Btn_DemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.Btn_DemonstracaoKey.Name = "Btn_DemonstracaoKey";
            this.Btn_DemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.Btn_DemonstracaoKey.TabIndex = 0;
            this.Btn_DemonstracaoKey.Text = "Demonstração Key";
            this.Btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            // 
            // Btn_HelloWorld
            // 
            this.Btn_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.Btn_HelloWorld.Name = "Btn_HelloWorld";
            this.Btn_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.Btn_HelloWorld.TabIndex = 1;
            this.Btn_HelloWorld.Text = "Hello World";
            this.Btn_HelloWorld.UseVisualStyleBackColor = true;
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Location = new System.Drawing.Point(252, 12);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Máscara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 5;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF2.TabIndex = 4;
            this.Btn_ValidaCPF2.Text = "Valida CPF2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF.TabIndex = 3;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            // 
            // Frm_Princial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 118);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_HelloWorld);
            this.Controls.Add(this.Btn_DemonstracaoKey);
            this.Name = "Frm_Princial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Princial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemonstracaoKey;
        private System.Windows.Forms.Button Btn_HelloWorld;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaSenha;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
        private System.Windows.Forms.Button Btn_ValidaCPF;
    }
}