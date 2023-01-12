using PruebaClases.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.MetodoAlgoritmos
{
    public class AlgoritmoInicio
    {
        public object ListaDemandas { get; private set; }

        //Objetivo: Método realizará el promedio de una lista de demandas
        public double CalcularMedia(List<Demanda> ListaDemandas)
        {
            //Paso 1: Declarar variables y setearlas
            double media = 0, suma = 0;
            //Paso 2: Calcular la variable suma
            foreach (Demanda demanda2 in ListaDemandas)
            {
                suma = suma + demanda2.CantidadRequerida;
            }
            //Paso 3: Dividir entre total de datos
            if (ListaDemandas.Count() > 0)
            {
                media = suma / ListaDemandas.Count();
            }
            return media;
        }
        public void LlenarDatosAleatorios(int numerodatos)
        {
            Random aleatorio = new Random(Environment.TickCount);
            for (int i = 0; i < numerodatos; i++)
            {
                double value = (double) aleatorio.Next(100, 999) / 1000000;
                double value2 = aleatorio.Next(0, 200);
                Demanda demanda = new Demanda();
                demanda.IdDemanda = i.ToString();
                demanda.CantidadRequerida = value2;
                ListaDemandas.Add(demanda);
                //Error en línea 42
            }
        }
    }
}