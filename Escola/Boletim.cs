using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Boletim : Form
    {
        public Boletim()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
        {

            string query = "select a.id as id, a.nome as nome, round(avg(b.nota), 2) as media, sum(b.frequencia) as freq from boletims b " +
                     "join alunos a on a.id = b.aluno_id group by nome order by id;";

            var alunos = Funcoes.Pesquisar(query);


            bool[,] aprovado = new bool[alunos.Rows.Count, 2];

            for (int i = 0; i < alunos.Rows.Count; i++)
            {
                if (double.Parse(alunos.Rows[i]["media"].ToString()) >= 70) aprovado[i , 0] = true;
                else aprovado[i , 0] = false;
            }

            string[] max = new string[alunos.Rows.Count];
            
                string horas_totais = "select a.id, sum(m.carga_horaria) as maximo from materias_turma mt" +
                    " join turmas t on t.id = mt.turma_id" +
                    " join materias m on m.id = mt.materia_id" +
                    " join alunos a on a.turma_id = t.id" +
                    $" group by a.id order by a.id limit {alunos.Rows.Count}";

                var frequencias = Funcoes.Pesquisar(horas_totais);

            for (int i = 0; i < frequencias.Rows.Count; i++)
            {
                max[i] = frequencias.Rows[i]["maximo"].ToString();
            }

            for (int i = 0;i < max.Length; i++)
            {
                if (double.Parse(alunos.Rows[i]["freq"].ToString()) / double.Parse(max[i]) * 100 >= 70/100)
                {
                    aprovado[i, 1] = true;
                }
                else aprovado[i, 1] = false;
            }

            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunos.Rows.Count; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Nome = alunos.Rows[i]["nome"].ToString();
                aluno.Media = alunos.Rows[i]["media"].ToString();
                aluno.Frequencia = alunos.Rows[i]["freq"].ToString();

                if (aprovado[i, 0] == true && aprovado[i, 1] == true)
                   aluno.Situacao = "Aprovado";
                else aluno.Situacao = "Reprovado";

                listaAlunos.Add(aluno);
            }
         
            dadosAlunos.DataSource = listaAlunos;    

        }
            private void dadosAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
