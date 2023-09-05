// https://code.highcharts.com/
// _content/Maanfee.Highcharts/JsInterop.js
// _content/Maanfee.Highcharts/HighCharts.js

function AddScript(Url) {
    var js = document.createElement("script");

    js.type = "text/javascript";
    js.src = Url;

    document.body.appendChild(js);

    return js;
}

function RemoveScript(Url) {

    var element = document.querySelector('script[src="' + Url + '"]');
    if (typeof (element) != 'undefined' && element != null) {
        // Exists.
        element.parentNode.removeChild(element);
    }

}

let selector;

export function Generate(chartOptions, IsDefaultFont) {

    RemoveScript("_content/Maanfee.Highcharts/HighCharts.js");

    // **************
    // Load HighCharts.js
    AddScript("_content/Maanfee.Highcharts/HighCharts.js").addEventListener('load', () => {

        var obj = JSON.parse(chartOptions);
        //alert(chartOptions);

        Highcharts.chart(selector, obj);

        if (!IsDefaultFont) {

            const fontFamily = window.getComputedStyle(document.getElementById(selector)).fontFamily;

            let AllHighcharts = document.getElementsByClassName('highcharts-root');
            Array.from(AllHighcharts).forEach((el) => {
                el.style.fontFamily = fontFamily;
            });

            //alert(fontFamily);
        }

        //Highcharts.chart(selector, {
        //    chart: {
        //        type: chartType
        //    },
        //    title: {
        //        text: obj["title"]["text"],
        //        align: obj["title"]["align"],
        //    },
        //    subtitle: {
        //        text: obj["subTitle"]["text"],
        //        align: obj["subTitle"]["align"],
        //    },
        //    xAxis: {
        //        categories: obj["xAxis"]["categories"],
        //        crosshair: obj["xAxis"]["crosshair"],
        //        accessibility: {
        //            description: obj["xAxis"]["accessibility"]["description"],
        //        }
        //    },
        //    yAxis: {
        //        min: obj["yAxis"]["min"],
        //        title: {
        //            text: obj["yAxis"]["title"]["text"]
        //        }
        //    },
        //    tooltip: {
        //        valueSuffix: obj["tooltip"]["valueSuffix"],
        //    },
        //    plotOptions: {        
        //        column: {
        //            pointPadding: obj["plotOptions"]["column"]["pointPadding"],
        //            borderWidth: obj["plotOptions"]["column"]["borderWidth"],
        //        },
        //        line: {
        //            dataLabels: {
        //                enabled: obj["plotOptions"]["line"]["dataLabels"]["enabled"],
        //            },
        //            enableMouseTracking: obj["plotOptions"]["line"]["enableMouseTracking"],
        //        },
        //    },
        //    series: obj["series"]
        //});

    });
    // **************

}

export function Init(Selector) {

    selector = Selector;

}


