using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeApp
{
    public interface ITradeDataParser
    {
        void Parse(IEnumerable<string> lines);
    }
}
