using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio1
{
    public partial class frmEdades : Form
    {
        public frmEdades()
        {
            InitializeComponent();
        }

        private void frmEdades_Load(object sender, EventArgs e)
        {
            txtedades.Clear() ;
            txtedades.Focus() ;
        }
    }
}
