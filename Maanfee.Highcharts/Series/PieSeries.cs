namespace Maanfee.Highcharts
{
    public class PieSeries
    {
        public string Name { get; set; }

        public bool ColorByPoint { get; set; }

        public IList<PieData> Data { get; set; } = new List<PieData>();

        public class PieData
        {
            public string Name { get; set; }

            public float Y { get; set; }

            public bool Sliced { get; set; }

            public bool Selected { get; set; }
        }
    }
}
