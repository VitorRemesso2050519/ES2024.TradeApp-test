
namespace TradeApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("TradeApp v1.0!");

            using var stream = File.OpenRead( "TradeData.txt" );

            //var provider = new FileTradeDataProvider( stream );
            var provider = new WebTradeDataProvider( "...." );
            //var storage = new SQLTradeStorage();
            var storage = new JSONTradeStorage();
            var parser = new TradeDataParser();

            var processor = new TradeProcessor(provider);
            processor.ProcessTrades( stream );
        }
    }
}