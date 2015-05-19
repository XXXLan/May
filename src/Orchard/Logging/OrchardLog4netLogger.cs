using System;
using System.Collections.Generic;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using log4net;
using log4net.Core;
using log4net.Util;

using Logger = Castle.Core.Logging.ILogger;

namespace Orchard.Logging
{
    [Serializable]
    public class OrchardLog4netLogger:MarshalByRefObject,Logger,IShim
    {
        private static readonly Type declaringType = typeof(OrchardLog4netLogger);

		private readonly Lazy<ShellSettings> _shellSettings;

		public IOrchardHostContainer HostContainer{ get; set;}

		public OrchardLog4netLogger(log4net.Core.ILogger logger,OrchardLog4netFactory factory){
			OrchardHostContainerRegistry.RegisterShim (this);
			Logger = logger;

		}
    }
}
