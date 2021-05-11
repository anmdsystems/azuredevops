# Link for Azure Devops Application Setup

https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fanmdsystems%2Fazuredevops%2Fmain%2Ftemplate.json

# Features
  <ul>
      <li>
          Define Environments and Infra Configurations.
      </li>
      <li>
          Manage Teams - Applications and Database Keyvaults.  
      </li>
      <li>
          Define Azure Application Registrations, Service Principals and Devops Service Connections for Configured Applications.
      </li>
      <li>
          Provision Resource Groups, Service Connections and Validate Ingress for Application CI/CD Pipelines.
      </li>
      <li>
          Generate CI/CD Pipelines for Application's Infra Automation.
      </li>
  </ul>
  
# PreRequisites
  # Create a new Azure AD Application Registration, Grant Permissions Below.
  <ul>
      <li>
          Azure Service Management - Delegated (user_impersonation)
      </li>
      <li>
          Micrososft Graph - Application (Application.ReadWrite.OwnedBy)
      </li>
      <li>
          Micrososft Graph - Delegated (User.Read)
      </li>
  </ul>

  # Use Existing or Create a New Linux App Service Plan - B1 or above
      Note the App Service Plan and Resource Group.

# Using Console App to Generate CI/CD Templates instead?
  # On Windows
    <ul>
      <li>
          Change rootTemplatePath int the Main to desired location.   
          var rootTemplatePath = @$"C:\research\azuredevops\azure-deploy\BaseTemplate\";
      </li>
      <li>
          Edit BaseTemplate\webDeployment.json to desired configurations
      </li>
      <li>
          Run the Console App to Generate the CI/CD Pipelines.
      </li>
      <li>
          LICENSE TERMS - MIT
      </li>
    </ul>

