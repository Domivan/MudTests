namespace MudTests.Shared
{
    public delegate Task Update();
    public class MyData
    {
        public string Category { get; set; }
        public int NetProfit { get; set; }
        public int Revenue { get; set; }
    }
}