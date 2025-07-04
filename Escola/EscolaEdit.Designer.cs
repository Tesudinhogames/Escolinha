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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            nomeEdit = new TextBox();
            razaoEdit = new TextBox();
            enderecoEdit = new TextBox();
            esclusaoEsc = new DataGridViewButtonColumn();
            selecaoEscola = new DataGridViewButtonColumn();
            nomeEsc = new DataGridViewTextBoxColumn();
            razaoEsc = new DataGridViewTextBoxColumn();
            enderecoEsc = new DataGridViewTextBoxColumn();
            cnpjEsc = new DataGridViewTextBoxColumn();
            tellEsc = new DataGridViewTextBoxColumn();
            label123 = new Label();
            label1 = new Label();
            cnpjEdit = new MaskedTextBox();
            tellEdit = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { esclusaoEsc, selecaoEscola, nomeEsc, razaoEsc, enderecoEsc, cnpjEsc, tellEsc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 204);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(19, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 204);
            panel1.TabIndex = 1;
            // 
            // nomeEdit
            // 
            nomeEdit.Location = new Point(68, 251);
            nomeEdit.Name = "nomeEdit";
            nomeEdit.Size = new Size(614, 23);
            nomeEdit.TabIndex = 1;
            // 
            // razaoEdit
            // 
            razaoEdit.Location = new Point(68, 299);
            razaoEdit.Name = "razaoEdit";
            razaoEdit.Size = new Size(614, 23);
            razaoEdit.TabIndex = 2;
            // 
            // enderecoEdit
            // 
            enderecoEdit.Location = new Point(68, 356);
            enderecoEdit.Name = "enderecoEdit";
            enderecoEdit.Size = new Size(166, 23);
            enderecoEdit.TabIndex = 4;
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
            // label123
            // 
            label123.AutoSize = true;
            label123.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label123.Location = new Point(68, 229);
            label123.Name = "label123";
            label123.Size = new Size(117, 19);
            label123.TabIndex = 6;
            label123.Text = "Nome da escola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(68, 277);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 7;
            label1.Text = "Razão social";
            // 
            // cnpjEdit
            // 
            cnpjEdit.Location = new Point(285, 356);
            cnpjEdit.Mask = "00.000.000/0000-00";
            cnpjEdit.Name = "cnpjEdit";
            cnpjEdit.Size = new Size(117, 23);
            cnpjEdit.TabIndex = 8;
            // 
            // tellEdit
            // 
            tellEdit.Location = new Point(462, 356);
            tellEdit.Mask = "(00) 00000-9999";
            tellEdit.Name = "tellEdit";
            tellEdit.Size = new Size(120, 23);
            tellEdit.TabIndex = 9;
            // 
            // EscolaEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
    }
}