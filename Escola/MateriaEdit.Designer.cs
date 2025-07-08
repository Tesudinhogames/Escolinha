namespace Escola
{
    partial class MateriaEdit
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
            materiasDtg = new DataGridView();
            nomeTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            editarBtn = new Button();
            CargaTxt = new MaskedTextBox();
            panel1 = new Panel();
            excluirBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)materiasDtg).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materiasDtg
            // 
            materiasDtg.AllowUserToAddRows = false;
            materiasDtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            materiasDtg.BackgroundColor = SystemColors.ControlDarkDark;
            materiasDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiasDtg.Location = new Point(47, 3);
            materiasDtg.Name = "materiasDtg";
            materiasDtg.Size = new Size(450, 170);
            materiasDtg.TabIndex = 0;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(47, 215);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(236, 25);
            nomeTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(47, 195);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 2;
            label1.Text = "Nome da disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(51, 260);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 3;
            label2.Text = "Carga horária";
            // 
            // editarBtn
            // 
            editarBtn.Location = new Point(396, 250);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(86, 36);
            editarBtn.TabIndex = 5;
            editarBtn.Text = "Alterar";
            editarBtn.UseVisualStyleBackColor = true;
            editarBtn.Click += editarBtn_Click;
            // 
            // CargaTxt
            // 
            CargaTxt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CargaTxt.Location = new Point(148, 257);
            CargaTxt.Mask = "000";
            CargaTxt.Name = "CargaTxt";
            CargaTxt.Size = new Size(45, 25);
            CargaTxt.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(excluirBtn);
            panel1.Controls.Add(materiasDtg);
            panel1.Controls.Add(CargaTxt);
            panel1.Controls.Add(nomeTxt);
            panel1.Controls.Add(editarBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(139, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 299);
            panel1.TabIndex = 7;
            // 
            // excluirBtn
            // 
            excluirBtn.Location = new Point(396, 186);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(86, 35);
            excluirBtn.TabIndex = 7;
            excluirBtn.Text = "Excluir";
            excluirBtn.UseVisualStyleBackColor = true;
            // 
            // MateriaEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1085, 510);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MateriaEdit";
            Text = "MateriaEdit";
            ((System.ComponentModel.ISupportInitialize)materiasDtg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView materiasDtg;
        private TextBox nomeTxt;
        private Label label1;
        private Label label2;
        private Button editarBtn;
        private MaskedTextBox CargaTxt;
        private Panel panel1;
        private Button excluirBtn;
    }
}