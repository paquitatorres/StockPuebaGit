using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        //Id de Sql 
       // public int Id { get; set; }


        public string CodigoArticulo { get; set; }

        public string Nombre { get; set; }

        public string Descripción { get; set; }

        //Voy a querer traer una lista desplegable de Marca
        public string Marca { get; set; }
        
        //tanto Marca como Categoria tienen un ID 
        public string Categoria {  get; set; }

        public string Imagen { get; set;}

        public decimal Precio { get; set; }


    }
}
