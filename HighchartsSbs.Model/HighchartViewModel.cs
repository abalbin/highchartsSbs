using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HighchartsSbs.Model
{
    public class HighchartViewModel
    {
        public ChartViewModel chart { get; set; }
        public TitleViewModel title { get; set; }
        public AxisViewModel xAxis { get; set; }
        public AxisViewModel yAxis { get; set; }
        public List<SerieViewModel> series { get; set; }

        public string GetSerialized()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
