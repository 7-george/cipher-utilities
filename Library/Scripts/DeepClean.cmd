takeown /f "%temp%" /r /d y
takeown /f "C:\Windows\Temp" /r /d y
takeown /f "C:\Windows\SoftwareDistribution" /r /d y


RD /S /Q C:\Windows\Temp
MKDIR C:\Windows\Temp


RD /S /Q %temp%
MKDIR %temp%


net stop UsoSvc
net stop wuauserv
RD /s /q C:\Windows\SoftwareDistribution
MD C:\Windows\SoftwareDistribution


del *.log /a /s /q /f