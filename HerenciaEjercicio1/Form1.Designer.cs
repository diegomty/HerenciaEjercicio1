namespace HerenciaEjercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SeleccionLibroImpreso = new System.Windows.Forms.CheckBox();
            this.SeleccionAudioLibro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.txtTiempoReproduccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearLibro = new System.Windows.Forms.Button();
            this.btnCrearCd = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Captura datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar Datos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SeleccionLibroImpreso
            // 
            this.SeleccionLibroImpreso.AutoSize = true;
            this.SeleccionLibroImpreso.Location = new System.Drawing.Point(54, 53);
            this.SeleccionLibroImpreso.Name = "SeleccionLibroImpreso";
            this.SeleccionLibroImpreso.Size = new System.Drawing.Size(111, 20);
            this.SeleccionLibroImpreso.TabIndex = 3;
            this.SeleccionLibroImpreso.Text = "Libro Impreso";
            this.SeleccionLibroImpreso.UseVisualStyleBackColor = true;
            this.SeleccionLibroImpreso.CheckedChanged += new System.EventHandler(this.SelecciónLibroImpreso);
            // 
            // SeleccionAudioLibro
            // 
            this.SeleccionAudioLibro.AutoSize = true;
            this.SeleccionAudioLibro.Location = new System.Drawing.Point(54, 101);
            this.SeleccionAudioLibro.Name = "SeleccionAudioLibro";
            this.SeleccionAudioLibro.Size = new System.Drawing.Size(97, 20);
            this.SeleccionAudioLibro.TabIndex = 4;
            this.SeleccionAudioLibro.Text = "Audio Libro";
            this.SeleccionAudioLibro.UseVisualStyleBackColor = true;
            this.SeleccionAudioLibro.CheckedChanged += new System.EventHandler(this.SelecciónAudioLibro);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Publicacion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(103, 220);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 22);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 254);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(133, 284);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroPaginas.TabIndex = 8;
            // 
            // txtTiempoReproduccion
            // 
            this.txtTiempoReproduccion.Location = new System.Drawing.Point(133, 319);
            this.txtTiempoReproduccion.Name = "txtTiempoReproduccion";
            this.txtTiempoReproduccion.Size = new System.Drawing.Size(100, 22);
            this.txtTiempoReproduccion.TabIndex = 9;
            this.txtTiempoReproduccion.TextChanged += new System.EventHandler(this.txtTiempoReproduccion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num. Paginas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiempo Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cuadros de Dialogo";
            // 
            // btnCrearLibro
            // 
            this.btnCrearLibro.Location = new System.Drawing.Point(441, 24);
            this.btnCrearLibro.Name = "btnCrearLibro";
            this.btnCrearLibro.Size = new System.Drawing.Size(149, 23);
            this.btnCrearLibro.TabIndex = 16;
            this.btnCrearLibro.Text = "Crear Libro";
            this.btnCrearLibro.UseVisualStyleBackColor = true;
            this.btnCrearLibro.Click += new System.EventHandler(this.btnCrearLibro_Click);
            // 
            // btnCrearCd
            // 
            this.btnCrearCd.Location = new System.Drawing.Point(442, 73);
            this.btnCrearCd.Name = "btnCrearCd";
            this.btnCrearCd.Size = new System.Drawing.Size(149, 23);
            this.btnCrearCd.TabIndex = 17;
            this.btnCrearCd.Text = "Crear CDs";
            this.btnCrearCd.UseVisualStyleBackColor = true;
            this.btnCrearCd.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(399, 126);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(374, 260);
            this.listBox.TabIndex = 18;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.Location = new System.Drawing.Point(16, 359);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(157, 36);
            this.btnConsultarVentas.TabIndex = 19;
            this.btnConsultarVentas.Text = "Consultar Ventas";
            this.btnConsultarVentas.UseVisualStyleBackColor = true;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarVentas);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnCrearCd);
            this.Controls.Add(this.btnCrearLibro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTiempoReproduccion);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeleccionAudioLibro);
            this.Controls.Add(this.SeleccionLibroImpreso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox SeleccionLibroImpreso;
        private System.Windows.Forms.CheckBox SeleccionAudioLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.TextBox txtTiempoReproduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrearLibro;
        private System.Windows.Forms.Button btnCrearCd;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnConsultarVentas;
    }
}

