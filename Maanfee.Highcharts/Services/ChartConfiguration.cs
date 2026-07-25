namespace Maanfee.Highcharts
{
    public class ChartConfiguration 
    {
        #region - Chart Class -

        public Charts Chart { get; set; }

        public class Charts
        {
            public string Type { get; set; }

            #region - Style Class -

            public Styles Style { get; set; }

            public class Styles
            {
                public string FontFamily { get; set; }
            }

            #endregion
        }

        #endregion

        public Title Title { get; set; }

        public SubTitle SubTitle { get; set; }

        public XAxis XAxis { get; set; }

        public YAxis YAxis { get; set; }

        public Tooltip Tooltip { get; set; }

        public PlotOptions PlotOptions { get; set; }

        public List<ColumnSeries> ColumnSeries { get; set; } = new List<ColumnSeries>();

        public List<LineSeries> LineSeries { get; set; } = new List<LineSeries>();

        public List<PieSeries> PieSeries { get; set; } = new List<PieSeries>();
    }
}
