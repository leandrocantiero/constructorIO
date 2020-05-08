namespace WindowsFormsApp2
{
    partial class Login
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
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "Usuário";
            this.txtLogin.Location = new System.Drawing.Point(183, 141);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(199, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(183, 209);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(199, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(226, 266);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = true;
            this.btnEntrar.Size = new System.Drawing.Size(112, 42);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnLogar);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 431);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
    }
}

