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
    
    #line 1 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CdnProfile : CdnProfileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            this.Write("\r\n");
            
            #line 14 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"

Deployment data = JsonConvert.DeserializeObject<Deployment>(this.deployment);

var ipSecurityRestrictions = data.IpSecurityRestrictions;
var internalNetworkName = data.InternalNetworkName;
var application = data.TeamDisplayName;
var applicationType = data.ApplicationType;
var owner = data.Owner;
var teamName = data.TeamName;
var appName = data.Name;

var stages = data.WebDeploymentStages;
var queryStringCachingBehavior = data.QueryStringCachingBehavior ?? "IgnoreQueryString";

// DO NOT WIPE THE SOURCE CODE...
var codeGenPath = $"{this.rootTemplatePath}codegen\\";
var blue = (isBlue) ? "-blue" : "";
var hostName = (isBlue) ? "[parameters('AppServiceBlueSlotCustomHostname')]" : "[parameters('AppServiceCustomHostname')]";

            
            #line default
            #line hidden
            this.Write(@"{
    ""$schema"": ""https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#"",
    ""contentVersion"": ""1.0.0.0"",
    ""parameters"": {
        ""OriginHostHeader"": {
            ""defaultValue"": """",
            ""type"": ""String""
        },
        ""Environment"" : {
            ""defaultValue"": """",
            ""type"": ""String""
        },
        ""AppServiceCustomHostname"": {
          ""defaultValue"": """",
          ""type"": ""String""
        },
        ""AppServiceBlueSlotCustomHostname"": {
          ""defaultValue"": """",
          ""type"": ""String""
        }
    },
    ""variables"": {
        ""originHost"": ""[replace(parameters('OriginHostHeader'),'.','-')]"",
        ""environment"": ""[parameters('Environment')]"",
        ""teamName"": """);
            
            #line 57 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(teamName));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"appName\": \"");
            
            #line 58 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appName));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"applicationType\": \"");
            
            #line 59 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(applicationType));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"blue\": \"");
            
            #line 60 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(blue));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"hostName\": \"");
            
            #line 61 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(hostName));
            
            #line default
            #line hidden
            this.Write(@""",
        ""cdnProfileName"": ""[concat(variables('teamName'), '-', variables('environment'), '-', variables('appName'), '-cdn')]"",
        ""cdnEndPointName"": ""[concat(variables('teamName'), '-', variables('environment'), '-', variables('appName'), variables('blue'), '-cdn')]""
    },
    ""resources"": [
        {
            ""type"": ""Microsoft.Cdn/profiles"",
            ""apiVersion"": ""2020-04-15"",
            ""name"": ""[variables('cdnProfileName')]"",
            ""location"": ""Global"",
            ""sku"": {
                ""name"": ""Standard_Microsoft""
            },
            ""properties"": {}
        },
        {
            ""type"": ""Microsoft.Cdn/profiles/endpoints"",
            ""apiVersion"": ""2020-04-15"",
            ""name"": ""[concat(variables('cdnProfileName'), '/', variables('cdnEndPointName'))]"",
            ""location"": ""Global"",
            ""dependsOn"": [
                ""[resourceId('Microsoft.Cdn/profiles', variables('cdnProfileName'))]""
            ],
            ""properties"": {
            ""originHostHeader"": ""[parameters('OriginHostHeader')]"",
            ""isHttpAllowed"": true,
            ""isHttpsAllowed"": true,
            ""queryStringCachingBehavior"": """);
            
            #line 88 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(queryStringCachingBehavior));
            
            #line default
            #line hidden
            this.Write("\",\r\n            \"origins\": [\r\n              {\r\n                \"name\": \"[variable" +
                    "s(\'originHost\')]\",\r\n                \"properties\": {\r\n                  \"hostName" +
                    "\": \"[parameters(\'OriginHostHeader\')]\",\r\n                  \"httpPort\": 80,\r\n     " +
                    "             \"httpsPort\": 443,\r\n                  \"originHostHeader\": \"[paramete" +
                    "rs(\'OriginHostHeader\')]\",\r\n                  \"priority\": 1,\r\n                  \"" +
                    "weight\": 1000,\r\n                  \"enabled\": true\r\n                }\r\n          " +
                    "    }\r\n            ],\r\n            \"originGroups\": [],\r\n            \"contentType" +
                    "sToCompress\": [\r\n              \"application/eot\",\r\n              \"application/fo" +
                    "nt\",\r\n              \"application/font-sfnt\",\r\n              \"application/javascr" +
                    "ipt\",\r\n              \"application/json\",\r\n              \"application/opentype\",\r" +
                    "\n              \"application/otf\",\r\n              \"application/pkcs7-mime\",\r\n    " +
                    "          \"application/truetype\",\r\n              \"application/ttf\",\r\n           " +
                    "   \"application/vnd.ms-fontobject\",\r\n              \"application/xhtml+xml\",\r\n   " +
                    "           \"application/xml\",\r\n              \"application/xml+rss\",\r\n           " +
                    "   \"application/x-font-opentype\",\r\n              \"application/x-font-truetype\",\r" +
                    "\n              \"application/x-font-ttf\",\r\n              \"application/x-httpd-cgi" +
                    "\",\r\n              \"application/x-javascript\",\r\n              \"application/x-mpeg" +
                    "url\",\r\n              \"application/x-opentype\",\r\n              \"application/x-otf" +
                    "\",\r\n              \"application/x-perl\",\r\n              \"application/x-ttf\",\r\n   " +
                    "           \"font/eot\",\r\n              \"font/ttf\",\r\n              \"font/otf\",\r\n  " +
                    "            \"font/opentype\",\r\n              \"image/svg+xml\",\r\n              \"tex" +
                    "t/css\",\r\n              \"text/csv\",\r\n              \"text/html\",\r\n              \"t" +
                    "ext/javascript\",\r\n              \"text/js\",\r\n              \"text/plain\",\r\n       " +
                    "       \"text/richtext\",\r\n              \"text/tab-separated-values\",\r\n           " +
                    "   \"text/xml\",\r\n              \"text/x-script\",\r\n              \"text/x-component\"" +
                    ",\r\n              \"text/x-java-source\"\r\n            ],\r\n            \"isCompressio" +
                    "nEnabled\": true,\r\n            \"geoFilters\": [],\r\n            \"deliveryPolicy\": {" +
                    "\r\n              \"rules\": [\r\n                {\r\n                  \"name\": \"Global" +
                    "\",\r\n                  \"order\": 0,\r\n                  \"conditions\": [],\r\n        " +
                    "          \"actions\": [\r\n                    {\r\n                      \"name\": \"Mo" +
                    "difyRequestHeader\",\r\n                      \"parameters\": {\r\n                    " +
                    "    \"@odata.type\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParamete" +
                    "rs\",\r\n                        \"headerAction\": \"Append\",\r\n                       " +
                    " \"headerName\": \"Strict-Transport-Security\",\r\n                        \"value\": \"m" +
                    "ax-age=31536000; includeSubDomains\"\r\n                      }\r\n                  " +
                    "  },\r\n                    {\r\n                      \"name\": \"ModifyRequestHeader\"" +
                    ",\r\n                      \"parameters\": {\r\n                        \"@odata.type\":" +
                    " \"#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters\",\r\n            " +
                    "            \"headerAction\": \"Append\",\r\n                        \"headerName\": \"X-" +
                    "XSS-Protection\",\r\n                        \"value\": \"1; mode=block\"\r\n            " +
                    "          }\r\n                    },\r\n                    {\r\n                    " +
                    "  \"name\": \"ModifyRequestHeader\",\r\n                      \"parameters\": {\r\n       " +
                    "                 \"@odata.type\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderA" +
                    "ctionParameters\",\r\n                        \"headerAction\": \"Append\",\r\n          " +
                    "              \"headerName\": \"X-Content-Type-Options\",\r\n                        \"" +
                    "value\": \"nosniff\"\r\n                      }\r\n                    }\r\n             " +
                    "     ]\r\n                },\r\n                {\r\n                  \"name\": \"HttpHe" +
                    "aders\",\r\n                  \"order\": 1,\r\n                  \"conditions\": [\r\n     " +
                    "               {\r\n                      \"name\": \"QueryString\",\r\n                " +
                    "      \"parameters\": {\r\n                        \"@odata.type\": \"#Microsoft.Azure." +
                    "Cdn.Models.DeliveryRuleQueryStringConditionParameters\",\r\n                       " +
                    " \"operator\": \"Any\",\r\n                        \"negateCondition\": false,\r\n        " +
                    "                \"matchValues\": [],\r\n                        \"transforms\": []\r\n  " +
                    "                    }\r\n                    }\r\n                  ],\r\n            " +
                    "      \"actions\": [\r\n                    {\r\n                      \"name\": \"Modify" +
                    "RequestHeader\",\r\n                      \"parameters\": {\r\n                        " +
                    "\"@odata.type\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters\"," +
                    "\r\n                        \"headerAction\": \"Append\",\r\n                        \"he" +
                    "aderName\": \"Content-Security-Policy\",\r\n                        \"value\": \"default" +
                    "-src \'self\';font-src *;img-src * data:;\"\r\n                      }\r\n             " +
                    "       },\r\n                    {\r\n                      \"name\": \"ModifyRequestHe" +
                    "ader\",\r\n                      \"parameters\": {\r\n                        \"@odata.t" +
                    "ype\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters\",\r\n       " +
                    "                 \"headerAction\": \"Append\",\r\n                        \"headerName\"" +
                    ": \"X-Content-Security-Policy\",\r\n                        \"value\": \"default-src \'s" +
                    "elf\';font-src *;img-src * data:;\"\r\n                      }\r\n                    " +
                    "},\r\n                    {\r\n                      \"name\": \"ModifyRequestHeader\",\r" +
                    "\n                      \"parameters\": {\r\n                        \"@odata.type\": \"" +
                    "#Microsoft.Azure.Cdn.Models.DeliveryRuleHeaderActionParameters\",\r\n              " +
                    "          \"headerAction\": \"Append\",\r\n                        \"headerName\": \"Refe" +
                    "rrer-Policy\",\r\n                        \"value\": \"strict-origin\"\r\n               " +
                    "       }\r\n                    }\r\n                  ]\r\n                },\r\n      " +
                    "          {\r\n                  \"name\": \"HttpHeader\",\r\n                  \"order\":" +
                    " 2,\r\n                  \"conditions\": [\r\n                    {\r\n                 " +
                    "     \"name\": \"RequestUri\",\r\n                      \"parameters\": {\r\n             " +
                    "           \"@odata.type\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleRequestUriCon" +
                    "ditionParameters\",\r\n                        \"operator\": \"Any\",\r\n                " +
                    "        \"negateCondition\": false,\r\n                        \"matchValues\": [],\r\n " +
                    "                       \"transforms\": []\r\n                      }\r\n              " +
                    "      }\r\n                  ],\r\n                  \"actions\": [\r\n                 " +
                    "   {\r\n                      \"name\": \"ModifyRequestHeader\",\r\n                    " +
                    "  \"parameters\": {\r\n                        \"@odata.type\": \"#Microsoft.Azure.Cdn." +
                    "Models.DeliveryRuleHeaderActionParameters\",\r\n                        \"headerActi" +
                    "on\": \"Append\",\r\n                        \"headerName\": \"X-Content-Type-Options\",\r" +
                    "\n                        \"value\": \"nosniff\"\r\n                      }\r\n          " +
                    "          }\r\n                  ]\r\n                },\r\n                {\r\n       " +
                    "           \"name\": \"EnforceHttps\",\r\n                  \"order\": 3,\r\n             " +
                    "     \"conditions\": [\r\n                    {\r\n                      \"name\": \"Requ" +
                    "estScheme\",\r\n                      \"parameters\": {\r\n                        \"@od" +
                    "ata.type\": \"#Microsoft.Azure.Cdn.Models.DeliveryRuleRequestSchemeConditionParame" +
                    "ters\",\r\n                        \"operator\": \"Equal\",\r\n                        \"n" +
                    "egateCondition\": false,\r\n                        \"matchValues\": [\r\n             " +
                    "             \"HTTP\"\r\n                        ]\r\n                      }\r\n       " +
                    "             }\r\n                  ],\r\n                  \"actions\": [\r\n          " +
                    "          {\r\n                      \"name\": \"UrlRedirect\",\r\n                     " +
                    " \"parameters\": {\r\n                        \"@odata.type\": \"#Microsoft.Azure.Cdn.M" +
                    "odels.DeliveryRuleUrlRedirectActionParameters\",\r\n                        \"redire" +
                    "ctType\": \"Found\",\r\n                        \"destinationProtocol\": \"Https\"\r\n     " +
                    "                 }\r\n                    }\r\n                  ]\r\n                " +
                    "}\r\n              ]\r\n            },\r\n            \"urlSigningKeys\": []\r\n          " +
                    "}\r\n        },\r\n        {\r\n            \"type\": \"Microsoft.Cdn/profiles/endpoints/" +
                    "customdomains\",\r\n            \"apiVersion\": \"2020-04-15\",\r\n            \"name\": \"[" +
                    "concat(variables(\'cdnProfileName\'), \'/\', variables(\'cdnProfileName\'), \'/\', varia" +
                    "bles(\'cdnEndPointName\'))]\",\r\n            \"dependsOn\": [\r\n                \"[resou" +
                    "rceId(\'Microsoft.Cdn/profiles/endpoints\', variables(\'cdnProfileName\'), variables" +
                    "(\'cdnEndPointName\'))]\",\r\n                \"[resourceId(\'Microsoft.Cdn/profiles\', " +
                    "variables(\'cdnProfileName\'))]\"\r\n            ],\r\n            \"properties\": {\r\n   " +
                    "             \"hostName\": \"[variables(\'hostName\')]\"\r\n            }\r\n        },\r\n " +
                    "       {\r\n            \"type\": \"Microsoft.Cdn/profiles/endpoints/origins\",\r\n     " +
                    "       \"apiVersion\": \"2020-04-15\",\r\n            \"name\": \"[concat(variables(\'cdnP" +
                    "rofileName\'), \'/\', variables(\'cdnProfileName\'), \'/\', variables(\'originHost\'))]\"," +
                    "\r\n            \"dependsOn\": [\r\n                \"[resourceId(\'Microsoft.Cdn/profil" +
                    "es/endpoints\', variables(\'cdnProfileName\'), variables(\'cdnEndPointName\'))]\",\r\n  " +
                    "              \"[resourceId(\'Microsoft.Cdn/profiles\', variables(\'cdnProfileName\')" +
                    ")]\"\r\n            ],\r\n            \"properties\": {\r\n                \"hostName\": \"[" +
                    "parameters(\'OriginHostHeader\')]\",\r\n                \"httpPort\": 80,\r\n            " +
                    "    \"httpsPort\": 443,\r\n                \"enabled\": true,\r\n                \"priori" +
                    "ty\": 1,\r\n                \"weight\": 1000,\r\n                \"originHostHeader\": \"[" +
                    "parameters(\'OriginHostHeader\')]\"\r\n            }\r\n        }\r\n    ]\r\n}\r\n");
            
            #line 321 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"

SaveOutputToSubFolder(codeGenPath, $"{data.Id}\\{data.TeamName.ToLower()}-{data.Name.ToLower()}-infra\\ArmTemplate", $"azuredeploy.cdnProfile{blue}.json");    

            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 325 "C:\research\azure-deploy\CodeTemplates\CdnProfile.tt"

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
private readonly bool isBlue;
public CdnProfile(string deployment, string rootTemplatePath, bool isBlue) {
    this.deployment = deployment;
    this.rootTemplatePath = rootTemplatePath;
    this.isBlue = isBlue;
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
    public class CdnProfileBase
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