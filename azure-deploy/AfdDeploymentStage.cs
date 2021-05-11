using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class AfdDeploymentStage
    {
        public string Name { get; set; }
        public string DeploymentLocation { get; set; }
        public string DeploymentLocationName { get; set; }
        public AfdDeploymentStep[] AfdDeploymentSteps { get; set; }
    }

    public class AfdDeploymentStep
    {
        public string Suffix { get; set; }
        public string Environment { get; set; }
        public Guid SubscriptionId { get; set; }
        public string AzureServiceConnectionName { get; set; }
        public string BuildSourceBranch { get; set; }
        public string Webapprg { get; set; }
        public string DeploymentLocation { get; set; }
        public string FirewallMode { get; set; }
        public string CookieBasedAffinity { get; set; }
        public string AffinityCookieName { get; set; }
        public string FrontendPort { get; set; }
        public string BackendPort { get; set; }
        public FrontDoorPool[] BackendAddressPools { get; set; }
        public string[] WebAppHosts { get; set; }
    }
}
