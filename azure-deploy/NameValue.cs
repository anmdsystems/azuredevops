using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class NameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class NameValueType
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class NameEmail
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }

    public class FrontDoorPool
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string PatternsToMatch { get; set; }
        public string ExistingFrontend { get; set; }
        public string SessionAffinityState { get; set; }
        public string CertKeyVaultName { get; set; }
        public string CertKeyVaultSecret { get; set; }
        public string CertKeyVaultVersion { get; set; }
        public string CertKeyVaultResourceGroupName { get; set; }
    }

    public class TmPool
    {
        public string EndpointLocation { get; set; }
        public bool IsAgw { get; set; }
        public string AppgatewayUrl { get; set; }
        public string WebAppRgName { get; set; }
        public string WebAppName { get; set; }
        public string[] WebAppHosts { get; set; }
    }
}
