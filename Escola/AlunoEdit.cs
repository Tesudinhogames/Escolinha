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
        static string query = "select * from alunos";
        DataTable alunos = Funcoes.Pesquisar(query);
        int indice = 0;

        public AlunoEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = alunoDtg.Rows[indice];

            nomeTxt.Text = row.Cells[0].Value.ToString();
            respTxt.Text = row.Cells[1].Value.ToString();
            TellTxt.Text = row.Cells[2].Value.ToString();
            DataTxt.Text = row.Cells[3].Value.ToString();
            escolaCbx.SelectedItem = row.Cells[4].Value.ToString();
            turmaCbx.SelectedItem = row.Cells[5].Value.ToString();
        }
    }
}
