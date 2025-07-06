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
            excluirEd = new DataGridViewButtonColumn();
            selecaoEd = new DataGridViewButtonColumn();
            nomeMatEd = new DataGridViewTextBoxColumn();
            cargaEd = new DataGridViewTextBoxColumn();
            nomeTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cargaTxt = new TextBox();
            editarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)materiasDtg).BeginInit();
            SuspendLayout();
            // 
            // materiasDtg
            // 
            materiasDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiasDtg.Columns.AddRange(new DataGridViewColumn[] { excluirEd, selecaoEd, nomeMatEd, cargaEd });
            materiasDtg.Location = new Point(177, 61);
            materiasDtg.Name = "materiasDtg";
            materiasDtg.Size = new Size(477, 170);
            materiasDtg.TabIndex = 0;
            // 
            // excluirEd
            // 
            excluirEd.HeaderText = "Excluir";
            excluirEd.Name = "excluirEd";
            excluirEd.Width = 70;
            // 
            // selecaoEd
            // 
            selecaoEd.HeaderText = "Selecionar";
            selecaoEd.Name = "selecaoEd";
            selecaoEd.Width = 75;
            // 
            // nomeMatEd
            // 
            nomeMatEd.HeaderText = "Disciplina";
            nomeMatEd.Name = "nomeMatEd";
            nomeMatEd.ReadOnly = true;
            nomeMatEd.Width = 130;
            // 
            // cargaEd
            // 
            cargaEd.HeaderText = "Carga horária";
            cargaEd.Name = "cargaEd";
            cargaEd.ReadOnly = true;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(177, 272);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(236, 25);
            nomeTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(177, 252);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 2;
            label1.Text = "Nome da disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(457, 252);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 3;
            label2.Text = "Carga horária";
            // 
            // cargaTxt
            // 
            cargaTxt.Location = new Point(457, 274);
            cargaTxt.Name = "cargaTxt";
            cargaTxt.Size = new Size(196, 25);
            cargaTxt.TabIndex = 4;
            // 
            // editarBtn
            // 
            editarBtn.Location = new Point(567, 349);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(86, 26);
            editarBtn.TabIndex = 5;
            editarBtn.Text = "Alterar";
            editarBtn.UseVisualStyleBackColor = true;
            // 
            // MateriaEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1085, 510);
            Controls.Add(editarBtn);
            Controls.Add(cargaTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nomeTxt);
            Controls.Add(materiasDtg);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MateriaEdit";
            Text = "MateriaEdit";
            ((System.ComponentModel.ISupportInitialize)materiasDtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView materiasDtg;
        private DataGridViewButtonColumn excluirEd;
        private DataGridViewButtonColumn selecaoEd;
        private DataGridViewTextBoxColumn nomeMatEd;
        private DataGridViewTextBoxColumn cargaEd;
        private TextBox nomeTxt;
        private Label label1;
        private Label label2;
        private TextBox cargaTxt;
        private Button editarBtn;
    }
}