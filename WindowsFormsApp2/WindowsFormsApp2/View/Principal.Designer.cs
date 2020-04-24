namespace WindowsFormsApp2.View
{
    partial class Principal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.button2 = new System.Windows.Forms.Button();
            this.flpAsideLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNomeUsuarioLogado = new MaterialSkin.Controls.MaterialLabel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.flpAsideLeft);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.materialDivider1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(259, 780);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "ContructorIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.White;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(7, 56);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(246, 10);
            this.materialDivider1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1120, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Alterar senha";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flpAsideLeft
            // 
            this.flpAsideLeft.Location = new System.Drawing.Point(1, 71);
            this.flpAsideLeft.Name = "flpAsideLeft";
            this.flpAsideLeft.Size = new System.Drawing.Size(255, 707);
            this.flpAsideLeft.TabIndex = 11;
            // 
            // txtNomeUsuarioLogado
            // 
            this.txtNomeUsuarioLogado.AutoSize = true;
            this.txtNomeUsuarioLogado.Depth = 0;
            this.txtNomeUsuarioLogado.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtNomeUsuarioLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNomeUsuarioLogado.Location = new System.Drawing.Point(285, 32);
            this.txtNomeUsuarioLogado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeUsuarioLogado.Name = "txtNomeUsuarioLogado";
            this.txtNomeUsuarioLogado.Size = new System.Drawing.Size(208, 19);
            this.txtNomeUsuarioLogado.TabIndex = 12;
            this.txtNomeUsuarioLogado.Text = "Nome do Funcionário Logado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.txtNomeUsuarioLogado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flpAsideLeft;
        private MaterialSkin.Controls.MaterialLabel txtNomeUsuarioLogado;
    }
}