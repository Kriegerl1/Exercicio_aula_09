
namespace eAgenda.WinApp
{
    partial class TelaPrincipalForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosToolStripMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(109, 29);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(222, 30);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosToolStripMenuItem
            // 
            compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            compromissosToolStripMenuItem.Size = new Size(222, 30);
            compromissosToolStripMenuItem.Text = "Compromissos";
            compromissosToolStripMenuItem.Click += compromissosToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolLabelPrincipal });
            statusStrip.Location = new Point(0, 419);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 31);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolLabelPrincipal
            // 
            toolLabelPrincipal.Font = new Font("Segoe UI", 11F);
            toolLabelPrincipal.Name = "toolLabelPrincipal";
            toolLabelPrincipal.Size = new Size(225, 25);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Text = "Excluir";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(98, 38);
            lblTipoCadastro.Text = "TipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 74);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 345);
            panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripLabel lblTipoCadastro;
    }
}
