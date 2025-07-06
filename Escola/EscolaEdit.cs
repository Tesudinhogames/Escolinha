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
    public partial class EscolaEdit : Form
    {
        static string query = "select nome_fantasia as nome, razao_social as razao, endereco, cnpj, telefone from escolas";
        DataTable escolas = Funcoes.Pesquisar(query);
        int indice = 0;

        private void Coiso()
        {

        }

        public EscolaEdit()
        {
            InitializeComponent();
        }

        private void EscolaEdit_Load(object sender, EventArgs e)
        {

        }

        private void escolaDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = escolaDtg.Rows[indice];

            nomeEdit.Text = row.Cells[0].Value.ToString();
            razaoEdit.Text = row.Cells[1].Value.ToString();
            enderecoEdit.Text = row.Cells[2].Value.ToString();
            cnpjEdit.Text = row.Cells[3].Value.ToString();
            tellEdit.Text = row.Cells[4].Value.ToString();
        }
    }
}
