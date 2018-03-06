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
    public partial class fCotizaciones : Form
    {
       
        Articulos Articulo = new Articulos();
        Cotizaciones Cotisar = new Cotizaciones();
        int ListaPasada = 0;
        List<CotizacionesDetalle> detalle = new List<CotizacionesDetalle>();
        public fCotizaciones()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizacion = LlenaClase();
            LimpiarProvider();
            int paso = 0;
            if (SetErrorProvider(4)==false)
            {
                MessageBox.Show("Llenar los campos marcados");
                return;
            }

            if (CotizaciontextBox.Text == string.Empty)
            {
                if (BLL.CotizacionesBLL.Guardar(cotizacion) && BLL.CotizacionesDetalleBLL.Guardar(Cotisar.CotizacionDetalle))
                {
                    MessageBox.Show("Guardado!!");

                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                }
            }
            else
            {
                foreach (var Detalle in Cotisar.CotizacionDetalle)
                {
                    if (BLL.CotizacionesBLL.Modificar(LlenaClase()) && BLL.CotizacionesDetalleBLL.Modificar(BLL.CotizacionesDetalleBLL.ModificarArticulos(Cotisar.CotizacionDetalle, Detalle.ID)))
                    {
                        paso = 1;
                    }
                    else
                    {
                        paso = 0;
                    }
                }
                if(paso == 1)
                {
                    MessageBox.Show("Modificado!!");
                }
                else
                {
                    MessageBox.Show("No se pudo Modificar!!");
                }


            }

        }

        private bool SetErrorProvider(int Abrir)
        {
            bool paso = false;
            if (Abrir == 1 || Abrir == 3 || Abrir == 4)
            {
                if (ArticuloIDnumericUpDown.Value == 0)
                {
                    ArticuloIdProvider.SetError(ArticuloIDnumericUpDown, "Campos Vacio");
                    paso = false;
                }
                else
                {
                    paso = true;
                }

            }
            if (Abrir == 2 || Abrir == 3 || Abrir == 4)
            {
                if (CantidadnumericUpDown.Value == 0)
                {
                    CantidadErrorProvider.SetError(CantidadnumericUpDown, "Campo vacio");
                    paso = false;
                }
                else
                {
                    paso = true;
                }
            }
            if (Abrir == 4)
            {
                if (ComentariotextBox.Text == string.Empty)
                {
                    ComentarioerrorProvider.SetError(ComentariotextBox, "Campo Vacio");
                    paso = false;
                }
                else
                {
                    paso = true;
                }
            }
            if (Abrir == 5)
            {
                if (CotizaciontextBox.Text == string.Empty)
                {
                    IDerrorProvider.SetError(CotizaciontextBox, "Campo vacio");

                }
                else
                {
                    paso = true;
                }
            }

            if (Abrir == 6)
            {
                if (DetallenumericUpDown.Value == 0)
                {
                    DetalleerrorProvider.SetError(DetallenumericUpDown, "Campo vacio");
                    paso = false;
                }
                else
                {
                    paso = true;
                }
            }



        
           
           
            return paso;
        }

        private Cotizaciones LlenaClase()
        {
            Cotizaciones cotizaciones = new Cotizaciones();
            int a;
            int.TryParse(CotizaciontextBox.Text, out a);

            cotizaciones.ID = a;
            cotizaciones.Monto = Cotisar.Monto; 
            cotizaciones.Fecha = FechadateTimePicker.Value;
            cotizaciones.Comentario = ComentariotextBox.Text;
            return cotizaciones;


        }

        private void NuevobuttonC_Click(object sender, EventArgs e)
        {
            CotizaciontextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            ComentariotextBox.Clear();
            ArticuloIDnumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;
            MontotextBox.Clear();
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            DetalledataGridView.ClearSelection();
            Cotisar.CotizacionDetalle = new List<CotizacionesDetalle>();
            DetalledataGridView.DataSource = null;
            DetallenumericUpDown.Value = 0;
            DetallenumericUpDown.Enabled = false;
            BuscarDetalllebutton.Enabled = false;
            LimpiarProvider();
            Cotisar.Monto = 0;
        }

        private void LimpiarProvider()
        {
            ArticuloIdProvider.Clear();
            CantidadErrorProvider.Clear();
            ComentarioerrorProvider.Clear();
            IDerrorProvider.Clear();
            DetalleerrorProvider.Clear();
            DetalleerrorProvider.Clear();

        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            ImportetextBox.Text  = BLL.CotizacionesBLL.calcularMonto(Convert.ToDecimal(PreciotextBox.Text), CantidadnumericUpDown.Value).ToString();
        }

        private void buscaButtonC_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CotizaciontextBox.Text, out id);
            List<CotizacionesDetalle> detalle = new List<CotizacionesDetalle>();
            LimpiarProvider();
            if(SetErrorProvider(5)==false)
            {
                MessageBox.Show("Llenar Campo Marcado");
                return;
            }
            
            if(BLL.CotizacionesBLL.Buscar(id)!=null && BLL.CotizacionesDetalleBLL.GetList(tt => tt.CotizacionesID == id) != null)
            {
               
                var cotizar = BLL.CotizacionesBLL.Buscar(id);
                FechadateTimePicker.Value = cotizar.Fecha;
                ComentariotextBox.Text = cotizar.Comentario;
                detalle = BLL.CotizacionesDetalleBLL.GetList(tt => tt.CotizacionesID == id);
                Cotisar.Monto = BLL.CotizacionesBLL.CotisarMonto(detalle);
                MontotextBox.Text = Cotisar.Monto.ToString();

                DetalledataGridView.DataSource = BLL.CotizacionesDetalleBLL.BuscarLista(id);
                BuscarDetalllebutton.Enabled = true;
                DetallenumericUpDown.Enabled = true;

            }
            else
            {
                MessageBox.Show("Cotizacion no encontrada!");
            }
          
        }

        private void EliminarbuttonC_Click(object sender, EventArgs e)
        {
            
            int ID;
            int.TryParse(CotizaciontextBox.Text, out ID);
            

            LimpiarProvider();
            if (SetErrorProvider(5) == false)
            {
                MessageBox.Show("Llenar campo Marcado");
                return;
            }

           
            if (BLL.CotizacionesDetalleBLL.EliminarArticulos(ID) && BLL.CotizacionesBLL.Eliminar(ID))
            {
                
                MessageBox.Show("Se ha Eliminado Con Exito!");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!");
            }
        }
       
        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
          
            int  articuloid, cantidad;
            decimal precio;

            //Monto
            Cotisar.Monto += Convert.ToInt32(BLL.CotizacionesBLL.calcularMonto(Articulo.Precio, CantidadnumericUpDown.Value));
            MontotextBox.Text = Cotisar.Monto.ToString();

            LimpiarProvider();
            if (SetErrorProvider(3)==false)
            {
                MessageBox.Show("Llenar Campos Vacios");
                return;
            }

            //Converciones
     
            precio = Convert.ToDecimal(PreciotextBox.Text);
            articuloid = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
           

            if(CotizaciontextBox.Text==string.Empty&& DetallenumericUpDown.Value ==0)
            {
                Cotisar.CotizacionDetalle.Add(new CotizacionesDetalle(0, articuloid, cantidad, precio, Articulo.Descripcion, Convert.ToInt32(BLL.CotizacionesBLL.calcularMonto(Articulo.Precio, CantidadnumericUpDown.Value).ToString())));

            }
            else
            {
                int id,IDdetalle;
                IDdetalle = Convert.ToInt32(DetallenumericUpDown.Value);

                id = Convert.ToInt32(DetallenumericUpDown.Value);
                Cotisar.CotizacionDetalle = BLL.CotizacionesDetalleBLL.GetList(tt => tt.ID ==id );
                BLL.CotizacionesDetalleBLL.Cambiar(Cotisar.CotizacionDetalle,Convert.ToInt32(DetallenumericUpDown.Value), cantidad);

                foreach (var detalle in Cotisar.CotizacionDetalle)
                {
                    Cotisar.CotizacionDetalle = BLL.CotizacionesDetalleBLL.ArreglarLista(IDdetalle, detalle.CotizacionesID,cantidad);
                    Cotisar.Monto = BLL.CotizacionesBLL.CotisarMonto(Cotisar.CotizacionDetalle);
                }
                MontotextBox.Text = Cotisar.Monto.ToString();
            }
            // por si se quiere agregar otro articulo 
            if(CotizaciontextBox.Text != string.Empty)
            {
                int id;
                int.TryParse(CotizaciontextBox.Text, out id);
                
                if(ListaPasada ==0)
                {
                    detalle = BLL.CotizacionesDetalleBLL.BuscarLista(id);
                    ListaPasada = 1;
                }
                
                Cotisar.CotizacionDetalle = BLL.CotizacionesDetalleBLL.AgregarArticulo(detalle, articuloid, cantidad, Convert.ToInt32(BLL.CotizacionesBLL.calcularMonto(Articulo.Precio, CantidadnumericUpDown.Value)), precio, Articulo.Descripcion);
                detalle = Cotisar.CotizacionDetalle;

            }

            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = Cotisar.CotizacionDetalle;
            
        }

        private void BuscarDetalllebutton_Click(object sender, EventArgs e)
        {
            int ID,id;
            int.TryParse(DetallenumericUpDown.Text, out ID);
            int.TryParse(CotizaciontextBox.Text, out id);
            

            LimpiarProvider();
            if (SetErrorProvider(6) == false)
            {
                MessageBox.Show("Campo Vacio");
                return;
            }

            if (BLL.CotizacionesDetalleBLL.Buscar(ID) != null)
            {

                DescripciontextBox.Text = BLL.CotizacionesDetalleBLL.BuscarDetalle(id,ID).Descripcion;
                PreciotextBox.Text = BLL.CotizacionesDetalleBLL.BuscarDetalle(id, ID).Precio.ToString();
                ArticuloIDnumericUpDown.Value = BLL.CotizacionesDetalleBLL.BuscarDetalle(id, ID).ArticuloID;
                CantidadnumericUpDown.Value = BLL.CotizacionesDetalleBLL.BuscarDetalle(id, ID).Cantidad;
                
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void BuscarArticulobutton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(ArticuloIDnumericUpDown.Text, out ID);

            LimpiarProvider();
            if (SetErrorProvider(1) == false)
            {
                MessageBox.Show("Campo Vacio");
                return;
            }

            if (BLL.ArticulosBLL.Buscar(ID) != null)
            {
                Articulo = BLL.ArticulosBLL.Buscar(ID);
                DescripciontextBox.Text = Articulo.Descripcion;
                PreciotextBox.Text = Articulo.Precio.ToString();
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Ccotizaciones abrir = new Ccotizaciones();
            abrir.Show();
        }
    }
}
