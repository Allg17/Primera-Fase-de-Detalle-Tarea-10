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
    public partial class rPagos : Form
    {
        public rPagos()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
            EstudianteIDtextBox.Clear();
            numericUpDown.Value = 0;
            ConceptotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Pagos pago = LlenaClase();

            if(BLL.PagosBLL.Guardar(pago))
            {
                MessageBox.Show("Guardado!!");
            }
        }

        private Pagos LlenaClase()
        {
            Pagos pago = new Pagos();
            int id1,id2;
            int.TryParse(IDtextBox.Text, out id1);
            pago.PagosID = id1;
            pago.Fecha = dateTimePicker.Value;
           int.TryParse(EstudianteIDtextBox.Text, out id2);
            pago.EstudianteID = id2;
            pago.Monto = numericUpDown.Value;
            pago.Concepto = ConceptotextBox.Text;
            return pago;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            if (BLL.PagosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!");
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if(BLL.PagosBLL.Modificar(LlenaClase()))
            {
                MessageBox.Show("Modificado");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDtextBox.Text, out id);
            Pagos pago = new Pagos();
            pago = BLL.PagosBLL.Buscar(id);
            if(pago!=null)
            {
                dateTimePicker.Value = pago.Fecha;
                EstudianteIDtextBox.Text = pago.EstudianteID.ToString();
                numericUpDown.Value = pago.Monto;
                ConceptotextBox.Text = pago.Concepto;

            }
            else
            {
                MessageBox.Show("Pago no Encontrado!!");
            }

        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            cPagos abrir = new cPagos();
            abrir.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(EstudianteIDtextBox.Text, out id);

            var estudiante = BLL.EstudiantesBLL.Buscar(id);
            NombretextBox.Text =  estudiante.Nombre;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
