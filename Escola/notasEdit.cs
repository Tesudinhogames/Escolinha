using Mysqlx.Crud;
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
    public partial class notasEdit : Form
    {
        static string notaQuery = "select b.aluno_id, a.nome, b.materia_id, m.disciplina, b.nota from boletims b" +
                                "join alunos a on a.id = b.aluno_id" +
                                "join materias m on m.id = b.materia_id where aluno_id = 6 order by materia_id";

        static string freqQuery = "select b.aluno_id, a.nome, b.materia_id, m.disciplina, b.frequencia from boletims b" +
                                "join alunos a on a.id = b.aluno_id" +
                                "join materias m on m.id = b.materia_id where aluno_id = 6 order by materia_id";

        DataTable notas = Funcoes.Pesquisar(notaQuery);
        DataTable frequencias = Funcoes.Pesquisar(freqQuery);



        public notasEdit()
        {
            InitializeComponent();
        }
    }
}
