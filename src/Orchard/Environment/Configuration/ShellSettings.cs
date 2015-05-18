using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Environment.Configuration
{
    /// <summary>
    /// Represents the minimalistic set of fields stored for each tenant.This 
    /// model is obtained from the IShellSettingsManager,which by default reads this
    /// from the App_Data settings.txt files.
    /// </summary>
    public class ShellSettings
    {
        public const string DefultName = "Default";
        private TenantState _tenantState;
        private string[] _themes;
        private string[] _modules;
        private readonly IDictionary<string, string> _values;

        public ShellSettings() {
            _values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            
        }

        public string this[string key]
        {
            get {
                string retVal;
                return _values.TryGetValue(key, out retVal) ? retVal : null;
            }
            set { _values[key] = value; }
        }

        /// <summary>
        /// Gets all keys held by this shell settings.
        /// </summary>
        public IEnumerable<string> Keys { get { return _values.Keys; } }

        public string Name 
        {
            get { return this["Name"] ?? ""; }
            set { this["Name"] = value; }
        }


    }
}
