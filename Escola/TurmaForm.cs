using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Escola
{
    public partial class TurmaForm : Form
    {

        string idEscola;

        public TurmaForm()
        {
            InitializeComponent();
        }

        private void TurmaForm_Load(object sender, EventArgs e)
        {
            string insert = "select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(insert);

            escolaTm.Items.AddRange(Funcoes.prencheer(dt).ToArray());

        }

        private void SalvarTm_Click(object sender, EventArgs e)
        {

            bool validacao = false;

            if(nomeTm.Text != "" && escolaTm.SelectedIndex != -1 && serieTm.SelectedIndex != -1 && anoTm.MaskFull)
                validacao = true;

            if (validacao)
            {
                string insert = "insert into turmas (escola_id ,nome, escola, ano_letivo, serie) " +
                    $"values ({idEscola}, '{nomeTm.Text}', '{escolaTm.SelectedItem}', {anoTm.Text}, '{serieTm.SelectedItem}')";

                Funcoes.Inserir(insert);

                Funcoes.Limpar(this);
            }
            else MessageBox.Show("Preencha todos os campos para prosseguir");
        }

        private void escolaTm_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (escolaTm.SelectedItem != null)
            {
                string insert = $"Select id, nome_fantasia from escolas where nome_fantasia = '{escolaTm.SelectedItem}'";

                var dt = Funcoes.Pesquisar(insert);

                idEscola = dt.Rows[0]["id"].ToString();
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(anoTm.MaskFull)
            {
                if (int.Parse(anoTm.Text) > 2025 || int.Parse(anoTm.Text) < 0) MessageBox.Show("Ano invalido! Preencha este campo novamente.");
            }
        }
    }
}
