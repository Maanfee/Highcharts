namespace Maanfee.Highcharts
{
    public static class ChartHelpers
    {
        public static async Task<Chart> InitAsync(this Task<Chart> dom, string Selector) => await (await dom).InitAsync(Selector);

        public static async Task GenerateAsync<T>(this Task<Chart> dom, ChartConfiguration chart,bool IsDefaultFont = true) => await (await dom).GenerateAsync<T>(chart, IsDefaultFont);
    }
}
