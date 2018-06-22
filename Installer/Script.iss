; #######################################################################################
; # This Inno Setup script was generated by Visual & Installer for MS Visual Studio     #
; # Visual & Installer (c) 2012 - 2018 unSigned, s. r. o. All Rights Reserved.          #
; # Visit http://www.visual-installer.com/ for more details.                            #
; #######################################################################################

; This script is perhaps one of the simplest Inno Setup installer you can make. 
; All of the optional settings are left to their default settings. 

; See the Inno Setup documentation at http://www.jrsoftware.org/ for details on creating script files!    

;--------------------------------

[Setup]
AppName=Installer
AppVersion=1.0
DefaultDirName={pf}\Installer
DefaultGroupName=Installer
UninstallDisplayIcon={app}\Installer.exe
Compression=lzma2
SolidCompression=yes
OutputDir=Output
OutputBaseFilename=Installer

[Files]
Source: "Script.iss"; DestDir: "{app}"

[Icons]
Name: "{group}\Installer"; Filename: "{app}\Installer.exe"

[Code]

// Place your code here...   
