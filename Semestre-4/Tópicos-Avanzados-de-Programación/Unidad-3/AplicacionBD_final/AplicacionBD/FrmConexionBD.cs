using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace AplicacionBD
{
    public partial class FrmConexionBD : Form
    {
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Inicio Bloque de campos
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        // Conexión
        SqlConnection ConnectionSlq = new SqlConnection(); //Conexión física a base de datos
        SqlCommand CommandSql; //Representación de la consulta sql
        SqlDataAdapter AdapterSql = null; //Adaptador para trabajar entre SQL y C#
        DataTable DtEstudiantes = new DataTable();
        
        // Variables
        string SqlString = null, SqlServer = "DESKTOP-DFE0LBF\\SQLEXPRESS", SqlDBName = "BD2024";
        int Index = 0;
        
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Fin Bloque de campos
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //Constructor
        public FrmConexionBD()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Inicio Bloque de métodos
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Establecer conexión
        void Conectar()
        {
            try
            {
                ConnectionSlq.ConnectionString = "Data Source=" + SqlServer + ";" +
                "Initial Catalog=" + SqlDBName + ";" + "Integrated security=true";
                try
                {
                    ConnectionSlq.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("BD2024 error al tratar de establecer la conexión: " + ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message);
            }

        }

        //
        void CargarDatos(int Index)
        {
            if (DtEstudiantes.Rows.Count > 0)
            {
                DataRow Row = DtEstudiantes.Rows[Index];

                TxtIdentificacion.Text = Row["identificacion"].ToString();
                TxtPrimerNombre.Text = Row["prim_nom"].ToString();
                TxtSegundoNombre.Text = Row["seg_nom"].ToString();
                TxtPrimerApellido.Text = Row["prim_ape"].ToString();
                TxtSegundoApellido.Text = Row["seg_ape"].ToString();
                CbxSexo.Text = Row["sexo"].ToString();
                TxtTelefono.Text = Row["telefono"].ToString();
                TxtDireccion.Text = Row["direccion"].ToString();
            }
            else
            {
                MessageBox.Show("No hay registros para mostrar");
            }
        }

        void RefrescarDatos()
        {
            SqlString = "SELECT * FROM estudiante";

            AdapterSql = new SqlDataAdapter(SqlString, ConnectionSlq);
            DtEstudiantes.Clear();
            AdapterSql.Fill(DtEstudiantes);
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Fin Bloque de métodos
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------



        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Inicio Bloque de Eventos para botones
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Evento para cargar forma
        private void FrmConexionBD_Load(object sender, EventArgs e)
        {
            Conectar();

            SqlString = "SELECT * FROM estudiante";
            AdapterSql = new SqlDataAdapter(SqlString, ConnectionSlq);
            AdapterSql.Fill(DtEstudiantes);
            CargarDatos(Index);
        }

        // Evento para botón Guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea guardar los cambios?","Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                //Instrucción SQL
                SqlString = "insert into estudiante(identificacion, prim_nom, seg_nom, prim_ape, seg_ape, sexo, telefono, direccion)" +
                            "values(@identificacion, @prim_nom, @seg_nom, @prim_ape, @seg_ape, @sexo, @telefono, @direccion)";
                //Objeto comando
                CommandSql = new SqlCommand(SqlString, ConnectionSlq);

                CommandSql.Parameters.AddWithValue("@identificacion", TxtIdentificacion.Text);
                CommandSql.Parameters.AddWithValue("@prim_nom", TxtPrimerNombre.Text);
                CommandSql.Parameters.AddWithValue("@seg_nom", TxtSegundoNombre.Text);
                CommandSql.Parameters.AddWithValue("@prim_ape", TxtPrimerApellido.Text);
                CommandSql.Parameters.AddWithValue("@seg_ape", TxtSegundoApellido.Text);
                CommandSql.Parameters.AddWithValue("@sexo", CbxSexo.Text);
                CommandSql.Parameters.AddWithValue("@telefono", TxtTelefono.Text);
                CommandSql.Parameters.AddWithValue("@direccion", TxtDireccion.Text);

                try
                {
                    CommandSql.ExecuteNonQuery();
                    MessageBox.Show("Registros guardados exitosamente", "REGISTROS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Los datos no se han podido guardar correctamente\nMensaje de error: " + ex.Message,"ERORR AL GUARDAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para botón Editar
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea editar los datos?", "Editar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                SqlString = "UPDATE estudiante SET prim_nom=@prim_nom, seg_nom=@seg_nom, prim_ape=@prim_ape, seg_ape=@seg_ape, sexo=@sexo, telefono=@telefono, direccion=@direccion WHERE identificacion=@identificacion";
                
                CommandSql = new SqlCommand(SqlString, ConnectionSlq);

                CommandSql.Parameters.AddWithValue("@identificacion", TxtIdentificacion.Text);
                CommandSql.Parameters.AddWithValue("@prim_nom", TxtPrimerNombre.Text);
                CommandSql.Parameters.AddWithValue("@seg_nom", TxtSegundoNombre.Text);
                CommandSql.Parameters.AddWithValue("@prim_ape", TxtPrimerApellido.Text);
                CommandSql.Parameters.AddWithValue("@seg_ape", TxtSegundoApellido.Text);
                CommandSql.Parameters.AddWithValue("@sexo", CbxSexo.Text);
                CommandSql.Parameters.AddWithValue("@telefono", TxtTelefono.Text);
                CommandSql.Parameters.AddWithValue("@direccion", TxtDireccion.Text);

                try
                {
                    CommandSql.ExecuteNonQuery();
                    MessageBox.Show("El registro ha sido editado correctamente", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDatos();
                }
                catch (SqlException ex)
                { 
                    MessageBox.Show("Los datos no se han podido editar correctamente\nMensaje de error: " + ex.Message,"ERORR AL GUARDAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Evento para botón Buscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea buscar un registro?", "Buscar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                if (DtEstudiantes.Rows.Count > 0)
                {
                    int id = int.Parse(Interaction.InputBox("Ingrese el identificador del estudiante que se buscará:","INGRESE IDENTIFICADOR","", (Width/2) + 300, (Height/2) + 100));
                    DataRow[] Row = DtEstudiantes.Select(String.Format("identificacion = {0}", id));

                    if(Row.Length > 0)
                    {
                        Index = DtEstudiantes.Rows.IndexOf(Row[0]);
                        CargarDatos(Index);
                    }
                    else MessageBox.Show("El estudiante buscado no ha sido registrado", "Error al buscar estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para botón Eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea eliminar un registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                SqlString = "DELETE FROM estudiante WHERE identificacion=@identificacion";
                CommandSql = new SqlCommand(SqlString, ConnectionSlq);

                CommandSql.Parameters.AddWithValue("@identificacion", TxtIdentificacion.Text);
                
                try
                {
                    CommandSql.ExecuteNonQuery();
                    MessageBox.Show("El registro ha sido eliminado correctamente", "REGISTRO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarDatos();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Los datos no se han podido eliminar correctamente\nMensaje de error: " + ex.Message, "ERORR AL GUARDAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        // Evento para botón Cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea cerrar el programa?\nLos cambios que no se guarden se borrarán",
                            "Salir del Programa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                ConnectionSlq.Close();
                this.Dispose();
            }
        }

        // Evento para botón Inicio
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Index = 0;
            CargarDatos(Index);
        }

        // Evento para botón Anterior
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (DtEstudiantes.Rows.Count > 0 && Index > 0)
            {
                Index--;
                CargarDatos(Index);
            }
        }

        // Evento para botón Siguiente
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (Index < DtEstudiantes.Rows.Count - 1)
            {
                Index++;
                CargarDatos(Index);
            }
        }
        
        // Evento para botón Fin
        private void BtnFinal_Click(object sender, EventArgs e)
        {
            if (DtEstudiantes.Rows.Count > 0)
            {
                Index = DtEstudiantes.Rows.Count - 1;
                CargarDatos(Index);
            }
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                 Fin Bloque de Eventos para botones
        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
