# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "src/EasyAbp.Abp.AspNetCoreRateLimit",
    "src/EasyAbp.Abp.AspNetCoreRateLimit.Client",
    "src/EasyAbp.Abp.AspNetCoreRateLimit.Ip"
)