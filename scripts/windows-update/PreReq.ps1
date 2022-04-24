#TLS Setting
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

#Trust PowerShell Gallery - this will avoid you getting any prompts that it's untrusted
Set-PSRepository -Name 'PSGallery' -InstallationPolicy Trusted

#Install NuGet
Install-PackageProvider -name NuGet -Force

#Install Module
Install-Module PSWindowsUpdate