using Newtonsoft.Json;

namespace Maanfee.Highcharts
{
    public class XAxis
    {
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Categories { get; set; } = new List<object>();

        [JsonProperty("crosshair", NullValueHandling = NullValueHandling.Ignore)]
        public bool Crosshair { get; set; } = true;

        #region - Accessibility Class -

        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Accessibilities Accessibility { get; set; }

        public class Accessibilities
        {
            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }
        }

        #endregion

    }
}
