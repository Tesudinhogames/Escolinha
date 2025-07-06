namespace Escola
{
    partial class TurmaEdit
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
            turmaDtg = new DataGridView();
            panel2 = new Panel();
            serieCbx = new ComboBox();
            escCbx = new ComboBox();
            editarBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            anoTxt = new TextBox();
            nomeTmTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)turmaDtg).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // turmaDtg
            // 
            turmaDtg.AllowUserToAddRows = false;
            turmaDtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            turmaDtg.BackgroundColor = SystemColors.ControlDarkDark;
            turmaDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            turmaDtg.Location = new Point(36, 20);
            turmaDtg.Name = "turmaDtg";
            turmaDtg.Size = new Size(671, 199);
            turmaDtg.TabIndex = 0;
            turmaDtg.CellClick += turmaDtg_CellClick;
           
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(turmaDtg);
            panel2.Controls.Add(serieCbx);
            panel2.Controls.Add(escCbx);
            panel2.Controls.Add(editarBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(anoTxt);
            panel2.Controls.Add(nomeTmTxt);
            panel2.Font = new Font("Segoe UI", 10F);
            panel2.Location = new Point(323, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 406);
            panel2.TabIndex = 2;
            // 
            // serieCbx
            // 
            serieCbx.FormattingEnabled = true;
            serieCbx.Location = new Point(479, 305);
            serieCbx.Name = "serieCbx";
            serieCbx.Size = new Size(226, 25);
            serieCbx.TabIndex = 12;
            // 
            // escCbx
            // 
            escCbx.FormattingEnabled = true;
            escCbx.Location = new Point(36, 305);
            escCbx.Name = "escCbx";
            escCbx.Size = new Size(424, 25);
            escCbx.TabIndex = 11;
            // 
            // editarBtn
            // 
            editarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarBtn.Location = new Point(623, 351);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(82, 33);
            editarBtn.TabIndex = 10;
            editarBtn.Text = "Alterar";
            editarBtn.UseVisualStyleBackColor = true;
            editarBtn.Click += editarBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(479, 285);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 9;
            label4.Text = "Série";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(479, 232);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 8;
            label3.Text = "Ano letivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(36, 285);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 7;
            label2.Text = "Escola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(36, 232);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 6;
            label1.Text = "Nome da turma";
            // 
            // anoTxt
            // 
            anoTxt.Font = new Font("Segoe UI", 10F);
            anoTxt.Location = new Point(479, 252);
            anoTxt.Name = "anoTxt";
            anoTxt.Size = new Size(226, 25);
            anoTxt.TabIndex = 4;
            // 
            // nomeTmTxt
            // 
            nomeTmTxt.Font = new Font("Segoe UI", 10F);
            nomeTmTxt.Location = new Point(36, 252);
            nomeTmTxt.Name = "nomeTmTxt";
            nomeTmTxt.Size = new Size(424, 25);
            nomeTmTxt.TabIndex = 2;
            // 
            // TurmaEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1380, 788);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TurmaEdit";
            Text = "TurmaEdit";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)turmaDtg).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView turmaDtg;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox anoTxt;
        private TextBox nomeTmTxt;
        private Button editarBtn;
        private ComboBox serieCbx;
        private ComboBox escCbx;
    }
}