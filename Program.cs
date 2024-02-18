
namespace TradeApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("TradeApp v1.0!");

            using var stream = File.OpenRead( "TradeData.txt" );

            var processor = new TradeProcessor();
            processor.ProcessTrades( stream );
        }
    }
}