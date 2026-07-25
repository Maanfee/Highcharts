namespace Maanfee.Highcharts
{
    public class PlotOptions
    {
        #region - Column Class -

       public Columns Column { get; set; }

        public class Columns
        {
            public float PointPadding { get; set; }

            public int BorderWidth { get; set; }

            public bool ColorByPoint { get; set; } = false;

            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                public bool Enabled { get; set; } = false;

                public string Format { get; set; }
            }
        }

        #endregion

        #region - Line Class -

        public Lines Line { get; set; }

        public class Lines
        {
            public bool EnableMouseTracking { get; set; } = true;

            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                public bool Enabled { get; set; } = false;

                public string Format { get; set; }
            }
        }

        #endregion

        #region - Pie Class -

        public Pies Pie { get; set; }

        public class Pies
        {
            public bool AllowPointSelect { get; set; } = true;

            public string Cursor { get; set; }

            public DataLabel DataLabels { get; set; }

            public class DataLabel
            {
                public bool Enabled { get; set; } = false;

                public string Format { get; set; }
            }

            public int StartAngle { get; set; }

            public int EndAngle { get; set; }

            public string InnerSize { get; set; }
        }

        #endregion


        #region - Series Class -

        public Seri Series { get; set; }

        public class Seri
        {
            public string PointPlacement { get; set; }
        }

        #endregion

    }
}
