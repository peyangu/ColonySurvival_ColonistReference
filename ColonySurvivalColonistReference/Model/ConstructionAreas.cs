using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonySurvivalColonistReference.Model
{
    public class ConstructionAreas
    {
        public class Rootobject
        {
            public Table table { get; set; }
            public int version { get; set; }
        }

        public class Table
        {
            public Localhost[] Localhost { get; set; }
        }

        public class Localhost
        {
            public Arguments arguments { get; set; }
            public Max max { get; set; }
            public Min min { get; set; }
        }

        public class Arguments
        {
            public string builderBlockType { get; set; }
            public string constructionType { get; set; }
        }

        public class Max
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
        }

        public class Min
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
        }
    }
}