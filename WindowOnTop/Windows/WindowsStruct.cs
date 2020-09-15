using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowOnTop.Windows
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    #region CPU
    public struct CPUInformation
    {
        public uint core;
        public string type;
        public uint level2;
        public uint masterfrequency;
    }
    #endregion

    #region Memory

    public struct MemoryInformation
    {
        public double AvailablePageFile;
        public double AvailablePhysicalMemory;
        public double AvailableVirtualMemory;
        public uint SizeofStructure;
        public double MemoryInUse;
        public double TotalPageSize;
        public double TotalPhysicalMemory;
        public double TotalVirtualMemory;
    }

    #endregion

    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    #region SYSTEMTIME

    public struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }

    #endregion

    #region WINDOWPLACEMENT

    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPLACEMENT
    {
        public int length;
        public int flags;
        public int showCmd;
        public Point ptMinPosition;
        public Point ptMaxPosition;
        public Rectangle rcNormalPosition;
    }

    #endregion

    #region OFSTRUCT

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OFSTRUCT
    {
        public byte cBytes;
        public byte fFixedDisk;
        public UInt16 nErrCode;
        public UInt16 Reserved1;
        public UInt16 Reserved2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string szPathName;
    }

    #endregion

    #region _SHFILEOPSTRUCT

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class _SHFILEOPSTRUCT
    {
        public IntPtr hwnd;
        public UInt32 wFunc;
        public string pFrom;
        public string pTo;
        public UInt16 fFlags;
        public Int32 fAnyOperationsAborted;
        public IntPtr hNameMappings;
        public string lpszProgressTitle;
    }

    #endregion

    #region COPYDATASTRUCT

    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }

    #endregion

    #region WindowInfo

    public struct WindowInfo
    {
        public IntPtr hWnd;
        public string szWindowName;
        public string szClassName;
    }

    public struct WINDOWINFO
    {
        public int cbSize;
        public Rectangle rcWindow;
        public Rectangle rcClient;
        public int dwStyle;
        public int dwExStyle;
        public int dwWindowStatus;
        public uint cxWindowBorders;
        public uint cyWindowBorders;
        public int atomWindowType;
        public int wCreatorVersion;
        public IntPtr hWnd;
        public string szWindowName;
        public string szClassName;
        public string szExePath;
    }

    #endregion

    #region SYSTEM_INFO

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        public uint dwOemId;
        public uint dwPageSize;
        public uint lpMinimumApplicationAddress;
        public uint lpMaximumApplicationAddress;
        public uint dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public uint dwProcessorLevel;
        public uint dwProcessorRevision;
    }

    #endregion

    #region MEMORYSTATUS

    //struct 收集内存情况 
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUS
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public uint dwTotalPhys;
        public uint dwAvailPhys;
        public uint dwTotalPageFile;
        public uint dwAvailPageFile;
        public uint dwTotalVirtual;
        public uint dwAvailVirtual;
    }

    #endregion

    #region TokPriv1Luid

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TokPriv1Luid
    {
        public int Count;
        public long Luid;
        public int Attr;
    }

    #endregion

    #region DEVMODE

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DEVMODE
    {
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        //public string dmDeviceName;
        //public short dmSpecVersion;
        //public short dmDriverVersion;
        //public short dmSize;
        //public short dmDriverExtra;
        //public int dmFields;
        //public int dmPositionX;
        //public int dmPositionY;
        //public DMDO dmDisplayOrientation;
        //public int dmDisplayFixedOutput;
        //public short dmColor;
        //public short dmDuplex;
        //public short dmYResolution;
        //public short dmTTOption;
        //public short dmCollate;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        //public string dmFormName;
        //public short dmLogPixels;
        //public int dmBitsPerPel;
        //public int dmPelsWidth;
        //public int dmPelsHeight;
        //public int dmDisplayFlags;
        //public int dmDisplayFrequency;
        //public int dmICMMethod;
        //public int dmICMIntent;
        //public int dmMediaType;
        //public int dmDitherType;
        //public int dmReserved1;
        //public int dmReserved2;
        //public int dmPanningWidth;
        //public int dmPanningHeight;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;
        public int dmSpecVersion;
        public int dmDriverVersion;
        public int dmSize;
        public int dmDriverExtra;
        public int dmFields;

        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;

        public Point dmPosition;
        public int dmDisplayOrientation;
        public int dmDisplayFixedOutput;

        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        public int dmLogPixels;
        public int dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;

        public int dmDisplayFlags;
        public int dmNup;
        public int dmDisplayFrequency;
        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;
        public int dmPanningWidth;
        public int dmPanningHeight;

    }

    #endregion

    #region COMBOBOXINFO

    public struct COMBOBOXINFO
    {
        public int cbSize;
        public Rectangle rcItem;
        public Rectangle rcButton;
        public int stateButton;
        public IntPtr hwndCombo;
        public IntPtr hwndItem;
        public IntPtr hwndList;
    }

    #endregion

    #region SHELLEXECUTEINFO

    [StructLayout(LayoutKind.Sequential)]
    public struct SHELLEXECUTEINFO //用于ShellExecuteEx
    {
        public int cbSize;
        public int fMask;
        public IntPtr hwnd;
        public string lpVerb;
        public string lpFile;
        public string lpParameters;
        public string lpDirectory;
        public int nShow;
        public IntPtr hInstApp;
        public IntPtr lpIDList;
        public string lpClass;
        public IntPtr hkeyClass;
        public int dwHotKey;
        public IntPtr hIcon;
        public IntPtr hProcess;
    }

    #endregion

    #region WIN32_FIND_DATA

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto), BestFitMapping(false)]
    public struct WIN32_FIND_DATA
    {
        public int dwFileAttributes;
        public int ftCreationTime_dwLowDateTime;
        public int ftCreationTime_dwHighDateTime;
        public int ftLastAccessTime_dwLowDateTime;
        public int ftLastAccessTime_dwHighDateTime;
        public int ftLastWriteTime_dwLowDateTime;
        public int ftLastWriteTime_dwHighDateTime;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int dwReserved0;
        public int dwReserved1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    #endregion

    #region OSVERSIONINFO

    [StructLayout(LayoutKind.Sequential)]
    public struct OSVERSIONINFO
    {
        public int dwOSVersionInfoSize;
        public int dwMajorVersion;
        public int dwMinorVersion;
        public int dwBuildNumber;
        public int dwPlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
    }

    #endregion

    #region OSVERSIONINFOEX

    [StructLayout(LayoutKind.Sequential)]
    public struct OSVERSIONINFOEX
    {
        public int dwOSVersionInfoSize;
        public int dwMajorVersion;
        public int dwMinorVersion;
        public int dwBuildNumber;
        public int dwPlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;
        public Int16 wServicePackMajor;
        public Int16 wServicePackMinor;
        public Int16 wSuiteMask;
        public Byte wProductType;
        public Byte wReserved;
    }

    #endregion

    #region OPENFILENAME

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class OPENFILENAME
    {
        public int structSize = 0;
        public IntPtr dlgOwner = IntPtr.Zero;
        public IntPtr instance = IntPtr.Zero;
        public String filter = null;
        public String customFilter = null;
        public int maxCustFilter = 0;
        public int filterIndex = 0;
        public String file = null;
        public int maxFile = 0;
        public String fileTitle = null;
        public int maxFileTitle = 0;
        public String initialDir = null;
        public String title = null;
        public int flags = 0;
        public short fileOffset = 0;
        public short fileExtension = 0;
        public String defExt = null;
        public IntPtr custData = IntPtr.Zero;
        public IntPtr hook = IntPtr.Zero;
        public String templateName = null;
        public IntPtr reservedPtr = IntPtr.Zero;
        public int reservedInt = 0;
        public int flagsEx = 0;
    }


    #endregion

    #region STARTUPINFO

    [StructLayout(LayoutKind.Sequential)]
    public struct STARTUPINFO
    {
        public int cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public int dwX;
        public int dwY;
        public int dwXSize;
        public int dwYSize;
        public int dwXCountChars;
        public int dwYCountChars;
        public int dwFillAttribute;
        public int dwFlags;
        public int wShowWindow;
        public int cbReserved2;
        public byte lpReserved2;
        public IntPtr hStdInput;
        public IntPtr htdOutput;
        public IntPtr hStdError;
    }

    #endregion

    #region _FILETIME

    public struct _FILETIME
    {
        public int dwLowDateTime;
        public int dwHighDateTime;
    }

    #endregion

    #region INTERNET_CACHE_ENTRY_INFO

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct INTERNET_CACHE_ENTRY_INFO
    {
        public int dwStructSize;
        public IntPtr lpszSourceUrlName;
        public IntPtr lpszLocalFileName;
        public int CacheEntryType;
        public int dwUseCount;
        public int dwHitRate;
        public int dwSizeLow;
        public int dwSizeHigh;
        public _FILETIME LastModifiedTime;
        public _FILETIME ExpireTime;
        public _FILETIME LastAccessTime;
        public _FILETIME LastSyncTime;
        public IntPtr lpHeaderInfo;
        public int dwHeaderInfoSize;
        public IntPtr lpszFileExtension;
        public int dwExemptDelta;
    }

    #endregion

    #region PROCESS_INFORMATION

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public uint dwProcessId;
        public uint dwThreadId;
    }

    #endregion

    #region SECURITY_ATTRIBUTES

    [StructLayout(LayoutKind.Sequential)]
    public class SECURITY_ATTRIBUTES
    {
        public int nLength;
        public string lpSecurityDescriptor;
        public bool bInheritHandle;
    }

    #endregion

    #region MODULEENTRY32

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct MODULEENTRY32
    {
        public int dwSize;
        public int th32ModuleID;
        public int th32ProcessID;
        public int GlblcntUsage;
        public int ProccntUsage;
        public byte modBaseAddr;
        public int modBaseSize;
        public IntPtr hModule;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szModule;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szExePath;
    }

    #endregion

    #region SCROLLINFO

    public struct SCROLLINFO
    {
        public uint cbSize;
        public uint fMask;
        public int nMin;
        public int nMax;
        public uint nPage;
        public int nPos;
        public int nTrackPos;
    }

    #endregion

    #region DISPLAY_DEVICE

    public struct DISPLAY_DEVICE
    {
        public int cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        public int StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    #endregion

    #region SHFILEINFO

    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public int dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    #endregion

    #region FLASHWINFO

    public struct FLASHWINFO
    {
        public uint cbSize;
        public IntPtr hwnd;
        public int dwFlags;
        public uint uCount;
        public int dwTimeout;
    }

    #endregion

    #region FINDREPLACE

    public delegate UInt32 FRHookProc(System.IntPtr hdlg, UInt32 uiMsg, UInt32 wParam, UInt32 lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct FINDREPLACE
    {
        public int lStructSize;
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public int Flags;
        public string lpstrFindWhat;
        public string lpstrReplaceWith;
        public UInt16 wFindWhatLen;
        public UInt16 wReplaceWithLen;
        public UInt32 lCustData;
        public FRHookProc lpfnHook;
        public string lpTemplateName;
    }

    #endregion

    #region CHOOSECOLOR

    //public delegate UInt32 CCHOOKPROC(IntPtr hdlg, UInt32 uiMsg, UInt32 wParam, UInt32 lParam);

    //[StructLayout(LayoutKind.Sequential)]
    //public struct CHOOSECOLOR
    //{
    //    public int lStructSize;
    //    public IntPtr hwndOwner;
    //    public IntPtr hInstance;
    //    public int rgbResult;
    //    public int lpCustColors;
    //    public int Flags;
    //    public CCHOOKPROC lCustData;
    //    public long lpfnHook;
    //    public string lpTemplateName;
    //}
    public delegate IntPtr WndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class CHOOSECOLOR
    {
        public int lStructSize = Marshal.SizeOf(typeof(CHOOSECOLOR));
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public int rgbResult;
        public IntPtr lpCustColors;
        public int Flags;
        public IntPtr lCustData = IntPtr.Zero;
        public WndProc lpfnHook;
        public string lpTemplateName;
    }



    #endregion

    #region CHOOSEFONT

    //public delegate UInt32 CFHOOKPROC();

    //[StructLayout(LayoutKind.Sequential)]
    //public struct CHOOSEFONT
    //{
    //    public int lStructSize;
    //    public IntPtr hwndOwner;
    //    public IntPtr hDC;
    //    public LOGFONT lpLogFont;
    //    public int iPointSize;
    //    public long Flags;
    //    public int rgbColors;
    //    public UInt32 lCustData;
    //    public CFHOOKPROC lpfnHook;
    //    public string lpTemplateName;
    //    public IntPtr hInstance;
    //    public string lpszStyle;
    //    public int nFontType;
    //    public int nSizeMin;
    //    public int nSizeMax;
    //}

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class CHOOSEFONT
    {
        public int lStructSize = Marshal.SizeOf(typeof(CHOOSEFONT));
        public IntPtr hwndOwner;
        public IntPtr hDC;
        public IntPtr lpLogFont;
        public int iPointSize;
        public int Flags;
        public int rgbColors;
        public IntPtr lCustData = IntPtr.Zero;
        public WndProc lpfnHook;
        public string lpTemplateName;
        public IntPtr hInstance;
        public string lpszStyle;
        public short nFontType;
        public short ___MISSING_ALIGNMENT__;
        public int nSizeMin;
        public int nSizeMax;
    }

    #endregion

    #region LOGFONT

    //public struct LOGFONT
    //{
    //    public long lfHeight;
    //    public long lfWidth;
    //    public long lfEscapement;
    //    public long lfOrientation;
    //    public long lfWeight;
    //    public byte lfItalic;
    //    public byte lfUnderline;
    //    public byte lfStrikeOut;
    //    public byte lfCharSet;
    //    public byte lfOutPrecision;
    //    public byte lfClipPrecision;
    //    public byte lfQuality;
    //    public byte lfPitchAndFamily;
    //    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    //    public string lfFaceName;
    //}

    [StructLayout(LayoutKind.Sequential)]
    public class LOGFONT
    {
        public const int LF_FACESIZE = 32;
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = LF_FACESIZE)]
        public string lfFaceName;
    }

    #endregion

    #region MENUINFO

    public struct MENUINFO
    {
        public int cbSize;
        public int fMask;
        public int dwStyle;
        public int cyMax;
        public IntPtr hbrBack;
        public int dwContextHelpID;
        public int dwMenuData;
    }

    #endregion

    #region MENUITEMINFO

    [StructLayout(LayoutKind.Sequential)]
    public struct MENUITEMINFO
    {
        public uint cbSize;
        public uint fMask;
        public uint fType;
        public uint fState;
        public int wID;
        public int hSubMenu;
        public int hbmpChecked;
        public int hbmpUnchecked;
        public int dwItemData;
        public IntPtr dwTypeData;
        public uint cch;
    }

    //[StructLayout(LayoutKind.Sequential)]
    //public struct MENUITEMINFO
    //{
    //    public uint cbSize;
    //    public uint fMask;
    //    public uint fType;
    //    public uint fState;
    //    public int wID;
    //    public int     /**//*HMENU*/       hSubMenu;
    //    public int     /**//*HBITMAP*/       hbmpChecked;
    //    public int     /**//*HBITMAP*/       hbmpUnchecked;
    //    public int     /**//*ULONG_PTR*/   dwItemData;
    //    public IntPtr dwTypeData;
    //    public uint cch;
    //    public int   /**//*HBITMAP*/   hbmpItem;
    //}

    #endregion

    #region MSG

    public struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public int wParam;
        public int lParam;
        public int time;
        public Point pt;
    }

    #endregion

    #region WNDCLASS

    public delegate string CallBack(IntPtr hwnd, int lParam);
    public delegate int WNDPROC(IntPtr hwnd, uint uMsg, int wParam, int lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASS
    {
        public uint style;
        public WNDPROC lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
    }

    #endregion

    #region NOTIFYICONDATA

    [StructLayout(LayoutKind.Sequential)]
    public struct NOTIFYICONDATA
    {
        public int cbSize;
        public IntPtr hWnd;
        public uint uID;
        public uint uFlags;
        public uint uCallbackMessage;
        public IntPtr hIcon;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szTip;
        public int dwState;
        public int dwStateMask;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szInfo;
        public uint uTimeout;
        public uint uVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szInfoTitle;
        public int dwInfoFlags;
    }

    #endregion

    #region BY_HANDLE_FILE_INFORMATION

    public struct BY_HANDLE_FILE_INFORMATION
    {
        public int dwFileAttributes;
        public _FILETIME ftCreationTime;
        public _FILETIME ftLastAccessTime;
        public _FILETIME ftLastWriteTime;
        public int dwVolumeSerialNumber;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int nNumberOfLinks;
        public int nFileIndexHigh;
        public int nFileIndexLow;
        public int dwOID;
    }

    #endregion

    #region ProcessInfo

    public struct ProcessInfo
    {
        public IntPtr hwnd;
        public string ClassName;
        public string WindowText;
        public string path;
        public int processsize;
        public Point location;
        public Size wsize;
        public Size csize;
        public DateTime starttime;
        public string runtime;
        public IntPtr phwnd;
        public int id;
        public string text;
        public int dwStyle;
        public int dwExStyle;
        public uint cxWindowBorders;
        public uint cyWindowBorders;
    }

    #endregion

    #region MODULEINFO

    public struct MODULEINFO
    {
        public IntPtr lpBaseOfDll;
        public int SizeOfImage;
        public IntPtr EntryPoint;
    }

    #endregion

    #region ServiceEnumInfo

    public struct ServiceEnumInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string szPrefix;
        public string szDllName;
        public IntPtr hServiceHandle;
        public int dwServiceState;
    }

    #endregion

    #region TIME_ZONE_INFORMATION

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct TIME_ZONE_INFORMATION
    {
        public long Bias;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string StandardName;
        public SYSTEMTIME StandardDate;
        public long StandardBias;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DaylightName;
        SYSTEMTIME DaylightDate;
        public long DaylightBias;
    }

    #endregion

    #region ICONINFO

    public struct ICONINFO
    {
        public bool fIcon;
        public int xHotspot;
        public int yHotspot;
        public IntPtr hbmMask;
        public IntPtr hbmColor;
    }

    #endregion

    #region MONITORINFO

    public struct MONITORINFO
    {
        public int cbSize;
        public Rectangle rcMonitor;
        public Rectangle rcWork;
        public int dwFlags;
    }

    #endregion

    #region MONITORINFOEX

    public struct MONITORINFOEX
    {
        public int cbSize;
        public Rectangle rcMonitor;
        public Rectangle rcWork;
        public int dwFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string szDevice;
    }

    #endregion

    #region INPUT

    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT
    {
        [System.Runtime.InteropServices.FieldOffset(0)]
        public int type;
        [System.Runtime.InteropServices.FieldOffset(4)]
        public MOUSEINPUT mi;
        [System.Runtime.InteropServices.FieldOffset(4)]
        public KEYBDINPUT ki;
        [System.Runtime.InteropServices.FieldOffset(4)]
        public HARDWAREINPUT hi;
    }

    #endregion

    #region KEYBDINPUT

    [StructLayout(LayoutKind.Sequential)]
    public struct KEYBDINPUT
    {
        public short wVk;
        public short wScan;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }

    #endregion

    #region MOUSEINPUT

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }

    #endregion

    #region HARDWAREINPUT

    [StructLayout(LayoutKind.Sequential)]
    public struct HARDWAREINPUT
    {
        public int uMsg;
        public short wParamL;
        public short wParamH;
    }

    #endregion

    #region DRAWTEXTPARAMS

    public struct DRAWTEXTPARAMS
    {
        public uint cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        public uint uiLengthDrawn;
    }
    #endregion
}
