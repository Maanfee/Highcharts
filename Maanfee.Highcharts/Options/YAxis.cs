namespace Maanfee.Highcharts
{
    public class YAxis
    {
        public int Min { get; set; } = 0;

        public AxisTitle Title { get; set; }

        public class AxisTitle
        {
            public string Text { get; set; }

            //[JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
            //public string Align { get; set; } = "center";

            //[JsonProperty("verticalAlign", NullValueHandling = NullValueHandling.Ignore)]
            //public string VerticalAlign { get; set; } = "top";
        }

    }
}
