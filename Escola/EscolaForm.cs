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
    public partial class EscolaForm : Form
    {
       
        public EscolaForm()
        {
            InitializeComponent();
        }

        private void SalvarEsc_Click(object sender, EventArgs e)
        {
            bool val = false;


            if (nomeEsc.Text != "" && razaoSocialTxt.Text != "" && endereco.Text != "" && Funcoes.isCnpj(cnpj.Text) && telefoneEsc.MaskFull)
                val = true;

            if (val)
            {
                string insert = "insert into escolas " +
                            "(nome_fantasia, razao_social, cnpj, endereco, telefone) " +
                            $"values ('{nomeEsc.Text}', '{razaoSocialTxt.Text}'," +
                            $"'{cnpj.Text}' , '{endereco.Text}', '{telefoneEsc.Text}')";

                Funcoes.Inserir(insert);

                Funcoes.Limpar(this);
            }
            else MessageBox.Show("Preencha todos os campos corretamente para prosseguir");

        }

        private void cnpj_TextChanged(object sender, EventArgs e)
        {
            if (cnpj.MaskFull)
            {
                if (!Funcoes.isCnpj(cnpj.Text))
                {
                    MessageBox.Show("Esse cnpj é invalído, preencha o campo novamente.");
                }
            }
        }
    }
}
