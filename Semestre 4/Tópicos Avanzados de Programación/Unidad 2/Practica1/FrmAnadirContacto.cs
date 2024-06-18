using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FrmAnadirContacto : Form
    {   //Instancia de la forma Main
        protected Form1 forma1;

        //Constructor de la clase
        public FrmAnadirContacto(Form1 forma1)
        {
            InitializeComponent();
            this.forma1 = forma1;//Se pasa la instancia de la primera forma como parametro en el constructor
        }

        //Método para el evento Click
        public void btnAnadirContacto_Click(object sender, EventArgs e)
        {   //Obteniendo el número de la fila o renglón
            int n = forma1.dgvContactos.Rows.Add();

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
