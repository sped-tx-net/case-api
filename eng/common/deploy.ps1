[CmdletBinding(PositionalBinding=$false)]
Param(
[Alias("c")][string]$Configuration = "Debug",
[Alias("k")][string]$ApiKey = "d3cb76e3-890c-4874-a882-267e518aee3d",
[Alias("s")][string]$Server = "https://www.myget.org/F/sped-mobi/api/v2/package"
)

Write-Host "Downloading nuget..." -NoNewline

wget -Uri 'https://dist.nuget.org/win-x86-commandline/latest/nuget.exe' -OutFile nuget.exe

Write-Host "Success!" -ForegroundColor Green  

$NuGetDir = Join-Path -Path "$PSScriptRoot\..\..\" -ChildPath "artifacts\packages\$Configuration\Shipping\"


Write-Host "Pushing Packages..." -NoNewline
Get-ChildItem -Path $NuGetDir -Filter *.nupkg | ForEach-Object -Process {
    $NuPkgFile = $_
    $NuPkgFilePath = $NuPkgFile.FullName
    Start-Process nuget.exe -NoNewWindow -ArgumentList "push $NuPkgFilePath $ApiKey -Source $Server" -Wait
    Write-Host "Success!" -ForegroundColor Green  

}

