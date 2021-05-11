using Newtonsoft.Json;
using ngCodeGen.CodeTemplates;
using System;
using System.IO;

namespace ngCodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootTemplatePath = @$"C:\research\azuredevops\azure-deploy\BaseTemplate\";

            var deployment = File.ReadAllText(rootTemplatePath + "WebDeployment.json");
            Deployment data = JsonConvert.DeserializeObject<Deployment>(deployment);

            var codeGenPath = $"{rootTemplatePath}CodeGen\\";

            CleanFolder(codeGenPath);

            //if (data.Type == DeploymentType.WebApp)
            //{
            //    var deploymentGenerator = new WebDeploymentGenerator(deployment, rootTemplatePath);
            //    deploymentGenerator.TransformText();

            //    var deploymentParametersGenerator = new WebDeploymentParameters(deployment, rootTemplatePath);
            //    deploymentParametersGenerator.TransformText();

            //    var deploymentEnvironmentGenerator = new WebDeploymentEnvironmentGenerator(deployment, rootTemplatePath);
            //    deploymentEnvironmentGenerator.TransformText();

            //    var deploymentYamlCIGenerator = new WebAzureYamlCIPipeline(deployment, rootTemplatePath);
            //    deploymentYamlCIGenerator.TransformText();

            //    var deploymentYamlCDGenerator = new WebAzureYamlCDPipeline(deployment, rootTemplatePath);
            //    deploymentYamlCDGenerator.TransformText();

            //    var deploymentReadMe = new ReadMe(deployment, rootTemplatePath, "");
            //    deploymentReadMe.TransformText();

            //    var deploymentGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
            //    deploymentGitIgnore.TransformText();

            //    // INGRESS INFRA
            //    bool ingress = false;
            //    if (data.IngressDeploymentStages != null && data.IngressDeploymentStages.Length > 0)
            //    {
            //        ingress = true;

            //        var deploymentIngressAgwGenerator = new AGWIngressDeployment(deployment, rootTemplatePath);
            //        deploymentIngressAgwGenerator.TransformText();
            //    }

            //    if (data.TmDeploymentStages != null && data.TmDeploymentStages.Length > 0)
            //    {
            //        ingress = true;

            //        var deploymentIngressTmGenerator = new TrafficManagerDeployment(deployment, rootTemplatePath);
            //        deploymentIngressTmGenerator.TransformText();
            //    }

            //    if (ingress)
            //    {
            //        var deploymentIngressYamlCDGenerator = new IngressYamlCDPipeline(deployment, rootTemplatePath);
            //        deploymentIngressYamlCDGenerator.TransformText();

            //        var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "ingress-");
            //        deploymentIngressReadMe.TransformText();

            //        var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "ingress-");
            //        deploymentIngressGitIgnore.TransformText();
            //    }
            //}
            //else if (data.Type == DeploymentType.FunctionApp)
            //{
            //    var deploymentGenerator = new AzureFunctionDeployment(deployment, rootTemplatePath);
            //    deploymentGenerator.TransformText();

            //    var deploymentYamlCDGenerator = new AzureFunctionYamlCDPipeline(deployment, rootTemplatePath);
            //    deploymentYamlCDGenerator.TransformText();

            //    var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "functionapp-");
            //    deploymentIngressReadMe.TransformText();

            //    var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "functionapp-");
            //    deploymentIngressGitIgnore.TransformText();
            //}
            //else if (data.Type == DeploymentType.WebJob)
            //{
            //    var deploymentGenerator = new AzureWebJobDeployment(deployment, rootTemplatePath);
            //    deploymentGenerator.TransformText();

            //    var deploymentYamlCDGenerator = new WebAzureYamlCDPipeline(deployment, rootTemplatePath);
            //    deploymentYamlCDGenerator.TransformText();

            //    var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "webjob-");
            //    deploymentIngressReadMe.TransformText();

            //    var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "webjob-");
            //    deploymentIngressGitIgnore.TransformText();
            //}





            if (!data.UseIndependentPlan && data.Type != DeploymentType.staticweb)
            {
                var deploymentPlanGenerator = new ServicePlan(deployment, rootTemplatePath);
                deploymentPlanGenerator.TransformText();

                var deploymentPlanParametersGenerator = new ServicePlanParameters(deployment, rootTemplatePath);
                deploymentPlanParametersGenerator.TransformText();

                var deploymentPlanEnvironmentGenerator = new ServicePlanEnvironment(deployment, rootTemplatePath);
                deploymentPlanEnvironmentGenerator.TransformText();

                var deploymentTeamReadMe = new ReadMe(deployment, rootTemplatePath, "");
                deploymentTeamReadMe.TransformText();

                var deploymentTeamGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
                deploymentTeamGitIgnore.TransformText();
            }

            if (data.Type == DeploymentType.webapp)
            {
                if (data.HasActionAlerts)
                {
                    var deploymentAlerts = new ActionGroups(deployment, rootTemplatePath);
                    deploymentAlerts.TransformText();
                }

                var deploymentGenerator = new WebDeploymentGenerator(deployment, rootTemplatePath);
                deploymentGenerator.TransformText();

                var deploymentParametersGenerator = new WebDeploymentParameters(deployment, rootTemplatePath);
                deploymentParametersGenerator.TransformText();

                var deploymentEnvironmentGenerator = new WebDeploymentEnvironmentGenerator(deployment, rootTemplatePath);
                deploymentEnvironmentGenerator.TransformText();

                var deploymentYamlCDGenerator = new WebAzureYamlCDPipeline(deployment, rootTemplatePath);
                deploymentYamlCDGenerator.TransformText();

                var deploymentReadMe = new ReadMe(deployment, rootTemplatePath, "");
                deploymentReadMe.TransformText();

                var deploymentGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
                deploymentGitIgnore.TransformText();
            }
            else if (data.Type == DeploymentType.functionapp)
            {
                var deploymentGenerator = new AzureFunctionDeployment(deployment, rootTemplatePath);
                deploymentGenerator.TransformText();

                var deploymentParametersGenerator = new AzureFunctionDeploymentParameter(deployment, rootTemplatePath);
                deploymentParametersGenerator.TransformText();

                var deploymentEnvironmentGenerator = new AzureFunctionEnvironmentGenerator(deployment, rootTemplatePath);
                deploymentEnvironmentGenerator.TransformText();

                var deploymentYamlCDGenerator = new WebAzureYamlCDPipeline(deployment, rootTemplatePath);
                deploymentYamlCDGenerator.TransformText();

                var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "");
                deploymentIngressReadMe.TransformText();

                var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
                deploymentIngressGitIgnore.TransformText();
            }
            else if (data.Type == DeploymentType.webjob)
            {
                var deploymentGenerator = new AzureWebJobDeployment(deployment, rootTemplatePath);
                deploymentGenerator.TransformText();

                var deploymentParametersGenerator = new AzureWebJobDeploymentParameter(deployment, rootTemplatePath);
                deploymentParametersGenerator.TransformText();

                var deploymentEnvironmentGenerator = new AzureWebJobDeploymentEnvironment(deployment, rootTemplatePath);
                deploymentEnvironmentGenerator.TransformText();

                var deploymentYamlCDGenerator = new WebAzureYamlCDPipeline(deployment, rootTemplatePath);
                deploymentYamlCDGenerator.TransformText();

                var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "");
                deploymentIngressReadMe.TransformText();

                var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
                deploymentIngressGitIgnore.TransformText();
            }
            else if (data.Type == DeploymentType.staticweb)
            {
                var deploymentGenerator = new WebSiteStorageAccount(deployment, rootTemplatePath, false);
                deploymentGenerator.TransformText();

                var webParametersGenerator = new WebSiteStorageAccountParameter(deployment, rootTemplatePath);
                webParametersGenerator.TransformText();

                var webEnvironmentGenerator = new WebSiteStorageAccountEnvironment(deployment, rootTemplatePath);
                webEnvironmentGenerator.TransformText();

                var cdnProfile = new CdnProfile(deployment, rootTemplatePath, false);
                cdnProfile.TransformText();

                var cdnProfileParametersGenerator = new CdnProfileParameters(deployment, rootTemplatePath);
                cdnProfileParametersGenerator.TransformText();

                var cdnProfileEnvironmentGenerator = new CdnProfileEnvironmentGenerator(deployment, rootTemplatePath);
                cdnProfileEnvironmentGenerator.TransformText();

                if (data.HasSlots)
                {
                    var deploymentGeneratorBlue = new WebSiteStorageAccount(deployment, rootTemplatePath, true);
                    deploymentGeneratorBlue.TransformText();

                    var webBlueParametersGenerator = new WebSiteStorageAccountParameter(deployment, rootTemplatePath);
                    webBlueParametersGenerator.TransformText();

                    var webBlueEnvironmentGenerator = new WebSiteStorageAccountEnvironment(deployment, rootTemplatePath);
                    webBlueEnvironmentGenerator.TransformText();

                    var cdnBlueProfile = new CdnProfile(deployment, rootTemplatePath, true);
                    cdnBlueProfile.TransformText();

                    var cdnBlueProfileParametersGenerator = new CdnProfileParameters(deployment, rootTemplatePath);
                    cdnBlueProfileParametersGenerator.TransformText();

                    var cdnBlueProfileEnvironmentGenerator = new CdnProfileEnvironmentGenerator(deployment, rootTemplatePath);
                    cdnBlueProfileEnvironmentGenerator.TransformText();
                }

                var deploymentYamlCDGenerator = new AzureStaticWebYamlCDPipeline(deployment, rootTemplatePath, data.HasSlots);
                deploymentYamlCDGenerator.TransformText();

                var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "");
                deploymentIngressReadMe.TransformText();

                var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "");
                deploymentIngressGitIgnore.TransformText();
            }

            // INGRESS INFRA
            bool ingress = false;
            if (data.IngressDeploymentStages != null && data.IngressDeploymentStages.Length > 0)
            {
                ingress = true;
                var deploymentIngressAgwGenerator = new AGWIngressDeployment(deployment, rootTemplatePath);
                deploymentIngressAgwGenerator.TransformText();

                var deploymentIngressYamlCDGenerator = new AgwIngressYamlCD(deployment, rootTemplatePath);
                deploymentIngressYamlCDGenerator.TransformText();
            }

            if (data.AfdDeploymentStages != null && data.AfdDeploymentStages.Length > 0)
            {
                ingress = true;
                var deploymentIngressAgwGenerator = new AFDIngressDeployment(deployment, rootTemplatePath);
                deploymentIngressAgwGenerator.TransformText();

                var deploymentIngressYamlCDGenerator = new AfdIngressYamlCDPipeline(deployment, rootTemplatePath);
                deploymentIngressYamlCDGenerator.TransformText();
            }

            if (data.TmDeploymentStages != null && data.TmDeploymentStages.Length > 0)
            {
                ingress = true;

                var deploymentIngressTmGenerator = new TrafficManagerDeployment(deployment, rootTemplatePath);
                deploymentIngressTmGenerator.TransformText();

                var deploymentIngressYamlCDGenerator = new TmIngressYamlCD(deployment, rootTemplatePath);
                deploymentIngressYamlCDGenerator.TransformText();
            }

            if (ingress)
            {
                var deploymentIngressReadMe = new ReadMe(deployment, rootTemplatePath, "ingress-");
                deploymentIngressReadMe.TransformText();

                var deploymentIngressGitIgnore = new GitIgnore(deployment, rootTemplatePath, "ingress-");
                deploymentIngressGitIgnore.TransformText();
            }

            Console.WriteLine("Code Generation Process Complete!!!");
        }

        private static void CleanFolder(string codeGenPath)
        {
            string templateDirectory = Path.GetDirectoryName(codeGenPath);
            if (Directory.Exists(templateDirectory))
            {
                Directory.Delete(templateDirectory, true);
                Directory.CreateDirectory(templateDirectory);
            }
        }
    }
}
