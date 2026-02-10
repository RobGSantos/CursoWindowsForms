namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha
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
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(12, 45);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(218, 22);
            this.Txt_Senha.TabIndex = 0;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Result
            // 
            this.Btn_Result.Location = new System.Drawing.Point(245, 42);
            this.Btn_Result.Name = "Btn_Result";
            this.Btn_Result.Size = new System.Drawing.Size(111, 23);
            this.Btn_Result.TabIndex = 2;
            this.Btn_Result.Text = "Limpa";
            this.Btn_Result.UseVisualStyleBackColor = true;
            // 
            // Frm_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 146);
            this.Controls.Add(this.Btn_Result);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Name = "Frm_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Result;
    }
}