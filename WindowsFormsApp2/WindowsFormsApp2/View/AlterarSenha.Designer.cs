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
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(322, 303);
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
            this.txtSenhaNova.Location = new System.Drawing.Point(313, 225);
            this.txtSenhaNova.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '\0';
            this.txtSenhaNova.SelectedText = "";
            this.txtSenhaNova.SelectionLength = 0;
            this.txtSenhaNova.SelectionStart = 0;
            this.txtSenhaNova.Size = new System.Drawing.Size(199, 23);
            this.txtSenhaNova.TabIndex = 4;
            this.txtSenhaNova.UseSystemPasswordChar = false;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Depth = 0;
            this.txtSenhaAtual.Hint = "";
            this.txtSenhaAtual.Location = new System.Drawing.Point(313, 153);
            this.txtSenhaAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '\0';
            this.txtSenhaAtual.SelectedText = "";
            this.txtSenhaAtual.SelectionLength = 0;
            this.txtSenhaAtual.SelectionStart = 0;
            this.txtSenhaAtual.Size = new System.Drawing.Size(199, 23);
            this.txtSenhaAtual.TabIndex = 3;
            this.txtSenhaAtual.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(220, 153);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Senha atual";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(220, 225);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Senha nova";
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtSenhaAtual);
            this.Name = "AlterarSenha";
            this.Text = "AlterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaNova;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaAtual;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}