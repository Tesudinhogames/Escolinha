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
        public static bool isCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

            if (cnpj.Length != 14 || cnpj == "00000000000000")
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public EscolaForm()
        {
            InitializeComponent();
        }

        private void SalvarEsc_Click(object sender, EventArgs e)
        {
            bool val = false;


            if (nomeEsc.Text != "" && razaoSocialTxt.Text != "" && endereco.Text != "" && isCnpj(cnpj.Text) && telefoneEsc.MaskFull)
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
                if (!isCnpj(cnpj.Text))
                {
                    MessageBox.Show("Esse cnpj é invalído, preencha o campo novamente.");
                }
            }
        }
    }
}
