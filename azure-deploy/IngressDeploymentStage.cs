using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class IngressDeploymentStage
    {
        public string TeamAppId { get; set; }
        public string Name { get; set; }
        public string Environment { get; set; }
        public Guid SubscriptionId { get; set; }
        public string BuildSourceBranch { get; set; }
        public string AzureServiceConnectionName { get; set; }
        public string DeploymentLocation { get; set; }
        public string DeploymentLocationName { get; set; }
        public string MultiRegionSeparator { get; set; }
        public string ApplicationGatewayName { get; set; }
        public string ApplicationGatewayResourceGroup { get; set; }
        public string Webapprg { get; set; }
        public string FirewallMode { get; set; }
        public string CookieBasedAffinity { get; set; }
        public string AffinityCookieName { get; set; }
        public string Tier { get; set; }
        public string Sku { get; set; }
        public string AllocationMethod { get; set; }
        public string Storageaccountname { get; set; }
        public string Storageaccountrgname { get; set; }
        public string Enablediagnostics { get; set; }
        public string CertKeyVaultName { get; set; }
        public string CertKeyVaultRG { get; set; }
        public string CertSecretName { get; set; }
        public string SubnetName { get; set; }
        public string VirtualNetworkResourceGroup { get; set; }
        public string VirtualNetworkName { get; set; }
        public int AutoScaleMaxCapacity { get; set; }
        public int Capacity { get; set; }
        public int ConnectionDrainingTimeout { get; set; }
        public bool ConnectionDrainingEnabled { get; set; }
        public string DiagnosticSettingName { get; set; }
        public string FrontendPort { get; set; }
        public string BackendPort { get; set; }
        public NameValue[] BackendAddressPools { get; set; }
        public string[] WebAppHosts { get; set; }
    }
}
