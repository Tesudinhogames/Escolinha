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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da turma";
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label123.Location = new Point(177, 95);
            label123.Name = "label123";
            label123.Size = new Size(36, 15);
            label123.TabIndex = 1;
            label123.Text = "Série";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 198);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Ano letivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 95);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Escola";
            // 
            // nomeTm
            // 
            nomeTm.Location = new Point(13, 40);
            nomeTm.Name = "nomeTm";
            nomeTm.Size = new Size(289, 23);
            nomeTm.TabIndex = 4;
            // 
            // serieTm
            // 
            serieTm.FormattingEnabled = true;
            serieTm.Items.AddRange(new object[] { "1° ano EM", "2° ano EM", "3° ano EM" });
            serieTm.Location = new Point(177, 113);
            serieTm.Name = "serieTm";
            serieTm.Size = new Size(82, 23);
            serieTm.TabIndex = 6;
            // 
            // escolaTm
            // 
            escolaTm.FormattingEnabled = true;
            escolaTm.Location = new Point(16, 113);
            escolaTm.Name = "escolaTm";
            escolaTm.Size = new Size(140, 23);
            escolaTm.TabIndex = 7;
            escolaTm.SelectedIndexChanged += escolaTm_SelectedIndexChanged;
            // 
            // SalvarTm
            // 
            SalvarTm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalvarTm.Location = new Point(323, 195);
            SalvarTm.Name = "SalvarTm";
            SalvarTm.Size = new Size(75, 33);
            SalvarTm.TabIndex = 8;
            SalvarTm.Text = "Cadastrar";
            SalvarTm.UseVisualStyleBackColor = true;
            SalvarTm.Click += SalvarTm_Click;
            // 
            // anoTm
            // 
            anoTm.Location = new Point(99, 195);
            anoTm.Mask = "0000";
            anoTm.Name = "anoTm";
            anoTm.Size = new Size(38, 23);
            anoTm.TabIndex = 9;
            anoTm.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(nomeTm);
            panel1.Controls.Add(anoTm);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SalvarTm);
            panel1.Controls.Add(label123);
            panel1.Controls.Add(escolaTm);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(serieTm);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(473, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 245);
            panel1.TabIndex = 10;
            // 
            // TurmaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1380, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TurmaForm";
            Text = "TurmaForm";
            Load += TurmaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}