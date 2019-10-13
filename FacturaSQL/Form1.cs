using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaSQL
{
    public partial class Form1 : Form
    {

        Conexion c = new Conexion();            //Variable conexión que permite acceder a todos los métodos creados.
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnRegistrar.Checked = true;
            //Se crea una instancia y se llama al constructor
            Conexion c = new Conexion();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            {
                                     
                MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text)); //datetimepicker, pendiente data greep view

            }

        }
    }
}
