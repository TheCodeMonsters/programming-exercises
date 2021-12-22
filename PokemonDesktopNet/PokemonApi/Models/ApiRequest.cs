using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Models
{
    public class ApiRequest
    {
        public string url { get; set; }
        public int actual = 0;
        
        public ApiRequest() 
        {
            url = "https://pokeapi.co/api/v2/pokemon?limit=6&offset=0";
        }

        public Pokelista obtenerLista() 
        {
            var consulta = (HttpWebRequest)WebRequest.Create(url + actual);
            consulta.Method = "GET";
            consulta.ContentType = "application/json";
            consulta.Accept = "application/json";

            try 
            {
                using (WebResponse response = consulta.GetResponse()) 
                {
                    using (Stream stream = response.GetResponseStream()) 
                    {
                        if (stream == null) 
                        {
                            return null;
                        }
                        using (StreamReader lector = new StreamReader(stream)) 
                        {
                            string responseTexto = lector.ReadToEnd();
                            Pokelista pokelista = JsonConvert.DeserializeObject<Pokelista>(responseTexto);
                            actual = 10;
                            return pokelista;

                        }
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }

        }
    }
}
