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
    
    #line 1 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class WebSiteStorageAccount : WebSiteStorageAccountBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n\r\n");
            this.Write("\r\n");
            
            #line 15 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"

Deployment data = JsonConvert.DeserializeObject<Deployment>(this.deployment);

var ipSecurityRestrictions = data.IpSecurityRestrictions;
var internalNetworkName = data.InternalNetworkName;
var application = data.TeamDisplayName;
var applicationType = data.ApplicationType;
var owner = data.Owner;
var teamName = data.TeamName;
var appName = data.Name;

var stages = data.WebDeploymentStages;

// DO NOT WIPE THE SOURCE CODE...
var codeGenPath = $"{this.rootTemplatePath}codegen\\";
var blue = (isBlue) ? "blue" : "";
var stageFileName = $"azuredeploy.storageaccount{blue}.json";

            
            #line default
            #line hidden
            this.Write(@"{
  ""$schema"": ""http://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#"",
  ""contentVersion"": ""1.0.0.0"",
  ""parameters"": {
    ""Environment"": {
        ""defaultValue"": """",
        ""type"": ""String""
    },
    ""DeploymentLocation"": {
        ""defaultValue"": """",
        ""type"": ""String""
    }
  },
  ""variables"": {
    ""teamName"": """);
            
            #line 46 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(teamName));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"appName\": \"");
            
            #line 47 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(appName));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"blue\": \"");
            
            #line 48 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(blue));
            
            #line default
            #line hidden
            this.Write(@""",
    ""storageAccountName"": ""[concat(variables('teamName'), parameters('Environment'), parameters('DeploymentLocation'), variables('appName'), variables('blue'), 'sa')]""
  },
  ""resources"": [
    {
      ""type"": ""Microsoft.Storage/storageAccounts"",
      ""apiVersion"": ""2018-07-01"",
      ""name"": ""[variables('storageAccountName')]"",
      ""location"": ""[resourceGroup().location]"",
      ""dependsOn"": [],
      ""tags"": {
        ""Environment"": ""[parameters('Environment')]"",
        ""Application"": """);
            
            #line 60 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(application));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"Owner\": \"");
            
            #line 61 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(owner));
            
            #line default
            #line hidden
            this.Write("\"\r\n      },\r\n      \"sku\": {\r\n        \"name\": \"Standard_RAGRS\",\r\n        \"tier\": \"" +
                    "Standard\"\r\n      },\r\n      \"kind\": \"StorageV2\",\r\n      \"properties\": {\r\n        " +
                    "\"networkAcls\": {\r\n            \"bypass\": \"AzureServices\",\r\n            \"virtualNe" +
                    "tworkRules\": [],\r\n            \"ipRules\": [],\r\n            \"defaultAction\": \"Allo" +
                    "w\"\r\n        },\r\n        \"supportsHttpsTrafficOnly\": true,\r\n        \"encryption\":" +
                    " {\r\n            \"services\": {\r\n                \"file\": {\r\n                    \"k" +
                    "eyType\": \"Account\",\r\n                    \"enabled\": true\r\n                },\r\n  " +
                    "              \"blob\": {\r\n                    \"keyType\": \"Account\",\r\n            " +
                    "        \"enabled\": true\r\n                }\r\n            },\r\n            \"keySour" +
                    "ce\": \"Microsoft.Storage\"\r\n        },\r\n        \"accessTier\": \"Hot\"\r\n      }\r\n    " +
                    "},\r\n    {\r\n        \"type\": \"Microsoft.Storage/storageAccounts/blobServices\",\r\n  " +
                    "      \"apiVersion\": \"2019-06-01\",\r\n        \"name\": \"[concat(variables(\'storageAc" +
                    "countName\'), \'/default\')]\",\r\n        \"dependsOn\": [\r\n            \"[resourceId(\'M" +
                    "icrosoft.Storage/storageAccounts\', variables(\'storageAccountName\'))]\"\r\n        ]" +
                    ",\r\n        \"sku\": {\r\n            \"name\": \"Standard_RAGRS\",\r\n            \"tier\": " +
                    "\"Standard\"\r\n        },\r\n        \"properties\": {\r\n            \"cors\": {\r\n        " +
                    "        \"corsRules\": []\r\n            },\r\n            \"deleteRetentionPolicy\": {\r" +
                    "\n                \"enabled\": false\r\n            }\r\n        }\r\n    },\r\n    {\r\n    " +
                    "    \"type\": \"Microsoft.Storage/storageAccounts/fileServices\",\r\n        \"apiVersi" +
                    "on\": \"2019-06-01\",\r\n        \"name\": \"[concat(variables(\'storageAccountName\'), \'/" +
                    "default\')]\",\r\n        \"dependsOn\": [\r\n            \"[resourceId(\'Microsoft.Storag" +
                    "e/storageAccounts\', variables(\'storageAccountName\'))]\"\r\n        ],\r\n        \"sku" +
                    "\": {\r\n            \"name\": \"Standard_RAGRS\",\r\n            \"tier\": \"Standard\"\r\n   " +
                    "     },\r\n        \"properties\": {\r\n            \"cors\": {\r\n                \"corsRu" +
                    "les\": []\r\n            }\r\n        }\r\n    },\r\n    {\r\n        \"type\": \"Microsoft.St" +
                    "orage/storageAccounts/blobServices/containers\",\r\n        \"apiVersion\": \"2019-06-" +
                    "01\",\r\n        \"name\": \"[concat(variables(\'storageAccountName\'), \'/default/$web\')" +
                    "]\",\r\n        \"dependsOn\": [\r\n            \"[resourceId(\'Microsoft.Storage/storage" +
                    "Accounts/blobServices\', variables(\'storageAccountName\'), \'default\')]\",\r\n        " +
                    "    \"[resourceId(\'Microsoft.Storage/storageAccounts\', variables(\'storageAccountN" +
                    "ame\'))]\"\r\n        ],\r\n        \"properties\": {\r\n            \"publicAccess\": \"Cont" +
                    "ainer\"\r\n        }\r\n    }\r\n  ],\r\n  \"outputs\": {\r\n  }\r\n}\r\n");
            
            #line 145 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"

SaveOutputToSubFolder(codeGenPath, $"{data.Id}\\{data.TeamName.ToLower()}-{data.Name.ToLower()}-infra\\ArmTemplate", stageFileName);    

            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 149 "C:\research\azure-deploy\CodeTemplates\WebSiteStorageAccount.tt"

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
public WebSiteStorageAccount(string deployment, string rootTemplatePath, bool isBlue) {
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
    public class WebSiteStorageAccountBase
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
