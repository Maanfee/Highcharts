using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public class PlotOptions
    {
        #region - Column Class -

        [JsonProperty("Column", NullValueHandling = NullValueHandling.Ignore)]
        public Columns Column { get; set; }

        public class Columns
        {
            [JsonProperty("pointPadding", NullValueHandling = NullValueHandling.Ignore)]
            public float PointPadding { get; set; }

            [JsonProperty("borderWidth", NullValueHandling = NullValueHandling.Ignore)]
            public int BorderWidth { get; set; }

            [JsonProperty("colorByPoint", NullValueHandling = NullValueHandling.Ignore)]
            public bool ColorByPoint { get; set; } = false;

            [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
                public bool Enabled { get; set; } = false;

                [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
                public string Format { get; set; }
            }
        }

        #endregion

        #region - Line Class -

        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public Lines Line { get; set; }

        public class Lines
        {
            [JsonProperty("enableMouseTracking", NullValueHandling = NullValueHandling.Ignore)]
            public bool EnableMouseTracking { get; set; } = true;

            [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
                public bool Enabled { get; set; } = false;

                [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
                public string Format { get; set; }
            }
        }

        #endregion

        #region - Pie Class -

        [JsonProperty("pie", NullValueHandling = NullValueHandling.Ignore)]
        public Pies Pie { get; set; }

        public class Pies
        {
            [JsonProperty("allowPointSelect", NullValueHandling = NullValueHandling.Ignore)]
            public bool AllowPointSelect { get; set; } = true;

            [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
            public string Cursor { get; set; }

            [JsonProperty("dataLabels", NullValueHandling = NullValueHandling.Ignore)]
            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
                public bool Enabled { get; set; } = false;

                [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
                public string Format { get; set; }
            }
        }

        #endregion


        #region - Series Class -

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public Seri Series { get; set; }

        public class Seri
        {
            [JsonProperty("pointPlacement", NullValueHandling = NullValueHandling.Ignore)]
            public string PointPlacement { get; set; }
        }

        #endregion

    }
}
