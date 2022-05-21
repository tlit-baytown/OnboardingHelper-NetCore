Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine -Force
#[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
#Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Force

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

Install-PackageProvider NuGet -Force

Set-PSRepository PSGallery -InstallationPolicy Trusted

#Module installs
Install-Module Microsoft.PowerShell.Management

#Module imports
Import-Module Microsoft.PowerShell.Management
Import-Module PrintManagement

#Check this module for an alternative to Powershell management: ComputerManagementDsc and ComputerManagement
#https://stackoverflow.com/questions/63385304/powershell-install-no-match-was-found-for-the-specified-search-criteria-and-mo
