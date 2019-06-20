using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql: IArchivos<Queue<Patente>>
    {
        public static String connectionSTR = "Data Source=LAB3PC21\\SQLEXPRESS; Initial Catalog= patentes-sp-2018; Integred Security= True";
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            conexion = new SqlConnection(connectionSTR);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            String consulta;
            foreach(Patente p in datos)
            {
                consulta = String.Format("INSERT INTO tabla (patente,tipo) VALUES({0},{1})", p.CodigoPatente, p.TipoCodigo);
                comando.CommandText = consulta;
            }
                   
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = null;
            string auxPatente;
            string auxTipo;
            Patente p;
            comando.CommandText = "SELECT patente,tipo FROM tabla";
            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();
            while(oDr.Read())
            {
                auxPatente = oDr["patente"].ToString();
                auxTipo = oDr["tipo"].ToString();
                if(auxPatente == "Vieja")
                {
                    p = new Patente(auxPatente, Patente.Tipo.Vieja);
                    datos.Enqueue(p);
                }
                else
                {
                    p = new Patente(auxPatente, Patente.Tipo.Mercosur);
                    datos.Enqueue(p);
                }
            }
        }
    }
}
