# Update path for SSH (Loaded in PowerShell Profile)
$env:path += ";" + (Get-Item "Env:ProgramFiles").Value + "\Git\bin"
$env:path += ";" + (Get-Item "Env:ProgramFiles").Value + "\Git\usr\bin"

# Load SSH agent utils
. (Resolve-Path ~/Documents/WindowsPowershell/ssh-agent-utils.ps1)

# Spoof terminal environment for git color.
$env:TERM = 'cygwin'

# Load posh-git example profile, which will setup a prompt
. 'C:\tools\poshgit\dahlbyk-posh-git-9bda399\profile.example.ps1'

Pop-Location

Add-SshKey
