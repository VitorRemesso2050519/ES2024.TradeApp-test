using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeApp
{
    internal class FileTradeDataProvider : TradeDataProvider
    {
        public FileTradeDataProvider(Stream stream)
        {
            Stream = stream;
        }

        Stream Stream { get; }

        IEnumerable<string> ReadTradeData(Stream stream)
        {
            // read rows
            var lines = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}