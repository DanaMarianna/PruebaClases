using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.Clases
{
    public class Maquina
    {
        public string IdMaquina { get; set; }
        public string Descripcion { get; set; }
        public List<string> ListaProductos { get; set; }
        //TandaMinima siendo un double por las decimales
        public double TandaMinima { get; set; }

        public Maquina () { }
        public Maquina (Maquina maquina)

        {
            IdMaquina= maquina.IdMaquina;
            Descripcion= maquina.Descripcion;
            TandaMinima = maquina.TandaMinima;
        }

    }
}
