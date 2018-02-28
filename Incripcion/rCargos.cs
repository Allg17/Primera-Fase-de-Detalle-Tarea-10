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
    public partial class rCargos : Form
    {
        public rCargos()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            PersonaIdtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            IDstextBox.Clear();
            numericUpDown.Value = 0;
            BalancetextBox.Clear();
            conceptoTxtbox.Clear();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cargos cargo = LlenaClase();

            if(BLL.CargosBLL.Guardar(cargo))
            {
                MessageBox.Show("Guardado!");
            }
            else
            {
                MessageBox.Show("No se puede guardar");
            }


        }

        private Cargos LlenaClase()
        {
            Cargos cargo = new Cargos();
            int a,b = 0,s = 0;
            int.TryParse(PersonaIdtextBox.Text, out a);
            cargo.CargoID = a;
            int.TryParse(IDstextBox.Text, out s);
            cargo.EstudianteID =s;
            cargo.Monto = numericUpDown.Value;
            cargo.Balance = b + Convert.ToInt32(numericUpDown.Value);
            cargo.Concepto = conceptoTxtbox.Text;
            cargo.Fecha = FechadateTimePicker.Value;
            return cargo;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);

            if (BLL.CargosBLL.Eliminar(a))
            {
                MessageBox.Show("Eliminado!!");
            }

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if(BLL.CargosBLL.Modificar(LlenaClase()))
            {
                MessageBox.Show("Modificado");
            }
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            cCargos abrir = new cCargos();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(IDstextBox.Text, out a);
            if(BLL.EstudiantesBLL.Buscar(a)!=null)
            {
                var id = BLL.EstudiantesBLL.Buscar(a);
                NombretextBox.Text = id.Nombre;
            }
            else
            {
                MessageBox.Show("No encontrado");
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);
            if (BLL.CargosBLL.Buscar(a) != null)
            {
                var id = BLL.CargosBLL.Buscar(a);
                FechadateTimePicker.Value = id.Fecha;
                IDstextBox.Text = id.EstudianteID.ToString();
                numericUpDown.Value = id.Monto;
                BalancetextBox.Text = id.Balance.ToString();
                conceptoTxtbox.Text = id.Concepto;

            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }
    }
}
