﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnModificarPropiedades_Click(object sender, EventArgs e)
        {
            form2 forma2 = new form2();
            forma2.Show();
            
        }
    }
}
