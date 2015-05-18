using System;
using System.Collections.Generic;
using Orchard.Environment;

using Logger = Castle.Core.Logging.ILogger;

namespace Orchard.Logging
{
    [Serializable]
    public class OrchardLog4netLogger:MarshalByRefObject,Logger,IShim
    {
        private static readonly Type declaringType = typeof(OrchardLog4netLogger);

        private readonly Lazy<Shell>
    }
}
