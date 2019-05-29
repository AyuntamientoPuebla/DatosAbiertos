using AppConsolaDemo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsolaDemo
{
    class Program
    {
        /// <summary>
        /// Url del recurso en el portal de datos abiertos.
        /// - Puedes establecer el límite de información a 
        /// obtener con el parámetro &limit=NroDeRegistros
        /// - Si deseas obtener todos los registros establece 
        /// el parámetro en cero: &limit=0
        /// </summary>
        public const string UrlAfluenciaTuristica = "http://datos.pueblacapital.gob.mx/api/action/datastore/search.json?resource_id=7bf6536b-d40d-4862-bbaa-1492808691a7&limit=5";
        static void Main(string[] args)
        {
            Afluencia afluenciaTuristica = new Servicios.ServicioAfluenciaTuristica().Obtener(UrlAfluenciaTuristica);

            int TotalTuristas2010 = 0;

            foreach (Entidades.Registro registroAfluencia in afluenciaTuristica.Resultado.records)
            {
                TotalTuristas2010 = TotalTuristas2010 + Convert.ToInt32(registroAfluencia.LlegadaDeTuristas);
            }

            // puedes dar formato para separar unidades de millar
            // en msdn, existen muchos string formats que puedes usar dependendiendo del valor que quieres mostrar
            Console.WriteLine("El total de turistas registrados en el año 2010 en {0} ciudades de Puebla es: {1}", afluenciaTuristica.Resultado.records.Count(), string.Format("{0:n0}", TotalTuristas2010));
            Console.ReadKey();
        }
    }
}
