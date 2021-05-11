﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ngCodeGen.CodeTemplates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AzureFunctionEnvironmentGenerator : AzureFunctionEnvironmentGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            this.Write("\r\n");
            
            #line 14 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

Deployment data = JsonConvert.DeserializeObject<Deployment>(this.deployment);

var tenantId = data.TenantId.ToString();
var stages = data.WebDeploymentStages;

// DO NOT WIPE THE SOURCE CODE...
var codeGenPath = $"{this.rootTemplatePath}codegen\\";

// provision deployment stages   
for (Int32 i = 0; i < stages.Length; ++i) {
	var stage = stages[i];
    var subscriptionId = stage.SubscriptionId;
    var deploymentLocation = stage.MultiRegionSeparator;
    var stageFileName = $"azuredeploy.parameters.{stage.Name}.json";
    var serviceBusNamespace = stage.ServiceBusNamespace ?? "";
    var relayResourceGroupName = stage.RelayResourceGroupName ?? "";
    var vNetName = stage.VNetName ?? "";
    var subNetName = stage.SubNetName ?? "";
    var actionGroupShortName = stage.ActionGroupShortName;
    var alerts = (data.HasActionAlerts) ? "Yes" : "No";
    
            
            #line default
            #line hidden
            this.Write("{\r\n  \"$schema\": \"https://schema.management.azure.com/schemas/2015-01-01/deploymen" +
                    "tParameters.json#\",\r\n  \"contentVersion\": \"1.0.0.0\",\r\n  \"parameters\": {\r\n    \"Env" +
                    "ironment\": {\r\n      \"value\": \"");
            
            #line 41 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.Environment));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServicePlanSku\": {\r\n      \"value\": \"");
            
            #line 44 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServicePlanSku));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServicePlanTier\": {\r\n      \"value\": \"");
            
            #line 47 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServicePlanTier));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServicePlanInstanceCount\": {\r\n      \"value\": ");
            
            #line 50 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServicePlanInstanceCount));
            
            #line default
            #line hidden
            this.Write("\r\n    },\r\n    \"EnableAppServiceAutoscaling\": {\r\n      \"value\": ");
            
            #line 53 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.EnableAppServiceAutoscaling));
            
            #line default
            #line hidden
            this.Write("\r\n    },\r\n    \"KeyVaultTenantId\": {\r\n      \"value\": \"");
            
            #line 56 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(tenantId));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"DeploymentLocation\": {\r\n      \"value\": \"");
            
            #line 59 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(deploymentLocation));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServiceSslCertificateName\": {\r\n      \"value\": \"");
            
            #line 62 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceSslCertificateName));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServiceCustomHostname\": {\r\n      \"value\": \"");
            
            #line 65 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AppServiceBlueSlotCustomHostname\": {\r\n      \"value\": \"");
            
            #line 68 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceBlueSlotCustomHostname));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"CertKeyVaultRG\": {\r\n      \"value\": \"");
            
            #line 71 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.CertKeyVaultRG));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"CertKeyVaultName\": {\r\n      \"value\": \"");
            
            #line 74 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.CertKeyVaultName));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"ProductionSpecificSettings\" : {\r\n      \"value\": {       \r\n       " +
                    " ");
            
            #line 78 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

        for (Int32 ips = 0; ips < stage.ProductionSpecificSettings.Length; ++ips) {
            var setting = stage.ProductionSpecificSettings[ips];
            var comma = (ips == stage.ProductionSpecificSettings.Length - 1) ? "" : ",";
            
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 82 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(setting.Name));
            
            #line default
            #line hidden
            this.Write("\" : \"");
            
            #line 82 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(setting.Value));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 82 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 83 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

        }
        
            
            #line default
            #line hidden
            this.Write("}\r\n    },\r\n    \"SlotSpecificSettings\" : {\r\n      \"value\": {        \r\n        ");
            
            #line 89 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          for (Int32 ips = 0; ips < stage.SlotSpecificSettings.Length; ++ips) {
            var setting = stage.SlotSpecificSettings[ips];
            var comma = (ips == stage.SlotSpecificSettings.Length - 1) ? "" : ",";
            
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 93 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(setting.Name));
            
            #line default
            #line hidden
            this.Write("\" : \"");
            
            #line 93 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(setting.Value));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 93 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 94 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          }
        
            
            #line default
            #line hidden
            this.Write("}\r\n    },\r\n    \"AppConnectionstrings\" : {\r\n      \"value\": {\r\n        ");
            
            #line 100 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          for (Int32 ips = 0; ips < stage.AppConnectionstrings.Length; ++ips) {
            var setting = stage.AppConnectionstrings[ips];
            var dbName = setting.Name; 
            var appElement = setting.Value;
            var appElementType = setting.Type;
            var comma = (ips == stage.AppConnectionstrings.Length - 1) ? "" : ",";
            
            
            #line default
            #line hidden
            this.Write("  \"");
            
            #line 107 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dbName));
            
            #line default
            #line hidden
            this.Write("\": {\r\n                \"value\": \"");
            
            #line 108 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appElement));
            
            #line default
            #line hidden
            this.Write("\",\r\n                \"type\": \"");
            
            #line 109 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appElementType));
            
            #line default
            #line hidden
            this.Write("\"\r\n            }");
            
            #line 110 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 111 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          }
        
            
            #line default
            #line hidden
            this.Write("}\r\n    },\r\n    \"SlotConnectionstringSettings\" : {\r\n      \"value\": {\r\n        ");
            
            #line 117 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          for (Int32 ips = 0; ips < stage.SlotConnectionstringSettings.Length; ++ips) {
            var setting = stage.SlotConnectionstringSettings[ips];
            var dbName = setting.Name; 
            var appElement = setting.Value;
            var appElementType = setting.Type;
            var comma = (ips == stage.SlotConnectionstringSettings.Length - 1) ? "" : ",";
            
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 124 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dbName));
            
            #line default
            #line hidden
            this.Write("\": {\r\n                \"value\": \"");
            
            #line 125 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appElement));
            
            #line default
            #line hidden
            this.Write("\",\r\n                \"type\": \"");
            
            #line 126 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appElementType));
            
            #line default
            #line hidden
            this.Write("\"\r\n            }");
            
            #line 127 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 128 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

          }
        
            
            #line default
            #line hidden
            this.Write("}\r\n    },\r\n    \"ServiceBusNamespace\": {\r\n      \"value\": \"");
            
            #line 133 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serviceBusNamespace));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"RelayResourceGroupName\": {\r\n      \"value\": \"");
            
            #line 136 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relayResourceGroupName));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"VNetName\": {\r\n      \"value\": \"");
            
            #line 139 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(vNetName));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"SubNetName\": {\r\n      \"value\": \"");
            
            #line 142 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subNetName));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n    \"AlertObject\": {\r\n      \"value\": {\r\n        \"alerts\": [\r\n         " +
                    " {\r\n            \"alertName\": \"");
            
            #line 148 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write(@" Http Server Error Dynamic Threshold"",
            ""alertDescription"": """",
            ""metricName"": ""Http5xx"",
            ""alertSeverity"": 3,
            ""dimensionName"": ""Instance"",
            ""operator"": ""GreaterOrLessThan"",
            ""alertSensitivity"": ""Medium"",
            ""numberOfEvaluationPeriods"": 4,
            ""minFailingPeriodsToAlert"": 4,
            ""timeAggregation"": ""Total"",
            ""windowSize"": ""PT5M"",
            ""evaluationFrequency"": ""PT5M"",
            ""actionGroupName"": """);
            
            #line 160 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.ActionGroupShortName));
            
            #line default
            #line hidden
            this.Write("\"\r\n          },\r\n          {\r\n            \"alertName\": \"");
            
            #line 163 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write(@" Request Dynamic Threshold"",
            ""alertDescription"": """",
            ""metricName"": ""Requests"",
            ""alertSeverity"": 3,
            ""dimensionName"": ""Instance"",
            ""operator"": ""GreaterOrLessThan"",
            ""alertSensitivity"": ""Medium"",
            ""numberOfEvaluationPeriods"": 4,
            ""minFailingPeriodsToAlert"": 4,
            ""timeAggregation"": ""Total"",
            ""windowSize"": ""PT5M"",
            ""evaluationFrequency"": ""PT5M"",
            ""actionGroupName"": """);
            
            #line 175 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.ActionGroupShortName));
            
            #line default
            #line hidden
            this.Write("\"\r\n          },\r\n          {\r\n            \"alertName\": \"");
            
            #line 178 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write(@" 4XX Error Dynamic Threshold"",
            ""alertDescription"": """",
            ""metricName"": ""Http4xx"",
            ""alertSeverity"": 3,
            ""dimensionName"": ""Instance"",
            ""operator"": ""GreaterOrLessThan"",
            ""alertSensitivity"": ""Medium"",
            ""numberOfEvaluationPeriods"": 4,
            ""minFailingPeriodsToAlert"": 4,
            ""timeAggregation"": ""Total"",
            ""windowSize"": ""PT5M"",
            ""evaluationFrequency"": ""PT5M"",
            ""actionGroupName"": """);
            
            #line 190 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.ActionGroupShortName));
            
            #line default
            #line hidden
            this.Write("\"\r\n          },          \r\n          {\r\n            \"alertName\": \"");
            
            #line 193 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write(@" High Average Response Time"",
            ""alertDescription"": """",
            ""metricName"": ""AverageResponseTime"",
            ""alertSeverity"": 3,
            ""dimensionName"": ""Instance"",
            ""operator"": ""GreaterThan"",
            ""alertSensitivity"": ""Medium"",
            ""numberOfEvaluationPeriods"": 4,
            ""minFailingPeriodsToAlert"": 4,
            ""timeAggregation"": ""Average"",
            ""windowSize"": ""PT5M"",
            ""evaluationFrequency"": ""PT5M"",
            ""actionGroupName"": """);
            
            #line 205 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.ActionGroupShortName));
            
            #line default
            #line hidden
            this.Write("\"\r\n          },\r\n          {\r\n            \"alertName\": \"");
            
            #line 208 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.AppServiceCustomHostname));
            
            #line default
            #line hidden
            this.Write(@" High Http Server Error"",
            ""alertDescription"": """",
            ""metricName"": ""Http5xx"",
            ""alertSeverity"": 3,
            ""dimensionName"": ""Instance"",
            ""operator"": ""GreaterThan"",
            ""alertSensitivity"": ""Medium"",
            ""numberOfEvaluationPeriods"": 4,
            ""minFailingPeriodsToAlert"": 4,
            ""timeAggregation"": ""Total"",
            ""threshold"": 10.0,
            ""windowSize"": ""PT5M"",
            ""evaluationFrequency"": ""PT5M"",
            ""actionGroupName"": """);
            
            #line 221 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stage.ActionGroupShortName));
            
            #line default
            #line hidden
            this.Write("\"\r\n          }\r\n        ]\r\n      }\r\n    },\r\n    \"Alerts\":{\r\n      \"value\":\"");
            
            #line 227 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(alerts));
            
            #line default
            #line hidden
            this.Write("\"\r\n    }\r\n  }\r\n}\r\n\r\n");
            
            #line 232 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

