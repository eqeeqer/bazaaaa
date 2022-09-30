; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "My Program"
#define MyAppVersion "1.5"
#define MyAppPublisher "My Company, Inc."
#define MyAppExeName "WindowsFormsApplication1.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{067583A2-9BC0-476D-8495-6779F375460C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=E:\�������� ������\���������\license.txt
InfoBeforeFile=E:\�������� ������\���������\install.txt
InfoAfterFile=E:\�������� ������\���������\readme.txt
OutputDir=C:\Users\����\Desktop\����� �����
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\3.accdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\Help.chm"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\Help.hmxz"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\NewProject.pdf"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\�������� ������\Windows Forms Application\bin\Debug\WindowsFormsApplication1.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

