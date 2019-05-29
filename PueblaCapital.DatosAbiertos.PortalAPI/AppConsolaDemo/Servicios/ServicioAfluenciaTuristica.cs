using AppConsolaDemo.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AppConsolaDemo.Servicios
{
    /// <summary>
    /// El siguiente ejemplo es una de las formas de como podemos consumir datos 
    /// en formato json y como podemos descerializarlos para hacer nuestro análisis
    /// </summary>
    public class ServicioAfluenciaTuristica
    {
        /// <summary>
        /// Obtiene los datos referentes a la afluencia turística publicados en el
        /// portal de datos abiertos
        /// </summary>
        /// <param name="apiUrl">Url del recurso en el portal de datos abiertos.
        /// Puedes establecer el límite de información a obtener con el parámetro &limit=NroDeRegistros
        /// Si deseas obtener todos los registros establece el parámetro en cero: &limit=0
        /// </param>
        /// <returns>Afluencia turistica en Puebla</returns>
        public Afluencia Obtener(string apiUrl)
        {

            Afluencia afluencia;
            string json;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
                afluencia = JsonConvert.DeserializeObject<Afluencia>(json);
            }

            return afluencia;
        }
    }
}
