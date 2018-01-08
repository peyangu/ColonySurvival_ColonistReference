using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ColonySurvivalColonistReference.Model;

namespace ColonySurvivalColonistReference.Json
{
    public static class JsonUtil
    {
        public static List<Localhost> ReadJSON(string jsonText)
        {
            return JsonConvert.DeserializeObject<List<Localhost>>(jsonText);
        }
    }
}
