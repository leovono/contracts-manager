namespace conciligContratos
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnLimparCad = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pbcBoxLogoCad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcBoxLogoCad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(109)))), ((int)(((byte)(129)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(274, 401);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 39);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(131, 224);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Digite seu nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(131, 277);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(270, 29);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Digite sua senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmaSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmaSenha.Location = new System.Drawing.Point(131, 338);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(270, 29);
            this.txtConfirmaSenha.TabIndex = 3;
            this.txtConfirmaSenha.Text = "Confirme sua senha";
            this.txtConfirmaSenha.Enter += new System.EventHandler(this.txtConfirmaSenha_Enter);
            this.txtConfirmaSenha.Leave += new System.EventHandler(this.txtConfirmaSenha_Leave);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.lblCadastro.Location = new System.Drawing.Point(144, 173);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(245, 32);
            this.lblCadastro.TabIndex = 9;
            this.lblCadastro.Text = "Cadastro de Usuário";
            // 
            // btnLimparCad
            // 
            this.btnLimparCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(109)))), ((int)(((byte)(129)))));
            this.btnLimparCad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimparCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCad.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnLimparCad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparCad.Location = new System.Drawing.Point(131, 401);
            this.btnLimparCad.Name = "btnLimparCad";
            this.btnLimparCad.Size = new System.Drawing.Size(127, 39);
            this.btnLimparCad.TabIndex = 5;
            this.btnLimparCad.Text = "Limpar";
            this.btnLimparCad.UseVisualStyleBackColor = false;
            this.btnLimparCad.Click += new System.EventHandler(this.btnLimparCad_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::conciligContratos.Properties.Resources.arrow_back_;
            this.btnVoltar.Location = new System.Drawing.Point(11, 11);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 36);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pbcBoxLogoCad
            // 
            this.pbcBoxLogoCad.Image = global::conciligContratos.Properties.Resources.logo_toico;
            this.pbcBoxLogoCad.Location = new System.Drawing.Point(201, 35);
            this.pbcBoxLogoCad.Margin = new System.Windows.Forms.Padding(2);
            this.pbcBoxLogoCad.Name = "pbcBoxLogoCad";
            this.pbcBoxLogoCad.Size = new System.Drawing.Size(130, 128);
            this.pbcBoxLogoCad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcBoxLogoCad.TabIndex = 12;
            this.pbcBoxLogoCad.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(515, 531);
            this.Controls.Add(this.pbcBoxLogoCad);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimparCad);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concilig - Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcBoxLogoCad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnLimparCad;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox pbcBoxLogoCad;
    }
}