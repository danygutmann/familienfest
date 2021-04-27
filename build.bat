
dotnet publish -c Release -o release

xcopy "C:\GIT\familienfest\repro\familienfest\release\wwwroot" "C:\GIT\familienfest\repro\familienfest\docs" /s /e /h /Y

BlazorReplaceRoot.exe "C:\GIT\familienfest\repro\familienfest\docs\index.html" "familienfest"

pause