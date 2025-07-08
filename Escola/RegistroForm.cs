using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class RegistroForm : Form
    {
        bool[] aprovado = new bool[2];
        int media = 0, freqTotal = 0;
        

        public void Aprovar()
        {
            if (aprovado[0] && aprovado[1])
            {
                aprovadoRbt.Checked = true;
                reprovadoRbt.Checked = false;          
            }
            else
            {
                aprovadoRbt.Checked = false;
                reprovadoRbt.Checked = true;
            }
        }

        public RegistroForm()
        {
            InitializeComponent();
        }

        public bool valNota(string num)
        {
            if (num.Length != 0)
            {
                if (int.Parse(num) > 100)
                {
                    MessageBox.Show("A nota maxíma permitida é 100!");
                    return false;
                }
                else { return true; }
            }
            return true;
        }

        public bool valHoras(string num, int max)
        {
            if (num.Length != 0)
            {
                if (int.Parse(num) > max)
                {
                    MessageBox.Show("A frequência maxíma permitida é " + max.ToString() + "!");
                    return false;
                }
                else { return true; }
            }
            return true;
        }



        public void Shiu(string text, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            else
              if (text.Length < 3)
            {
                if (e.KeyValue >= 48 && e.KeyValue <= 57)
                    e.SuppressKeyPress = false;
                else e.SuppressKeyPress = true;
            }
            else e.SuppressKeyPress = true;

        }


        private void escolaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (escolaCb.SelectedItem != null)
            {
                turmaCb.Items.Clear();

                string query = $"select id, nome_fantasia from escolas where nome_fantasia = '{escolaCb.SelectedItem}'";

                var dt = Funcoes.Pesquisar(query);

                string id = dt.Rows[0]["Id"].ToString();

                query = $"select nome, escola_id from turmas where escola_id = {id}";

                dt = Funcoes.Pesquisar(query);

                turmaCb.Items.AddRange(Funcoes.prencheer(dt).ToArray());
            }
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            string query = "select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(query);

            escolaCb.Items.AddRange(Funcoes.prencheer(dt).ToArray());




        }

        private void turmaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turmaCb.SelectedItem != null)
            {
                alunoCb.Items.Clear();

                string query = $"select id, nome from turmas where nome = '{turmaCb.SelectedItem}'";

                var dt = Funcoes.Pesquisar(query);

                string id = dt.Rows[0]["id"].ToString();

                query = "select nome, turma_id from alunos where turma_id = " + id;

                dt = Funcoes.Pesquisar(query);

                alunoCb.Items.AddRange(Funcoes.prencheer(dt).ToArray());
            }

        }

        private void alunoCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alunoCb.SelectedItem != null && turmaCb.SelectedItem != null)
            {
                
                
                    string query = $"select id, nome from turmas where nome = '{turmaCb.SelectedItem}'";

                    var dt = Funcoes.Pesquisar(query);

                    string id = dt.Rows[0]["id"].ToString();

                    query = $"select m.disciplina as materia, t.nome as nome, m.carga_horaria as maximo, mt.turma_id as turmaID, mt.materia_id as materiaID from materias_turma mt" +
                        $" join turmas t on t.id = mt.turma_id" +
                        $" join materias m on m.id = mt.materia_id where nome = '{turmaCb.SelectedItem}' order by materia";

                    dt = Funcoes.Pesquisar(query);

                    mat1.Text = dt.Rows[0]["materia"].ToString();
                    mat2.Text = dt.Rows[1]["materia"].ToString();
                    mat3.Text = dt.Rows[2]["materia"].ToString();
                    mat4.Text = dt.Rows[3]["materia"].ToString();
                    freq1.Text = mat1.Text;
                    freq2.Text = mat2.Text;
                    freq3.Text = mat3.Text;
                    freq4.Text = mat4.Text;


                    string[] maximo = new string[4];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        maximo[i] = dt.Rows[i]["maximo"].ToString();
                    }

                    max1.Text = maximo[0];
                    max2.Text = maximo[1];
                    max3.Text = maximo[2];
                    max4.Text = maximo[3];
                
            }
        }

        private void lancar_Click(object sender, EventArgs e)
        {

            string query = $"select id, nome from alunos where nome = '{alunoCb.SelectedItem}'";

            DataTable dt = Funcoes.Pesquisar(query);

            string alunoId = dt.Rows[0]["id"].ToString();

            query = $"select m.disciplina as materia, t.nome as nome, m.carga_horaria as maximo, mt.turma_id as turmaID, mt.materia_id as materiaID from materias_turma mt" +
                  $" join turmas t on t.id = mt.turma_id" +
                  $" join materias m on m.id = mt.materia_id where nome = '{turmaCb.SelectedItem}' order by materia";

            dt = Funcoes.Pesquisar(query);

            string[] materiaId = new string[4];

            for (int i = 0; i < dt.Rows.Count; i++) materiaId[i] = dt.Rows[i]["materiaId"].ToString();

            string insert = "insert into boletims (aluno_id, materia_id, nota, frequencia) " +
                 $"values({alunoId},{materiaId[0]}, {nota1.Text}, {horas1.Text})," +
                 $"({alunoId},{materiaId[1]}, {nota2.Text}, {horas2.Text})," +
                 $"({alunoId},{materiaId[2]}, {nota3.Text}, {horas3.Text})," +
                 $"({alunoId},{materiaId[3]}, {nota4.Text}, {horas4.Text})";

            Funcoes.Inserir(insert);

            Funcoes.Limpar(this);

            turmaCb.Items.Clear();
            alunoCb.Items.Clear();

            mat1.Text = "";
            mat2.Text = "";
            mat3.Text = "";
            mat4.Text = "";
            freq1.Text = "";
            freq2.Text = "";
            freq3.Text = "";
            freq4.Text = "";
            max1.Text = "";
            max2.Text = "";
            max3.Text = "";
            max4.Text = "";

        }

        private void nota1_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(nota1.Text, e);
        }

        private void nota2_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(nota2.Text, e);
        }

        private void nota3_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(nota3.Text, e);
        }

        private void nota4_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(nota4.Text, e);
        }

        private void horas1_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(horas1.Text, e);
        }

        private void horas2_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(horas2.Text, e);
        }

        private void horas3_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(horas3.Text, e);
        }

        private void horas4_KeyDown(object sender, KeyEventArgs e)
        {
            Shiu(horas4.Text, e);
        }

        private void nota1_TextChanged(object sender, EventArgs e)
        {
            if (nota1.Text != "")
            {
                if (!valNota(nota1.Text)) nota1.Text = "100";


                if (nota2.Text != "" && nota3.Text != "" && nota4.Text != "")

                    media = (int.Parse(nota1.Text) + int.Parse(nota2.Text) + int.Parse(nota3.Text) + int.Parse(nota4.Text)) / 4;
                mediaTxt.Text = media.ToString();
            }

        }

        private void nota2_TextChanged(object sender, EventArgs e)
        {
            if (nota2.Text != "")
            {
                if (!valNota(nota2.Text)) nota2.Text = "100";


                if (nota1.Text != "" && nota3.Text != "" && nota4.Text != "")

                    media = (int.Parse(nota1.Text) + int.Parse(nota2.Text) + int.Parse(nota3.Text) + int.Parse(nota4.Text)) / 4;
                mediaTxt.Text = media.ToString();
            }

        }

        private void nota3_TextChanged(object sender, EventArgs e)
        {
            if (nota3.Text != "")
            {
                if (!valNota(nota3.Text)) nota3.Text = "100";


                if (nota2.Text != "" && nota1.Text != "" && nota4.Text != "")

                    media = (int.Parse(nota1.Text) + int.Parse(nota2.Text) + int.Parse(nota3.Text) + int.Parse(nota4.Text)) / 4;
                mediaTxt.Text = media.ToString();
            }
        }

        private void nota4_TextChanged(object sender, EventArgs e)
        {
            if (nota4.Text != "")
            {
                if (!valNota(nota4.Text)) nota4.Text = "100";


                if (nota2.Text != "" && nota3.Text != "" && nota1.Text != "")

                    media = (int.Parse(nota1.Text) + int.Parse(nota2.Text) + int.Parse(nota3.Text) + int.Parse(nota4.Text)) / 4;
                mediaTxt.Text = media.ToString();
            }
        }

        private void horas1_TextChanged(object sender, EventArgs e)
        {
            if (horas1.Text != "")
            {
                int max = int.Parse(max1.Text);

                if (!valHoras(horas1.Text, max)) horas1.Text = max.ToString();

                if (horas2.Text != "" && horas3.Text != "" && horas4.Text != "")
                {
                    freqTotal = int.Parse(horas1.Text) + int.Parse(horas2.Text) + int.Parse(horas3.Text) + int.Parse(horas4.Text);
                    freqTotalTxt.Text = freqTotal.ToString();
                }

            }
        }

        private void horas2_TextChanged(object sender, EventArgs e)
        {
            if (horas2.Text != "")
            {
                int max = int.Parse(max2.Text);

                if (!valHoras(horas2.Text, max)) horas2.Text = max.ToString();

                if (horas1.Text != "" && horas3.Text != "" && horas4.Text != "")
                {
                    freqTotal = int.Parse(horas1.Text) + int.Parse(horas2.Text) + int.Parse(horas3.Text) + int.Parse(horas4.Text);
                    freqTotalTxt.Text = freqTotal.ToString();
                }

            }
        }

        private void horas3_TextChanged(object sender, EventArgs e)
        {
            if (horas3.Text != "")
            {
                int max = int.Parse(max3.Text);

                if (!valHoras(horas3.Text, max)) horas3.Text = max.ToString();

                if (horas2.Text != "" && horas1.Text != "" && horas4.Text != "")
                {
                    freqTotal = int.Parse(horas1.Text) + int.Parse(horas2.Text) + int.Parse(horas3.Text) + int.Parse(horas4.Text);
                    freqTotalTxt.Text = freqTotal.ToString();
                }

            }
        }

        private void horas4_TextChanged(object sender, EventArgs e)
        {
            if (horas4.Text != "")
            {
                int max = int.Parse(max4.Text);

                if (!valHoras(horas4.Text, max)) horas4.Text = max.ToString();

                if (horas2.Text != "" && horas3.Text != "" && horas1.Text != "")
                {
                    freqTotal = int.Parse(horas1.Text) + int.Parse(horas2.Text) + int.Parse(horas3.Text) + int.Parse(horas4.Text);
                    freqTotalTxt.Text = freqTotal.ToString();
                }
            }
        }

        private void mediaTxt_TextChanged(object sender, EventArgs e)
        {
            if (mediaTxt.Text != "")
            {
                if (media >= 70)
                    aprovado[0] = true;
                else aprovado[0] = false;

                if (freqTotalTxt.Text != "") Aprovar();

            }
        }

        private void freqTotalTxt_TextChanged(object sender, EventArgs e)
        {
            if (freqTotalTxt.Text != "")
            {
                double carga = double.Parse(horas1.Text) + double.Parse(horas2.Text) + double.Parse(horas3.Text) + double.Parse(horas4.Text);
                double maximu = double.Parse(max1.Text) + double.Parse(max2.Text) + double.Parse(max3.Text) + double.Parse(max4.Text);
                double percentual = carga / maximu * 100;

                if (percentual >= 70)
                    aprovado[1] = true;
                else
                    aprovado[1] = false;

                if (mediaTxt.Text != "") Aprovar();   
            }
        }
    }
}
