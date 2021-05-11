using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class RelayConfiguration
    {
        public string ServiceBusNamespace { get; set; }
        public string RelayResourceGroupName { get; set; }
        public string RelayName { get; set; }
    }
}
