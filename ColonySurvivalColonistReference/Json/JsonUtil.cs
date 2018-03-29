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
        public static List<NPC.Localhost> ReadJSONFromNPC(string jsonText)
        {
            return JsonConvert.DeserializeObject<List<NPC.Localhost>>(jsonText);
        }

        public static List<ConstructionAreas.Localhost> ReadJSONFromConstruction(string jsonText)
        {
            return JsonConvert.DeserializeObject<List<ConstructionAreas.Localhost>>(jsonText);
        }
    }
}
