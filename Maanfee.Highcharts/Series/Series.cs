using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Maanfee.Highcharts
{
    public class Series
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IList<object> Data { get; set; } = new List<object>();

        [JsonProperty("pointPlacement", NullValueHandling = NullValueHandling.Ignore)]
        public string PointPlacement { get; set; }

        [Browsable(true)]
        [Display(Name = "Employee Name")]
        [Category("Pie")]
        [Description("Pie")]
        [JsonProperty("colorByPoint", NullValueHandling = NullValueHandling.Ignore)]
        public bool ColorByPoint { get; set; } 

    }
}
