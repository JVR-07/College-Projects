using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class frmModificarContacto : Form
    {
        Form1 forma1;
        int n;
        public frmModificarContacto(Form1 forma1, int id_cell)
        {
            InitializeComponent();
            this.forma1 = forma1;
            n = id_cell;
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            //Asignando los valores de los textboxs a sus respectivas celdas
            forma1.dgvContactos.Rows[n].Cells[0].Value = (n + 1).ToString();
            forma1.dgvContactos.Rows[n].Cells[1].Value = txtbxNombre.Text;
            forma1.dgvContactos.Rows[n].Cells[2].Value = txtbxTelefono.Text;
            forma1.dgvContactos.Rows[n].Cells[3].Value = dtpFechaNacimiento.Text;
            forma1.dgvContactos.Rows[n].Cells[4].Value = txtbxRedSocial.Text;

            //Cerrando la segunda forma
            Close();
        }
    }
}
