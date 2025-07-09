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
            panel2 = new Panel();
            excluirBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)escolaDtg).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // escolaDtg
            // 
            escolaDtg.AllowUserToAddRows = false;
            escolaDtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            escolaDtg.BackgroundColor = SystemColors.ControlDarkDark;
            escolaDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            escolaDtg.Location = new Point(3, 3);
            escolaDtg.Name = "escolaDtg";
            escolaDtg.Size = new Size(812, 204);
            escolaDtg.TabIndex = 0;
            escolaDtg.CellClick += escolaDtg_CellClick;
            // 
            // nomeEdit
            // 
            nomeEdit.Font = new Font("Segoe UI", 10F);
            nomeEdit.Location = new Point(34, 245);
            nomeEdit.Name = "nomeEdit";
            nomeEdit.Size = new Size(614, 25);
            nomeEdit.TabIndex = 1;
            // 
            // razaoEdit
            // 
            razaoEdit.Font = new Font("Segoe UI", 10F);
            razaoEdit.Location = new Point(34, 304);
            razaoEdit.Name = "razaoEdit";
            razaoEdit.Size = new Size(614, 25);
            razaoEdit.TabIndex = 2;
            // 
            // enderecoEdit
            // 
            enderecoEdit.Font = new Font("Segoe UI", 10F);
            enderecoEdit.Location = new Point(34, 357);
            enderecoEdit.Name = "enderecoEdit";
            enderecoEdit.Size = new Size(262, 25);
            enderecoEdit.TabIndex = 4;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label123.Location = new Point(34, 223);
            label123.Name = "label123";
            label123.Size = new Size(117, 19);
            label123.TabIndex = 6;
            label123.Text = "Nome da escola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(34, 282);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 7;
            label1.Text = "Razão social";
            // 
            // cnpjEdit
            // 
            cnpjEdit.Font = new Font("Segoe UI", 10F);
            cnpjEdit.Location = new Point(313, 357);
            cnpjEdit.Mask = "00.000.000/0000-00";
            cnpjEdit.Name = "cnpjEdit";
            cnpjEdit.Size = new Size(145, 25);
            cnpjEdit.TabIndex = 8;
            cnpjEdit.TextChanged += cnpjEdit_TextChanged;
            // 
            // tellEdit
            // 
            tellEdit.Font = new Font("Segoe UI", 10F);
            tellEdit.Location = new Point(473, 357);
            tellEdit.Mask = "(00) 00000-9999";
            tellEdit.Name = "tellEdit";
            tellEdit.Size = new Size(175, 25);
            tellEdit.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 339);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 10;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(313, 339);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 11;
            label3.Text = "CNPJ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(473, 337);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 12;
            label4.Text = "Telefone";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(696, 353);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 13;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(excluirBtn);
            panel2.Controls.Add(escolaDtg);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(nomeEdit);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(razaoEdit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(enderecoEdit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label123);
            panel2.Controls.Add(tellEdit);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cnpjEdit);
            panel2.Location = new Point(281, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 395);
            panel2.TabIndex = 14;
            // 
            // excluirBtn
            // 
            excluirBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            excluirBtn.Location = new Point(696, 245);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(96, 31);
            excluirBtn.TabIndex = 14;
            excluirBtn.Text = "Excluir";
            excluirBtn.UseVisualStyleBackColor = true;
            excluirBtn.Click += excluirBtn_Click;
            // 
            // EscolaEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1380, 788);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EscolaEdit";
            Text = "EscolaEdit";
            Load += EscolaEdit_Load;
            ((System.ComponentModel.ISupportInitialize)escolaDtg).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView escolaDtg;
        private TextBox nomeEdit;
        private TextBox razaoEdit;
        private TextBox enderecoEdit;
        private Label label123;
        private Label label1;
        private MaskedTextBox cnpjEdit;
        private MaskedTextBox tellEdit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel2;
        private Button excluirBtn;
    }
}