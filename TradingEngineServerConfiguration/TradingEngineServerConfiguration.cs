using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Core.Configuration
{
    internal class TradingEngineServerConfiguration
    {
        public required TradingEngineServerSettings TradingEngineServerSettings { get; set; }
    }
    class TradingEngineServerSettings
    {
        public int port { get; set; }
    }
}
