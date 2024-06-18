using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio2
{
    public partial class frmNum : Form
    {
        public frmNum()
        {
            InitializeComponent();
        }

        private void frmNum_Load(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtnum.Focus();
        }
    }
}
