namespace Escola
{
    partial class TurmaForm
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
            label1 = new Label();
            label123 = new Label();
            label3 = new Label();
            label4 = new Label();
            nomeTm = new TextBox();
            serieTm = new ComboBox();
            escolaTm = new ComboBox();
            SalvarTm = new Button();
            anoTm = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da turma";
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Location = new Point(239, 96);
            label123.Name = "label123";
            label123.Size = new Size(32, 15);
            label123.TabIndex = 1;
            label123.Text = "Série";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Ano letivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 96);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Escola";
            // 
            // nomeTm
            // 
            nomeTm.Location = new Point(32, 56);
            nomeTm.Name = "nomeTm";
            nomeTm.Size = new Size(289, 23);
            nomeTm.TabIndex = 4;
            // 
            // serieTm
            // 
            serieTm.FormattingEnabled = true;
            serieTm.Items.AddRange(new object[] { "1° ano EM", "2° ano EM", "3° ano EM" });
            serieTm.Location = new Point(239, 114);
            serieTm.Name = "serieTm";
            serieTm.Size = new Size(82, 23);
            serieTm.TabIndex = 6;
            // 
            // escolaTm
            // 
            escolaTm.FormattingEnabled = true;
            escolaTm.Location = new Point(32, 114);
            escolaTm.Name = "escolaTm";
            escolaTm.Size = new Size(140, 23);
            escolaTm.TabIndex = 7;
            escolaTm.SelectedIndexChanged += escolaTm_SelectedIndexChanged;
            // 
            // SalvarTm
            // 
            SalvarTm.Location = new Point(217, 188);
            SalvarTm.Name = "SalvarTm";
            SalvarTm.Size = new Size(75, 23);
            SalvarTm.TabIndex = 8;
            SalvarTm.Text = "Cadastrar";
            SalvarTm.UseVisualStyleBackColor = true;
            SalvarTm.Click += SalvarTm_Click;
            // 
            // anoTm
            // 
            anoTm.Location = new Point(90, 188);
            anoTm.Mask = "0000";
            anoTm.Name = "anoTm";
            anoTm.Size = new Size(38, 23);
            anoTm.TabIndex = 9;
            anoTm.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // TurmaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(670, 381);
            Controls.Add(anoTm);
            Controls.Add(SalvarTm);
            Controls.Add(escolaTm);
            Controls.Add(serieTm);
            Controls.Add(nomeTm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label123);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TurmaForm";
            Text = "TurmaForm";
            Load += TurmaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label123;
        private Label label3;
        private Label label4;
        private TextBox nomeTm;
        private ComboBox serieTm;
        private ComboBox escolaTm;
        private Button SalvarTm;
        private MaskedTextBox anoTm;
    }
}