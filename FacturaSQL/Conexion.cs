using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;             //Para poder usar el message.box



namespace FacturaSQL
{
    class Conexion
    {
        //Declaración de variables

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        //Crear el constructor de la clase el cual debe tener el mismo nombre de la clase

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-9VN6QT9R\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");


            }

            catch(Exception ex)
            {

                MessageBox.Show("No se conecto con la base de datos" + ex.Message);
           //     MessageBox.Show("No se conecto con la base de datos" + ex.ToString());


            }


        }



    }
}
