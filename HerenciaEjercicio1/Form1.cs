using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerenciaEjercicio1;

namespace HerenciaEjercicio1
{

    public partial class Form1 : Form
    {
      
        private List<Publicación> publicaciones;

        public Form1()
        {
            InitializeComponent();
            publicaciones = new List<Publicación>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            //Obtener los datos ingresados por el usuario
            string titulo = txtTitulo.Text;
            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor, ingresa un precio válido.");
                return; // Detener la ejecución del método si la entrada no es válida.
            }

            int numeroPaginas;
            if (!int.TryParse(txtNumeroPaginas.Text, out numeroPaginas))
            {
                MessageBox.Show("Por favor, ingresa un número válido para las páginas.");
                return; // Detener la ejecución del método si la entrada no es válida.
            }

            //Crear instancia de libro
            Libro libro = new Libro(titulo,precio,numeroPaginas);
            publicaciones.Add(libro);

            //Hacer algo con el objeto libro, por ejemplo mostrarlo en un list box
            listBox.Items.Add($"Libro - Título: {libro.Titulo}, Precio: {libro.Precio}, Páginas: {libro.NumeroPaginas}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            string titulo = txtTitulo.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            double tiempoReproduccion = Convert.ToDouble(txtTiempoReproduccion.Text);

            // Crear instancia de CD
            CD cd = new CD(titulo, precio, tiempoReproduccion);
            publicaciones.Add(cd);

            // Hacer algo con el objeto cd, por ejemplo, mostrarlo en un ListBox
            listBox.Items.Add($"CD - Título: {cd.Titulo}, Precio: {cd.Precio}, Tiempo de Reproducción: {cd.TiempoReproduccion}");
        }

        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelecciónLibroImpreso(object sender, EventArgs e)
        {
            if (SeleccionLibroImpreso.Checked)
            {
                //Si el usuario selecciona "Libro Impres", activa el TexBox
                //para seleccionar un libro
                txtNumeroPaginas.Enabled = true;
                txtTiempoReproduccion.Enabled = false;

            }
            else 
            {
                txtNumeroPaginas.Enabled=false;
                txtTiempoReproduccion.Enabled=true;
            }
        }

        private void SelecciónAudioLibro(object sender, EventArgs e)
        {
            if (SeleccionAudioLibro.Checked)
            {
                txtNumeroPaginas.Enabled = false;
                txtTiempoReproduccion.Enabled = true;
            }
            else
            {
                txtNumeroPaginas.Enabled = true;
                txtTiempoReproduccion.Enabled = false;  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempoReproduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ///////////////////////////////////
        /// </summary>

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            //Limpiar el ListoBox Antes de mostrar nuevas ventas
            listBox.Items.Clear();
            double ventasLibrosImpresos = 0;
            double ventasAudioLibros = 0;

            //Recorrer la lista de publicaciones y sumar las ventas totales
            foreach (Publicación publicacion in publicaciones)
            {
                ventasLibrosImpresos += publicacion.VentasLibrosImpresos;
                ventasAudioLibros += publicacion.VentasAudioLibros;
            }
            // Mostrar las ventas totales en el ListBox
            listBox.Items.Add($"Ventas de Libros Impresos: {ventasLibrosImpresos}");
            listBox.Items.Add($"Ventas de Audio-libros: {ventasAudioLibros}");
        }
    }

    public class Publicación
    {
        public string Titulo { get; set; }
        public double Precio { get; set; }
        public double VentasLibrosImpresos { get; set; }
        public double VentasAudioLibros { get; set; }

        public Publicación(string titulo, double precio)
        {
            Titulo = titulo;
            Precio = precio;
            VentasLibrosImpresos = 0;
            VentasAudioLibros = 0;
        }

        
    }

}

    

