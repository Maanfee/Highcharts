using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public abstract class BaseSeries 
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Data { get; set; } = new List<object>();

        [JsonProperty("pointPlacement", NullValueHandling = NullValueHandling.Ignore)]
        public string PointPlacement { get; set; }
    }
}
