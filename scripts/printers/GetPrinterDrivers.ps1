# Change ExecutionPolicy for Powershell so we can run scripts
Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Scope LocalMachine -Force

Import-Module PrintManagement

Get-PrinterDriver

# Change ExecutionPolicy back for Powershell for security
Set-ExecutionPolicy -ExecutionPolicy Restricted -Scope LocalMachine -Force