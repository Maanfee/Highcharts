using Newtonsoft.Json;
using System.ComponentModel;

namespace Maanfee.Highcharts
{
    public class PieSeries
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("colorByPoint", NullValueHandling = NullValueHandling.Ignore)]
        public bool ColorByPoint { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IList<PieData> Data { get; set; } = new List<PieData>();

        public class PieData
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
            public float Y { get; set; }

            [JsonProperty("sliced", NullValueHandling = NullValueHandling.Ignore)]
            public bool Sliced { get; set; }

            [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
            public bool Selected { get; set; }

        }
    }
}
