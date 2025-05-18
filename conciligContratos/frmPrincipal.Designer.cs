namespace conciligContratos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnEscolherArquivo = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.grdGeral = new System.Windows.Forms.DataGridView();
            this.txtSomaValor = new System.Windows.Forms.TextBox();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.lblValorContratos = new System.Windows.Forms.Label();
            this.lblDiasAtrasados = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRecarregar = new System.Windows.Forms.PictureBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblFiltroCliente = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.lblFiltroImpor = new System.Windows.Forms.Label();
            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.cmbFiltroArquivo = new System.Windows.Forms.ComboBox();
            this.cmbFiltroImportado = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(109)))), ((int)(((byte)(129)))));
            this.btnEscolherArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherArquivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEscolherArquivo.Location = new System.Drawing.Point(18, 14);
            this.btnEscolherArquivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(207, 37);
            this.btnEscolherArquivo.TabIndex = 1;
            this.btnEscolherArquivo.Text = "Escolher Arquivo";
            this.btnEscolherArquivo.UseVisualStyleBackColor = false;
            this.btnEscolherArquivo.Click += new System.EventHandler(this.btnEscolherArquivo_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(18, 61);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(460, 29);
            this.txtCaminho.TabIndex = 15;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(109)))), ((int)(((byte)(129)))));
            this.btnImportar.Enabled = false;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportar.Location = new System.Drawing.Point(271, 14);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(207, 37);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // grdGeral
            // 
            this.grdGeral.AllowUserToAddRows = false;
            this.grdGeral.AllowUserToDeleteRows = false;
            this.grdGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdGeral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdGeral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGeral.Location = new System.Drawing.Point(18, 247);
            this.grdGeral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdGeral.MultiSelect = false;
            this.grdGeral.Name = "grdGeral";
            this.grdGeral.ReadOnly = true;
            this.grdGeral.RowHeadersVisible = false;
            this.grdGeral.RowHeadersWidth = 51;
            this.grdGeral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdGeral.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdGeral.Size = new System.Drawing.Size(1157, 378);
            this.grdGeral.TabIndex = 3;
            this.grdGeral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGeral_CellClick);
            // 
            // txtSomaValor
            // 
            this.txtSomaValor.Location = new System.Drawing.Point(543, 689);
            this.txtSomaValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSomaValor.Name = "txtSomaValor";
            this.txtSomaValor.ReadOnly = true;
            this.txtSomaValor.Size = new System.Drawing.Size(194, 29);
            this.txtSomaValor.TabIndex = 7;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(329, 689);
            this.txtVencimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.ReadOnly = true;
            this.txtVencimento.Size = new System.Drawing.Size(166, 29);
            this.txtVencimento.TabIndex = 8;
            // 
            // lblValorContratos
            // 
            this.lblValorContratos.AutoSize = true;
            this.lblValorContratos.Location = new System.Drawing.Point(538, 647);
            this.lblValorContratos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorContratos.Name = "lblValorContratos";
            this.lblValorContratos.Size = new System.Drawing.Size(81, 21);
            this.lblValorContratos.TabIndex = 10;
            this.lblValorContratos.Text = "Valor total";
            // 
            // lblDiasAtrasados
            // 
            this.lblDiasAtrasados.AutoSize = true;
            this.lblDiasAtrasados.Location = new System.Drawing.Point(325, 647);
            this.lblDiasAtrasados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasAtrasados.Name = "lblDiasAtrasados";
            this.lblDiasAtrasados.Size = new System.Drawing.Size(136, 21);
            this.lblDiasAtrasados.TabIndex = 11;
            this.lblDiasAtrasados.Text = "Maior vencimento";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(109)))), ((int)(((byte)(129)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(945, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Image = global::conciligContratos.Properties.Resources.refresh_;
            this.btnRecarregar.Location = new System.Drawing.Point(1128, 188);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(47, 48);
            this.btnRecarregar.TabIndex = 16;
            this.btnRecarregar.TabStop = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(13, 119);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(82, 21);
            this.lblFiltros.TabIndex = 18;
            this.lblFiltros.Text = "Filtrar por:";
            // 
            // lblFiltroCliente
            // 
            this.lblFiltroCliente.AutoSize = true;
            this.lblFiltroCliente.Location = new System.Drawing.Point(13, 157);
            this.lblFiltroCliente.Name = "lblFiltroCliente";
            this.lblFiltroCliente.Size = new System.Drawing.Size(58, 21);
            this.lblFiltroCliente.TabIndex = 19;
            this.lblFiltroCliente.Text = "Cliente";
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(303, 157);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(65, 21);
            this.lblArquivo.TabIndex = 20;
            this.lblArquivo.Text = "Arquivo";
            // 
            // lblFiltroImpor
            // 
            this.lblFiltroImpor.AutoSize = true;
            this.lblFiltroImpor.Location = new System.Drawing.Point(591, 157);
            this.lblFiltroImpor.Name = "lblFiltroImpor";
            this.lblFiltroImpor.Size = new System.Drawing.Size(114, 21);
            this.lblFiltroImpor.TabIndex = 21;
            this.lblFiltroImpor.Text = "Importado por:";
            // 
            // cmbFiltroCliente
            // 
            this.cmbFiltroCliente.FormattingEnabled = true;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(18, 188);
            this.cmbFiltroCliente.Name = "cmbFiltroCliente";
            this.cmbFiltroCliente.Size = new System.Drawing.Size(268, 29);
            this.cmbFiltroCliente.TabIndex = 3;
            this.cmbFiltroCliente.DropDown += new System.EventHandler(this.cmbFiltroCliente_Enter);
            this.cmbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCliente_SelectedIndexChanged);
            // 
            // cmbFiltroArquivo
            // 
            this.cmbFiltroArquivo.FormattingEnabled = true;
            this.cmbFiltroArquivo.Location = new System.Drawing.Point(308, 188);
            this.cmbFiltroArquivo.Name = "cmbFiltroArquivo";
            this.cmbFiltroArquivo.Size = new System.Drawing.Size(268, 29);
            this.cmbFiltroArquivo.TabIndex = 4;
            this.cmbFiltroArquivo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArquivo_SelectedIndexChanged);
            this.cmbFiltroArquivo.Enter += new System.EventHandler(this.cmbFiltroArquivo_Enter);
            // 
            // cmbFiltroImportado
            // 
            this.cmbFiltroImportado.FormattingEnabled = true;
            this.cmbFiltroImportado.Location = new System.Drawing.Point(596, 188);
            this.cmbFiltroImportado.Name = "cmbFiltroImportado";
            this.cmbFiltroImportado.Size = new System.Drawing.Size(268, 29);
            this.cmbFiltroImportado.TabIndex = 5;
            this.cmbFiltroImportado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroImportado_SelectedIndexChanged);
            this.cmbFiltroImportado.Enter += new System.EventHandler(this.cmbFiltroImportado_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 687);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(261, 29);
            this.txtNome.TabIndex = 5;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(14, 647);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(58, 21);
            this.lblNomeCliente.TabIndex = 9;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1192, 779);
            this.Controls.Add(this.cmbFiltroImportado);
            this.Controls.Add(this.cmbFiltroArquivo);
            this.Controls.Add(this.cmbFiltroCliente);
            this.Controls.Add(this.lblFiltroImpor);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.lblFiltroCliente);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDiasAtrasados);
            this.Controls.Add(this.lblValorContratos);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.txtSomaValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.grdGeral);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnEscolherArquivo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concilig - Contratos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolherArquivo;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView grdGeral;
        private System.Windows.Forms.TextBox txtSomaValor;
        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.Label lblValorContratos;
        private System.Windows.Forms.Label lblDiasAtrasados;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox btnRecarregar;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblFiltroCliente;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Label lblFiltroImpor;
        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.ComboBox cmbFiltroArquivo;
        private System.Windows.Forms.ComboBox cmbFiltroImportado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCliente;
    }
}