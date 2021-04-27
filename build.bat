
dotnet publish -c Release -o release

xcopy "C:\GIT\familienfest\repro\familienfest\release\wwwroot" "C:\GIT\familienfest\repro\familienfest\docs" /s /e /h
pause