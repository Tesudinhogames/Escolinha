using MySql.Data.MySqlClient;

namespace Escola
{
    public partial class Form1 : Form
    {
        public void Abrir(Form form)
        {

            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoForm aluno = new AlunoForm();

            Abrir(aluno);
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TurmaForm turma = new TurmaForm();
            Abrir(turma);
        }

        private void escolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscolaForm escola = new EscolaForm();
            Abrir(escola);
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaForm materia = new MateriaForm();

            Abrir(materia);
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            Abrir(registro);
        }

        private void boletimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boletim boletim = new Boletim();
            Abrir(boletim);
        }

        private void escolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscolaEdit escola = new EscolaEdit();
            Abrir(escola);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurmaEdit turma = new TurmaEdit();
            Abrir(turma);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoEdit aluno = new AlunoEdit();
            Abrir(aluno);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaEdit materia = new MateriaEdit();
            Abrir(materia); 
        }
    }
}
