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
    public partial class frmVuelos : Form
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

        public frmVuelos()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion, ref conexionSql);
        }

        #endregion

        #region Métodos

        private void restaurarBarraLateral()
        {
            lblBarraLateral.Text = "Vuelo Seleccionado";
            txtId.ReadOnly = true;
            txtCiuDest.ReadOnly = true;
            txtEstDest.ReadOnly = true;
            txtCiuOrigen.ReadOnly = true;
            txtEstOrigen.ReadOnly = true;
            txtHoraSal.ReadOnly = true;
            txtHoraLleg.ReadOnly = true;
            btnAgregarTripulante.Visible = false;
            btnEliminarTripulante.Visible = false;
            btnAceptarAgregar.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void actualizarTabla()
        {
            conexionSql.Open();
            consultaSql = "select * from VUELO";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ningún vuelo registrado");
            else dgvTablaVuelos.DataSource = tablaSql;
            conexionSql.Close();
        }
        
        private void actualizarTripulacion(int id)
        {
            dgvTablaTripulacion.Rows.Clear();
            conexionSql.Open();
            consultaSql = "select * from DETALLE_VUELO_TRIPULANTE where VUE_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ningún triulante agregado");
            else
            {
                int filastotales = tablaSql.Rows.Count;
                for(int i = 0; i < filastotales; i++)
                {
                    DataRow fila = tablaSql.Rows[i];
                    dgvTablaTripulacion.Rows.Add();
                    dgvTablaTripulacion.Rows[i].Cells[0].Value = fila[0];
                    dgvTablaTripulacion.Rows[i].Cells[1].Value = fila[1];
                }
            }
            conexionSql.Close();
        }

        private void InsertarTripulacion(int VUE_ID, int TRIP_ID)
        {
            conexionSql.Open();
            consultaSql = "insert into DETALLE_VUELO_TRIPULANTE values ('" + VUE_ID + "','" + TRIP_ID + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
        }

        private void LimpiarTripulacion(int VUE_ID)
        {
            conexionSql.Open();
            consultaSql = "delete from DETALLE_VUELO_TRIPULANTE where VUE_ID  = '" + VUE_ID + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            dgvTablaTripulacion.SelectAll();
            dgvTablaTripulacion.ClearSelection();
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Agregar Vuelo";
            txtId.ReadOnly = false;
            txtCiuDest.ReadOnly = false;
            txtEstDest.ReadOnly = false;
            txtCiuOrigen.ReadOnly = false;
            txtEstOrigen.ReadOnly = false;
            txtHoraSal.ReadOnly = false;
            txtHoraLleg.ReadOnly = false;
            txtPilId.ReadOnly = false;
            txtAvnId.ReadOnly = false;
            btnAgregarTripulante.Visible = true;
            btnEliminarTripulante.Visible = true;
            btnAceptarAgregar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Editar Vuelo";
            txtCiuDest.ReadOnly = false;
            txtEstDest.ReadOnly = false;
            txtCiuOrigen.ReadOnly = false;
            txtEstOrigen.ReadOnly = false;
            txtHoraSal.ReadOnly = false;
            txtHoraLleg.ReadOnly = false;
            txtPilId.ReadOnly = false;
            txtAvnId.ReadOnly = false;
            btnAgregarTripulante.Visible = true;
            btnEliminarTripulante.Visible = true;
            btnAceptarEditar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaResultante = new DataTable();
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificar del vuelo", "Buscador de Vuelos", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "select * from VUELO where VUE_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            adaptadorSql.Fill(tablaResultante);
            if (tablaResultante.Rows.Count == 0) MessageBox.Show("No se ha encontrado el vuelo");
            else
            {
                restaurarBarraLateral();
                DataRow Row = tablaResultante.Rows[0];
                txtId.Text = Row["VUE_ID"].ToString();
                txtCiuDest.Text = Row["VUE_CIUDEST"].ToString();
                txtEstDest.Text = Row["VUE_ESTDEST"].ToString();
                txtCiuOrigen.Text = Row["VUE_CIUORIGEN"].ToString();
                txtEstOrigen.Text = Row["VUE_ESTORIGEN"].ToString();
                txtHoraSal.Text = Row["VUE_HORASAL"].ToString();
                txtHoraLleg.Text = Row["VUE_HORALLEG"].ToString();
                txtPilId.Text = Row["PIL_ID"].ToString();
                txtAvnId.Text = Row["AVN_ID"].ToString();
                actualizarTripulacion(id);
            }
            conexionSql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificador del vuelo", "Eliminador de Vuelos", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "delete FROM DETALLE_VUELO_TRIPULANTE where VUE_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            consultaSql = "delete FROM VUELO where VUE_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            MessageBox.Show("El vuelo ha sido eliminado exitosamente");
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "insert into VUELO values ('" + txtId.Text + "','" + txtCiuDest.Text + "','" + txtEstDest.Text + "','" + txtCiuOrigen.Text + "','" + txtEstOrigen.Text +"','" + txtHoraSal.Text + "','" + txtHoraLleg.Text + "','" + txtPilId.Text + "','" + txtAvnId.Text + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            int FilasTotales = dgvTablaTripulacion.Rows.Count;
            for(int i = 0; i < FilasTotales; i++)
            {
                int VUE_ID = int.Parse(dgvTablaTripulacion.Rows[i].Cells[0].Value.ToString());
                int TRIP_ID = int.Parse(dgvTablaTripulacion.Rows[i].Cells[1].Value.ToString());
                InsertarTripulacion(VUE_ID, TRIP_ID);
            }
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El vuelo se ha registado exitosamente");
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "update VUELO set VUE_CIUDEST = '" + txtCiuDest.Text + "', VUE_ESTDEST = '" + txtEstDest.Text + "', VUE_CIUORIGEN = '" + txtCiuOrigen.Text + "', VUE_ESTORIGEN = '" + txtEstOrigen.Text + "', VUE_HORASAL = '" + txtHoraSal.Text + "', VUE_HORALLEG = '" + txtHoraLleg.Text + "', PIL_ID = '" + txtPilId.Text + "', AVN_ID = '" + txtAvnId.Text + "' " +
                          "where VUE_ID = '" + txtId.Text + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            LimpiarTripulacion(int.Parse(txtId.Text));
            int FilasTotales = dgvTablaTripulacion.Rows.Count - 1;
            for (int i = 0; i < FilasTotales; i++)
            {
                int VUE_ID = int.Parse(dgvTablaTripulacion.Rows[i].Cells[0].Value.ToString());
                int TRIP_ID = int.Parse(dgvTablaTripulacion.Rows[i].Cells[1].Value.ToString());
                InsertarTripulacion(VUE_ID, TRIP_ID);
            }
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("La base se ha editado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarBarraLateral();
        }

        private void btnAgregarTripulante_Click(object sender, EventArgs e)
        {
            int TRIP_ID = int.Parse(Interaction.InputBox("Ingrese el identificador del tripulante", "Agregar Tripulante", "", (Width / 2) + 300, (Height / 2) + 100));
            int index = dgvTablaTripulacion.Rows.Add();
            dgvTablaTripulacion.Rows[index].Cells[0].Value = txtId.Text;
            dgvTablaTripulacion.Rows[index].Cells[1].Value = TRIP_ID;

        }

        private void btnEliminarTripulante_Click(object sender, EventArgs e)
        {
            if (dgvTablaTripulacion.SelectedCells.Count == 0) MessageBox.Show("No ha seleccionado ningún tripulante");
            else
            {
                DataGridViewRow FilaSeleccionada = dgvTablaTripulacion.CurrentRow;
                dgvTablaTripulacion.Rows.Remove(FilaSeleccionada);
            }
        }

        private void frmVuelos_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dgvTablaVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTablaVuelos.SelectedCells[0].Value.ToString();
            txtCiuDest.Text = dgvTablaVuelos.SelectedCells[1].Value.ToString();
            txtEstDest.Text = dgvTablaVuelos.SelectedCells[2].Value.ToString();
            txtCiuOrigen.Text = dgvTablaVuelos.SelectedCells[3].Value.ToString();
            txtEstOrigen.Text = dgvTablaVuelos.SelectedCells[4].Value.ToString();
            txtHoraSal.Text = dgvTablaVuelos.SelectedCells[5].Value.ToString();
            txtHoraLleg.Text = dgvTablaVuelos.SelectedCells[6].Value.ToString();
            txtPilId.Text = dgvTablaVuelos.SelectedCells[7].Value.ToString();
            txtAvnId.Text = dgvTablaVuelos.SelectedCells[8].Value.ToString();
            actualizarTripulacion(int.Parse(txtId.Text));
        }

        #endregion
    }
}
