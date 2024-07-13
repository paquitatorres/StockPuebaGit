using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Negocio
{
    public class ArticulosNegocio
    {

        public List <Articulos> Listar()
        {
           List<Articulos> lista = new List<Articulos>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando= new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server =.\\SQLEXPRESS;  Initial Catalog=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, nombre , descripcion , ImagenUrl, Precio from articulos;";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                  

                    Articulos art = new Articulos();
                    
                    
                    art.CodigoArticulo = (string)lector["Codigo"] ;
                    art.Nombre = (string)lector["Nombre"];
                    art.Descripción = (string)lector["descripcion"];
                    art.Imagen = (string)lector["ImagenUrl"];
                    art.Precio = Math.Round((lector.GetDecimal(4)),2); 
                   
                    lista.Add(art); 
                }


                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }









    }
}
