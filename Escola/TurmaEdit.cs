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
    public partial class TurmaEdit : Form
    {
        static string query = "select * from turmas";
        DataTable turmas = Funcoes.Pesquisar(query);
        int indice = 0;

        public TurmaEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = turmaDtg.Rows[indice];

            string queryy = $"select id, nome_fantasia from escolas where nome_fantasia = '{escCbx.SelectedItem}'";

            var dt = Funcoes.Pesquisar(queryy);

            string id = dt.Rows[0]["id"].ToString();

            string update = $"update turmas set nome = '{nomeTmTxt.Text}', escola = '{escCbx.SelectedItem}', ano_letivo = {anoTxt.Text}, escola_id = {id}" +
                $" where id = {row.Cells[0].Value}";

            Funcoes.Inserir(update);

            queryy = "select * from turmas";
            dt = Funcoes.Pesquisar(query);

            turmaDtg.DataSource = null;
            turmaDtg.DataSource = dt;
        }

        private void turmaDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = turmaDtg.Rows[indice];
            nomeTmTxt.Text = row.Cells[1].Value.ToString();
            anoTxt.Text = row.Cells[3].Value.ToString();
            escCbx.SelectedItem = row.Cells[2].Value.ToString();
            serieCbx.SelectedItem = row.Cells[4].Value.ToString();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = turmaDtg.Rows[indice];

            string delete = "delete from turmas where id = " + row.Cells[0].Value.ToString();

            Funcoes.Inserir(delete);

            string queryy = "select * from turmas ";

            var dt = Funcoes.Pesquisar(queryy);

            turmaDtg.DataSource = null;
            turmaDtg.DataSource = dt;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TurmaEdit_Load(object sender, EventArgs e)
        {
            turmaDtg.DataSource = turmas;

            string queryy = "select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(queryy);

            escCbx.Items.AddRange(Funcoes.prencheer(dt).ToArray());

            turmaDtg.Columns["escola_id"].Visible = false;
        }
    }
}
