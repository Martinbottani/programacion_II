using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio61
{
    class PersonaDAO
    {
        public static String connectionSTR = "Data Source=LAB3PC21\\SQLEXPRESS; Initial Catalog= Persona; Integred Security= True";
        public static SqlConnection conexion;
        public static SqlCommand comando;
        

        public PersonaDAO()
        {
            conexion = new SqlConnection(connectionSTR);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Guardar(Persona p)
        {
            String consulta;
            consulta = String.Format("INSERT INTO dbo.Personilla (Nombre,Apellido) VALUES({0},{1})", p.Nombre, p.Apellido);

            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public static void Modificar(Persona p)
        {
            String consulta;
            consulta = String.Format("UPDATE dbo.Personilla SET Nombre = {0}, Apellido = {1} WHERE ID = {2}", p.Nombre, p.Apellido, p.ID);

            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public static void Borrar(Persona p)
        {
            String consulta;
            consulta = String.Format("DELETE FROM dbo.Personilla WHERE id = {0}", p.ID);

            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            string id;
            int auxID = 0;
            comando.CommandText = "SELECT ID,Nombre,Apellido FROM dbo.Personillas";
            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            while (oDr.Read())
            {
                string auxNombre = oDr["Nombre"].ToString();
                string auxApellido = oDr["Apellido"].ToString();
                int.TryParse(id = oDr["ID"].ToString(), out auxID);
                Persona p = new Persona(auxID, auxNombre, auxApellido);
                personas.Add(p);
            }
            return personas;
        }

        public static Persona LeerPorID(int id)
        {
            Persona p;
            string strId;
            int auxID = 0;
            comando.CommandText = String.Format("SELECT ID,Nombre,Apellido FROM dbo.Personillas WHERE ID = {0}", id);
            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            if (oDr.Read())
            {
                string auxNombre = oDr["Nombre"].ToString();
                string auxApellido = oDr["Apellido"].ToString();
                int.TryParse(strId = oDr["ID"].ToString(), out auxID);
                p = new Persona(auxID, auxNombre, auxApellido);
                
            }else
            {
                p = null;
            }
            return p;
        }
    }
}
