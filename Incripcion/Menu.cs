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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPagos abrir = new rPagos();
            abrir.Show();
        }

        private void registrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restudiantes abrir = new Restudiantes();
            abrir.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargos cargo = new rCargos();
            cargo.Show();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fArticulo abrir = new fArticulo();
            abrir.Show();
        }

        private void cotizacionDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCotizaciones abrir = new fCotizaciones();
            abrir.Show();
        }

        
    }
}
