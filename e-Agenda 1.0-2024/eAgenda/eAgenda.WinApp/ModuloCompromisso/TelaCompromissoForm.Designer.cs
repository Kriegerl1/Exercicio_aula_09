namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaCompromissoForm
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
            lblAssunto = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            datetimeCompromisso = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lblData = new Label();
            lblFim = new Label();
            dateTimePicker3 = new DateTimePicker();
            ckbContato = new CheckBox();
            lblContato = new Label();
            lbliD = new Label();
            txtiD = new TextBox();
            lblInicio = new Label();
            rdbPresencial = new RadioButton();
            rdbOnline = new RadioButton();
            gboxLocal = new GroupBox();
            btnGravarCompromisso = new Button();
            btnCancelarCompromisso = new Button();
            gboxLocal.SuspendLayout();
            SuspendLayout();
            // 
            // lblAssunto
            // 
            lblAssunto.AutoSize = true;
            lblAssunto.Location = new Point(39, 72);
            lblAssunto.Name = "lblAssunto";
            lblAssunto.Size = new Size(64, 20);
            lblAssunto.TabIndex = 0;
            lblAssunto.Text = "Assunto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 1;
            // 
            // datetimeCompromisso
            // 
            datetimeCompromisso.Format = DateTimePickerFormat.Short;
            datetimeCompromisso.Location = new Point(104, 108);
            datetimeCompromisso.Name = "datetimeCompromisso";
            datetimeCompromisso.Size = new Size(116, 27);
            datetimeCompromisso.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(104, 158);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(116, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(59, 113);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Data:";
            // 
            // lblFim
            // 
            lblFim.AutoSize = true;
            lblFim.Location = new Point(253, 145);
            lblFim.Name = "lblFim";
            lblFim.Size = new Size(68, 40);
            lblFim.TabIndex = 0;
            lblFim.Text = "Horário\r\nterminio:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(327, 158);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(116, 27);
            dateTimePicker3.TabIndex = 2;
            // 
            // ckbContato
            // 
            ckbContato.AutoSize = true;
            ckbContato.Location = new Point(39, 215);
            ckbContato.Name = "ckbContato";
            ckbContato.RightToLeft = RightToLeft.Yes;
            ckbContato.Size = new Size(234, 24);
            ckbContato.TabIndex = 3;
            ckbContato.Text = "?Deseja selecionar um contato";
            ckbContato.UseVisualStyleBackColor = true;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(297, 216);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(65, 20);
            lblContato.TabIndex = 4;
            lblContato.Text = "Contato:";
            // 
            // lbliD
            // 
            lbliD.AutoSize = true;
            lbliD.Location = new Point(76, 36);
            lbliD.Name = "lbliD";
            lbliD.Size = new Size(27, 20);
            lbliD.TabIndex = 0;
            lbliD.Text = "ID:";
            // 
            // txtiD
            // 
            txtiD.Enabled = false;
            txtiD.ForeColor = SystemColors.InactiveCaption;
            txtiD.Location = new Point(104, 29);
            txtiD.Name = "txtiD";
            txtiD.Size = new Size(50, 27);
            txtiD.TabIndex = 1;
            txtiD.Text = "0";
            txtiD.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(39, 145);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(64, 40);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Horário \r\nInicio:";
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(51, 28);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(99, 24);
            rdbPresencial.TabIndex = 5;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Location = new Point(74, 68);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(76, 24);
            rdbOnline.TabIndex = 5;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online:";
            rdbOnline.UseVisualStyleBackColor = true;
            // 
            // gboxLocal
            // 
            gboxLocal.Controls.Add(rdbOnline);
            gboxLocal.Controls.Add(rdbPresencial);
            gboxLocal.Controls.Add(textBox3);
            gboxLocal.Controls.Add(textBox2);
            gboxLocal.Location = new Point(22, 257);
            gboxLocal.Name = "gboxLocal";
            gboxLocal.Size = new Size(483, 113);
            gboxLocal.TabIndex = 6;
            gboxLocal.TabStop = false;
            gboxLocal.Text = "Local";
            // 
            // btnGravarCompromisso
            // 
            btnGravarCompromisso.Location = new Point(213, 391);
            btnGravarCompromisso.Name = "btnGravarCompromisso";
            btnGravarCompromisso.Size = new Size(124, 47);
            btnGravarCompromisso.TabIndex = 7;
            btnGravarCompromisso.Text = "Gravar";
            btnGravarCompromisso.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompromisso
            // 
            btnCancelarCompromisso.Location = new Point(343, 391);
            btnCancelarCompromisso.Name = "btnCancelarCompromisso";
            btnCancelarCompromisso.Size = new Size(124, 47);
            btnCancelarCompromisso.TabIndex = 7;
            btnCancelarCompromisso.Text = "Cancelar";
            btnCancelarCompromisso.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(btnCancelarCompromisso);
            Controls.Add(btnGravarCompromisso);
            Controls.Add(gboxLocal);
            Controls.Add(lblContato);
            Controls.Add(ckbContato);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(datetimeCompromisso);
            Controls.Add(txtiD);
            Controls.Add(textBox1);
            Controls.Add(lblFim);
            Controls.Add(lblInicio);
            Controls.Add(lbliD);
            Controls.Add(lblData);
            Controls.Add(lblAssunto);
            Name = "TelaCompromissoForm";
            Text = "TelaCompromissoForm";
            gboxLocal.ResumeLayout(false);
            gboxLocal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAssunto;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker datetimeCompromisso;
        private DateTimePicker dateTimePicker2;
        private Label lblData;
        private Label lblFim;
        private DateTimePicker dateTimePicker3;
        private CheckBox ckbContato;
        private Label lblContato;
        private Label lbliD;
        private TextBox txtiD;
        private Label lblInicio;
        private RadioButton rdbPresencial;
        private RadioButton rdbOnline;
        private GroupBox gboxLocal;
        private Button btnGravarCompromisso;
        private Button btnCancelarCompromisso;
    }
}