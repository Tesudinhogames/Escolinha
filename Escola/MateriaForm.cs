using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class MateriaForm : Form
    {

        List<string> idMaterias = new List<string>();

        public MateriaForm()
        {
            InitializeComponent();
        }

        private void SalvarMat_Click(object sender, EventArgs e)
        {
            bool val = false;

            if (disciplina.Text != "" && horas.MaskFull) val = true;

            if (val)
            {
                string insert = "insert into materias (disciplina, carga_horaria)" +
                    $" values ('{disciplina.Text}', {horas.Text})";

                Funcoes.Inserir(insert);

                materiasList.Items.Add(disciplina.Text);

                Funcoes.Limpar(this);
            }
        }

        private void MateriaForm_Load(object sender, EventArgs e)
        {


            string query = $"select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(query);

            escolasCbx.Items.AddRange(Funcoes.prencheer(dt).ToArray());

            query = "select m.turma_id, t.nome as nome, count(m.materia_id) as quant from materias_turma m " +
                "join turmas t on t.id = m.turma_id group by m.turma_id";

            dt = Funcoes.Pesquisar(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["quant"].ToString() == "4")
                {

                    turmaMateria.Items.Remove(dt.Rows[i]["nome"]);
                }
            }

            query = $"select disciplina from materias";

            dt = Funcoes.Pesquisar(query);

            materiasList.Items.AddRange(Funcoes.prencheer(dt).ToArray());

        }

        private void materiaTurmaCadastro_Click(object sender, EventArgs e)
        {
            bool val = false;

            if (escolasCbx.SelectedIndex != -1 && turmaMateria.SelectedIndex != -1) val = true;
            else MessageBox.Show("Selecione uma escola e uma turma para prosseguir");

            if (val)
            {
                if (idMaterias.Count == 4)
                {
                    string pesquisa = $"select id, nome from turmas where nome = '{turmaMateria.SelectedItem}'";

                    var dt = Funcoes.Pesquisar(pesquisa);

                    var id = dt.Rows[0]["id"].ToString();

                    string insert = "insert into materias_turma(turma_id, materia_id) values ";

                    for (int i = 0; i < idMaterias.Count; i++)
                    {
                        if (i < idMaterias.Count - 1) insert += $"({id},{idMaterias[i]}), ";
                        else insert += $"({id},{idMaterias[i]})";
                    }

                    Funcoes.Inserir(insert);

                    materiasAdicionadas.Items.Clear();

                    turmaMateria.Items.Remove(turmaMateria.SelectedItem);

                    pesquisa = $"select disciplina from materias";

                    dt = Funcoes.Pesquisar(pesquisa);

                    materiasList.Items.AddRange(Funcoes.prencheer(dt).ToArray());

                    MessageBox.Show("Matérias adicionadas com sucesso!");

                }
                else { MessageBox.Show("É necessário cadastrar quatro matérias por turma!!"); }
            }


        }

        private void materiasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materiasList.SelectedItem != null)
            {
                if (idMaterias.Count < 4)
                {
                    string query = $"Select id, disciplina from materias where disciplina = '{materiasList.SelectedItem}'";

                    var dt = Funcoes.Pesquisar(query);

                    string id = dt.Rows[0]["id"].ToString();

                    idMaterias.Add(id);

                    materiasAdicionadas.Items.Add(materiasList.SelectedItem.ToString());

                    materiasList.Items.Remove(materiasList.SelectedItem);
                }
                else MessageBox.Show("Só é possível cadastrar quatro matérias por turma");
            }
        }

        private void materiasAdicionadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materiasAdicionadas.SelectedItem != null)
            {

                string query = $"Select id, disciplina from materias where disciplina = '{materiasAdicionadas.SelectedItem}'";

                var dt = Funcoes.Pesquisar(query);

                string id = dt.Rows[0]["id"].ToString();

                idMaterias.Remove(id);

                materiasList.Items.Add(materiasAdicionadas.SelectedItem);

                materiasAdicionadas.Items.Remove(materiasAdicionadas.SelectedItem.ToString());
            }
        }

        private void escolasCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (escolasCbx.SelectedItem != null)
            {
                turmaMateria.Items.Clear();

                string query = $"select id, nome_fantasia from escolas where nome_fantasia = '{escolasCbx.SelectedItem}'";

                var dt = Funcoes.Pesquisar(query);

                string id = dt.Rows[0]["Id"].ToString();

                query = $"select nome, escola_id from turmas where escola_id = {id}";

                dt = Funcoes.Pesquisar(query);

                turmaMateria.Items.AddRange(Funcoes.prencheer(dt).ToArray());
            }
        }
    }
}
