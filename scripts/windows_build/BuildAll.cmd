@echo off
cd %~dp0
set App=MathBotCLI
title %App% Compiler 
echo DMC C# Universal Compiling Script for %App%
echo.
echo Compiling %App%
echo.
cd ..\..\src\Windows\
dotnet build MathBotCLI.csproj --nologo -c Release -o bin\Release\net8.0-windows10.0.17763.0
echo.
echo Application Compiled!
echo.
echo Compiling %App% Installer
echo.
cd /d "C:\Program Files (x86)\NSIS\"
makensis.exe %~dp0\main.nsi
echo.
echo Installer Compiled!
pause
exit