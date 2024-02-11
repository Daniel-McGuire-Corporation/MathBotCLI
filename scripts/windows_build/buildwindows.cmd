@echo off
echo DMC Compiler (Windows .NET)
cd ..\..\src\Windows\
dotnet build MathBotCLI.csproj --nologo -c Release -o bin\Release\net7.0
cd ..\Windows-NSIS-PathVari\PathEd\
dotnet build PathEd.csproj --nologo -c Release -o ..\..\Windows\bin\Release\net7.0\Path\
pause
