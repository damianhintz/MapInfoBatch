@set pa=
@reg query "HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v PROCESSOR_ARCHITECTURE | find /i "amd64"
@if %errorlevel% equ 0 set pa= (x86)
@set path=%path%;c:\Program Files%pa%\GeoMedia Professional\Program\
@set loc="%CD%"
@set dll="%CD%"
@for %%f in (*.ini) do InstallUsrCmd "%cd%\%%~nf.dll" "%cd%\%%~nf.ini"
@pause