
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Escola
{
    public class Funcoes
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

        public static void Inserir(string dados)
        {
            using (MySqlConnection conexao = new MySqlConnection(Conexao.caminho))
            {
                conexao.Open();

                using (MySqlCommand comando = conexao.CreateCommand())
                {

                    string insert = dados;

                    comando.CommandText = insert;

                    comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable Pesquisar(string pesquisa)
        {
            using (MySqlConnection conexao = new MySqlConnection(Conexao.caminho))
            {
                conexao.Open();

                using (MySqlCommand comando = conexao.CreateCommand())
                {
                    Funcoes funcoes = new Funcoes();

                    string insert = pesquisa;

                    comando.CommandText = insert;

                    DataTable dt = new DataTable();

                    using (MySqlDataAdapter garcom = new MySqlDataAdapter(comando))
                    {
                        garcom.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static List<string> prencheer(DataTable consulta)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < consulta.Rows.Count; i++)
            {
                lista.Add(consulta.Rows[i][0].ToString());
            }

            return lista;
        }
        public static void Limpar(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = ""; //	((TextBox)c).Clear();
                else if (c is RichTextBox)
                    ((RichTextBox)c).Text = "";
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
                //((Label)c).Text = "";

                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else if (c is TrackBar)
                    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                // else if (c is RichTextBoxExtended)
                // ((RichTextBoxExtended)c).ResetText();
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    Limpar(c);

                }
            }
        }
    }

}
