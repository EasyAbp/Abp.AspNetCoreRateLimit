# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "src/EasyAbp.Abp.UsingLimiter",
    "src/EasyAbp.Abp.UsingLimiter.Client",
    "src/EasyAbp.Abp.UsingLimiter.Ip"
)