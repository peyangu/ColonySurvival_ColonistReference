using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonySurvivalColonistReference.Model
{
    public class NPC
    {
        public int Id { get; set; }
        public Inventory Inventory { get; set; }
        public Position Position { get; set; }
        public int Storedfood { get; set; }
        public string Type { get; set; }
    }

    public class Rootobject
    {
        public Localhost[] Localhost { get; set; }
    }

    public class Localhost
    {
        public int id { get; set; }
        public Inventory inventory { get; set; }
        public Position position { get; set; }
        public float storedfood { get; set; }
        public string type { get; set; }
    }

    public class Inventory
    {
        public float capacity { get; set; }
        public Content[] content { get; set; }
    }

    public class Content
    {
        public int amount { get; set; }
        public string type { get; set; }
    }

    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

}
