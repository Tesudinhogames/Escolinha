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
        int index = 0;

        public void Coiso()
        {

        }

        public TurmaEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

        }

   

        private void turmaDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = turmaDtg.Rows[index];
            nomeTmTxt.Text = row.Cells[0].Value.ToString();
            anoTxt.Text = row.Cells[1].Value.ToString();
            escCbx.SelectedItem = row.Cells[2].Value.ToString();
            serieCbx.SelectedItem = row.Cells[3].Value.ToString();
        }
    }
}
