using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsolaDemo.Entidades
{
    public class Afluencia
    {
        public Afluencia()
        {
            Resultado = new Resultado();
        }
        //Si lo deseas, puedes omitir propiedades que no te interesan deserializar

        //public string help { get; set; }
        //public bool success { get; set; }
        [Newtonsoft.Json.JsonProperty("result")]
        public Resultado Resultado { get; set; }
    }
}
