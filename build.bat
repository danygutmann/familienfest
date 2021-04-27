
dotnet publish -c Release -o release

BlazorReplaceRoot.exe "C:\GIT\familienfest\repro\familienfest\release\wwwroot\index.html" "familienfest"

xcopy "C:\GIT\familienfest\repro\familienfest\release\wwwroot" "C:\GIT\familienfest\repro\familienfest\docs" /s /e /h /Y
pause