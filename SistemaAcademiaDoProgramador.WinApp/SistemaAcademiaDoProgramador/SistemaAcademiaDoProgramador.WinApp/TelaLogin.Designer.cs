namespace SistemaAcademiaDoProgramador.WinApp
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(236, 106, 250);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(118, 358);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(350, 70);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNome.Location = new Point(154, 159);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(213, 32);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome de Usuário";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(154, 190);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 39);
            txtNome.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSenha.Location = new Point(154, 237);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(82, 32);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14F);
            txtSenha.Location = new Point(154, 268);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(280, 39);
            txtSenha.TabIndex = 3;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(64, 0, 64);
            lblMessage.Location = new Point(154, 456);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(96, 38);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "label1";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 67, 186);
            ClientSize = new Size(589, 503);
            Controls.Add(lblMessage);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(lblSenha);
            Controls.Add(lblNome);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Name = "TelaLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblMessage;
    }
}
