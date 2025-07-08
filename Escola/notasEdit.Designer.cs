namespace Escola
{
    partial class notasEdit
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
            panel1 = new Panel();
            notasDtg = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notasDtg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(notasDtg);
            panel1.Location = new Point(137, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 320);
            panel1.TabIndex = 0;
            // 
            // notasDtg
            // 
            notasDtg.AllowUserToAddRows = false;
            notasDtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notasDtg.BackgroundColor = SystemColors.ControlDarkDark;
            notasDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notasDtg.Location = new Point(3, 3);
            notasDtg.Name = "notasDtg";
            notasDtg.Size = new Size(670, 161);
            notasDtg.TabIndex = 0;
            // 
            // notasEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1016, 566);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "notasEdit";
            Text = "notasEdit";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)notasDtg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView notasDtg;
    }
}