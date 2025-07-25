﻿namespace Escola
{
    partial class AlunoEdit
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
            alunoDtg = new DataGridView();
            nomeTxt = new TextBox();
            respTxt = new TextBox();
            TellTxt = new MaskedTextBox();
            DataTxt = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            escolaCbx = new ComboBox();
            turmaCbx = new ComboBox();
            editarBtn = new Button();
            panel1 = new Panel();
            excluirBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)alunoDtg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // alunoDtg
            // 
            alunoDtg.AllowUserToAddRows = false;
            alunoDtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alunoDtg.BackgroundColor = SystemColors.ControlDarkDark;
            alunoDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alunoDtg.Location = new Point(29, 3);
            alunoDtg.Name = "alunoDtg";
            alunoDtg.Size = new Size(930, 221);
            alunoDtg.TabIndex = 0;
            alunoDtg.CellClick += dataGridView1_CellClick;
            // 
            // nomeTxt
            // 
            nomeTxt.Font = new Font("Segoe UI", 10F);
            nomeTxt.Location = new Point(30, 255);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(459, 25);
            nomeTxt.TabIndex = 1;
            // 
            // respTxt
            // 
            respTxt.Font = new Font("Segoe UI", 10F);
            respTxt.Location = new Point(34, 308);
            respTxt.Name = "respTxt";
            respTxt.Size = new Size(454, 25);
            respTxt.TabIndex = 2;
            // 
            // TellTxt
            // 
            TellTxt.Font = new Font("Segoe UI", 10F);
            TellTxt.Location = new Point(509, 308);
            TellTxt.Mask = "(00)00000-9999";
            TellTxt.Name = "TellTxt";
            TellTxt.Size = new Size(321, 25);
            TellTxt.TabIndex = 5;
            // 
            // DataTxt
            // 
            DataTxt.Font = new Font("Segoe UI", 10F);
            DataTxt.Location = new Point(509, 255);
            DataTxt.Mask = "00/00/0000";
            DataTxt.Name = "DataTxt";
            DataTxt.Size = new Size(321, 25);
            DataTxt.TabIndex = 6;
            DataTxt.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(30, 232);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 7;
            label1.Text = "Nome do aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(30, 287);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 8;
            label2.Text = "Nome do responsável";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(509, 287);
            label3.Name = "label3";
            label3.Size = new Size(158, 17);
            label3.TabIndex = 9;
            label3.Text = "Telefone do responsável";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(509, 232);
            label4.Name = "label4";
            label4.Size = new Size(131, 17);
            label4.TabIndex = 10;
            label4.Text = "Data de nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(34, 341);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 11;
            label5.Text = "Escola";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(509, 341);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 12;
            label6.Text = "Turma";
            // 
            // escolaCbx
            // 
            escolaCbx.FormattingEnabled = true;
            escolaCbx.Location = new Point(34, 364);
            escolaCbx.Name = "escolaCbx";
            escolaCbx.Size = new Size(454, 25);
            escolaCbx.TabIndex = 13;
            escolaCbx.SelectedIndexChanged += escolaCbx_SelectedIndexChanged;
            // 
            // turmaCbx
            // 
            turmaCbx.FormattingEnabled = true;
            turmaCbx.Location = new Point(509, 364);
            turmaCbx.Name = "turmaCbx";
            turmaCbx.Size = new Size(321, 25);
            turmaCbx.TabIndex = 14;
            // 
            // editarBtn
            // 
            editarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarBtn.Location = new Point(867, 354);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(91, 36);
            editarBtn.TabIndex = 15;
            editarBtn.Text = "alterar";
            editarBtn.UseVisualStyleBackColor = true;
            editarBtn.Click += editarBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(excluirBtn);
            panel1.Controls.Add(alunoDtg);
            panel1.Controls.Add(editarBtn);
            panel1.Controls.Add(nomeTxt);
            panel1.Controls.Add(turmaCbx);
            panel1.Controls.Add(respTxt);
            panel1.Controls.Add(escolaCbx);
            panel1.Controls.Add(TellTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DataTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(199, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 411);
            panel1.TabIndex = 16;
            // 
            // excluirBtn
            // 
            excluirBtn.Location = new Point(867, 255);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(86, 36);
            excluirBtn.TabIndex = 16;
            excluirBtn.Text = "Excluir";
            excluirBtn.UseVisualStyleBackColor = true;
            excluirBtn.Click += excluirBtn_Click;
            // 
            // AlunoEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1380, 788);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlunoEdit";
            Text = "AlunoEdit";
            Load += AlunoEdit_Load;
            ((System.ComponentModel.ISupportInitialize)alunoDtg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView alunoDtg;
        private TextBox nomeTxt;
        private TextBox respTxt;
        private MaskedTextBox TellTxt;
        private MaskedTextBox DataTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox escolaCbx;
        private ComboBox turmaCbx;
        private Button editarBtn;
        private Panel panel1;
        private Button excluirBtn;
    }
}