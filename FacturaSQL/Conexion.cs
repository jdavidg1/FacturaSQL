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
            {   //Creación del objeto
                cn = new SqlConnection("Data Source=LAPTOP-9VN6QT9R\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");
                cn.Open();
                //using System.Windows.Forms; 
                MessageBox.Show("Conectado");
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos" + ex.Message);
            }
            
        }

        // Procedimiento para registra una persona

        public string insertar(int id, string nombre, string apellido, string fecha)
        {
            string salida = "Si se incerto";

            try
            {
                //comando SQL

                cmd = new SqlCommand("Insert into Persona(Id,Nombre,Apellidos,FechaNacimiento) values (" + id + ",'" + nombre + "','" + apellido + "','" + fecha + "')", cn);

                cmd.ExecuteNonQuery();      //Comanto para ejecutar la sentencia SQL

            }
            catch (Exception ex)
            {
                salida = "No se conectó " + ex.Message;

            }


            return salida;

        }


        //Validar que lo que se va a insertar no esté en la base de datos; 13:11
        
        public int personaRegistrada (int id)
        {
            int contador = 0;

            try
            {
                //comando SQL

                cmd = new SqlCommand("Select * from Persona WHERE Id = "+id+"", cn);

                dr = cmd.ExecuteReader();

                while(dr.Read())            //Incrementar el datareader
                {
                    contador++;                    
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.Message);
            }
            
            return contador;

        }

        // TERMINA EN 18:39

        public string eliminar(int id)
        {
            string salida = "Ha sido borrado";
            try
            {
                cmd = new SqlCommand("Delete from Persona where Id=" + id + "", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo borrar:" + ex.ToString();
            }
            return salida;
        }





    }
}
