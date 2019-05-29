using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsolaDemo.Entidades
{
    /// <summary>
    /// Toda información que se obtenga a través de la API que se publica en el portal de datos abiertos 
    /// tiene la estructura principal de esta clase.
    /// Únicamente cambia la clase Registro según la información.
    /// 
    /// La información públicada en el portal tiene la estructura que establecida por los lineamientos que 
    /// definen la información como datos abiertos, sin embargo, esta misma característica, es útil para 
    /// ser descargada pero no siempre para ser analizada de manera automática. 
    /// Un ejemplo claro podemos ver que las columnas de los años de la afluencia de visitantes turísticos 
    /// es número que representa el año, 2010, 2011, 2012...
    /// Estos valores no pueden convertirse en propiedades de una clase ya que son números, para esto es 
    /// necesario renombrar estas propiedades y asignarle el nombre real del archivo JSON lo que permite 
    /// que la librería que deserializa el archivo JSON deposite en información en la propiedad que 
    /// queremos.
    /// </summary>
    public class Resultado
    {
        public Resultado()
        {
            records = new Registro[] { };
        }
        //public Field[] fields { get; set; }
        public string[] resource_id { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        [Newtonsoft.Json.JsonProperty("records")]
        public Registro[] records { get; set; }
        //public string sql { get; set; }
    }
}
