namespace Escola
{
    partial class EscolaForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nomeEsc = new TextBox();
            endereco = new TextBox();
            SalvarEsc = new Button();
            telefoneEsc = new MaskedTextBox();
            label5 = new Label();
            cnpj = new MaskedTextBox();
            razaoSocialTxt = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da escola:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 77);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "CNPJ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 21);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Razão social:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 76);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // nomeEsc
            // 
            nomeEsc.Location = new Point(31, 43);
            nomeEsc.Name = "nomeEsc";
            nomeEsc.Size = new Size(445, 23);
            nomeEsc.TabIndex = 4;
            // 
            // endereco
            // 
            endereco.Location = new Point(31, 94);
            endereco.Name = "endereco";
            endereco.Size = new Size(445, 23);
            endereco.TabIndex = 7;
            // 
            // SalvarEsc
            // 
            SalvarEsc.Location = new Point(374, 94);
            SalvarEsc.Name = "SalvarEsc";
            SalvarEsc.Size = new Size(75, 23);
            SalvarEsc.TabIndex = 9;
            SalvarEsc.Text = "Cadastrar";
            SalvarEsc.UseVisualStyleBackColor = true;
            SalvarEsc.Click += SalvarEsc_Click;
            // 
            // telefoneEsc
            // 
            telefoneEsc.Location = new Point(217, 94);
            telefoneEsc.Mask = "(00) 00000-0000";
            telefoneEsc.Name = "telefoneEsc";
            telefoneEsc.Size = new Size(98, 23);
            telefoneEsc.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 76);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefone:";
            // 
            // cnpj
            // 
            cnpj.Location = new Point(51, 95);
            cnpj.Mask = "00.000.000/0000-00";
            cnpj.Name = "cnpj";
            cnpj.Size = new Size(114, 23);
            cnpj.TabIndex = 12;
            cnpj.TextChanged += cnpj_TextChanged;
            // 
            // razaoSocialTxt
            // 
            razaoSocialTxt.Location = new Point(31, 39);
            razaoSocialTxt.Name = "razaoSocialTxt";
            razaoSocialTxt.Size = new Size(445, 23);
            razaoSocialTxt.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endereco);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nomeEsc);
            groupBox1.Location = new Point(88, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 137);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SalvarEsc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(telefoneEsc);
            groupBox2.Controls.Add(razaoSocialTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cnpj);
            groupBox2.Location = new Point(73, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 138);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // EscolaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1209, 628);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EscolaForm";
            Text = "EscolaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SalvarEsc;
        public TextBox nomeEsc;
        public TextBox endereco;
        private Label label5;
        public MaskedTextBox telefoneEsc;
        private MaskedTextBox cnpj;
        private TextBox razaoSocialTxt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}