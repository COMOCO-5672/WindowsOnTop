; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "WindowsOnTop"
#define MyAppVersion "1.0.0.1"
#define MyAppExeName "WindowOnTop.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (若要生成新的 GUID，可在菜单中点击 "工具|生成 GUID"。)
AppId={{C8CB1240-41B5-4CEA-9773-CF5B21180069}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; 以下行取消注释，以在非管理安装模式下运行（仅为当前用户安装）。
;PrivilegesRequired=lowest
OutputDir=D:\vsfile\WindowsOnTop
OutputBaseFilename=WindowsOnTop
SetupIconFile=C:\Users\COMOCO\Desktop\Icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\WindowOnTop.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\CommonServiceLocator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Extras.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Extras.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Extras.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Platform.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Platform.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.Platform.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\GalaSoft.MvvmLight.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\Lierda.WPFHelper.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\Lierda.WPFHelper.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\System.Windows.Interactivity.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\WindowOnTop.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\vsfile\WindowsOnTop\WindowOnTop\bin\Release\WindowOnTop.pdb"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

