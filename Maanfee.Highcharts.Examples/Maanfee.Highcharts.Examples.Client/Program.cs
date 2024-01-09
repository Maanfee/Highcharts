using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Maanfee.Highcharts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// HighCharts
builder.Services.AddHighCharts();

await builder.Build().RunAsync();
