namespace Escola
{
    partial class MateriaForm
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
            label1 = new Label();
            label2 = new Label();
            disciplina = new TextBox();
            SalvarMat = new Button();
            labl1234 = new Label();
            label3 = new Label();
            turmaMateria = new ComboBox();
            materiasAdicionadas = new ListBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            escolasCbx = new ComboBox();
            materiasList = new ListBox();
            materiaTurmaCadastro = new Button();
            horas = new MaskedTextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 66);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da matéria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 133);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Carga horária";
            // 
            // disciplina
            // 
            disciplina.Location = new Point(33, 84);
            disciplina.Name = "disciplina";
            disciplina.Size = new Size(132, 23);
            disciplina.TabIndex = 2;
            // 
            // SalvarMat
            // 
            SalvarMat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalvarMat.Location = new Point(60, 191);
            SalvarMat.Name = "SalvarMat";
            SalvarMat.Size = new Size(75, 23);
            SalvarMat.TabIndex = 4;
            SalvarMat.Text = "Cadastrar";
            SalvarMat.UseVisualStyleBackColor = true;
            SalvarMat.Click += SalvarMat_Click;
            // 
            // labl1234
            // 
            labl1234.AutoSize = true;
            labl1234.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labl1234.Location = new Point(66, 104);
            labl1234.Name = "labl1234";
            labl1234.Size = new Size(50, 15);
            labl1234.TabIndex = 5;
            labl1234.Text = "Turmas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 177);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 6;
            label3.Text = "Materias disponíveis";
            // 
            // turmaMateria
            // 
            turmaMateria.FormattingEnabled = true;
            turmaMateria.Location = new Point(31, 120);
            turmaMateria.Name = "turmaMateria";
            turmaMateria.Size = new Size(125, 23);
            turmaMateria.TabIndex = 8;
            // 
            // materiasAdicionadas
            // 
            materiasAdicionadas.FormattingEnabled = true;
            materiasAdicionadas.ItemHeight = 15;
            materiasAdicionadas.Location = new Point(230, 193);
            materiasAdicionadas.Name = "materiasAdicionadas";
            materiasAdicionadas.Size = new Size(152, 124);
            materiasAdicionadas.Sorted = true;
            materiasAdicionadas.TabIndex = 10;
            materiasAdicionadas.SelectedIndexChanged += materiasAdicionadas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(230, 175);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 11;
            label4.Text = "Materias adicionadas:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(escolasCbx);
            groupBox1.Controls.Add(materiasList);
            groupBox1.Controls.Add(materiaTurmaCadastro);
            groupBox1.Controls.Add(materiasAdicionadas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labl1234);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(turmaMateria);
            groupBox1.Location = new Point(230, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 366);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 39);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 15;
            label5.Text = "Escolas:";
            // 
            // escolasCbx
            // 
            escolasCbx.FormattingEnabled = true;
            escolasCbx.Location = new Point(31, 57);
            escolasCbx.Name = "escolasCbx";
            escolasCbx.Size = new Size(125, 23);
            escolasCbx.TabIndex = 14;
            escolasCbx.SelectedIndexChanged += escolasCbx_SelectedIndexChanged;
            // 
            // materiasList
            // 
            materiasList.FormattingEnabled = true;
            materiasList.ItemHeight = 15;
            materiasList.Location = new Point(22, 193);
            materiasList.Name = "materiasList";
            materiasList.Size = new Size(152, 124);
            materiasList.Sorted = true;
            materiasList.TabIndex = 13;
            materiasList.SelectedIndexChanged += materiasList_SelectedIndexChanged;
            // 
            // materiaTurmaCadastro
            // 
            materiaTurmaCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materiaTurmaCadastro.Location = new Point(250, 69);
            materiaTurmaCadastro.Name = "materiaTurmaCadastro";
            materiaTurmaCadastro.Size = new Size(75, 41);
            materiaTurmaCadastro.TabIndex = 12;
            materiaTurmaCadastro.Text = "Adicionar";
            materiaTurmaCadastro.UseVisualStyleBackColor = true;
            materiaTurmaCadastro.Click += materiaTurmaCadastro_Click;
            // 
            // horas
            // 
            horas.Location = new Point(119, 130);
            horas.Mask = "009";
            horas.Name = "horas";
            horas.Size = new Size(27, 23);
            horas.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SalvarMat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(horas);
            panel1.Controls.Add(disciplina);
            panel1.Location = new Point(366, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 394);
            panel1.TabIndex = 13;
            // 
            // MateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1380, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MateriaForm";
            Text = "z";
            Load += MateriaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox disciplina;
        private Button SalvarMat;
        private Label labl1234;
        private Label label3;
        private ComboBox turmaMateria;
        private ListBox materiasAdicionadas;
        private Label label4;
        private GroupBox groupBox1;
        private Button materiaTurmaCadastro;
        private ListBox materiasList;
        private Label label5;
        private ComboBox escolasCbx;
        private MaskedTextBox horas;
        private Panel panel1;
    }
}