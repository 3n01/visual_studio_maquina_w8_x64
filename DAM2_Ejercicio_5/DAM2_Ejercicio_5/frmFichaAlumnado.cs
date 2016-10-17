using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DAM2_Ejercicio_5
{
    //Formulario principal que muestra el nombre del fichero que se va a utilizar
    //Se puede modificar el nombre, borrar el fichero, inscribir alumnos y consultar datos

    //Autor:Enol Cachero
    //16_10_2016
    //V 1
    //*****************************************************************************************
    public partial class frmFichaAlumnado : Form
    {

        //Atributos
        private string directorio; //Carpeta del fichero

        public frmFichaAlumnado()
        {
            InitializeComponent();
        }

        //Evento asociado a la carga del formulario
        private void frmFichaAlumnado_Load(object sender, EventArgs e)
        {
            //Por defecto sitúa los valores del numeridUpdown
            nudAnio.Maximum = 2030;
            nudAnio.Minimum = 2010;
            nudAnio.Value = anioSistema();

            //Directorio por defecto el del sistema
            directorio = Environment.CurrentDirectory.ToString();

            //Sitúa el nombre del fichero, enviando el nombre del directorio de la aplicación
            tbxArchivoAlumnado.Text = formaNombre();

            //tbxFichaAlumando es readonly, no se puede editar
            //También es público, para que se pueda acceder a su contenido desde formularios hijos
            tbxArchivoAlumnado.ReadOnly = true;
            


        }

        //Método que obtiene el año del sistema
        private int anioSistema()
        {
            string fecha = System.DateTime.Now.Year.ToString();
            return Convert.ToInt32(fecha);
        }

        //Método que forma el nombre, recibe como parámetro la carpeta en forma de string
        private string formaNombre()
        {
            string nombreFichero = directorio + "\\alm" + nudAnio.Value.ToString() + ".dat";

            return nombreFichero;
        }

        //Salir de la aplicación
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        //Abre un FolderBrowserDialog para que el usuario elija la carpeta
        private void btnElegirCarpeta_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            FolderBrowserDialog fbs = new FolderBrowserDialog();
            if (fbs.ShowDialog() == DialogResult.OK)
            {
                directorio = fbs.SelectedPath;//guarda el directorio elegido
                tbxArchivoAlumnado.Text = formaNombre();//actualiza el nombre con el nuevo directorio
            }
        }

        //Borra el fichero con nombre igual al contenido del textobox con el nombre
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("¿Está seguro de que desea borrar el fichero?", "Aviso de la aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
                if (File.Exists(tbxArchivoAlumnado.Text)) File.Delete(tbxArchivoAlumnado.Text);
                else MessageBox.Show("El fichero no existe");
            }
        }

        //Lanza el formulario de inscripción
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion objInscripcion = new frmInscripcion(tbxArchivoAlumnado.Text);
            objInscripcion.ShowDialog();
        }

        //Actualiza el nombre en el TextBox cada vez que se cambia el año
        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            tbxArchivoAlumnado.Text = formaNombre();
        }
    }
}
