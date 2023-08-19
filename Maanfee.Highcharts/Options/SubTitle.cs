using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public class SubTitle
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public string Align { get; set; } = "center";

        [JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string VerticalAlign { get; set; } = "top";
    }
}
