using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public abstract class BaseModel
    {
        public Guid? Id { get; set; }
    }

    public abstract class UniqueNameBaseModel : BaseModel
    {
        public string Name { get; set; }
    }

    public class Deployment : BaseModel
    {
        public string Name { get; set; }
        public string IntAzureServiceConnectionName { get; set; }
        public string IntResourceGroup { get; set; }
        public string DevOpsProjectName { get; set; }
        public DeploymentType Type { get; set; }
        public bool IsMultiRegion { get; set; }
        public bool UseTeamRG { get; set; }
        public Guid TenantId { get; set; }
        public string TeamName { get; set; }
        public bool UseVnetIntegration { get; set; }
        public bool UseDbaVault { get; set; }
        public bool IsDotNetCore { get; set; }
        public bool IsContainer { get; set; }
        public bool IsLinux { get; set; }
        public bool IsCustomDns { get; set; }
        public string Dotnetversion { get; set; }
        public string StartupCommand { get; set; }
        public string QueryStringCachingBehavior { get; set; }
        public bool HasSlots { get; set; }
        public bool HasActionAlerts { get; set; }
        public bool UseIndependentPlan { get; set; }
        public string Kind { get; set; }
        public string ApplicationName { get; set; }
        public string TeamDisplayName { get; set; }
        public string ApplicationType { get; set; }
        public string Owner { get; set; }
        public string PoolName { get; set; }
        public string VmImage { get; set; }
        public string IpSecurityRestrictions { get; set; }
        public string InternalNetworkName { get; set; }
        public string DefaultLocation { get; set; }
        public string LocationName { get; set; }
        public string ResourceGroupConfigKVSuffix { get; set; }
        public string[] AppServicePlanAutoScaleEmailNotificationContacts { get; set; }
        public string[] RelayConfiguration { get; set; }
        public WebDeploymentStage[] WebDeploymentStages { get; set; }
        public string IngressType { get; set; }
        public IngressDeploymentStage[] IngressDeploymentStages { get; set; }
        public TmDeploymentStage[] TmDeploymentStages { get; set; }
        public AfdDeploymentStage[] AfdDeploymentStages { get; set; }
    }
}
