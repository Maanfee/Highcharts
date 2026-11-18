using Maanfee.Highcharts;
using Maanfee.Highcharts.Examples.Components;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// HighCharts
builder.Services.AddHighCharts();
// Mudblazor
builder.Services.AddMudServices();

var app = builder.Build();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Maanfee.Highcharts.Examples.Client._Imports).Assembly);

app.Run();
