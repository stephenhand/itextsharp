@echo off


set PACKAGE_VERSION=0.0.0.2

if not exist publish mkdir publish   || exit /b 1

nuget list iTextSharp.Core | findstr /e %PACKAGE_VERSION%
if %errorlevel% == 0 (
    echo iTextSharp.Core version %PACKAGE_VERSION% already published
) else (
	echo publishing BTMagma
	nuget pack iTextSharp.Core.nuspec -OutputDirectory  publish -Symbols -Version %PACKAGE_VERSION%
	nuget push publish/iTextSharp.Core.%PACKAGE_VERSION%.nupkg -s http://localhost:49928/  blu3tr33g3n13
)
