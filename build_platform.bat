@echo off
setlocal
rem | Compiles the library for a specific platform

rem Argument check
set argC=0
for %%x in (%*) do Set /A argC+=1

if %argC% NEQ 2 goto argfail

rem Globals
set baseDir=Compiled
set platform=%1
set arch=%2
set DefaultFrameworkDir=%WINDIR%\Microsoft.NET\Framework

if not defined FrameworkDir (
   set FrameworkDir=%DefaultFrameworkDir%
)

echo %FrameworkDir%
if not exist %FrameworkDir%\v4.0.30319 (
  ECHO.
  ECHO.
  echo .NET Framework 4.0 required.
  ECHO.
  ECHO.
  goto error
)

rem Directories
if not exist %baseDir% mkdir %baseDir%
set outputDir=%baseDir%\%platform%-%arch%
if not exist %outputDir% mkdir %outputDir%

rem Build
set msbuild=%FrameworkDir%\v4.0.30319\MSBuild.exe

if "%platform%"=="WindowsGL" (
  pushd MonoGame\ThirdParty\Lidgren.Network
  %msbuild% Lidgren.Network.Windows.csproj /p:Configuration=Release;OutputPath=bin\Linux\Release
  if errorlevel 1 goto error
  copy bin\Windows\Release\Lidgren.Network.dll ..\..\..\%outputDir%\
  popd
)

if "%platform%"=="Linux" (
  pushd MonoGame\ThirdParty\Lidgren.Network
  %msbuild% Lidgren.Network.Linux.csproj /p:Configuration=Release;OutputPath=bin\Linux\Release
  if errorlevel 1 goto error
  copy bin\Linux\Release\Lidgren.Network.dll ..\..\..\%outputDir%\
  popd
)

pushd MonoGame
%msbuild% Jypeli.MonoGame.Framework.%platform%.sln /t:Rebuild /p:Configuration=Release;Platform=%arch%
if errorlevel 1 goto error
copy MonoGame.Framework\bin\%platform%\%arch%\Release\*.dll ..\%outputDir%\
popd

pushd Jypeli
%msbuild% Jypeli-%platform%.sln /t:Rebuild /p:Configuration=Release;Platform=%arch%
if errorlevel 1 goto error
copy bin\%platform%\%arch%\Release\Jypeli.dll ..\%outputDir%\
copy bin\%platform%\%arch%\Release\Jypeli.xml ..\%outputDir%\
copy bin\%platform%\%arch%\Release\SDL.dll ..\%outputDir%\
copy bin\%platform%\%arch%\Release\smpeg.dll ..\%outputDir%\
popd

pushd SimplePhysics
%msbuild% SimplePhysics-%platform%.sln /t:Rebuild /p:Configuration=Release;Platform=%arch%
if errorlevel 1 goto error
copy bin\%platform%\%arch%\Release\Jypeli.SimplePhysics.dll ..\%outputDir%\
copy bin\%platform%\%arch%\Release\Jypeli.SimplePhysics.xml ..\%outputDir%\
popd

if not "%platform%"=="Win8" (
  pushd Physics2d
  %msbuild% Physics2d-%platform%.sln /t:Rebuild /p:Configuration=Release;Platform=%arch%
  if errorlevel 1 goto error
  copy bin\%platform%\%arch%\Release\Jypeli.Physics2d.dll ..\%outputDir%\
  copy bin\%platform%\%arch%\Release\Jypeli.Physics2d.xml ..\%outputDir%\
  popd
)

goto end

:argfail
echo Syntax: %0% (platform) (build architecture)
goto error

:error
endlocal
exit /B 1


:end
endlocal
