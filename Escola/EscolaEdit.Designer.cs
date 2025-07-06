namespace Escola
{
    partial class EscolaEdit
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
            escolaDtg = new DataGridView();
            esclusaoEsc = new DataGridViewButtonColumn();
            selecaoEscola = new DataGridViewButtonColumn();
            nomeEsc = new DataGridViewTextBoxColumn();
            razaoEsc = new DataGridViewTextBoxColumn();
            enderecoEsc = new DataGridViewTextBoxColumn();
            cnpjEsc = new DataGridViewTextBoxColumn();
            tellEsc = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            nomeEdit = new TextBox();
            razaoEdit = new TextBox();
            enderecoEdit = new TextBox();
            label123 = new Label();
            label1 = new Label();
            cnpjEdit = new MaskedTextBox();
            tellEdit = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)escolaDtg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // escolaDtg
            // 
            escolaDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            escolaDtg.Columns.AddRange(new DataGridViewColumn[] { esclusaoEsc, selecaoEscola, nomeEsc, razaoEsc, enderecoEsc, cnpjEsc, tellEsc });
            escolaDtg.Dock = DockStyle.Fill;
            escolaDtg.Location = new Point(0, 0);
            escolaDtg.Name = "escolaDtg";
            escolaDtg.Size = new Size(727, 204);
            escolaDtg.TabIndex = 0;
            escolaDtg.CellContentClick += dataGridView1_CellContentClick;
            // 
            // esclusaoEsc
            // 
            esclusaoEsc.HeaderText = "Excluir";
            esclusaoEsc.Name = "esclusaoEsc";
            esclusaoEsc.Width = 60;
            // 
            // selecaoEscola
            // 
            selecaoEscola.HeaderText = "Selecionar";
            selecaoEscola.Name = "selecaoEscola";
            selecaoEscola.Width = 70;
            // 
            // nomeEsc
            // 
            nomeEsc.HeaderText = "Nome Fantasia";
            nomeEsc.Name = "nomeEsc";
            nomeEsc.ReadOnly = true;
            nomeEsc.Width = 110;
            // 
            // razaoEsc
            // 
            razaoEsc.HeaderText = "Razao Social";
            razaoEsc.Name = "razaoEsc";
            razaoEsc.ReadOnly = true;
            razaoEsc.Width = 110;
            // 
            // enderecoEsc
            // 
            enderecoEsc.HeaderText = "Endereço";
            enderecoEsc.Name = "enderecoEsc";
            enderecoEsc.ReadOnly = true;
            enderecoEsc.Width = 110;
            // 
            // cnpjEsc
            // 
            cnpjEsc.HeaderText = "CNPJ";
            cnpjEsc.Name = "cnpjEsc";
            cnpjEsc.ReadOnly = true;
            cnpjEsc.Width = 110;
            // 
            // tellEsc
            // 
            tellEsc.HeaderText = " Telefone";
            tellEsc.Name = "tellEsc";
            tellEsc.ReadOnly = true;
            tellEsc.Width = 110;
            // 
            // panel1
            // 
            panel1.Controls.Add(escolaDtg);
            panel1.Location = new Point(296, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 204);
            panel1.TabIndex = 1;
            // 
            // nomeEdit
            // 
            nomeEdit.Font = new Font("Segoe UI", 10F);
            nomeEdit.Location = new Point(296, 395);
            nomeEdit.Name = "nomeEdit";
            nomeEdit.Size = new Size(614, 25);
            nomeEdit.TabIndex = 1;
            // 
            // razaoEdit
            // 
            razaoEdit.Font = new Font("Segoe UI", 10F);
            razaoEdit.Location = new Point(296, 454);
            razaoEdit.Name = "razaoEdit";
            razaoEdit.Size = new Size(614, 25);
            razaoEdit.TabIndex = 2;
            // 
            // enderecoEdit
            // 
            enderecoEdit.Font = new Font("Segoe UI", 10F);
            enderecoEdit.Location = new Point(296, 507);
            enderecoEdit.Name = "enderecoEdit";
            enderecoEdit.Size = new Size(262, 25);
            enderecoEdit.TabIndex = 4;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label123.Location = new Point(296, 373);
            label123.Name = "label123";
            label123.Size = new Size(117, 19);
            label123.TabIndex = 6;
            label123.Text = "Nome da escola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(296, 432);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 7;
            label1.Text = "Razão social";
            // 
            // cnpjEdit
            // 
            cnpjEdit.Font = new Font("Segoe UI", 10F);
            cnpjEdit.Location = new Point(575, 507);
            cnpjEdit.Mask = "00.000.000/0000-00";
            cnpjEdit.Name = "cnpjEdit";
            cnpjEdit.Size = new Size(145, 25);
            cnpjEdit.TabIndex = 8;
            // 
            // tellEdit
            // 
            tellEdit.Font = new Font("Segoe UI", 10F);
            tellEdit.Location = new Point(735, 507);
            tellEdit.Mask = "(00) 00000-9999";
            tellEdit.Name = "tellEdit";
            tellEdit.Size = new Size(175, 25);
            tellEdit.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 489);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 10;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(575, 489);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 11;
            label3.Text = "CNPJ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(735, 487);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 12;
            label4.Text = "Telefone";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(938, 480);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 13;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            // 
            // EscolaEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1318, 732);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tellEdit);
            Controls.Add(cnpjEdit);
            Controls.Add(label1);
            Controls.Add(label123);
            Controls.Add(enderecoEdit);
            Controls.Add(razaoEdit);
            Controls.Add(nomeEdit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EscolaEdit";
            Text = "EscolaEdit";
            Load += EscolaEdit_Load;
            ((System.ComponentModel.ISupportInitialize)escolaDtg).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView escolaDtg;
        private Panel panel1;
        private TextBox nomeEdit;
        private TextBox razaoEdit;
        private TextBox enderecoEdit;
        private DataGridViewButtonColumn esclusaoEsc;
        private DataGridViewButtonColumn selecaoEscola;
        private DataGridViewTextBoxColumn nomeEsc;
        private DataGridViewTextBoxColumn razaoEsc;
        private DataGridViewTextBoxColumn enderecoEsc;
        private DataGridViewTextBoxColumn cnpjEsc;
        private DataGridViewTextBoxColumn tellEsc;
        private Label label123;
        private Label label1;
        private MaskedTextBox cnpjEdit;
        private MaskedTextBox tellEdit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}