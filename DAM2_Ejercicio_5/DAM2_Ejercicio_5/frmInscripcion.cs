using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Ejercicio_5
{
    //Formulario de inscripción. Sus boton Volver tiene asignada la propiedad de DialogResult.OK, al pulsarlo se vuelve al form padre
    //Recoge los datos de un alumno, y si se pulsa Grabar se graban en el fichero cuyo nombre aparece en labFichero.Text
    public partial class frmInscripcion : Form
    {
        //Atributos
        private string fichero;//Nombre del fichero que aparece en la etiqueta labFichero
        private ErrorProvider erpAvisoError = new ErrorProvider();//Instanciar un errorProvider

        //El constructor recibe el nombre del fichero con el que se trabajará
        public frmInscripcion(string fichero)
        {
            InitializeComponent();

            this.fichero = fichero;
        }

        //Evento asociado a la carga del formulario
        //Todos los métodos invocados asignan propiedades se podrían asignar en el diseñador gráfico
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            //Asigna la propiedad DialogResult.OK al botón Volver
            btnVolver.DialogResult = DialogResult.OK;

            //invocar al método que coloca el nombre del fichero (se podría hacer en el diseñador gráfico)
            colocaNombreFichero();

            //invocar al método que asigna las longitudes máximas (se podría hacer en el diseñador gráfico)
            asignaMaxLongitud();

            //invocar al método que asigna los tags
            asignaTag();


        }

        //Colocar el nombre del fichero en labFichero
        //Si el string es muy largo, poner un substring que parte del antepenúltimo separador \
        private void colocaNombreFichero()
        {
            
            if (fichero.Length < 90) labFichero.Text = fichero;
            else
            {
                int posicionSeparador = devuelveSeparador(fichero);
                labFichero.Text = fichero.Substring(posicionSeparador, fichero.Length - posicionSeparador);
            }
        }

        //Método que asigna los máximos de caracteres que acepta cada textbox
        private void asignaMaxLongitud()
        {
            
            tbxMatricula.MaxLength = 3;
            tbxCodigo.MaxLength = 4;
            tbxApellidos.MaxLength = 50;
            tbxNombre.MaxLength = 30;
            tbxDireccion.MaxLength = 50;
            tbxPoblacion.MaxLength = 30;
            tbxCP.MaxLength = 5;
            tbxProvincia.MaxLength = 20;
            tbxTelefono.MaxLength = 9;
        }

        //Método que asigna los tags de cada textbox numérico, represntan
        //los mínimos valores que aceptan
        private void asignaTag()
        {
            tbxMatricula.Tag = 1;
            tbxCP.Tag = 10000;
            tbxTelefono.Tag = 100000000;
        }

        //Método que devuelve la posición del antepenúltimo caracter '\' de separación
        private int devuelveSeparador(string cadena)
        {
            int contador = 0;
            for (int i = cadena.Length - 1; i >= 0; i--)
            {

                if (cadena[i].Equals('\\')) contador++;
                if (contador == 3)
                {
                    return i;//Retorna la posición del antepenúltimo \
                }

            }
            return 0;//Nunca llegará aquí si el método recibe una ruta con \
        }

        //No debe tener valores no numéricos
        //Utilizado por tbxMatrícula, tbxCP, tbxTeléfono
        private void tbxNumerico_Validating(object sender, CancelEventArgs e)
        {
            //Capturar el sender poruque es compartido por varios textbox
            TextBox tbxSender = (TextBox)sender;
            int valorMinimo = (int)tbxSender.Tag;//obtener el mínimo valor que acepta el control del tag

            if (!tbxSender.Text.Equals(string.Empty))
            {
                try
                {

                    int entero = Convert.ToInt32(tbxSender.Text);
                    if (entero < valorMinimo) throw new Exception("No se admiten valores menores que "+valorMinimo.ToString());
                    erpAvisoError.Clear();//Eliminar el icono si todo ha ido bien y ha llegado hasta aquí
                    //Para tratamiento individual donde no hubiera e.Cancel=true sería:
                    //erpAvisoError.SetError(tbxSender, ""); Porque Clear borraría todos los errores

                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    erpAvisoError.SetError(tbxSender, "Debe introducir valores enteros");
                }

                catch (Exception error)
                {
                    e.Cancel = true;
                    erpAvisoError.SetError(tbxSender, error.Message);
                }
            }

            else erpAvisoError.Clear();//Sale del textbox estando vacío, así que se elimina el aviso de error

        }

        #region metodo detecta alfanumerico o no

        /*   //Método que devuelve true si la cadena recibida contiene valores no alfanuméricos
        private bool controlAlfanumerico(string cadena)
        {
            cadena=cadena.ToUpper();//Pasar todo a mayúsculas si es que no estaba ya

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] >90) return true;//La cadena no válida (90 es Z ascii)
                else
                {
                    if (cadena[i]<65) //(65 es A ascii)
                    {
                        if (cadena[i] > 57) return true; //cadena no válida (57 es 9 ascii)
                        else
                        {
                            if (cadena[i]<48) //48 es 1 ascii
                            {
                                if (cadena[i] != 32) return true;//Cadena no válida (32 es espacio ascii)
                            }
                        }
                    }
                }
               
            }

            return false; //La cadena es válida
        }*/

        #endregion 

        //Método que verifica si el contenido del texbox es alfanumérico
        private bool alfanumericoControl(string cadena)
        {
            cadena = cadena.ToUpper();//Pasar todo a mayúsculas para reducir el número de valores a controlar

            for (int i = 0; i < cadena.Length; i++)
            {
                if (!detectaValido(cadena[i]))return false;
            }

            return true; //Si llega hasta aquí es que la cadena es válida
        }

        //Método que detecta valores válidos
        private bool detectaValido(char caracter)
        {
            string validos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÑÁÉÍÓÚ0123456789 ";//Incluye un espacio vacío como válido
            for (int i = 0; i < validos.Length; i++)
            {
                if (caracter.Equals(validos[i])) return true;//El caracter es válido
            }

            return false;//El caracter no es válido si llega hasta aquí
        }

        private void tbxAlfanumerico_Validating(object sender, CancelEventArgs e)
        {
            //Capturar el sender
            TextBox tbxSender = (TextBox)sender;

            if(!tbxSender.Text.Equals(string.Empty))//Si el contenido no está vacio...
            {
                if (!alfanumericoControl(tbxSender.Text))//Si el método que controla la validez retorna false
                {
                    e.Cancel = true;
                    erpAvisoError.SetError(tbxSender, "Solo se aceptan caracteres alfanuméricos");
                }
                else erpAvisoError.Clear();//Quita error porque el contenido es válido
            }
            else erpAvisoError.Clear();//:Quita error porque el textobox está vacío

        }


    }
}
