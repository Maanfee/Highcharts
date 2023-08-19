using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public class Tooltip
    {
        [JsonProperty("valueSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueSuffix { get; set; }
    }
}
