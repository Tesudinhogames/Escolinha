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
    public partial class MateriaEdit : Form
    {
        static string query = "select * from materias";
        DataTable materias = Funcoes.Pesquisar(query);


        public MateriaEdit()
        {
            InitializeComponent();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
