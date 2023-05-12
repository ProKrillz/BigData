using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigData.JsonToCsharp
{
    public class Feature
    {
        public Geometry geometry { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string rel { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Properties
    {
        public DateTime created { get; set; }
        public DateTime observed { get; set; }
        public string parameterId { get; set; }
        public string stationId { get; set; }
        public double value { get; set; }
    }

    public class Root
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
        public DateTime timeStamp { get; set; }
        public int numberReturned { get; set; }
        public List<Link> links { get; set; }
    }
}
