; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "WindowsOnTop"
#define MyAppVersion "1.0.0.1"
#define MyAppExeName "WindowOnTop.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (��Ҫ�����µ� GUID�����ڲ˵��е�� "����|���� GUID"��)
AppId={{C8CB1240-41B5-4CEA-9773-CF5B21180069}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; ������ȡ��ע�ͣ����ڷǹ���װģʽ�����У���Ϊ��ǰ�û���װ����
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
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

