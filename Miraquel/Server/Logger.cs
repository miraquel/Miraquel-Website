using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Extensions.Logging;

namespace Miraquel.Server
{
    public static partial class LoggerMessageInfo
    {
        [LoggerMessage(EventId = 0, Level = LogLevel.Information, Message = "test message {param1}")]
        public static partial void LogInfoWeather(this ILogger logger, int param1);
    }
}
