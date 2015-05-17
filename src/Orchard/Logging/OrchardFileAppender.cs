using System.Collections.Generic;
using log4net.Appender;
using log4net.Util;

namespace Orchard.Logging
{
    public class OrchardFileAppender:RollingFileAppender
    {
        /// <summary>
        /// Dictionary of already known suffixes(based on previous attempts) for a given filename.
        /// </summary>
        private static readonly Dictionary<string, int> _suffixes = new Dictionary<string, int>();

        /// <summary>
        /// The number of suffix attempts that will be made on each OpenFile method call.
        /// </summary>
        private const int Retries = 50;

        private const int MaxSuffixex = 100;

    }
}
