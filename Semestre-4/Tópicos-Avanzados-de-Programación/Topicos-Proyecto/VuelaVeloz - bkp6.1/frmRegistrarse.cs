using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelaVeloz
{
    public partial class frmRegistrarse : Form
    {
        #region Campos

        string comandoConexion; //Variable para guardar el comando con el nombre de la base de datos y el servidor
        SqlConnection conexionSql; //Variable de tipo SqlConnection para crear una conexión a la base de datos

        #endregion

        #region Constructor

        public frmRegistrarse()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion, ref conexionSql); //Llmada a método público para inicicar conexión
        }

        #endregion

        #region Métodos

        //Método para determinar si el usuario ya existe
        private bool UsuarioExistente()
        {   //Se abre la conexión
            conexionSql.Open();
            //Se hace la consulta sql con el parametro del textbox para el nombre de usuario
            string consultaSql = "select USR_NOMBRE from USUARIO where USR_NOMBRE='" + txtNombreUsuario.Text + "'";
            //Se crea un DataTable para guardar la tabla de sql
            DataTable dtUsuarios = new DataTable();
            //Se crea adaptador con la consulta y la conexión
            SqlDataAdapter adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            //El adaptador rellena la tabla con los resultados de la consulta
            adaptadorSql.Fill(dtUsuarios);
            //Se cierra la conexión
            conexionSql.Close();
            //Operación ternaria
            //Si la condición se cumple se regresa verdadero, sino, se regresa falso
            return dtUsuarios.Rows.Count > 0 ? true : false;
        }
        #endregion

        #region Eventos

        //Evento click para el botón registrarse
       private void btnRegistrarse_Click(object sender, EventArgs e)
        { //si el usuario no existe y las contraseñas son iguales
            if (!UsuarioExistente() && txtContrasena.Text == txtConfirmarContrasena.Text)
            {   //Se abre la conexión
                conexionSql.Open();
                //Se hace la consulta sql con los parametros de los textboxs
                string consultaSql = "insert into USUARIO (USR_NOMBRE, USR_CONTRA) values  ('" + txtNombreUsuario.Text + "','" + txtContrasena.Text + "')";
                //Se crea un nuevo comando con la consulta y la conexión
                SqlCommand comandoSql = new SqlCommand(consultaSql, conexionSql);
                //Se ejecuta el comando
                comandoSql.ExecuteNonQuery();
                MessageBox.Show("usuario registrado y sesión iniciada");
                //Se inicia sesióny se pasa el nombre a la clase Sesion
                Sesion.ObtenerDatosSesion(true, txtNombreUsuario.Text);
                //Se cierra el formulario
                this.Close();
                //Se cierra la conexión
                conexionSql.Close();
            }//Si las contraseñas no coinciden se lanza un mensaje
            else if (txtContrasena.Text != txtConfirmarContrasena.Text) MessageBox.Show("Las contraseñas no coinciden");
            else if (UsuarioExistente()) MessageBox.Show("Ya existe ese usuario pai"); //Si el usuario ya existe se lanza un mensaje
            else MessageBox.Show("No se ha podido completar el registro"); //Sino, se lanza un mensaje
        }
        #endregion
    }
}
