using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class WebDeploymentStage
    {
        public Guid Id { get; set; }
        public bool IsChecked { get; set; }
        public bool CannotDelete { get; set; }
        public string TeamAppId { get; set; }
        public string Name { get; set; }
        public string Environment { get; set; }
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public bool DevOpsContributorRole { get; set; }
        public string MultiRegionSeparator { get; set; }
        public string BuildSourceBranch { get; set; }
        public string AzureServiceConnectionName { get; set; }
        public string AzureTeamServiceConnectionName { get; set; }
        public string ResourceGroup { get; set; }
        public string TeamResourceGroup { get; set; }
        public string DeploymentLocation { get; set; }
        public string DeploymentLocationName { get; set; }
        public string DeploymentLocationShort { get; set; }
        public string StorageAccountSku { get; set; }
        public string StorageAccountContainer { get; set; }
        public string AppServicePlanSku { get; set; }
        public int AppServicePlanInstanceCount { get; set; }
        public string AppServicePlanTier { get; set; }
        public string AppServicePlanFamily { get; set; }
        public string AppServiceSslCertificateName { get; set; }
        public string AppServiceCustomHostname { get; set; }
        public string AppServiceBlueSlotCustomHostname { get; set; }
        public string WebAppCustomHostname { get; set; }
        public string WebAppBlueSlotCustomHostname { get; set; }
        public string LoadBalancing { get; set; }
        public string CertKeyVaultRG { get; set; }
        public string CertKeyVaultName { get; set; }
        public string CertKeyVaultSecret { get; set; }
        public string CertKeyVaultVersion { get; set; }
        public string Relays { get; set; }
        public string EnableAppServiceAutoscaling { get; set; }
        public bool HasActionAlerts { get; set; }
        public NameValue[] ProductionSpecificSettings { get; set; }
        public NameValue[] SlotSpecificSettings { get; set; }
        public NameValueType[] AppConnectionstrings { get; set; }
        public NameValueType[] SlotConnectionstringSettings { get; set; }
        public string[] SlotConfiguration { get; set; }
        public string ServiceBusNamespace { get; set; }
        public string RelayResourceGroupName { get; set; }
        public string VNetName { get; set; }
        public string SubNetName { get; set; }
        public string ActionGroupShortName { get; set; }
    }
}
