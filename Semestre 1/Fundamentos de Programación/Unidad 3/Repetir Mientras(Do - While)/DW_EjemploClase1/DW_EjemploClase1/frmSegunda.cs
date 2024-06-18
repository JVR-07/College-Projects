using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_EjemploClase1
{
    public partial class frmSegunda : Form
    {
        public frmSegunda()
        {
            InitializeComponent();
        }

        private void frmSegunda_Load(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
        }
    }
}
