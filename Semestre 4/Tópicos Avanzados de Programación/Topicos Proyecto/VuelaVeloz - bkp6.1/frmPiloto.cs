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
    public partial class frmPiloto : Form
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

        public frmPiloto()
        {
            InitializeComponent();
            frmPaginaPrincipal.iniciarConexion(ref comandoConexion, ref conexionSql);
        }

        #endregion

        #region Métodos

        private void restaurarBarraLateral()
        {
            lblBarraLateral.Text = "Piloto Seleccionado";
            txtId.ReadOnly = true;
            txtPrimNom.ReadOnly = true;
            txtSegNom.ReadOnly = true;
            txtPrimApe.ReadOnly = true;
            txtSegApe.ReadOnly = true;
            txtHrsVuel.ReadOnly = true;
            txtBaseId.ReadOnly = true;
            btnAceptarAgregar.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void actualizarTabla()
        {
            conexionSql.Open();
            consultaSql = "select * from PILOTO";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            tablaSql = new DataTable();
            adaptadorSql.Fill(tablaSql);
            if (tablaSql.Rows.Count == 0) MessageBox.Show("No hay ningún piloto registrado");
            else dgvTablaBases.DataSource = tablaSql;
            conexionSql.Close();
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Agregar Piloto";
            txtId.ReadOnly = false;
            txtPrimNom.ReadOnly = false;
            txtSegNom.ReadOnly = false;
            txtPrimApe.ReadOnly = false;
            txtSegApe.ReadOnly = false;
            txtHrsVuel.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarAgregar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblBarraLateral.Text = "Editar Piloto";
            txtPrimNom.ReadOnly = false;
            txtSegNom.ReadOnly = false;
            txtPrimApe.ReadOnly = false;
            txtSegApe.ReadOnly = false;
            txtHrsVuel.ReadOnly = false;
            txtBaseId.ReadOnly = false;
            btnAceptarEditar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tablaResultante = new DataTable();
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificar del piloto", "Buscador de Pilotos", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "select * from PILOTO where PIL_ID = '" + id + "'";
            adaptadorSql = new SqlDataAdapter(consultaSql, conexionSql);
            adaptadorSql.Fill(tablaResultante);
            if (tablaResultante.Rows.Count == 0) MessageBox.Show("No se ha encontrado el piloto");
            else
            {
                restaurarBarraLateral();
                DataRow Row = tablaResultante.Rows[0];
                txtId.Text = Row["PIL_ID"].ToString();
                txtPrimNom.Text = Row["PIL_PRIMNOM"].ToString();
                txtSegNom.Text = Row["PIL_SEGNOM"].ToString();
                txtPrimApe.Text = Row["PIL_PRIMAPE"].ToString();
                txtSegApe.Text = Row["PIL_SEGNOM"].ToString();
                txtHrsVuel.Text = Row["PIL_HRSVUEL"].ToString();
                txtBaseId.Text = Row["BS_ID"].ToString();
            }
            conexionSql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            int id = int.Parse(Interaction.InputBox("Ingrese el identificador del piloto", "Eliminador de Pilotos", "", (Width / 2) + 300, (Height / 2) + 100));
            consultaSql = "delete FROM PILOTO where PIL_ID = '" + id + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            MessageBox.Show("El piloto ha sido eliminado exitosamente");
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "insert into PILOTO values ('" + txtId.Text + "','" + txtPrimNom.Text + "','" + txtSegNom.Text + "','" + txtPrimApe.Text + "','" + txtSegApe.Text+ "','" + txtHrsVuel.Text + "','" + txtBaseId.Text + "')";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El piloto se ha registado exitosamente");
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            conexionSql.Open();
            consultaSql = "update PILOTO set PIL_PRIMNOM = '" + txtPrimNom.Text + "', PIL_SEGNOM = '" + txtSegNom.Text + "', PIL_PRIMAPE = '" + txtPrimApe.Text + "', PIL_SEGAPE = '" + txtSegApe.Text + "', PIL_HRSVUEL = '" + txtHrsVuel.Text + "', BS_ID = '" + txtBaseId.Text + "' " +
                          "where PIL_ID = '" + txtId.Text + "'";
            comandoSql = new SqlCommand(consultaSql, conexionSql);
            comandoSql.ExecuteNonQuery();
            conexionSql.Close();
            actualizarTabla();
            restaurarBarraLateral();
            MessageBox.Show("El piloto se ha editado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarBarraLateral();
        }

        private void frmPiloto_Load(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void dgvTablaBases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTablaBases.SelectedCells[0].Value.ToString();
            txtPrimNom.Text = dgvTablaBases.SelectedCells[1].Value.ToString();
            txtSegNom.Text = dgvTablaBases.SelectedCells[2].Value.ToString();
            txtPrimApe.Text = dgvTablaBases.SelectedCells[3].Value.ToString();
            txtSegApe.Text = dgvTablaBases.SelectedCells[4].Value.ToString();
            txtHrsVuel.Text = dgvTablaBases.SelectedCells[5].Value.ToString();
            txtBaseId.Text = dgvTablaBases.SelectedCells[6].Value.ToString();
        }

        #endregion
    }
}
