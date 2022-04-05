namespace SistemaLogin
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.butnCancelar = new System.Windows.Forms.Button();
            this.butnSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(13, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(643, 53);
            this.txtUsuario.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(12, 155);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(70, 25);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 197);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(643, 53);
            this.txtSenha.TabIndex = 3;
            // 
            // butnCancelar
            // 
            this.butnCancelar.Location = new System.Drawing.Point(30, 291);
            this.butnCancelar.Name = "butnCancelar";
            this.butnCancelar.Size = new System.Drawing.Size(199, 55);
            this.butnCancelar.TabIndex = 4;
            this.butnCancelar.Text = "Cancelar";
            this.butnCancelar.UseVisualStyleBackColor = true;
            this.butnCancelar.Click += new System.EventHandler(this.butnCancelar_Click);
            // 
            // butnSenha
            // 
            this.butnSenha.Location = new System.Drawing.Point(440, 291);
            this.butnSenha.Name = "butnSenha";
            this.butnSenha.Size = new System.Drawing.Size(199, 55);
            this.butnSenha.TabIndex = 5;
            this.butnSenha.Text = "Entrar";
            this.butnSenha.UseVisualStyleBackColor = true;
            this.butnSenha.Click += new System.EventHandler(this.butnSenha_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 370);
            this.ControlBox = false;
            this.Controls.Add(this.butnSenha);
            this.Controls.Add(this.butnCancelar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button butnCancelar;
        private System.Windows.Forms.Button butnSenha;
    }
}