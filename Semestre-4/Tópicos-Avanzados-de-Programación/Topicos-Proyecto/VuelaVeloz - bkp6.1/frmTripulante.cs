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
    public partial class frmTripulante : Form
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

        public frmTripulante()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion, ref conexionSql);
        }

        #endregion

        #region Métodos

        private void restaurarBarraLateral()
        {
            lblBarraLateral.Text = "Tripulante Seleccionado";
            txtId.ReadOnly = true;
            txtPrimNom.ReadOnly = true;
            txtSegNom.ReadOnly = true;
            txtPrimApe.ReadOnly = true;
            txtSegApe.ReadOnly = true;
            txtBaseId.ReadOnly = true;
            btnAceptarAgregar.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void actualizarTabla()
        {
            conexionSql.Open();
            consultaSql = "select * from TRIPULANTE";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ningÚn tripulante registrado");
            else dgvTablaTripulantes.DataSource = tablaSql;
            conexionSql.Close();
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Agregar Tripulante";
            txtId.ReadOnly = false;
            txtPrimNom.ReadOnly = false;
            txtSegNom.ReadOnly = false;
            txtPrimApe.ReadOnly = false;
            txtSegApe.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarAgregar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Editar Tripulante";
            txtPrimNom.ReadOnly = false;
            txtSegNom.ReadOnly = false;
            txtPrimApe.ReadOnly = false;
            txtSegApe.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarEditar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaResultante = new DataTable();
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificar del tripulante", "Buscador de Tripulantes", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "select * from TRIPULANTE where TRIP_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            adaptadorSql.Fill(tablaResultante);
            if (tablaResultante.Rows.Count == 0) MessageBox.Show("No se ha encontrado el tripulante");
            else
            {
                restaurarBarraLateral();
                DataRow Row = tablaResultante.Rows[0];
                txtId.Text = Row["TRIP_ID"].ToString();
                txtPrimNom.Text = Row["TRIP_PRIMNOM"].ToString();
                txtSegNom.Text = Row["TRIP_SEGNOM"].ToString();
                txtPrimApe.Text = Row["TRIP_PRIMAPE"].ToString();
                txtSegApe.Text = Row["TRIP_SEGAPE"].ToString();
                txtBaseId.Text = Row["BS_ID"].ToString();
            }
            conexionSql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificador del tripulante", "Eliminador de Tripulantes", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "delete FROM TRIPULANTE where TRIP_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            MessageBox.Show("El tripulante ha sido eliminado exitosamente");
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "insert into TRIPULANTE values ('" + txtId.Text + "','" + txtPrimNom.Text + "','" + txtSegNom.Text + "','" + txtPrimApe.Text + "','" + txtSegApe.Text + "','" + txtBaseId.Text + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El tripulante se ha registado exitosamente");
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "update TRIPULANTE set TRIP_PRIMNOM = '" + txtPrimNom.Text + "', TRIP_SEGNOM = '" + txtSegNom.Text + "', TRIP_PRIMAPE = '" + txtPrimApe.Text + "', TRIP_SEGAPE = '" + txtSegApe.Text + "', BS_ID = '" + txtBaseId.Text + "' " +
                          "where TRIP_ID = '" + txtId.Text + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El tripulante se ha editado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarBarraLateral();
        }

        private void frmTripulante_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dgvTablaTripulantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTablaTripulantes.SelectedCells[0].Value.ToString();
            txtPrimNom.Text = dgvTablaTripulantes.SelectedCells[1].Value.ToString();
            txtSegNom.Text = dgvTablaTripulantes.SelectedCells[2].Value.ToString();
            txtPrimApe.Text = dgvTablaTripulantes.SelectedCells[3].Value.ToString();
            txtSegApe.Text = dgvTablaTripulantes.SelectedCells[4].Value.ToString();
            txtBaseId.Text = dgvTablaTripulantes.SelectedCells[5].Value.ToString();
        }

        #endregion
    }
}
