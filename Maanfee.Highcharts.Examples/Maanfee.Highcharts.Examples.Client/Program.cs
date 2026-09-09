using Maanfee.Highcharts;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// HighCharts
builder.Services.AddHighCharts();
// Mudblazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
