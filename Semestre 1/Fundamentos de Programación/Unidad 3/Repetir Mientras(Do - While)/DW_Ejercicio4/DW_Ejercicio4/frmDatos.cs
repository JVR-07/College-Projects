using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio4
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            txtName.Clear();
            txtName.Focus();
            txtDep.Clear();
            txtDep.Focus();
            txtCode.Clear();
            txtCode.Focus();
            txtHorasT.Clear();
            txtHorasT.Focus();
            txtSxH.Clear();
            txtSxH.Focus();
        }
    }
}
