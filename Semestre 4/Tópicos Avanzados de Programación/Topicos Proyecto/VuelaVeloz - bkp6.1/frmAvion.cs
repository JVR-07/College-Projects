using Microsoft.VisualBasic;
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

namespace VuelaVeloz
{
    public partial class frmAvion : Form
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

        public frmAvion()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion,ref conexionSql);
        }

        #endregion

        #region Métodos

        private void restaurarBarraLateral()
        {
            lblBarraLateral.Text = "Avión Seleccionado";
            txtId.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtBaseId.ReadOnly = true;
            btnAceptarAgregar.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void actualizarTabla()
        {
            conexionSql.Open();
            consultaSql = "select * from AVION";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ningún avión registrado");
            else dgvTablaAviones.DataSource = tablaSql;
            conexionSql.Close();
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Agregar Avión";
            txtId.ReadOnly = false;
            txtModelo.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarAgregar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Editar Avión";
            txtModelo.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarEditar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaResultante = new DataTable();
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificar del avión", "Buscador de Aviones", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "select * from AVION where AVN_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            adaptadorSql.Fill(tablaResultante);
            if (tablaResultante.Rows.Count == 0) MessageBox.Show("No se ha encontrado el avión");
            else
            {
                restaurarBarraLateral();
                DataRow Row = tablaResultante.Rows[0];
                txtId.Text = Row["AVN_ID"].ToString();
                txtModelo.Text = Row["AVN_MODELO"].ToString();
                txtBaseId.Text = Row["BS_ID"].ToString();
            }
            conexionSql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificador del avión", "Eliminador de Aviones", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "delete FROM AVION where AVN_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            MessageBox.Show("El avión ha sido eliminado exitosamente");
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "insert into AVION values ('" + txtId.Text + "','" + txtModelo.Text + "','" + txtBaseId.Text + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El avión se ha registado exitosamente");
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "update AVION set AVN_MODELO = '" + txtModelo.Text + "', BS_ID = '" + txtBaseId.Text + "' " +
                          "where AVN_ID = '" + txtId.Text + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El avión se ha editado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarBarraLateral();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dgvTablaAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTablaAviones.SelectedCells[0].Value.ToString();
            txtModelo.Text = dgvTablaAviones.SelectedCells[1].Value.ToString();
            txtBaseId.Text = dgvTablaAviones.SelectedCells[2].Value.ToString();
        }

        #endregion
    }
}
