namespace Escola
{
    partial class Boletim
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
            dadosAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dadosAlunos).BeginInit();
            SuspendLayout();
            // 
            // dadosAlunos
            // 
            dadosAlunos.AllowUserToAddRows = false;
            dadosAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dadosAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dadosAlunos.Location = new Point(175, 128);
            dadosAlunos.Name = "dadosAlunos";
            dadosAlunos.Size = new Size(806, 222);
            dadosAlunos.TabIndex = 0;
            dadosAlunos.CellContentClick += dadosAlunos_CellContentClick;
            // 
            // Boletim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1156, 639);
            Controls.Add(dadosAlunos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Boletim";
            Text = "Boletim";
            Load += Boletim_Load;
            ((System.ComponentModel.ISupportInitialize)dadosAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dadosAlunos;
    }
}