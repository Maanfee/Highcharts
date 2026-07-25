namespace Maanfee.Highcharts
{
    public abstract class BaseSeries 
    {
        public string Name { get; set; }

        public IList<object> Data { get; set; } = new List<object>();

        public string PointPlacement { get; set; }
    }
}
