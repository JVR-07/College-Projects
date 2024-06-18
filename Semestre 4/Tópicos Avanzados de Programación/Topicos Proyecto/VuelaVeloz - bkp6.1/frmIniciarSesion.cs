using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VuelaVeloz
{
    public partial class frmIniciarSesion : Form
    {
        #region Campos

        private string comandoConexion; //Variable para guardar el comando con el nombre de la base de datos y el servidor
        private SqlConnection conexionSql; //Variable de tipo SqlConnection para crear una conexión a la base de datos

        #endregion

        #region Constructor

        public frmIniciarSesion()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion, ref conexionSql); //Llmada a método público para inicicar conexión
        }

        #endregion

        #region Métodos

        //Método para hacer el inicio de sesión
        private void iniciarSesion()
        {   //Se abre la conexión
            conexionSql.Open();
            //Se escribe la cadena de la consulta pasando los parametros de los textboxs
            string consultaSql = "select * from USUARIO where USR_NOMBRE='" + txtNombreUsuario.Text + "' and USR_CONTRA='" + txtContrasena.Text + "'";
           //Se crea el objeto comando para ejecutar la consulta
            SqlCommand comandoSql = new SqlCommand(consultaSql, conexionSql);
            SqlDataReader lectorSql; //Se crea un lector para leer el resultado de la consulta
            lectorSql = comandoSql.ExecuteReader(); //Se ejecuta el comando y se le pasa al lector

            if (lectorSql.Read()) //Si el método de leer regresa verdadero, se inicia la sesión
            {
                MessageBox.Show("Has iniciado sesiòn");
                Sesion.ObtenerDatosSesion(true, txtNombreUsuario.Text); //Se cambia el valor booleano de la clase sesión y se pasa el nombre de la sesión
                this.Close(); //Se cierra el formulario
            } //sino, la sesión no se inicia
            else MessageBox.Show("Usuario o contraseña incorrectos");
            //Se cierra la conexión
            conexionSql.Close();
        }

        #endregion

        #region Eventos
        
        //Evento click para el botón de iniciar sesión
        private void btnInicicarSesion_Click(object sender, EventArgs e)
        {   //Se ejecuta el método para iniciar sesión
            iniciarSesion();
        }
        #endregion
    }
}
