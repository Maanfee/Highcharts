namespace Maanfee.Highcharts
{
    public class XAxis
    {
        public IEnumerable<object> Categories { get; set; } = new List<object>();

        public bool Crosshair { get; set; } = true;

        #region - Accessibility Class -

        public Accessibilities Accessibility { get; set; }

        public class Accessibilities
        {
            public string Description { get; set; }
        }

        #endregion

    }
}
