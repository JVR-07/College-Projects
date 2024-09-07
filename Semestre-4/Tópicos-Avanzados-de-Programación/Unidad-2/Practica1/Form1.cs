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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Método para llamar a la segunda forma AnadirContacto con evento click
        private void smiAnadirContacto_Click(object sender, EventArgs e)
        {   //Validando que se quiera añadir un contacto nuevo
            DialogResult Respuesta = MessageBox.Show("¿Desea agregar un nuevo contacto?","Añadir Contacto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                //Creando instancia de segunda forma pasando la primera como parametro
                FrmAnadirContacto AnadirContacto = new FrmAnadirContacto(this);
                AnadirContacto.Show(); //Mostrando segunda forma
            }            
        }

        //Método para salir del programa con evento click
        private void smiSalirPrograma_Click(object sender, EventArgs e)
        {   //Se muestra un messagebox preguntandosi desea salir y se guarda la respuesta
            DialogResult Respuesta = MessageBox.Show("¿Está seguro que desea salir del programa?","Protocolo de Salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(Respuesta == DialogResult.Yes) Close(); //En cado de ser verdadera la condición, la forma principal se cierra
        }

        //Método para llamar a la tercera forma ModificarContacto con evento click
        private void smiModificarContacto_Click(object sender, EventArgs e)
        {
            //Validando que se quiera editar un contacto
            DialogResult Respuesta = MessageBox.Show("¿Desea editar un contacto existente?", "Añadir Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {   //Usando un inputbox para preguntar el id del registro a editar
                int id_cell = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de registro del contacto", "Seleccione un contacto", "Ingrese el número aquí", 500, 400));

                MessageBox.Show("PROXIMAMENTE", "COMING SOON", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                //Creando instancia de tercera forma pasando la primera como parametro
                //frmModificarContacto ModificarContacto = new frmModificarContacto(this, id_cell);
                //ModificarContacto.Show(); //Mostrando tercera forma
            }
        }

        private void smiEliminarContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE", "COMING SOON", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
