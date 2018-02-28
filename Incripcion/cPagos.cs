using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Incripcion
{
    public partial class cPagos : Form
    {
        public cPagos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            string todo;
            todo = CriteriotextBox.Text;
            int.TryParse(CriteriotextBox.Text, out id);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                PersonasdataGridView.DataSource = BLL.PagosBLL.GetList(t => t.Concepto.Contains(todo));
            }
            else
            {
                PersonasdataGridView.DataSource = BLL.PagosBLL.GetList(t => t.PagosID == id);
            }
        }
    }
}
