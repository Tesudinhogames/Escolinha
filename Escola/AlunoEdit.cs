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
    public partial class AlunoEdit : Form
    {
        static string query = "select a.id as ID,a.nome as nomeAl, a.data_nascimento, a.sexo, a.nome_resp, a.telefone_resp , e.nome_fantasia, " +
            "t.nome as nomeTm, e.id as escolaID, t.id as TurmaId from escolas e " +
            " join turmas t on t.escola_id = e.id " +
            " join alunos a on t.id = a.turma_id order by ID";

        DataTable alunos = Funcoes.Pesquisar(query);
        int indice = 0;

        public AlunoEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            string queryy = $"select id, nome from turmas where nome = '{turmaCbx.SelectedItem}'";

            var dt = Funcoes.Pesquisar(queryy);

            string id = dt.Rows[0]["id"].ToString();

            string update = $"update alunos set nome = '{nomeTxt.Text}', data_nascimento = '{DataTxt.Text}', " +
                $" nome_resp = '{respTxt.Text}', telefone_resp = '{TellTxt.Text}', turma_id = {id}";

            Funcoes.Inserir(update);

            var alunoss = Funcoes.Pesquisar(query);
            alunoDtg.DataSource = null;
            alunoDtg.DataSource = alunoss;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = alunoDtg.Rows[indice];

            

            nomeTxt.Text = row.Cells[1].Value.ToString();
            respTxt.Text = row.Cells[4].Value.ToString();
            TellTxt.Text = row.Cells[5].Value.ToString();
            DataTxt.Text = row.Cells[2].Value.ToString();
            escolaCbx.SelectedItem = row.Cells[6].Value.ToString();
            turmaCbx.SelectedItem = row.Cells[7].Value.ToString();
        }

        private void AlunoEdit_Load(object sender, EventArgs e)
        {
            string query = "select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(query);

            escolaCbx.Items.AddRange(Funcoes.prencheer(dt).ToArray());


            alunoDtg.DataSource = alunos;
            alunoDtg.Columns["escolaID"].Visible = false;
            alunoDtg.Columns["turmaID"].Visible = false;
            alunoDtg.Columns["nomeAl"].HeaderText = "Nome do aluno";
            alunoDtg.Columns["nomeTm"].HeaderText = "Turma";
            alunoDtg.Columns["nome_fantasia"].HeaderText = "Escola";
            alunoDtg.Columns["nome_resp"].HeaderText = "Responsável";
            alunoDtg.Columns["telefone_resp"].HeaderText = "Telefone do responsável";
            alunoDtg.Columns["data_nascimento"].HeaderText = "Data de nascimento";

        }

        private void escolaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (escolaCbx.SelectedIndex != -1)
            {
                turmaCbx.Items.Clear();
                string queryy = "select t.nome, e.nome_fantasia from escolas e" +
                                $" join turmas t on t.escola_id = e.id where nome_fantasia = '{escolaCbx.SelectedItem}'";

                var combo = Funcoes.Pesquisar(queryy);


                turmaCbx.Items.AddRange(Funcoes.prencheer(combo).ToArray());


            }
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = alunoDtg.Rows[indice];

            string delete = $"delete from alunos where id = {row.Cells[0].Value}";

            Funcoes.Inserir(delete);

            var alunoss = Funcoes.Pesquisar(query);
            alunoDtg.DataSource = null;
            alunoDtg.DataSource = alunoss;
        }
    }
}
