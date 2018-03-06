namespace Incripcion
{
    partial class Ccotizaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CotizacionesdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Modo a buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = " Filtro";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(149, 38);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(192, 20);
            this.CriteriotextBox.TabIndex = 44;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Monto"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(54, 38);
            this.FiltrarcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(73, 21);
            this.FiltrarcomboBox.TabIndex = 43;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(398, 25);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(78, 45);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CotizacionesdataGridView
            // 
            this.CotizacionesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CotizacionesdataGridView.Location = new System.Drawing.Point(11, 89);
            this.CotizacionesdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.CotizacionesdataGridView.Name = "CotizacionesdataGridView";
            this.CotizacionesdataGridView.RowTemplate.Height = 24;
            this.CotizacionesdataGridView.Size = new System.Drawing.Size(772, 328);
            this.CotizacionesdataGridView.TabIndex = 41;
            // 
            // Ccotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CotizacionesdataGridView);
            this.Name = "Ccotizaciones";
            this.Text = "Ccotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView CotizacionesdataGridView;
    }
}