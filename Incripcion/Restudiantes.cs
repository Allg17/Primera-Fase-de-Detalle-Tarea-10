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
    public partial class Restudiantes : Form
    {
        public Restudiantes()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            PersonaIdtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Clear();
            txObservacion.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = LlenaClase();
            if(BLL.EstudiantesBLL.Guardar(estudiante))
            {
                MessageBox.Show("Guardado!!");
            }
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);
            estudiante.EstudianteId = a;
            estudiante.Nombre = NombrestextBox.Text;
            estudiante.Observaciones = txObservacion.Text;
            estudiante.FechaActual = FechadateTimePicker.Value;
            return estudiante;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(PersonaIdtextBox.Text, out id);
            if(BLL.EstudiantesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!");
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if(BLL.EstudiantesBLL.Modificar(LlenaClase()))
            {
                MessageBox.Show("Modificado!!");
            }
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            cEstudiantes abrir = new cEstudiantes();
            abrir.Show();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(PersonaIdtextBox.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                NombrestextBox.Text = estudiante.Nombre;
                txObservacion.Text = estudiante.Observaciones;
                FechadateTimePicker.Value = estudiante.FechaActual;

            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }

        }
    }
}
