namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            lblID = new Label();
            txtID = new TextBox();
            lblNome = new Label();
            txtCargo = new TextBox();
            lblEmail = new Label();
            txtEmpresa = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmpresa = new Label();
            txtEmail = new TextBox();
            lblCargo = new Label();
            txtNomee = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(124, 66);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.ForeColor = Color.LightSlateGray;
            txtID.HideSelection = false;
            txtID.Location = new Point(157, 63);
            txtID.Name = "txtID";
            txtID.Size = new Size(36, 27);
            txtID.TabIndex = 1;
            txtID.Text = "0";
            txtID.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(98, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(423, 195);
            txtCargo.Name = "txtCargo";
            txtCargo.RightToLeft = RightToLeft.No;
            txtCargo.Size = new Size(186, 27);
            txtCargo.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(102, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(157, 195);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(186, 27);
            txtEmpresa.TabIndex = 0;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(82, 165);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(157, 162);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(452, 27);
            txtTelefone.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(85, 198);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(66, 20);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Empresa";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(368, 198);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo";
            // 
            // txtNomee
            // 
            txtNomee.Location = new Point(157, 96);
            txtNomee.Name = "txtNomee";
            txtNomee.Size = new Size(452, 27);
            txtNomee.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(379, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(185, 361);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(188, 36);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomee);
            Controls.Add(txtEmail);
            Controls.Add(lblCargo);
            Controls.Add(lblEmpresa);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmail);
            Controls.Add(txtCargo);
            Controls.Add(lblNome);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "TelaContatoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaContatoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private TextBox txtID;
        private Label lblNome;
        private TextBox txtCargo;
        private Label lblEmail;
        private TextBox txtEmpresa;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmpresa;
        private TextBox txtEmail;
        private Label lblCargo;
        private TextBox txtNomee;
        private Button btnCancelar;
        private Button btnGravar;
    }
}