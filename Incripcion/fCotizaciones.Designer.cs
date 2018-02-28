namespace Incripcion
{
    partial class fCotizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CotizaciontextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComentariotextBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.ArticuloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotizacionedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ArticuloIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EliminarbuttonC = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NuevobuttonC = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.buscaButtonC = new System.Windows.Forms.Button();
            this.ArticuloIdProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidadErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComentarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Importe = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.DetallenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarDetalllebutton = new System.Windows.Forms.Button();
            this.DetalleerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarArticulobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComentarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentario";
            // 
            // CotizaciontextBox
            // 
            this.CotizaciontextBox.Location = new System.Drawing.Point(68, 30);
            this.CotizaciontextBox.Name = "CotizaciontextBox";
            this.CotizaciontextBox.Size = new System.Drawing.Size(79, 20);
            this.CotizaciontextBox.TabIndex = 4;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(68, 61);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // ComentariotextBox
            // 
            this.ComentariotextBox.Location = new System.Drawing.Point(68, 96);
            this.ComentariotextBox.Multiline = true;
            this.ComentariotextBox.Name = "ComentariotextBox";
            this.ComentariotextBox.Size = new System.Drawing.Size(290, 104);
            this.ComentariotextBox.TabIndex = 7;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloID,
            this.CotizacionedID,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importes});
            this.DetalledataGridView.Location = new System.Drawing.Point(19, 333);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DetalledataGridView.Size = new System.Drawing.Size(518, 206);
            this.DetalledataGridView.TabIndex = 8;
            // 
            // ArticuloID
            // 
            this.ArticuloID.DataPropertyName = "ArticuloID";
            this.ArticuloID.HeaderText = "Articulo ID";
            this.ArticuloID.Name = "ArticuloID";
            // 
            // CotizacionedID
            // 
            this.CotizacionedID.DataPropertyName = "CotizacionesID";
            this.CotizacionedID.HeaderText = "Cotizacioned ID";
            this.CotizacionedID.Name = "CotizacionedID";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Importes
            // 
            this.Importes.DataPropertyName = "Importe";
            this.Importes.HeaderText = "Importe";
            this.Importes.Name = "Importes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ArticuloID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(68, 307);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.CantidadnumericUpDown.TabIndex = 18;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // ArticuloIDnumericUpDown
            // 
            this.ArticuloIDnumericUpDown.Location = new System.Drawing.Point(68, 274);
            this.ArticuloIDnumericUpDown.Name = "ArticuloIDnumericUpDown";
            this.ArticuloIDnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.ArticuloIDnumericUpDown.TabIndex = 19;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(206, 269);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.ReadOnly = true;
            this.DescripciontextBox.Size = new System.Drawing.Size(212, 20);
            this.DescripciontextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(430, 269);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 24;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(430, 545);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(100, 20);
            this.MontotextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Monto";
            // 
            // EliminarbuttonC
            // 
            this.EliminarbuttonC.Location = new System.Drawing.Point(311, 583);
            this.EliminarbuttonC.Name = "EliminarbuttonC";
            this.EliminarbuttonC.Size = new System.Drawing.Size(116, 33);
            this.EliminarbuttonC.TabIndex = 31;
            this.EliminarbuttonC.Text = "Eliminar";
            this.EliminarbuttonC.UseVisualStyleBackColor = true;
            this.EliminarbuttonC.Click += new System.EventHandler(this.EliminarbuttonC_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(189, 583);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(116, 33);
            this.Guardarbutton.TabIndex = 29;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NuevobuttonC
            // 
            this.NuevobuttonC.Location = new System.Drawing.Point(68, 584);
            this.NuevobuttonC.Name = "NuevobuttonC";
            this.NuevobuttonC.Size = new System.Drawing.Size(116, 33);
            this.NuevobuttonC.TabIndex = 28;
            this.NuevobuttonC.Text = "Nuevo";
            this.NuevobuttonC.UseVisualStyleBackColor = true;
            this.NuevobuttonC.Click += new System.EventHandler(this.NuevobuttonC_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(125, 302);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(53, 23);
            this.Agregarbutton.TabIndex = 32;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click_1);
            // 
            // buscaButtonC
            // 
            this.buscaButtonC.Location = new System.Drawing.Point(153, 28);
            this.buscaButtonC.Name = "buscaButtonC";
            this.buscaButtonC.Size = new System.Drawing.Size(75, 23);
            this.buscaButtonC.TabIndex = 33;
            this.buscaButtonC.Text = "Buscar";
            this.buscaButtonC.UseVisualStyleBackColor = true;
            this.buscaButtonC.Click += new System.EventHandler(this.buscaButtonC_Click);
            // 
            // ArticuloIdProvider
            // 
            this.ArticuloIdProvider.ContainerControl = this;
            // 
            // CantidadErrorProvider
            // 
            this.CantidadErrorProvider.ContainerControl = this;
            // 
            // ComentarioerrorProvider
            // 
            this.ComentarioerrorProvider.ContainerControl = this;
            // 
            // IDerrorProvider
            // 
            this.IDerrorProvider.ContainerControl = this;
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(381, 305);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 34;
            this.Importe.Text = "Importe";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(430, 302);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 35;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(187, 308);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 13);
            this.id.TabIndex = 36;
            this.id.Text = "ID Detalle";
            // 
            // DetallenumericUpDown
            // 
            this.DetallenumericUpDown.Enabled = false;
            this.DetallenumericUpDown.Location = new System.Drawing.Point(250, 302);
            this.DetallenumericUpDown.Name = "DetallenumericUpDown";
            this.DetallenumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.DetallenumericUpDown.TabIndex = 37;
            // 
            // BuscarDetalllebutton
            // 
            this.BuscarDetalllebutton.Enabled = false;
            this.BuscarDetalllebutton.Location = new System.Drawing.Point(323, 299);
            this.BuscarDetalllebutton.Name = "BuscarDetalllebutton";
            this.BuscarDetalllebutton.Size = new System.Drawing.Size(52, 23);
            this.BuscarDetalllebutton.TabIndex = 38;
            this.BuscarDetalllebutton.Text = "Detalle";
            this.BuscarDetalllebutton.UseVisualStyleBackColor = true;
            this.BuscarDetalllebutton.Click += new System.EventHandler(this.BuscarDetalllebutton_Click);
            // 
            // DetalleerrorProvider
            // 
            this.DetalleerrorProvider.ContainerControl = this;
            // 
            // BuscarArticulobutton
            // 
            this.BuscarArticulobutton.Location = new System.Drawing.Point(125, 274);
            this.BuscarArticulobutton.Name = "BuscarArticulobutton";
            this.BuscarArticulobutton.Size = new System.Drawing.Size(53, 23);
            this.BuscarArticulobutton.TabIndex = 39;
            this.BuscarArticulobutton.Text = "Buscar";
            this.BuscarArticulobutton.UseVisualStyleBackColor = true;
            this.BuscarArticulobutton.Click += new System.EventHandler(this.BuscarArticulobutton_Click);
            // 
            // fCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 629);
            this.Controls.Add(this.BuscarArticulobutton);
            this.Controls.Add(this.BuscarDetalllebutton);
            this.Controls.Add(this.DetallenumericUpDown);
            this.Controls.Add(this.id);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.buscaButtonC);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.EliminarbuttonC);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NuevobuttonC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ArticuloIDnumericUpDown);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.ComentariotextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.CotizaciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fCotizaciones";
            this.Text = "fCotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComentarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CotizaciontextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox ComentariotextBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.NumericUpDown ArticuloIDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EliminarbuttonC;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NuevobuttonC;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button buscaButtonC;
        private System.Windows.Forms.ErrorProvider ArticuloIdProvider;
        private System.Windows.Forms.ErrorProvider CantidadErrorProvider;
        private System.Windows.Forms.ErrorProvider ComentarioerrorProvider;
        private System.Windows.Forms.ErrorProvider IDerrorProvider;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotizacionedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importes;
        private System.Windows.Forms.NumericUpDown DetallenumericUpDown;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button BuscarDetalllebutton;
        private System.Windows.Forms.ErrorProvider DetalleerrorProvider;
        private System.Windows.Forms.Button BuscarArticulobutton;
    }
}