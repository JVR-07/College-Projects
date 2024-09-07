using System;
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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btnDesaparecerlo_Click(object sender, EventArgs e)
        { 
            btnDesaparecer.Visible = false;
        }

        private void btnAparecerlo_Click(object sender, EventArgs e)
        {
            btnDesaparecer.Visible = true;
        }

        private void btnBloquearControl_Click(object sender, EventArgs e)
        {
            txtbxTextoPrincipal.Enabled = true;
            btnDesaparecer.Enabled = false;
            btnAparecerlo.Enabled = false;
            btnBloquearControl.Enabled = false;
            cbColorFuente.Enabled = false;
            txtbxTextoSecundario.Enabled = false;
            btnCambiarColorLetra.Enabled = false;
            btnCambiarColorFondo.Enabled = false;
            btnEnviarTexto.Enabled = false;

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            txtbxTextoPrincipal.Enabled = true;
            btnDesaparecer.Enabled = true;
            btnAparecerlo.Enabled = true;
            btnBloquearControl.Enabled = true;
            cbColorFuente.Enabled = true;
            txtbxTextoSecundario.Enabled = true;
            btnCambiarColorLetra.Enabled = true;
            btnCambiarColorFondo.Enabled = true;
            btnEnviarTexto.Enabled = true;
        }

        private void btnEnviarTexto_Click(object sender, EventArgs e)
        {
            if (this.txtbxTextoSecundario.Text == String.Empty) MessageBox.Show("No se ha encontrado ningún texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string texto = this.txtbxTextoSecundario.Text;
                this.txtbxTextoPrincipal.Text = texto;
                this.txtbxTextoSecundario.Text = String.Empty;
                MessageBox.Show("Se ha enviado el texto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCambiarColorLetra_Click(object sender, EventArgs e)
        {
            switch (cbColorFuente.Text)
            {
                case "Ligth Golden Yellow":
                    {
                        txtbxTextoPrincipal.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnDesaparecer.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnAparecerlo.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnCambiarColorLetra.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnCambiarColorFondo.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnBloquearControl.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnDesbloquear.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnEnviarTexto.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                        btnLimpiar.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
                    }
                    break;
                case "Forest Green":
                    {
                        txtbxTextoPrincipal.ForeColor = System.Drawing.Color.ForestGreen;
                        btnDesaparecer.ForeColor = System.Drawing.Color.ForestGreen;
                        btnAparecerlo.ForeColor = System.Drawing.Color.ForestGreen;
                        btnCambiarColorLetra.ForeColor = System.Drawing.Color.ForestGreen;
                        btnCambiarColorFondo.ForeColor = System.Drawing.Color.ForestGreen;
                        btnBloquearControl.ForeColor = System.Drawing.Color.ForestGreen;
                        btnDesbloquear.ForeColor = System.Drawing.Color.ForestGreen;
                        btnEnviarTexto.ForeColor = System.Drawing.Color.ForestGreen;
                        btnLimpiar.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    break;
                case "Medium Slate Blue":
                    {
                        txtbxTextoPrincipal.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnDesaparecer.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnAparecerlo.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnCambiarColorLetra.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnCambiarColorFondo.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnBloquearControl.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnDesbloquear.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnEnviarTexto.ForeColor = System.Drawing.Color.MediumSlateBlue;
                        btnLimpiar.ForeColor = System.Drawing.Color.MediumSlateBlue;
                    }
                    break;
                case "Pale Turquoise":
                    {
                        txtbxTextoPrincipal.ForeColor = System.Drawing.Color.PaleTurquoise; 
                        btnDesaparecer.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnAparecerlo.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnCambiarColorLetra.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnCambiarColorFondo.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnBloquearControl.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnDesbloquear.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnEnviarTexto.ForeColor = System.Drawing.Color.PaleTurquoise;
                        btnLimpiar.ForeColor = System.Drawing.Color.PaleTurquoise;
                    }
                    break;
                case "Hot Pink":
                    {
                        txtbxTextoPrincipal.ForeColor = System.Drawing.Color.HotPink;
                        btnDesaparecer.ForeColor = System.Drawing.Color.HotPink;
                        btnAparecerlo.ForeColor = System.Drawing.Color.HotPink;
                        btnCambiarColorLetra.ForeColor = System.Drawing.Color.HotPink;
                        btnCambiarColorFondo.ForeColor = System.Drawing.Color.HotPink;
                        btnBloquearControl.ForeColor = System.Drawing.Color.HotPink;
                        btnDesbloquear.ForeColor = System.Drawing.Color.HotPink;
                        btnEnviarTexto.ForeColor = System.Drawing.Color.HotPink;
                        btnLimpiar.ForeColor = System.Drawing.Color.HotPink;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("EL valor no es válido", "Color inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void btnCambiarColorFondo_Click(object sender, EventArgs e)
        {
            switch (cbColorFuente.Text)
            {
                case "Ligth Golden Yellow":
                    {
                        txtbxTextoPrincipal.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    }
                    break;  
                case "Forest Green":
                    {
                        txtbxTextoPrincipal.BackColor = System.Drawing.Color.ForestGreen;
                    }
                    break;
                case "Medium Slate Blue":
                    {
                        txtbxTextoPrincipal.BackColor = System.Drawing.Color.MediumSlateBlue;
                    }
                    break;
                case "Pale Turquoise":
                    {
                        txtbxTextoPrincipal.BackColor = System.Drawing.Color.PaleTurquoise;
                    }
                    break;
                case "Hot Pink":
                    {
                        txtbxTextoPrincipal.BackColor = System.Drawing.Color.HotPink;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("EL valor no es válido","Color inexistente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnAparecerlo_Click(sender, e);
            btnDesbloquear_Click(sender, e);

            txtbxTextoPrincipal.Text = String.Empty;
            txtbxTextoPrincipal.BackColor = System.Drawing.Color.White;
            txtbxTextoPrincipal.ForeColor = System.Drawing.Color.Black;
            txtbxTextoSecundario.Text = string.Empty;
            txtbxTextoSecundario.BackColor = System.Drawing.Color.White;
            txtbxTextoSecundario.ForeColor = System.Drawing.Color.Black;


            btnEnviarTexto_Click(sender, e);

            cbColorFuente.Text = String.Empty;
            txtbxTextoPrincipal.Text = String.Empty;
        }

    }
}
