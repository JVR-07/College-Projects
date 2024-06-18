using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VuelaVeloz
{
    public partial class frmBases : Form
    {
        #region Campos

        private string comandoConexion; //Variable para guardar el comando con el nombre de la base de datos y el servidor
        string consultaSql;
        private SqlConnection conexionSql; //Variable de tipo SqlConnection para crear una conexión a la base de datos
        SqlDataAdapter adaptadorSql;
        DataTable tablaSql;
        SqlCommand comandoSql;

        #endregion

        #region Constructor

        public frmBases()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion,ref conexionSql);
        }

        #endregion

        #region Métodos

        private void restaurarBarraLateral()
        {
            lblBarraLateral.Text = "Base Seleccionada";
            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtCiudad.ReadOnly = true;
            txtEstado.ReadOnly = true;
            btnAceptarAgregar.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void actualizarTabla()
        {
            conexionSql.Open();
            consultaSql = "select * from BASE";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ninguna base registrada");
            else dgvTablaBases.DataSource = tablaSql;
            conexionSql.Close();
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Agregar Base";
            txtId.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtCiudad.ReadOnly = false;
            txtEstado.ReadOnly = false;
            btnAceptarAgregar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Editar Base";
            txtNombre.ReadOnly = false;
            txtCiudad.ReadOnly = false;
            txtEstado.ReadOnly = false;
            btnAceptarEditar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaResultante = new DataTable();
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificar de la base", "Buscador de Bases", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "select * from BASE where BS_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            adaptadorSql.Fill(tablaResultante);
            if(tablaResultante.Rows.Count == 0) MessageBox.Show("No se ha encontrado la base");
            else
            {
                restaurarBarraLateral();
                DataRow Row = tablaResultante.Rows[0];
                txtId.Text = Row["BS_ID"].ToString();
                txtNombre.Text = Row["BS_NOMBRE"].ToString();
                txtCiudad.Text = Row["BS_CIUDAD"].ToString();
                txtEstado.Text = Row["BS_ESTADO"].ToString();
            }
            conexionSql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificador de la base", "Eliminador de Bases", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "delete FROM BASE where BS_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            MessageBox.Show("La base ha sido eliminada exitosamente");
            
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "insert into BASE values ('" + txtId.Text + "','" + txtNombre.Text + "','" + txtCiudad.Text + "','" + txtEstado.Text + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("La base se ha registado exitosamente");            
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "update BASE set BS_NOMBRE = '" + txtNombre.Text + "', BS_CIUDAD = '"+txtCiudad.Text+"', BS_ESTADO = '"+txtEstado.Text+"' " + 
                          "where BS_ID = '"+txtId.Text+"'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("La base se ha editado exitosamente");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarBarraLateral();
        }

        private void frmBases_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dgvTablaBases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTablaBases.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvTablaBases.SelectedCells[1].Value.ToString();
            txtCiudad.Text = dgvTablaBases.SelectedCells[2].Value.ToString();
            txtEstado.Text = dgvTablaBases.SelectedCells[3].Value.ToString();
        }

        #endregion
    }
}
