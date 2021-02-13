xs@echo off


set Schemapath=Schema
set Outputpath=../../Generated
set Namepl=Mim.V6301

echo.Starting processing MIM XSD files ...
for /f %%a IN ('dir %Schemapath%\*.xsd /a-d /b /s') do call:ProcessSchema %%a

echo.Finished processing XSD files ...
echo.&pause&
goto:eof


:ProcessSchema
Xsd2Code %~1 %Namepl% %Outputpath% /m /pl Net35 /if- /xa /sc /is /cl /c Array /eit /sdefault+ /sskipnull+
echo.Processed %~n1
goto:eof
