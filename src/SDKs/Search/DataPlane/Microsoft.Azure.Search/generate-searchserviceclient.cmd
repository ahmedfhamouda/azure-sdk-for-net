::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
set autoRestVersion=1.0.0-Nightly20170110
if  "%1" == "" (
    set specFile="https://raw.githubusercontent.com/Azure/azure-rest-api-specs-pr/search-service/search/2016-09-01-Preview/swagger/searchservice.json"
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..\..
set generateFolder=%~dp0GeneratedSearchService
set header=MICROSOFT_MIT_NO_VERSION

if exist %generateFolder% rd /S /Q  %generateFolder%
call "%repoRoot%\tools\autorest.gen.cmd" %specFile% Microsoft.Azure.Search %autoRestVersion% %generateFolder% %header%
