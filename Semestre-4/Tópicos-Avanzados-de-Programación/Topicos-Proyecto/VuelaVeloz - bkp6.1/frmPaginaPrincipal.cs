using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelaVeloz
{
    public partial class frmPaginaPrincipal : Form
    {
        #region Campos

        private string comandoConexion; //Variable para guardar el comando con el nombre de la base de datos y el servidor
        private SqlConnection conexionSql; //Variable de tipo SqlConnection para crear una conexión a la base de datos

        private Form formularioActivo = null; //Sirve para almacenar el formulario que se está mostrando en el panel contenedor        

        #endregion

        #region Constructor

        public frmPaginaPrincipal()
        {
            InitializeComponent(); //Método para iniciar controles gráficos
        }

        #endregion

        #region Métodos

        //Método público que sirve para iniciar la conexión sql y guardarla en el parametro correspondiente a la conexión SqlConnection
        public static void iniciarConexion(ref string comandoConexion, ref SqlConnection conexionSql)
        {
            comandoConexion = ConfigurationManager.ConnectionStrings["conexionAerolineaDB"].ConnectionString;
            conexionSql = new SqlConnection(comandoConexion);
        }

        //Método privado que permite abrir un formulario hijo en el panel contenedor, se le pasa un formulario por parametro
        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null) formularioActivo.Close(); //En caso de haber otro formulario lo cierra
            pnlPanelSuperior.Visible = false;
            formularioActivo = formularioHijo; // el formulario que se abrirá se guarda en el campo para el formulario activo
            formularioHijo.TopLevel = false; //Se pone falsa la propiedad para determinar si el formulario hijo es una forma de alto nivel
            formularioHijo.FormBorderStyle = FormBorderStyle.None; //Se elimina el borde del formulario hijo
            formularioHijo.Dock = DockStyle.Fill; //Se selecciona el Dock fill para que el formulario hijo rellene todo el panel contenedor
            pnlContenedorFormHijo.Controls.Add(formularioHijo); //Se agrega el formulario hijo al panel contenedor
            pnlContenedorFormHijo.Tag = formularioHijo; //Se etiqueta el panel contenedor con el formulario hijo
            pnlContenedorFormHijo.BringToFront(); //El panel contenedor se pasa al frente de la vista
            formularioHijo.Show(); //Se muestra el formulario hijo
        }

        //Método que sirve para desplegar el texto de bienvenida en caso de que exista una sesión activa
        private void DesplegarBienvenidaConSesion()
        {
          //Modificación de los labels
            this.lblBienvenida.Text = $"¡ Bienvenido usuario {Sesion.ObtenerNombre()} !";
            this.lblMensaje.Text = "Recuerde aprovechar su corta jornada de 18 horas para aumentar la productividad de la compañia. \r\nSeleccione una opción de la barra lateral para comenzar a trabajar.\r\n";
            //Condiciones para determinar cuando bloquear y  cuando no el botón de Registrase
            if (btnRegistrarse.Enabled) btnRegistrarse.Enabled = false;
            //activando botones de la barra lateral
            btnVuelos.Enabled = true;
            btnTripulantes.Enabled = true;
            btnPilotos.Enabled = true;
            btnAviones.Enabled = true;
            btnBases.Enabled = true;
            //Desactivando el botón Inicicar Sesión y activando el de Cerrar Sesión
            pnlPanelSuperior.Visible = true;
            tbpnlPanelSuperior.Visible = false;
            btnCerrarSesion.Visible = true;
            btnCerrarSesion.Enabled = true;
        }

        //Método que sirve para desplegar el texto de bienvenida en caso de que no exista una sesión activa
        private void DesplegarBienvenidaSinSesion()//Comprando que esté iniciada la sesión por medio del método de la clase Sesion
        {   //Modificación de los labels
            this.lblBienvenida.Text = $"¡ Bienvenido !";
            this.lblMensaje.Text = "Para acceder a todas las funcionalidades del software,\r\npor favor inicie sesión o cree una cuenta nueva.";
            //Condiciones para determinar cuando bloquear y  cuando no los botones de Iniciar Sesion y Registrase
            if (!btnIniciarSesion.Enabled) btnIniciarSesion.Enabled = true;
            if (!btnRegistrarse.Enabled) btnRegistrarse.Enabled = true;
            //desactivando botones de la barra lateral
            btnVuelos.Enabled = false;
            btnTripulantes.Enabled = false;
            btnPilotos.Enabled = false;
            btnAviones.Enabled = false;
            btnBases.Enabled = false;
            //Desactivando el botón Cerrar Sesión y activando el de Iniciar Sesión
            pnlPanelSuperior.Visible = true;            
            btnCerrarSesion.Visible = false;
            tbpnlPanelSuperior.Visible = true;
        }

        //Método para eliminar el borde izquierdo de todo los botones de la barra lateral
        private void BorrarBordesBarraLateral()
        {   //Se agrega un borde de tamaño 0 pixeles
            btnVuelos.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnTripulantes.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnPilotos.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnAviones.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnBases.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnAyuda.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            btnCuenta.CustomBorderThickness = new System.Windows.Forms.Padding(0);
        }

        //Método para dibujar el borde izquierdo del botón
        private void AgregarBordeBarraLateral(ref Guna2Button boton)
        {   //Se crea un borde de 4 pixeles en la parte izquierda y se dibuja del color correspondiente
            boton.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            boton.CustomBorderColor = System.Drawing.Color.Lime;
        }

        #endregion

        #region Eventos

        //Evento del timer para esconder el menú
        private void tmPlegarMenu_Tick(object sender, EventArgs e)
        {   /* Si el ancho de la barra es menor o igual a 60 pixeles, se detiene el timer
                 En caso contrario, se restan 20 pixeles
                 Esto se ejectua hasta que el timer sea false */
            if (pnlBarraLateral.Width <= 60) tmPlegarMenu.Enabled = false;
            else pnlBarraLateral.Width -= 20;
        }

        //Evento del timer para mostrar el menú
        private void tmDesplegarMenu_Tick(object sender, EventArgs e)
        {   /* Si el ancho de la barra es mayor o igual a 200 pixeles, se detiene el timer
                 En caso contrario, se suman 20 pixeles
                 Esto se ejectua hasta que el timer sea false */
            if (pnlBarraLateral.Width >= 200) tmDesplegarMenu.Enabled = false;
            else pnlBarraLateral.Width += 20;
        }

        //Evento del botón de la barra lateral para plegar / desplegar menú lateral
        private void btnBarraLateral_Click(object sender, EventArgs e)
        {  //Si el ancho es igual a 200, se oculta, si es igual a 60 se muestra
            if (pnlBarraLateral.Width == 200) tmPlegarMenu.Enabled = true;
            else if (pnlBarraLateral.Width == 60) tmDesplegarMenu.Enabled = true;
        }

        //Evento de click al botón de inicicar sesión
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {  
            abrirFormularioHijo(new frmIniciarSesion()); //Se abre el formulario hijo para el inicio de sesión
            pnlPanelSuperior.Visible = true;
            tbpnlPanelSuperior.Visible = true;
            //Se desactiva el botón de inicicar sesión
            btnIniciarSesion.Enabled = false;
            // Se activa el botón de registrarse en caso de que esté desactivado
            if (!btnRegistrarse.Enabled)
            {
                btnRegistrarse.Enabled = true;
            }
        }

        //Evento de click al botón de registrarse
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRegistrarse()); //Se abre el formulario hijo para el inicio de sesión
            pnlPanelSuperior.Visible = true;
            tbpnlPanelSuperior.Visible = true;
            //Se desactiva el botón de inicicar sesión
            btnRegistrarse.Enabled = false;
            // Se activa el botón de registrarse en caso de que esté desactivado
            if (!btnIniciarSesion.Enabled)
            {
                btnIniciarSesion.Enabled = true;
            }
        }

        //Evento control removido para cuando se elimine un formulario hijo del panel contenedor
        private void pnlContenedorFormHijo_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnlContenedorFormHijo.Controls.Clear(); //Se limpian todos los controles del panel contenedor 
            formularioActivo = null; //Se elimina el formulario activo
            pnlContenedorFormHijo.SendToBack(); //Se envia el panel hacia la parte trasera
            if (Sesion.SesionIniciada()) DesplegarBienvenidaConSesion();
            else DesplegarBienvenidaSinSesion();
        }

        //Evento click para el botón de cerrar sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        { //Si la sesion está iniciada se cierra y se imprime la bienvenida sin sesion
            if (Sesion.SesionIniciada())
            {
                Sesion.CerrarSesion();

                DesplegarBienvenidaSinSesion();
                MessageBox.Show("Sesion cerrada papú");
            }
        }

        //Evento click para el botón de Vuelo de la barra lateral
        private void btnVuelos_Click(object sender, EventArgs e)
        { //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnVuelos);
            abrirFormularioHijo(new frmVuelos());
        }

        //Evento click para el botón de Tripulantes de la barra lateral
        private void btnTripulantes_Click(object sender, EventArgs e)
        { //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnTripulantes);
            abrirFormularioHijo(new frmTripulante());
        }

        //Evento click para el botón de Pilotos de la barra lateral
        private void btnPilotos_Click(object sender, EventArgs e)
        {   //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnPilotos);
            abrirFormularioHijo(new frmPiloto());
        }

        //Evento click para el botón de Aviones de la barra lateral
        private void btnAviones_Click(object sender, EventArgs e)
        {   //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnAviones);
            abrirFormularioHijo(new frmAvion());
        }

        //Evento click para el botón de Bases de la barra lateral
        private void btnBases_Click(object sender, EventArgs e)
        {   //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnBases);
            abrirFormularioHijo(new frmBases());
        }

        //Evento click para el botón de Ayuda de la bara lateral
        private void btnAyuda_Click(object sender, EventArgs e)
        {   //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnAyuda);
        }
        //Evento de click para el botón cuenta de la barra lateral
        private void btnCuenta_Click(object sender, EventArgs e)
        {
            //Se borran los bordes de todos los botones
            BorrarBordesBarraLateral();
            //Se dibuja el borde izquierdo del botón
            AgregarBordeBarraLateral(ref btnCuenta);

            pnlContenedorFormHijo.Controls.Clear(); //Se limpia el contenedor hijo
            formularioActivo = null;  //Se limpia el formulario activo
            pnlContenedorFormHijo.SendToBack(); //Se envía a la parte trasera el panel contenedor
            if (Sesion.SesionIniciada()) //Si la sesión está iniciada se despliega la bienvenida con sesion inicicada
            {
                DesplegarBienvenidaConSesion();
            } //sino, se despliega la bienvendia sin sesión iniciada
            else DesplegarBienvenidaSinSesion();
        }

        #endregion
    }

    #region Clase Sesion

    //Clase pública para manejar cuando la sesión está iniciada o no
    public static class Sesion
    { //Campos
        private static bool Iniciada; //Bool que determina si la sesión está iniciada o no
        private static string Nombre; //Nombre de la sesión iniciada

        //Método para obtener los datos de una sesión iniciada
        public static void ObtenerDatosSesion(bool _Iniciada, string _Nombre)
        {
            Iniciada = _Iniciada; //Se activa el bool
            Nombre = _Nombre; //Se asigna el nombre
        }

        //Método booleano para saber si hay una sesión iniciada
        public static bool SesionIniciada()
        {
            return Iniciada;
        }

        //Método para obtener el nombre de la sesión
        public static string ObtenerNombre()
        {
            return Nombre;
        }

        //Método para modificar el valor booleano en caso de cerrar la sesión
        public static void CerrarSesion()
        {
            Iniciada = false;
        }
    }
}

#endregion