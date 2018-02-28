using Incripcion.DAL;
using Incripcion.Entidades;
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
    public partial class fArticulo : Form
    {
        public fArticulo()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetProvider(1))
            {
                return;
            }
            Articulos articulo =  LlenaClase();
            if(IDtextBox.Text == string.Empty)
            {
                if (BLL.ArticulosBLL.Guardar(articulo))
                {
                    MessageBox.Show("Guardado!!");
                }
            }
            else
            {
                LimpiarProvider();
                if (SetProvider(2))
                {
                    return;
                }
                if (BLL.ArticulosBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                }
            }
            
        }

        private bool SetProvider(int id)
        {
            bool paso = false;
            if(id==1)
            {
                if (numericUpDown.Value == 0 || DescripcionrichTextBox.Text == string.Empty)
                {
                    PrecioerrorProvider.SetError(numericUpDown, "Campo debe de estar lleno");
                    DescripcionerrorProvider.SetError(DescripcionrichTextBox, "Debe de estar lleno");
                    paso = true;
                }

            }
            if(id==2)
            {
                if(IDtextBox.Text==string.Empty)
                {
                    IDerrorProvider.SetError(IDtextBox, "Debe llenar este campo");
                    paso = true;
                }
                
            }
            return paso;
        }
        private void LimpiarProvider()
        {
            DescripcionerrorProvider.Clear();
            PrecioerrorProvider.Clear();
            IDerrorProvider.Clear();
        }
        private Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();
            int id;
            int.TryParse(IDtextBox.Text, out id);

            articulo.ArticuloID = id;
            articulo.Descripcion = DescripcionrichTextBox.Text;
            articulo.Precio = numericUpDown.Value;
            return articulo;


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            DescripcionrichTextBox.Clear();
            numericUpDown.Value = 0;
            IDtextBox.Clear();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            LimpiarProvider();
            if (SetProvider(2))
            {
                return;
            }
            if(BLL.ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!");
            }
        }

     
        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            LimpiarProvider();
            if (SetProvider(2))
            {
                return;
            }

            if (BLL.ArticulosBLL.Buscar(id)==null)
            {
                MessageBox.Show("Articulo no encontrado!");
            }
            else    
            {
                var articulo = BLL.ArticulosBLL.Buscar(id);
                DescripcionrichTextBox.Text = articulo.Descripcion;
                numericUpDown.Value = articulo.Precio;
            }
        }
    }
}
