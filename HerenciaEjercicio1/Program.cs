using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaEjercicio1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
public class Publicacion
{
    public string Titulo { get; set; }
    public double Precio { get; set; }

    // Constructor
    public Publicacion(string titulo, double precio)
    {
        Titulo = titulo;
        Precio = precio;
    }
}
// Clase derivada Libro
public class Libro : Publicacion
{
    public int NumeroPaginas { get; set; }

    // Constructor
    public Libro(string titulo, double precio, int numeroPaginas) : base(titulo, precio)
    {
        NumeroPaginas = numeroPaginas;
    }
}
// Clase derivada CD
public class CD : Publicacion
{
    public double TiempoReproduccion { get; set; }

    // Constructor
    public CD(string titulo, double precio, double tiempoReproduccion) : base(titulo, precio)
    {
        TiempoReproduccion = tiempoReproduccion;
    }
}
