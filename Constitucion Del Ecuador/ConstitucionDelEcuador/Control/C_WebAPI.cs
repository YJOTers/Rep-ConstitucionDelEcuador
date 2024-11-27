using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using ConstitucionDelEcuador.Entidad;
using System.Threading.Tasks;

namespace ConstitucionDelEcuador.Control
{
    public class C_WebAPI
    {
        const string URL = "https://app-e5986904-f51d-4cb4-a3c9-aa35ed721efb.cleverapps.io/api/";

        public async Task<List<E_Articulos>> VerTodosLosArticulos()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri($"{URL}verTodosLosArticulos/");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept","application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK) 
            {
                string contenido = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<E_Articulos>>(contenido);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<E_Articulos>> BuscarArticulo(string articulo)
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri($"{URL}buscarArticulo/{articulo}");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string contenido = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<E_Articulos>>(contenido);
            }
            else
            {
                return null;
            }
        }
    }
}

