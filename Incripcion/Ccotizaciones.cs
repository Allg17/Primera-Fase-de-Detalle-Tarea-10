using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Incripcion
{
    public partial class Ccotizaciones : Form
    {
        public Ccotizaciones()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
           

            Expression<Func<Cotizaciones, bool  >> filtrar = x => true; 

            switch(FiltrarcomboBox.SelectedIndex)
            {
                case 0:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.ID == id;
                    break;
                case 1:
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar =  t => t.Monto == id;
                    break;
                    
            }


            CotizacionesdataGridView.DataSource = BLL.CotizacionesBLL.GetList(filtrar);
        }
    }
}
