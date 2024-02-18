namespace TradeApp
{
    internal class TradeRecord
    {
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public double Lots { get; set; }
        public decimal Price { get; set; }
    }
}
