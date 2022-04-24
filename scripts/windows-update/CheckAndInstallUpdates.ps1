#Check what updates are required for this server
Get-WindowsUpdate

#Accept and install all the updates that it's found are required
Install-WindowsUpdate -AcceptAll