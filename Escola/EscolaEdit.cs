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
        static string query = "select * from escolas order by id";
        DataTable escolas = Funcoes.Pesquisar(query);
        int indice = 0;

        public EscolaEdit()
        {
            InitializeComponent();
        }

        private void EscolaEdit_Load(object sender, EventArgs e)
        {
            escolaDtg.DataSource = escolas;
        }

        private void escolaDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            DataGridViewRow row = escolaDtg.Rows[indice];

            nomeEdit.Text = row.Cells[1].Value.ToString();
            razaoEdit.Text = row.Cells[2].Value.ToString();
            enderecoEdit.Text = row.Cells[4].Value.ToString();
            cnpjEdit.Text = row.Cells[3].Value.ToString();
            tellEdit.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = escolaDtg.Rows[indice];


            string update = $"update escolas set nome_fantasia = '{nomeEdit.Text}', razao_social = '{razaoEdit.Text}', cnpj = '{cnpjEdit.Text}' ," +
                 $" endereco = '{enderecoEdit.Text}', telefone = '{tellEdit.Text}' where id = {row.Cells[0].Value}";

            Funcoes.Inserir(update);

            string query = "select * from escolas order by id";

            DataTable escolass = Funcoes.Pesquisar(query);
            escolaDtg.DataSource = null;
            escolaDtg.DataSource = escolass;
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = escolaDtg.Rows[indice];

            string delete = $"delete from escolas where id = {row.Cells[0].Value}";

            Funcoes.Inserir(delete);

            string query = "select * from escolas order by id";

            DataTable escolass = Funcoes.Pesquisar(query);
            escolaDtg.DataSource = null;
            escolaDtg.DataSource = escolass;
        }

        private void cnpjEdit_TextChanged(object sender, EventArgs e)
        {
            if (cnpjEdit.MaskFull)
            {
                if (!Funcoes.isCnpj(cnpjEdit.Text))
                {
                    MessageBox.Show("Esse cnpj é invalído, preencha o campo novamente.");
                }
            }
        }
    }
}
