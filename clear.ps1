#!/usr/bin/env pwsh
#requires -version 3

[System.Diagnostics.CodeAnalysis.SuppressMessage("PSUseApprovedVerbs", "")]
[CmdletBinding()]
param()

$ErrorActionPreference = "Stop"
$ProgressPreference = "SilentlyContinue"

trap { throw $Error[0] }

$root = Resolve-Path "$PSScriptRoot"
$sources = "$root\*"

$binDirectoryName = "bin"
$objDirectoryName = "obj"

$projectDirs = Get-ChildItem -Path $sources -Filter *.csproj -Recurse -ErrorAction SilentlyContinue -Force | Sort-Object -Property Directory | Select-Object -ExpandProperty Directory
$numProjectDirs = $projectDirs | Measure-Object | Select-Object -ExpandProperty Count
Write-Host "Found ${numProjectDirs} project directories"

$numBinDirectories = 0
$numObjDirectories = 0
$numVsmetaDirectories = 0
foreach ($dir in $projectDirs) {
    $binDirectory = "${dir}\${binDirectoryName}"
    $objDirectory = "${dir}\${objDirectoryName}"
    $vsmetaDirectory = "${dir}\.vs"

    if ([System.IO.Directory]::Exists($binDirectory)) {
        #Write-Host $binDirectory
        Remove-Item $binDirectory -Recurse -Force
        $numBinDirectories = $numBinDirectories + 1
    }

    if ([System.IO.Directory]::Exists($objDirectory)) {
        #Write-Host $objDirectory
        Remove-Item $objDirectory -Recurse -Force
        $numObjDirectories = $numObjDirectories + 1
    }

    if ([System.IO.Directory]::Exists($vsmetaDirectory)) {
        #Write-Host $vsmetaDirectory
        Remove-Item $vsmetaDirectory -Recurse -Force
        $numVsmetaDirectories = $numVsmetaDirectories + 1
    }
}

Write-Host "Deleted ${numBinDirectories} bins and ${numObjDirectories} objs"

$solutionDirs = Get-ChildItem -Path $sources -Filter *.sln -Recurse -ErrorAction SilentlyContinue -Force | Sort-Object -Property Directory | Select-Object -ExpandProperty Directory
$numSolutionDirs = $solutionDirs | Measure-Object | Select-Object -ExpandProperty Count
Write-Host "Found ${numSolutionDirs} solution directories"

foreach ($dir in $solutionDirs) {
    $vsmetaDirectory = "${dir}\.vs"
    if ([System.IO.Directory]::Exists($vsmetaDirectory)) {
        Remove-Item $vsmetaDirectory -Recurse -Force
        $numVsmetaDirectories = $numVsmetaDirectories + 1
    }
}

Write-Host "Deleted ${numVsmetaDirectories} .vs metadata directories"