SaveOutputToSubFolder(codeGenPath, $"{data.Id}\\{data.TeamName.ToLower()}-{data.Name.ToLower()}-infra\\ArmTemplate", stageFileName);    
}

            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 238 "C:\research\azure-deploy\CodeTemplates\AzureFunctionEnvironmentGenerator.tt"

private void SaveOutputToSubFolder(string rootTemplatePath, string folderName, string outputFileName) {
  string templateDirectory = Path.GetDirectoryName(rootTemplatePath.Replace('\\', Path.DirectorySeparatorChar));
  string newDirectoryName = Path.Combine(templateDirectory,folderName.Replace('\\', Path.DirectorySeparatorChar));
  if(!Directory.Exists(newDirectoryName))
  {  
	Directory.CreateDirectory(newDirectoryName);
  }
  string outputFilePath = Path.Combine(newDirectoryName, outputFileName.Replace('\\', Path.DirectorySeparatorChar));
  File.WriteAllText(outputFilePath, this.GenerationEnvironment.ToString()); 
  this.GenerationEnvironment.Remove(0, this.GenerationEnvironment.Length);
}

private readonly string deployment;
private readonly string rootTemplatePath;
public AzureFunctionEnvironmentGenerator(string deployment, string rootTemplatePath) {
    this.deployment = deployment;
    this.rootTemplatePath = rootTemplatePath;
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class AzureFunctionEnvironmentGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}