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
    public partial class AlunoForm : Form
    {
        string sexo = "";
        string idTurma;

        public AlunoForm()
        {
            InitializeComponent();
        }

        private void aluno_Load(object sender, EventArgs e)
        {
            string insert = "select nome_fantasia from escolas";

            var dt = Funcoes.Pesquisar(insert);



            escolaCmb.Items.AddRange(Funcoes.prencheer(dt).ToArray());

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SalvarAl_Click(object sender, EventArgs e)
        {
            bool validacao = false;
          

            if (nomeAl.Text != "" && resp.Text != "" && respTell.MaskFull && dataAl.MaskFull && escolaCmb.SelectedIndex != -1 &&
                turmaAl.SelectedIndex != -1 && sexo != "") validacao = true;

            else validacao = false;

            if (validacao == true)
            {
                string insert = $"insert into alunos (turma_id,nome, data_nascimento, nome_resp, telefone_resp, sexo)" +
                    $" values ({idTurma},'{nomeAl.Text}', '{dataAl.Text}', '{resp.Text}', '{respTell.Text}', '{sexo}')";

                Funcoes.Inserir(insert);

                Funcoes.Limpar(this);
               
            }
            else  MessageBox.Show("Preencha todos os campos para prosseguir");


        }

        private void mascu_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "masculino";

        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "feminino";
        }

        private void turmaAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turmaAl.SelectedItem != null)
            {
                string insert = $"select id, nome from turmas where nome = '{turmaAl.SelectedItem}'";

                var dt = Funcoes.Pesquisar(insert);

                idTurma = dt.Rows[0]["id"].ToString();
            }
        }

        private void escolaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (escolaCmb.SelectedItem != null)
            {
                turmaAl.Items.Clear();

                string query = $"select id, nome_fantasia from escolas where nome_fantasia = '{escolaCmb.SelectedItem}'";

                var dt = Funcoes.Pesquisar(query);

                string id = dt.Rows[0]["Id"].ToString();

                query = $"select nome, escola_id from turmas where escola_id = {id}";

                dt = Funcoes.Pesquisar(query);

                turmaAl.Items.AddRange(Funcoes.prencheer(dt).ToArray());
            }
        }

       

        private void dataAl_TextChanged(object sender, EventArgs e)
        {
            if(dataAl.MaskFull)
            {
                try 
                {
                    Convert.ToDateTime(dataAl.Text);
                }
                catch 
                {
                    MessageBox.Show("Data inválida! Preencha novamente");
                    dataAl.Text = "";
                }
            }
        }
    }
}
