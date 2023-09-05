using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Maanfee.Highcharts
{
    public class ChartConfiguration 
    {
        #region - Chart Class -

        [JsonProperty("chart", NullValueHandling = NullValueHandling.Ignore)]
        public Charts Chart { get; set; }

        public class Charts
        {
            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type { get; set; }

            #region - Style Class -

            [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
            public Styles Style { get; set; }

            public class Styles
            {
                [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
                public string FontFamily { get; set; }
            }

            #endregion
        }

        #endregion

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title Title { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public SubTitle SubTitle { get; set; }

        [JsonProperty("xAxis", NullValueHandling = NullValueHandling.Ignore)]
        public XAxis XAxis { get; set; }

        [JsonProperty("yAxis", NullValueHandling = NullValueHandling.Ignore)]
        public YAxis YAxis { get; set; }

        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip Tooltip { get; set; }

        [JsonProperty("plotOptions", NullValueHandling = NullValueHandling.Ignore)]
        public PlotOptions PlotOptions { get; set; }

        [JsonProperty("columnSeries", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnSeries> ColumnSeries { get; set; } = new List<ColumnSeries>();

        [JsonProperty("lineSeries", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineSeries> LineSeries { get; set; } = new List<LineSeries>();

        [JsonProperty("pieSeries", NullValueHandling = NullValueHandling.Ignore)]
        public List<PieSeries> PieSeries { get; set; } = new List<PieSeries>();

    }
}
