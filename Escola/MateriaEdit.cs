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
    public partial class MateriaEdit : Form
    {
        static string query = "select * from materias";
        DataTable materias = Funcoes.Pesquisar(query);
        static int indice;

        public bool Pode(string id)
        {
            bool podendo = true;

            string queryy = "select id, disciplina from materias where id = " + id;

            var m = Funcoes.Pesquisar(queryy);

            queryy = "select materia_id from materias_turma";

            var mt = Funcoes.Pesquisar(queryy);

            for (int i = 0; i < mt.Rows.Count; i++)
            {
                if (m.Rows[0]["id"].ToString() == mt.Rows[i]["materia_id"].ToString())
                    podendo = false;
            }
            return podendo;
        }

        public MateriaEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = materiasDtg.Rows[indice];
            string id = row.Cells[0].Value.ToString(); 

                string update = $"update materias set disciplina = '{nomeTxt.Text}', carga_horaria = '{CargaTxt.Text}' where id = {id}";
                Funcoes.Inserir(update);

                materiasDtg.DataSource = null;
                materiasDtg.DataSource = Funcoes.Pesquisar(query);
       
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = materiasDtg.Rows[indice];
            string id = row.Cells[0].Value.ToString();

            bool pode = Pode(id);

            if (pode)
            {
                string delete = $"delete from materias where id = {id}";
                Funcoes.Inserir(delete);

                materiasDtg.DataSource = null;
                materiasDtg.DataSource = Funcoes.Pesquisar(query);
            }
            else MessageBox.Show("não é possível excluir essa matéria pois ela já está em uma turma");
        }

        private void MateriaEdit_Load(object sender, EventArgs e)
        {
            materiasDtg.DataSource = materias;
        }

        private void materiasDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = materiasDtg.Rows[indice];

            nomeTxt.Text = row.Cells[1].Value.ToString();
            CargaTxt.Text = row.Cells[2].Value.ToString();
        }
    }
}
