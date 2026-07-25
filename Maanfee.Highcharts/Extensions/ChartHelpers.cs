namespace Maanfee.Highcharts
{
    public static class ChartHelpers
    {
        public static async Task<ChartService> InitAsync(this Task<ChartService> dom, string Selector) => await (await dom).InitAsync(Selector);

        public static async Task GenerateAsync<T>(this Task<ChartService> dom, ChartConfiguration chart,bool IsDefaultFont = true) => await (await dom).GenerateAsync<T>(chart, IsDefaultFont);
    }
}
