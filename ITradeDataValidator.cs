using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeApp
{
    public interface ITradeDataValidator
    {
        bool Validate(string[] fields, int lineCount);
    }
}
