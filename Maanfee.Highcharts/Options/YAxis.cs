using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public class YAxis
    {
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int Min { get; set; } = 0;

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public AxisTitle Title { get; set; }

        public class AxisTitle
        {
            [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
            public string Text { get; set; }

            //[JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
            //public string Align { get; set; } = "center";

            //[JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
            //public string VerticalAlign { get; set; } = "top";
        }

    }
}
