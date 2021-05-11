using System;
using System.Collections.Generic;
using System.Text;

namespace ngCodeGen
{
    public class TmDeploymentStage
    {
        public string Environment { get; set; }
        public string Name { get; set; }
        public string TrafficManagerName { get; set; }
        public Guid SubscriptionId { get; set; }
        public string DeploymentLocation { get; set; }
        public string DeploymentLocationName { get; set; }
        public string AzureServiceConnectionName { get; set; }
        public string BuildSourceBranch { get; set; }
        public string ResourceGroup { get; set; }
        public TmPool[] TmPools { get; set; }
        public string Outagewebappurl { get; set; }
        public string TrafficRoutingMethod { get; set; }
        public string TrafficViewEnrollmentStatus { get; set; }
    }
}
