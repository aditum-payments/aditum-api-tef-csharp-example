using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace example_csharp_api_tef.service.util
{
    public static class Mapper<T>
    {
        public static StringContent Convert(T objectToConvert)
        {
            var json = JsonConvert.SerializeObject(objectToConvert);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }
    }
}