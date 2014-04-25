using System;
using System.Collections.Generic;
using System.Web.UI;
using HighchartsSbs.Model;

namespace HighchartsSbs.Demo
{
    public partial class Demo1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var high = new HighchartViewModel
                {
                    chart = new ChartViewModel { type = "line" },
                    title = new TitleViewModel { text = "Prueba Melsi" },
                    xAxis = new AxisViewModel { categories = new List<string> { "Enero", "Febrero", "Marzo" }, title = new TitleViewModel { text = "Meses" } },
                    yAxis = new AxisViewModel { title = new TitleViewModel { text = "Monto" } },
                    series =
                        new List<SerieViewModel>
                    {
                        new SerieViewModel {name = "Melsi", data = new List<double> {1, 2, 3}},
                        new SerieViewModel {name = "Roberto", data = new List<double> {2, 3, 4}}
                    }
                };
                var cadenaChart = high.GetSerialized();
                var script = string.Format(@"<script>$(function () {{$('#container').highcharts({0});}});</script>", cadenaChart);
                ltrChart.Text = script;
            }
        }
    }
}