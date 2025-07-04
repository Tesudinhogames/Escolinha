namespace Escola
{
    partial class AlunoForm
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
            nomeAl = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            resp = new TextBox();
            dataAl = new MaskedTextBox();
            label6 = new Label();
            mascu = new RadioButton();
            fem = new RadioButton();
            SalvarAl = new Button();
            respTell = new MaskedTextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            masc = new Label();
            escolaCmb = new ComboBox();
            turmaAl = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // nomeAl
            // 
            nomeAl.Location = new Point(189, 38);
            nomeAl.Name = "nomeAl";
            nomeAl.Size = new Size(453, 23);
            nomeAl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(69, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(59, 76);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome do responsável:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(99, 141);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefone do responsável:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 141);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 5;
            label5.Text = "Data de nascimento:";
            label5.Click += label5_Click;
            // 
            // resp
            // 
            resp.Location = new Point(189, 76);
            resp.Name = "resp";
            resp.Size = new Size(453, 23);
            resp.TabIndex = 6;
            // 
            // dataAl
            // 
            dataAl.Location = new Point(533, 138);
            dataAl.Mask = " 00/00/0000";
            dataAl.Name = "dataAl";
            dataAl.Size = new Size(69, 23);
            dataAl.TabIndex = 9;
            dataAl.ValidatingType = typeof(DateTime);
            dataAl.TextChanged += dataAl_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(257, 93);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Sexo:";
            // 
            // mascu
            // 
            mascu.AutoSize = true;
            mascu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            mascu.Location = new Point(301, 93);
            mascu.Name = "mascu";
            mascu.Size = new Size(80, 19);
            mascu.TabIndex = 11;
            mascu.TabStop = true;
            mascu.Text = "Masculino";
            mascu.UseVisualStyleBackColor = true;
            mascu.CheckedChanged += mascu_CheckedChanged;
            // 
            // fem
            // 
            fem.AutoSize = true;
            fem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fem.Location = new Point(387, 93);
            fem.Name = "fem";
            fem.Size = new Size(76, 19);
            fem.TabIndex = 12;
            fem.TabStop = true;
            fem.Text = "Feminino";
            fem.UseVisualStyleBackColor = true;
            fem.CheckedChanged += fem_CheckedChanged;
            // 
            // SalvarAl
            // 
            SalvarAl.BackColor = SystemColors.ButtonFace;
            SalvarAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalvarAl.Location = new Point(633, 396);
            SalvarAl.Name = "SalvarAl";
            SalvarAl.Size = new Size(110, 41);
            SalvarAl.TabIndex = 13;
            SalvarAl.Text = "Cadastrar";
            SalvarAl.UseVisualStyleBackColor = false;
            SalvarAl.Click += SalvarAl_Click;
            // 
            // respTell
            // 
            respTell.Location = new Point(244, 138);
            respTell.Mask = "(00) 00000-0000";
            respTell.Name = "respTell";
            respTell.Size = new Size(100, 23);
            respTell.TabIndex = 16;
            respTell.ValidatingType = typeof(DateTime);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SalvarAl);
            panel1.Location = new Point(252, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 467);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(mascu);
            panel3.Controls.Add(masc);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(escolaCmb);
            panel3.Controls.Add(turmaAl);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(fem);
            panel3.Location = new Point(33, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(506, 183);
            panel3.TabIndex = 18;
            // 
            // masc
            // 
            masc.AutoSize = true;
            masc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masc.Location = new Point(43, 97);
            masc.Name = "masc";
            masc.Size = new Size(45, 15);
            masc.TabIndex = 2;
            masc.Text = "Turma:";
            // 
            // escolaCmb
            // 
            escolaCmb.FormattingEnabled = true;
            escolaCmb.Location = new Point(43, 47);
            escolaCmb.Name = "escolaCmb";
            escolaCmb.Size = new Size(121, 23);
            escolaCmb.TabIndex = 14;
            escolaCmb.SelectedIndexChanged += escolaCmb_SelectedIndexChanged;
            // 
            // turmaAl
            // 
            turmaAl.FormattingEnabled = true;
            turmaAl.Location = new Point(43, 115);
            turmaAl.Name = "turmaAl";
            turmaAl.Size = new Size(121, 23);
            turmaAl.TabIndex = 8;
            turmaAl.SelectedIndexChanged += turmaAl_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 29);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 15;
            label2.Text = "Escola:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(nomeAl);
            panel2.Controls.Add(dataAl);
            panel2.Controls.Add(resp);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(respTell);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(33, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 211);
            panel2.TabIndex = 17;
            // 
            // AlunoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1270, 648);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlunoForm";
            Text = "aluno";
            Load += aluno_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox resp;
        private Label label1;
        private TextBox nomeAl;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox dataAl;
        private Label label6;
        private RadioButton mascu;
        private RadioButton fem;
        private Button SalvarAl;
        private MaskedTextBox respTell;
        private Panel panel1;
        private Label label2;
        private ComboBox turmaAl;
        private ComboBox escolaCmb;
        private Label masc;
        private Panel panel3;
        private Panel panel2;
    }
}