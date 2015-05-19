using System;
using System.Collections.Generic;
using Castle.Core.Logging;
using log4net;
using log4net.Config;
using Orchard.Environment;

namespace Orchard.Logging
{
	public class OrchardLog4netFactory:AbstractLoggerFactory
    {
		private static bool _isFileWatched=false;

		public OrchardLog4netFactory( hostEnviroment)
		{
		}

		public OrchardLog4netFactory(string configFilename)
    }
}
