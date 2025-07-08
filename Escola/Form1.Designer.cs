namespace Escola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            turmaToolStripMenuItem = new ToolStripMenuItem();
            escolaToolStripMenuItem = new ToolStripMenuItem();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            boletimToolStripMenuItem = new ToolStripMenuItem();
            escolasToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, turmaToolStripMenuItem, escolaToolStripMenuItem, materiaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(64, 20);
            cadastroToolStripMenuItem.Text = "cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(114, 22);
            alunoToolStripMenuItem.Text = "aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // turmaToolStripMenuItem
            // 
            turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            turmaToolStripMenuItem.Size = new Size(114, 22);
            turmaToolStripMenuItem.Text = "turma";
            turmaToolStripMenuItem.Click += turmaToolStripMenuItem_Click;
            // 
            // escolaToolStripMenuItem
            // 
            escolaToolStripMenuItem.Name = "escolaToolStripMenuItem";
            escolaToolStripMenuItem.Size = new Size(114, 22);
            escolaToolStripMenuItem.Text = "escola";
            escolaToolStripMenuItem.Click += escolaToolStripMenuItem_Click;
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(114, 22);
            materiaToolStripMenuItem.Text = "materia";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem, boletimToolStripMenuItem, escolasToolStripMenuItem, turmasToolStripMenuItem, alunosToolStripMenuItem, materiasToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(68, 20);
            relatoriosToolStripMenuItem.Text = "relatórios";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.AccessibleRole = AccessibleRole.None;
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(180, 22);
            registroToolStripMenuItem.Text = "registro de notas";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // boletimToolStripMenuItem
            // 
            boletimToolStripMenuItem.Name = "boletimToolStripMenuItem";
            boletimToolStripMenuItem.Size = new Size(180, 22);
            boletimToolStripMenuItem.Text = "boletims";
            boletimToolStripMenuItem.Click += boletimToolStripMenuItem_Click;
            // 
            // escolasToolStripMenuItem
            // 
            escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            escolasToolStripMenuItem.Size = new Size(180, 22);
            escolasToolStripMenuItem.Text = "escolas";
            escolasToolStripMenuItem.Click += escolasToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(180, 22);
            turmasToolStripMenuItem.Text = "turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(180, 22);
            alunosToolStripMenuItem.Text = "alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(180, 22);
            materiasToolStripMenuItem.Text = "materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1364, 749);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem turmaToolStripMenuItem;
        private ToolStripMenuItem escolaToolStripMenuItem;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem boletimToolStripMenuItem;
        private ToolStripMenuItem escolasToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
    }
}
