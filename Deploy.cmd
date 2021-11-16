@echo off
powershell -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\common\deploy.ps1""" -c Release %*"
exit /b %ErrorLevel%
