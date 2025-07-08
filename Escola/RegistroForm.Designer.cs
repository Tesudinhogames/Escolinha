namespace Escola
{
    partial class RegistroForm
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
            escolaCb = new ComboBox();
            turmaCb = new ComboBox();
            alunoCb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lancar = new Button();
            groupBox2 = new GroupBox();
            nota3 = new TextBox();
            nota2 = new TextBox();
            nota1 = new TextBox();
            label4 = new Label();
            nota4 = new TextBox();
            mat4 = new Label();
            mat3 = new Label();
            mat2 = new Label();
            mat1 = new Label();
            groupBox3 = new GroupBox();
            horas3 = new TextBox();
            horas4 = new TextBox();
            horas2 = new TextBox();
            horas1 = new TextBox();
            freq4 = new Label();
            freq3 = new Label();
            freq2 = new Label();
            freq1 = new Label();
            max4 = new Label();
            max3 = new Label();
            max2 = new Label();
            max1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            reprovadoRbt = new RadioButton();
            aprovadoRbt = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            freqTotalTxt = new TextBox();
            mediaTxt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // escolaCb
            // 
            escolaCb.FormattingEnabled = true;
            escolaCb.Location = new Point(36, 51);
            escolaCb.Name = "escolaCb";
            escolaCb.Size = new Size(121, 23);
            escolaCb.TabIndex = 0;
            escolaCb.SelectedIndexChanged += escolaCb_SelectedIndexChanged;
            // 
            // turmaCb
            // 
            turmaCb.FormattingEnabled = true;
            turmaCb.Location = new Point(36, 115);
            turmaCb.Name = "turmaCb";
            turmaCb.Size = new Size(121, 23);
            turmaCb.TabIndex = 1;
            turmaCb.SelectedIndexChanged += turmaCb_SelectedIndexChanged;
            // 
            // alunoCb
            // 
            alunoCb.FormattingEnabled = true;
            alunoCb.Location = new Point(36, 181);
            alunoCb.Name = "alunoCb";
            alunoCb.Size = new Size(121, 23);
            alunoCb.TabIndex = 2;
            alunoCb.SelectedIndexChanged += alunoCb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Escola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Turma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 163);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Aluno";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(alunoCb);
            groupBox1.Controls.Add(escolaCb);
            groupBox1.Controls.Add(turmaCb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(37, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 246);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // lancar
            // 
            lancar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lancar.Location = new Point(618, 328);
            lancar.Name = "lancar";
            lancar.Size = new Size(94, 29);
            lancar.TabIndex = 16;
            lancar.Text = "Lançar";
            lancar.UseVisualStyleBackColor = true;
            lancar.Click += lancar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nota3);
            groupBox2.Controls.Add(nota2);
            groupBox2.Controls.Add(nota1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nota4);
            groupBox2.Controls.Add(mat4);
            groupBox2.Controls.Add(mat3);
            groupBox2.Controls.Add(mat2);
            groupBox2.Controls.Add(mat1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(291, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 120);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notas";
            // 
            // nota3
            // 
            nota3.Location = new Point(217, 58);
            nota3.Name = "nota3";
            nota3.Size = new Size(75, 23);
            nota3.TabIndex = 34;
            nota3.TextChanged += nota3_TextChanged;
            nota3.KeyDown += nota3_KeyDown;
            // 
            // nota2
            // 
            nota2.Location = new Point(118, 58);
            nota2.Name = "nota2";
            nota2.Size = new Size(78, 23);
            nota2.TabIndex = 35;
            nota2.TextChanged += nota2_TextChanged;
            nota2.KeyDown += nota2_KeyDown;
            // 
            // nota1
            // 
            nota1.Location = new Point(21, 58);
            nota1.Name = "nota1";
            nota1.Size = new Size(75, 23);
            nota1.TabIndex = 33;
            nota1.TextChanged += nota1_TextChanged;
            nota1.KeyDown += nota1_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(7, 104);
            label4.Name = "label4";
            label4.Size = new Size(179, 13);
            label4.TabIndex = 27;
            label4.Text = "*A nota máxima por matéria é 100";
            // 
            // nota4
            // 
            nota4.Location = new Point(314, 58);
            nota4.Name = "nota4";
            nota4.Size = new Size(75, 23);
            nota4.TabIndex = 33;
            nota4.TextChanged += nota4_TextChanged;
            nota4.KeyDown += nota4_KeyDown;
            // 
            // mat4
            // 
            mat4.AutoSize = true;
            mat4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            mat4.Location = new Point(314, 43);
            mat4.Name = "mat4";
            mat4.Size = new Size(0, 13);
            mat4.TabIndex = 26;
            // 
            // mat3
            // 
            mat3.AutoSize = true;
            mat3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            mat3.Location = new Point(217, 43);
            mat3.Name = "mat3";
            mat3.Size = new Size(0, 13);
            mat3.TabIndex = 25;
            // 
            // mat2
            // 
            mat2.AutoSize = true;
            mat2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            mat2.Location = new Point(118, 43);
            mat2.Name = "mat2";
            mat2.Size = new Size(0, 13);
            mat2.TabIndex = 24;
            // 
            // mat1
            // 
            mat1.AutoSize = true;
            mat1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            mat1.Location = new Point(21, 43);
            mat1.Name = "mat1";
            mat1.Size = new Size(0, 13);
            mat1.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(horas3);
            groupBox3.Controls.Add(horas4);
            groupBox3.Controls.Add(horas2);
            groupBox3.Controls.Add(horas1);
            groupBox3.Controls.Add(freq4);
            groupBox3.Controls.Add(freq3);
            groupBox3.Controls.Add(freq2);
            groupBox3.Controls.Add(freq1);
            groupBox3.Controls.Add(max4);
            groupBox3.Controls.Add(max3);
            groupBox3.Controls.Add(max2);
            groupBox3.Controls.Add(max1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(291, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 97);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Frequências";
            // 
            // horas3
            // 
            horas3.Location = new Point(217, 45);
            horas3.Name = "horas3";
            horas3.Size = new Size(75, 23);
            horas3.TabIndex = 34;
            horas3.TextChanged += horas3_TextChanged;
            horas3.KeyDown += horas3_KeyDown;
            // 
            // horas4
            // 
            horas4.Location = new Point(314, 45);
            horas4.Name = "horas4";
            horas4.Size = new Size(75, 23);
            horas4.TabIndex = 37;
            horas4.TextChanged += horas4_TextChanged;
            horas4.KeyDown += horas4_KeyDown;
            // 
            // horas2
            // 
            horas2.Location = new Point(118, 45);
            horas2.Name = "horas2";
            horas2.Size = new Size(78, 23);
            horas2.TabIndex = 35;
            horas2.TextChanged += horas2_TextChanged;
            horas2.KeyDown += horas2_KeyDown;
            // 
            // horas1
            // 
            horas1.Location = new Point(21, 45);
            horas1.Name = "horas1";
            horas1.Size = new Size(75, 23);
            horas1.TabIndex = 36;
            horas1.TextChanged += horas1_TextChanged;
            horas1.KeyDown += horas1_KeyDown;
            // 
            // freq4
            // 
            freq4.AutoSize = true;
            freq4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            freq4.Location = new Point(314, 27);
            freq4.Name = "freq4";
            freq4.Size = new Size(0, 13);
            freq4.TabIndex = 12;
            // 
            // freq3
            // 
            freq3.AutoSize = true;
            freq3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            freq3.Location = new Point(217, 27);
            freq3.Name = "freq3";
            freq3.Size = new Size(0, 13);
            freq3.TabIndex = 11;
            // 
            // freq2
            // 
            freq2.AutoSize = true;
            freq2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            freq2.Location = new Point(118, 27);
            freq2.Name = "freq2";
            freq2.Size = new Size(0, 13);
            freq2.TabIndex = 10;
            // 
            // freq1
            // 
            freq1.AutoSize = true;
            freq1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            freq1.Location = new Point(21, 28);
            freq1.Name = "freq1";
            freq1.Size = new Size(0, 13);
            freq1.TabIndex = 9;
            // 
            // max4
            // 
            max4.AutoSize = true;
            max4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            max4.Location = new Point(327, 71);
            max4.Name = "max4";
            max4.Size = new Size(0, 13);
            max4.TabIndex = 8;
            // 
            // max3
            // 
            max3.AutoSize = true;
            max3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            max3.Location = new Point(217, 71);
            max3.Name = "max3";
            max3.Size = new Size(0, 13);
            max3.TabIndex = 7;
            // 
            // max2
            // 
            max2.AutoSize = true;
            max2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            max2.Location = new Point(118, 71);
            max2.Name = "max2";
            max2.Size = new Size(0, 13);
            max2.TabIndex = 6;
            // 
            // max1
            // 
            max1.AutoSize = true;
            max1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            max1.Location = new Point(21, 71);
            max1.Name = "max1";
            max1.Size = new Size(0, 13);
            max1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(freqTotalTxt);
            panel1.Controls.Add(mediaTxt);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(lancar);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(53, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 370);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(reprovadoRbt);
            panel2.Controls.Add(aprovadoRbt);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(334, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 60);
            panel2.TabIndex = 32;
            // 
            // reprovadoRbt
            // 
            reprovadoRbt.AutoCheck = false;
            reprovadoRbt.AutoSize = true;
            reprovadoRbt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reprovadoRbt.Location = new Point(118, 27);
            reprovadoRbt.Name = "reprovadoRbt";
            reprovadoRbt.Size = new Size(86, 19);
            reprovadoRbt.TabIndex = 31;
            reprovadoRbt.TabStop = true;
            reprovadoRbt.Text = "Reprovado";
            reprovadoRbt.UseVisualStyleBackColor = true;
            // 
            // aprovadoRbt
            // 
            aprovadoRbt.AutoCheck = false;
            aprovadoRbt.AutoSize = true;
            aprovadoRbt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            aprovadoRbt.Location = new Point(21, 27);
            aprovadoRbt.Name = "aprovadoRbt";
            aprovadoRbt.Size = new Size(79, 19);
            aprovadoRbt.TabIndex = 30;
            aprovadoRbt.TabStop = true;
            aprovadoRbt.Text = "Aprovado";
            aprovadoRbt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(22, 9);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 29;
            label7.Text = "Situação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(177, 300);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 28;
            label6.Text = "Frequência total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(46, 298);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 27;
            label5.Text = "Média";
            // 
            // freqTotalTxt
            // 
            freqTotalTxt.Location = new Point(177, 316);
            freqTotalTxt.Name = "freqTotalTxt";
            freqTotalTxt.Size = new Size(118, 23);
            freqTotalTxt.TabIndex = 26;
            freqTotalTxt.TextChanged += freqTotalTxt_TextChanged;
            // 
            // mediaTxt
            // 
            mediaTxt.Location = new Point(46, 316);
            mediaTxt.Name = "mediaTxt";
            mediaTxt.Size = new Size(100, 23);
            mediaTxt.TabIndex = 25;
            mediaTxt.TextChanged += mediaTxt_TextChanged;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(875, 524);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroForm";
            Text = "RegistroForm";
            Load += RegistroForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox escolaCb;
        private ComboBox turmaCb;
        private ComboBox alunoCb;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
    
        private Button lancar;
    
        private GroupBox groupBox2;
        private Label mat4;
        private Label mat3;
        private Label mat2;
        private Label mat1;
        private GroupBox groupBox3;
      
        private Label max1;
        private Label label4;
        private Label max2;
      
        private Label freq4;
        private Label freq3;
        private Label freq2;
        private Label freq1;
        private Label max4;
        private Label max3;
      
        private TextBox nota1;
        private TextBox nota2;
        private TextBox nota3;
        private TextBox nota4;
        private TextBox horas3;
        private TextBox horas2;
        private TextBox horas1;
        private TextBox horas4;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox freqTotalTxt;
        private TextBox mediaTxt;
        private Panel panel2;
        private RadioButton reprovadoRbt;
        private RadioButton aprovadoRbt;
    }
}