using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace Maanfee.Highcharts
{
    public class Chart : ComponentBase, IAsyncDisposable
    {
        #region - JsRuntime -

        public Chart(IJSRuntime JsRuntime)
        {
            moduleTask = new(() => JsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Maanfee.Highcharts/JsInterop.js").AsTask());
        }

        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                //    var Module = await moduleTask.Value;
                //        await Module.DisposeAsync();
                await Task.Delay(100);
            }
        }

        #endregion

        // ************************************************

        public async Task<Chart> InitAsync(string Selector)
        {
            var Module = await moduleTask.Value;

            if (!string.IsNullOrEmpty(Selector))
            {
                await Module.InvokeAsync<Task>("Init", Selector);
            }

            return this;
        }

        public async Task GenerateAsync<T>(ChartConfiguration chart, bool IsDefaultFont)
        {
            var ChartOptions = JsonSerializer.Serialize(chart, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });
            ChartOptions = ChartOptions.Replace("pieSeries", "series");
            ChartOptions = ChartOptions.Replace("lineSeries", "series");
            ChartOptions = ChartOptions.Replace("columnSeries", "series");
            ChartOptions = ChartOptions.Replace(",\"series\":[]", "");

            ChartOptions = ChartOptions.Replace("subTitle", "subtitle");

            var Module = await moduleTask.Value;
            await Module.InvokeVoidAsync("Generate", ChartOptions, IsDefaultFont);
        }

        //public async Task<Chart> TitleOptionsAsync(string Text, Align Align)
        //{
        //    var Module = await moduleTask.Value;
        //    await Module.InvokeVoidAsync("TitleOptions", Text, Align.ToDescriptionString());

        //    return this;
        //}

        //public async Task<Chart> SubTitleOptionsAsync(string Text, Align Align)
        //{
        //    var Module = await moduleTask.Value;
        //    await Module.InvokeVoidAsync("SubTitleOptions", Text, Align.ToDescriptionString());

        //    return this;
        //}


        // ************************************************

        //public async Task ClearAsync()
        //{
        //    var Module = await moduleTask.Value;
        //    await Module.InvokeVoidAsync("Clear");
        //}

        //public async Task<string> KeyAsync(int Index)
        //{
        //    var Module = await moduleTask.Value;
        //    return await Module.InvokeAsync<string>("Key", Index);
        //}

        //public async Task<T> GetAsync<T>(string Key)
        //{
        //    var Module = await moduleTask.Value;
        //    var data = await Module.InvokeAsync<string>("Get", Key);

        //    return data == null ? default(T) : JsonSerializer.Deserialize<T>(data);
        //}

        //public async Task<List<string>> KeysAsync()
        //{
        //    var Module = await moduleTask.Value;
        //    var data = await Module.InvokeAsync<string>("Keys");

        //    return data == null ? new List<string>() : JsonSerializer.Deserialize<List<string>>(data);
        //}

        //public async Task<int?> LengthAsync()
        //{
        //    var Module = await moduleTask.Value;
        //    var data = await Module.InvokeAsync<int?>("Length");

        //    return data == null ? default : data;
        //}

        //public async Task SetAsync<T>(string Key, T value)
        //{
        //    var Module = await moduleTask.Value;
        //    await Module.InvokeVoidAsync("Set", Key, JsonSerializer.Serialize(value));
        //}

        //public async Task RemoveAsync(string Key)
        //{
        //    var Module = await moduleTask.Value;
        //    await Module.InvokeVoidAsync("Remove", Key);
        //}
    }
}
