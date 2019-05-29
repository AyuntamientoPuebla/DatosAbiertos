using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsolaDemo.Entidades
{
    /// <summary>
    /// Información particular del dato a consumir
    /// </summary>
    public class Registro
    {
        [JsonProperty("Año")]
        public string Anio { get; set; }
        [JsonProperty("Mes")]
        public string Mes { get; set; }
        [JsonProperty("Porcentaje de estadía promedio")]
        public string PorcentajeEestadiaPromedio { get; set; }
        [JsonProperty("Llegada de turistas")]
        public string LlegadaDeTuristas { get; set; }
    }
}
