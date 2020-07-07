namespace WindowsFormsApp2.View
{
    partial class AlterarSenha
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
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSenhaNova = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenhaAtual = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenhaNovaConfirmar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(156, 370);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(112, 42);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterarSenha);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Depth = 0;
            this.txtSenhaNova.Hint = "";
            this.txtSenhaNova.Location = new System.Drawing.Point(114, 246);
            this.txtSenhaNova.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '\0';
            this.txtSenhaNova.SelectedText = "";
            this.txtSenhaNova.SelectionLength = 0;
            this.txtSenhaNova.SelectionStart = 0;
            this.txtSenhaNova.Size = new System.Drawing.Size(199, 23);
            this.txtSenhaNova.TabIndex = 4;
            this.txtSenhaNova.UseSystemPasswordChar = false;
            this.txtSenhaNova.Click += new System.EventHandler(this.txtSenhaNova_Click);
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Depth = 0;
            this.txtSenhaAtual.Hint = "";
            this.txtSenhaAtual.Location = new System.Drawing.Point(114, 189);
            this.txtSenhaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '\0';
            this.txtSenhaAtual.SelectedText = "";
            this.txtSenhaAtual.SelectionLength = 0;
            this.txtSenhaAtual.SelectionStart = 0;
            this.txtSenhaAtual.Size = new System.Drawing.Size(199, 23);
            this.txtSenhaAtual.TabIndex = 3;
            this.txtSenhaAtual.UseSystemPasswordChar = false;
            this.txtSenhaAtual.Click += new System.EventHandler(this.txtSenhaAtual_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(110, 167);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Senha atual  [ Necessário ]";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(113, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(187, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Senha nova  [ Necessário ]";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(110, 102);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Login atual";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Enabled = false;
            this.txtLogin.Hint = "";
            this.txtLogin.Location = new System.Drawing.Point(114, 124);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(199, 23);
            this.txtLogin.TabIndex = 10;
            this.txtLogin.UseSystemPasswordChar = false;
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(113, 285);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(258, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Confirmar Senha nova  [ Necessário ]";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // txtSenhaNovaConfirmar
            // 
            this.txtSenhaNovaConfirmar.Depth = 0;
            this.txtSenhaNovaConfirmar.Hint = "";
            this.txtSenhaNovaConfirmar.Location = new System.Drawing.Point(114, 307);
            this.txtSenhaNovaConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaNovaConfirmar.Name = "txtSenhaNovaConfirmar";
            this.txtSenhaNovaConfirmar.PasswordChar = '\0';
            this.txtSenhaNovaConfirmar.SelectedText = "";
            this.txtSenhaNovaConfirmar.SelectionLength = 0;
            this.txtSenhaNovaConfirmar.SelectionStart = 0;
            this.txtSenhaNovaConfirmar.Size = new System.Drawing.Size(199, 23);
            this.txtSenhaNovaConfirmar.TabIndex = 11;
            this.txtSenhaNovaConfirmar.UseSystemPasswordChar = false;
            this.txtSenhaNovaConfirmar.Click += new System.EventHandler(this.txtSenhaNovaConfirmar_Click);
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 465);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtSenhaNovaConfirmar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtSenhaAtual);
            this.Name = "AlterarSenha";
            this.Text = "AlterarSenha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaNova;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaAtual;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaNovaConfirmar;
    }
}