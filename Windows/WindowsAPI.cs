using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpCommon.Windows
{
    public static class WindowsAPI
    {
        /// <summary>
        /// 给句柄发送指令消息，等待消息处理完成
        /// </summary>
        /// <param name="handle">指定句柄</param>
        /// <param name="message">消息指令：如click</param>
        /// <param name="wParam">默认都为 - 0</param>
        /// <param name="lParam">默认都为 - 0</param>
        /// <returns>返回的结果</returns>
        [DllImport("user32.dll")]
        public static extern UInt32 SendMessage(IntPtr handle, UInt32 message, UInt32 wParam, UInt32 lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr handle, uint message, int WParam, IntPtr LParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int PostMessage(IntPtr handle, uint message, int WParam, int LParam);

        /// <summary>
        /// 判断按钮的可使用状态
        /// </summary>
        /// <param name="handle">按钮的句柄</param>
        /// <returns>True：按钮可使用 || False：不可使用(灰色状态)</returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled(IntPtr handle);

        /// <summary>
        ///  键盘操作指令
        /// </summary>
        /// <param name="bVk">键盘指令：Enter，F1等键盘按钮，使用Keys枚举即可</param>
        /// <param name="bScan">默认都为 - 0</param>
        /// <param name="dwFlags">默认都为 - 0</param>
        /// <param name="dwExtraInfo">默认都为 - 0</param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(Byte bVk, Byte bScan, Int32 dwFlags, Int32 dwExtraInfo);

        /// <summary>
        ///  设置鼠标操作指令
        /// </summary>
        /// <param name="flag">指令类型：单击，移动，双击</param>
        /// <param name="x">X坐标的位置</param>
        /// <param name="y">Y坐标的位置</param>
        /// <param name="cButtons">默认都为 - 0</param>
        /// <param name="dwExtraInfo">默认都为 - 0</param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int flag, int x, int y, int cButtons, int dwExtraInfo);

        /// <summary>
        /// 获取控件句柄在屏幕上的位置
        /// </summary>
        /// <param name="handle">控件的句柄</param>
        /// <param name="rectangle">坐标信息</param>
        /// <returns>返回的结果</returns>
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr handle, out Rectangle rectangle);

        [DllImport("user32.dll")]
        public static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetNextWindow(IntPtr hWnd, uint wCmd);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr processHandle, IntPtr memoryAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFreeEx(IntPtr processHandle, IntPtr memoryAddress, int dwSize, int dwFreeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr processHandle, IntPtr lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);


        #region TOP 100

        #region ShellAbout 1

        /// <summary>
        /// Show Windows About Dialog.
        /// </summary>
        /// <param name="hWnd">This handle.</param>
        /// <param name="caption">Caption.</param>
        /// <param name="text">Context.</param>
        /// <param name="iconHandle">Icon Handle.</param>
        /// <returns>Return Int Type Value.</returns>
        /// <example>WindowsAPI.ShellAbout(this.Handle, "caption", "text", this.Icon.Handle.ToInt32());</example>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string caption, string text, IntPtr iconHandle);

        #endregion

        #region BlockInput 2

        /// <summary>
        /// Enable/Disable Both Keyboard and Mouse Input
        /// </summary>
        /// <param name="enable">Status.</param>
        /// <returns>Whether success.</returns>
        /// <example>WindowsAPI.BlockInput(true);</example>
        [DllImport("user32.dll")]
        public extern static bool BlockInput(bool enable);

        #endregion

        #region SendMessage 3_重载_4

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr HWnd, uint Msg, int WParam, int LParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr HWnd, uint Msg, int WParam, ref COPYDATASTRUCT lParam);

        [DllImport("user32.dll ", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, uint wMsg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll ", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, uint wMsg, int wParam, string lParam);

        [DllImport("user32.dll ", EntryPoint = "SendMessageA")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint wMsg, IntPtr wParam, IntPtr lParam);

        #endregion

        #region MessageBox 4

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, int uType);

        #endregion

        #region GetShortPathName 5_重载_2

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, int cchBuffer);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(string lpszLongPath, string lpszShortPath, int cchBuffer);

        #endregion

        #region mciSendString 6

        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int cchReturn, IntPtr hwndCallback);

        #endregion

        #region BitBlt 7

        /// <summary>
        /// 将一幅位图从一个设备场景复制到另一个
        /// </summary>
        /// <param name="handle">目标设备场景</param>
        /// <param name="nXDest">对目标DC中目标矩形左上角位置进行描述的那个点。用目标DC的逻辑坐标表示</param>
        /// <param name="nYDest">对目标DC中目标矩形左上角位置进行描述的那个点。用目标DC的逻辑坐标表示</param>
        /// <param name="nWidth">欲传输图象的宽度和高度</param>
        /// <param name="nHeight">欲传输图象的宽度和高度</param>
        /// <param name="hObjectSource">源设备场景。如光栅运算未指定源，则应设为0</param>
        /// <param name="nXSrc">对源DC中源矩形左上角位置进行描述的那个点。用源DC的逻辑坐标表示</param>
        /// <param name="nYSrc">对源DC中源矩形左上角位置进行描述的那个点。用源DC的逻辑坐标表示</param>
        /// <param name="dwRop">传输过程要执行的光栅运算</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr handle, int nXDest,
                                                 int nYDest, int nWidth,
                                                 int nHeight, IntPtr hObjectSource,
                                                 int nXSrc, int nYSrc,
                                                 int dwRop);

        #endregion

        #region CreateDC 8

        [DllImportAttribute("gdi32.dll")]
        public static extern IntPtr CreateDC(
            string lpszDriver,   //   驱动名称  
            string lpszDevice,   //   设备名称  
            string lpszOutput,   //   无用，可以设定位"NULL"  
            IntPtr lpInitData   //   任意的打印机数据  
            );

        #endregion

        #region SystemInfo GetSystemInfo 9

        /// <summary>
        /// Get system information.
        /// </summary>
        /// <param name="systemInfo">System info struct.</param>
        [DllImport("kernel32")]
        public static extern void GetSystemInfo(ref SYSTEM_INFO systemInfo);

        #endregion

        #region GlobalMemoryStatus 10

        /// <summary>
        /// Get memory information.
        /// </summary>
        /// <param name="lpBuffer">Memory info struct.</param>
        [DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS memoryInfo);

        #endregion

        #region OpenProcessToken 11

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

        #endregion

        #region LookupPrivilegeValue 12

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, ref long pluid);

        #endregion

        #region AdjustTokenPrivileges 13

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, bool DisableAllPrivileges,
                                                                       ref TokPriv1Luid NewState, int BufferLength,
                                                                       IntPtr PreviousState, IntPtr ReturnLength);

        #endregion

        #region ExitWindowsEx 14

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern bool ExitWindowsEx(int uFlags, int dwReason);

        #endregion

        #region ChangeDisplaySettings 15

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ChangeDisplaySettings([In] ref DEVMODE lpDevMode, int dwFlags);

        #endregion

        #region CloseHandle 16

        [DllImport("kernel32.dll")]
        public extern static bool CloseHandle(IntPtr hObject);

        #endregion

        #region GetForegroundWindow 17

        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        #endregion

        #region SetForegroundWindow 18

        /// <summary>
        /// 将窗口设为系统的前台窗口
        /// 也就是激活焦点
        /// </summary>
        /// <param name="handleIntPtr">句柄</param>
        /// <returns>返回执行结果</returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr handleIntPtr);

        #endregion

        #region EnumWindows 19

        public delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);

        #endregion

        #region FindWindow 20

        /// <summary>
        /// 获取主窗体的句柄
        /// 类名如果为[NULL]，则通过标题查找
        /// 类名或者标题可以通过Spy++查看
        /// </summary>
        /// <param name="className">窗体的类名</param>
        /// <param name="captionName">窗体的标题</param>
        /// <returns>返回窗体句柄</returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string className, string captionName);

        #endregion

        #region FindWindowEx 21

        /// <summary>
        ///  获取主窗体下子控件的句柄
        ///  类名如果为[NULL]，则通过标题查找
        /// </summary>
        /// <param name="parentHandle">主窗体句柄</param>
        /// <param name="childHandle">子控件句柄</param>
        /// <param name="className">类名</param>
        /// <param name="captionName">标题</param>
        /// <returns>返回控件句柄</returns>
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childHandle, string className, string captionName);

        #endregion

        #region GetWindowText 22

        /// <summary>
        /// 获取句柄的标题
        /// </summary>
        /// <param name="handle">指定句柄</param>
        /// <param name="captionName">标题名：初始化一个StringBuilder来获取标题名</param>
        /// <param name="maxCount">缓冲区的大小</param>
        /// <returns>返回结果值</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr handle, StringBuilder captionName, int maxCount);
        #endregion

        #region GetClassName 23

        /// <summary>
        /// 获取指定句柄的类名
        /// </summary>
        /// <param name="handle">指定句柄</param>
        /// <param name="className">类名：初始化一个StringBuilder来获取类名</param>
        /// <param name="maxCount">缓冲区的大小</param>
        /// <returns>返回结果值</returns>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr handle, StringBuilder className, int maxCount);

        #endregion

        #region GetComboBoxInfo 24

        [DllImport("user32.dll")]
        public static extern bool GetComboBoxInfo(IntPtr hwndCombo, ref COMBOBOXINFO info);

        #endregion

        #region SHAutoComplete 25

        [DllImport("Shlwapi.dll")]
        public static extern void SHAutoComplete(IntPtr hwndEdit, int dwFlags);

        #endregion

        #region PlaySound 26

        [DllImport("Winmm.dll", EntryPoint = "PlaySound")]
        public static extern bool PlaySound(string pszSound, IntPtr hmod, int fdwSound);

        #endregion

        #region GetCaretPos 27

        [DllImport("user32.dll")]
        public static extern bool GetCaretPos(ref Point lpPoint);

        #endregion

        #region GetCursorPos 28

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);

        #endregion

        #region mciExecute 29

        [DllImport("winmm.dll")]
        public static extern bool mciExecute(string pszCommand);

        #endregion

        #region ExtractIconEx 30

        [DllImport("shell32.dll")]
        public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);

        #endregion

        #region ExtractIcon 31

        [DllImport("shell32.dll")]
        public static extern int ExtractIcon(int hInst, string lpszExeFileName, int nIconIndex);

        #endregion

        #region GetSystemMenu 32

        [DllImport("user32.dll", EntryPoint = "GetSystemMenu", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, int bRevert);

        #endregion

        #region GetTempPath 33

        [DllImport("kernel32.dll")]
        public static extern bool GetTempPath(int ccBuffer, StringBuilder lpszBuffer);

        #endregion

        #region InsertMenu 34

        [DllImport("user32.dll", EntryPoint = "InsertMenuW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern bool InsertMenu(IntPtr hMenu, uint uPosition, uint uFlags, uint uIDNewItem, string lpNewItem);

        #endregion

        #region DeleteMenu 35

        [DllImport("user32.dll")]
        public static extern bool DeleteMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        #endregion

        #region RemoveMenu 36
        [DllImport("user32.dll")]
        public static extern bool RemoveMenu(IntPtr hMenu, uint nPosition, uint wFlags);

        #endregion

        #region GetWindowsDirectory 37

        [DllImport("kernel32.dll")]
        public static extern int GetWindowsDirectory(StringBuilder lpBuffer, int uSize);

        #endregion

        #region GetSystemDirectory 38

        [DllImport("kernel32")]
        public static extern void GetSystemDirectory(StringBuilder lpBuffer, int uSize);

        #endregion

        #region ShowWindow 39

        /// <summary>
        /// 对窗体的简单操作，如：关闭，最大化等等
        /// </summary>
        /// <param name="formHandle">窗体句柄</param>
        /// <param name="nCmdShow">消息常量
        /// 0：关闭窗体 || 1：正常大小显示窗体 || 2：最小化窗体 || 3：最大化窗体
        /// </param>
        /// <returns>是否成功</returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr formHandle, int nCmdShow);

        #endregion

        #region GetDesktopWindow 41

        /// <summary>
        /// 获得代表整个屏幕的一个窗口（桌面窗口）句柄
        /// </summary>
        /// <returns>返回句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        #endregion

        #region Sleep 42

        [DllImport("kernel32.dll")]
        public static extern void Sleep(int dwMilliseconds);

        #endregion

        #region ClipCursor 43

        [DllImport("user32.dll")]
        public static extern bool ClipCursor(ref Rectangle lpRect);

        #endregion

        #region ShowCursor 44

        [DllImport("user32.dll")]
        public static extern int ShowCursor(bool bShow);

        #endregion

        #region DestroyCursor 45

        [DllImport("user32.dll")]
        public static extern bool DestroyCursor(IntPtr hCursor);

        #endregion

        #region GetDlgItem 47

        [DllImport("user32.dll")]
        public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        #endregion

        #region GetWindowLong 49

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        #endregion

        #region PostMessage 50

        /// <summary>
        /// 发送消息到指定的句柄
        /// 发送消息后会立即返回，不会等待
        /// </summary>
        /// <param name="hWnd">指定句柄</param>
        /// <param name="Msg">消息指令</param>
        /// <param name="wParam">默认都为 - 0</param>
        /// <param name="lParam">默认都为 - 0</param>
        /// <returns>返回的结果</returns>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        #endregion

        #region GetActiveWindow 51

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();

        #endregion

        #region GetCurrentProcess 52

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern IntPtr GetCurrentProcess();

        #endregion

        #region GetCurrentProcessId 53

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentProcessId();

        #endregion

        #region GetExitCodeProcess 54

        [DllImport("kernel32.dll")]
        public static extern bool GetExitCodeProcess(IntPtr hProcess, ref int lpExitCode);

        #endregion

        #region WindowFromPoint 55

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point Point);

        #endregion

        #region GetTopWindow 56

        #endregion

        #region WNetGetConnection 57

        [DllImport("mpr.dll")]
        public static extern int WNetGetConnection(string lpLocalName, StringBuilder lpRemoteName, int lpnLength);

        #endregion

        #region SetWindowPos 58

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        #endregion

        #region MoveWindow 59
        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        #endregion

        #region GetWindowExtEx 60

        [DllImport("gdi32.dll")]
        public static extern bool GetWindowExtEx(IntPtr hdc, ref Size lpSize);

        #endregion

        #region GetDC 61

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        #endregion

        #region GetClientRect 62

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, ref Rectangle lpRect);

        #endregion

        #region GetWindowDC 63

        /// <summary>
        /// 获取整个窗口（包括边框、滚动条、标题栏、菜单等）的设备场景
        /// [用完后一定要用ReleaseDC函数释放场景]
        /// </summary>
        /// <param name="handle"></param>
        /// <returns>执行成功为窗口设备场景，失败则为0</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr handle);

        #endregion

        #region GetWindowModuleFileName 64

        [DllImport("user32.dll")]
        public static extern uint GetWindowModuleFileName(IntPtr hwnd, StringBuilder lpszFileName, uint cchFileNameMax);

        #endregion

        #region GetWindowTextLength 65

        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        #endregion

        #region GetSystemTime 66

        [DllImport("kernel32.dll")]
        public extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        #endregion

        #region SetSystemTime 67

        [DllImport("kernel32.dll")]
        public static extern bool SetSystemTime(ref SYSTEMTIME lpSystemTime);

        #endregion

        #region GetCharWidthFloatA 68

        [DllImport("gdi32.dll")]
        public static extern bool GetCharWidthFloatA(IntPtr hdc, uint iFirstChar, uint iLastChar, ref float pxBuffer);

        #endregion

        #region GetCharWidth32 69

        [DllImport("gdi32.dll")]
        public static extern bool GetCharWidth32A(IntPtr hdc, uint iFirstChar, uint iLastChar, ref int lpBuffer);

        #endregion

        #region GetWindowPlacement 70

        [DllImport("user32.dll")]
        public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        #endregion

        #region OpenFile 71

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenFile(string lpFileName, ref OFSTRUCT lpReOpenBuff, uint uStyle);

        #endregion

        #region SetFileShortName 72

        [DllImport("kernel32.dll")]
        public static extern bool SetFileShortName(IntPtr hFile, string lpShortName);

        #endregion

        #region QueryPerformanceCounter 73

        [DllImport("kernel32")]
        public static extern bool QueryPerformanceCounter(ref long PerformanceCount);

        #endregion

        #region CreateFile 74

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, uint dwFlagsAndAttributes, int hTemplateFile);

        #endregion

        #region SHFileOperation 75

        [DllImport("shell32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int SHFileOperation(_SHFILEOPSTRUCT str);

        #endregion

        #region AdjustWindowRect 76

        [DllImport("user32.dll")]
        public static extern bool AdjustWindowRect(ref Rectangle lpRect, int dwStyle, bool bMenu);

        #endregion

        #region AdjustWindowRectEx 77

        [DllImport("user32.dll")]
        public static extern bool AdjustWindowRectEx(Rectangle lpRect, int dwStyle, bool bMenu, int dwExStyle);

        #endregion

        #region GetUserDefaultLangID 78

        [DllImport("kernel32.dll")]
        public static extern int GetUserDefaultLangID();

        #endregion

        #region GetUserDefaultLCID 79

        [DllImport("kernel32.dll")]
        public static extern int GetUserDefaultLCID();

        #endregion

        #region GetSystemDefaultLangID 80

        [DllImport("kernel32.dll")]
        public static extern int GetSystemDefaultLangID();

        #endregion

        #region FindExecuteable 81

        [DllImport("shell32.dll")]
        public static extern int FindExecutable(string lpFile, string lpDirectory, StringBuilder lpResult);

        #endregion

        #region GetTickCount 82

        [DllImport("kernel32.dll")]
        public static extern int GetTickCount();

        #endregion

        #region AbortSystemShutdownA 83

        [DllImport("advapi32.dll")]
        public static extern bool AbortSystemShutdown(string lpMachineName);

        #endregion

        #region GetKeyState 84

        [DllImport("user32")]
        public static extern short GetKeyState(int nVirtKey);

        #endregion

        #region LockWindowUpdate 85

        [DllImport("user32")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion

        #region GetComputerName 86

        [DllImport("kernel32.dll")]
        public static extern bool GetComputerName(StringBuilder lpBuffer, ref int lpnSize);

        #endregion

        #region ShellExecuteEx 87

        [DllImport("shell32.dll")]
        public static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        #endregion WaitForSingleObject 88

        #region WaitForSingleObject 88

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);

        #endregion

        #region FindFirstFile 89

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindFirstFile(string pFileName, ref WIN32_FIND_DATA pFindFileData);

        #endregion

        #region FindNextFile 90

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FindNextFile(IntPtr hndFindFile, ref WIN32_FIND_DATA lpFindFileData);

        #endregion

        #region FindClose 91

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FindClose(IntPtr hndFindFile);


        #endregion

        #region GetModuleFileNameEx 92

        [DllImport("psapi.dll", CharSet = CharSet.Auto)]
        public static extern int GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, StringBuilder lpFilename, int nSize);

        #endregion

        #region GetModuleFileName 93

        [DllImport("kernel32.dll")]
        public static extern int GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize);

        #endregion

        #region GetVersionEx 94_重载_2

        [DllImport("kernel32.dll", EntryPoint = "GetVersionEx")]
        public static extern bool GetVersionEx(ref OSVERSIONINFO lpVersionInformation);

        [DllImport("kernel32.dll")]
        public static extern bool GetVersionEx(ref OSVERSIONINFOEX lpVersionInformation);

        #endregion

        #region GetOpenFileName 95

        [DllImport("comdlg32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetOpenFileName(OPENFILENAME lpofn);

        #endregion

        #region GetStartupInfo 96

        [DllImport("kernel32.dll")]
        public static extern int GetStartupInfo(ref STARTUPINFO lpStartupInfo);

        #endregion

        #region GetNumberOfConsoleMouseButtons 97

        [DllImport("kernel32.dll")]
        public static extern int GetNumberOfConsoleMouseButtons(int lpNumberOfMouseButtons);

        #endregion

        #region LoadLibrary 98

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string lpLibFileName);

        #endregion

        #region GetProcAddress 99

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        #endregion

        #region FreeLibrary 100

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hLibModule);

        #endregion

        #endregion

        #region TOP 200

        #region GetModuleHandle 101

        /// <summary>
        /// 获取一个应用程序或动态链接库的模块句柄
        /// </summary>
        /// <param name="name">指定模块名，这通常是与模块的文件名相同的一个名字</param>
        /// <returns>返回模块句柄</returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        #endregion

        #region GetFullPathName 102

        [DllImport("kernel32.dll")]
        public static extern int GetFullPathName(string lpFileName, int nBufferLength, StringBuilder lpBuffer, string lpFilePart);
        //Path.GetFullPath

        #endregion

        #region GetMessagePos 103

        [DllImport("user32.dll")]
        public static extern int GetMessagePos();

        public static int GET_X_LPARAM(int lParam)
        {
            return (lParam & 0xffff);
        }

        public static int GET_Y_LPARAM(int lParam)
        {
            return (lParam >> 16);
        }

        #endregion

        #region GetParent 104

        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        #endregion

        #region GetProcessTimes 105

        [DllImport("kernel32.dll")]
        public static extern bool GetProcessTimes(IntPtr hProcess, ref  _FILETIME lpCreationTime, ref  _FILETIME lpExitTime, ref _FILETIME lpKernelTime, ref  _FILETIME lpUserTime);

        #endregion

        #region GetLastError 106

        [DllImport("kernel32.dll")]
        public static extern int GetLastError();

        #endregion

        #region FileTimeToLocalFileTime 107

        [DllImport("kernel32.dll")]
        public static extern bool FileTimeToLocalFileTime([In] ref _FILETIME lpFileTime, out _FILETIME lpLocalTime);

        #endregion

        #region FileTimeToSystemTime 108_重载_2

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int FileTimeToSystemTime(IntPtr lpFileTime, IntPtr lpSystemTime);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int FileTimeToSystemTime(ref _FILETIME lpFileTime, ref SYSTEMTIME lpSystemTime);

        #endregion

        #region LocalFileTimeToFileTime 109

        [DllImport("kernel32.dll")]
        public static extern bool LocalFileTimeToFileTime([In] ref _FILETIME lpLocalTime, out _FILETIME lpFileTime);

        #endregion

        #region SystemTimeToFileTime 110

        [DllImport("kernel32.dll")]
        public static extern bool SystemTimeToFileTime([In] ref SYSTEMTIME lpSystemTime, out _FILETIME lpFileTime);

        #endregion

        #region FindFirstUrlCacheEntry 111

        [DllImport("wininet.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr FindFirstUrlCacheEntry([MarshalAs(UnmanagedType.LPTStr)] string lpszUrlSearchPattern, IntPtr lpFirstCacheEntryInfo, ref int lpdwFirstCacheEntryInfoBufferSize);

        #endregion

        #region FindNextUrlCacheEntry 112

        [DllImport("wininet.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool FindNextUrlCacheEntry(IntPtr hEnumHandle, IntPtr lpNextCacheEntryInfo, ref int lpdwNextCacheEntryInfoBufferSize);

        #endregion

        #region FindCloseUrlCache 113

        [DllImport("wininet.dll")]
        public static extern bool FindCloseUrlCache(IntPtr hEnumHandle);

        #endregion

        #region ReleaseCapture 114

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region RtlZeroMemory 115

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern void RtlZeroMemory(IntPtr Destination, int Length);

        #endregion

        #region LoadCursor 116_重载_2

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursor(IntPtr hInstance, string lpCursorName);

        #endregion

        #region LoadCursorFromFile 117

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string lpFileName);

        #endregion

        #region SetCursor 118

        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr hCursor);
        //在WndProc中使用
        //case WM_SETCURSOR:
        //IntPtr hCursor;
        //hCursor = WindowsAPI.LoadCursorFromFile(@"C:\Windows\Cursors\3dgarro.cur");
        //hCursor = WindowsAPI.LoadCursor(IntPtr.Zero, CommonConst.IDC_CROSS);
        //WindowsAPI.SetCursor(hCursor);

        #endregion

        #region CreateCursor 119

        [DllImport("user32.dll")]
        public static extern IntPtr CreateCursor(IntPtr hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, ref int pvANDPlane, ref int pvXORPlane);

        #endregion

        #region CopyIcon 120

        [DllImport("user32.dll")]
        public static extern IntPtr CopyIcon(IntPtr hIcon);

        #endregion

        #region GetClipCursor 121

        [DllImport("user32.dll")]
        public static extern bool GetClipCursor(ref Rectangle lpRect);

        #endregion

        #region SetWindowPlacement 122

        [DllImport("user32.dll")]
        public static extern bool SetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        #endregion

        #region ShowOwnedPopups 123

        [DllImport("user32.dll")]
        public static extern bool ShowOwnedPopups(IntPtr hWnd, bool fShow);

        #endregion

        #region GetIfTable 124

        [DllImport("IpHlpApi.dll")]
        public static extern int GetIfTable(byte[] pIfTable, ref uint pdwSize, bool bOrder);

        #endregion

        #region SendARP 125


        [DllImport("Iphlpapi.dll")]
        public static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref IntPtr pMacAddr, ref IntPtr PhyAddrLen);

        #endregion

        #region inet_addr 126

        [DllImport("Ws2_32.dll")]
        public static extern Int32 inet_addr(string cp);

        #endregion

        #region GetSaveFileName 127

        [DllImport("comdlg32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetSaveFileName(ref OPENFILENAME lpofn);

        #endregion

        #region WinExec 128

        [DllImport("kernel32.dll")]
        public static extern uint WinExec(string lpCmdLine, uint uCmdShow);

        #endregion

        #region Shell_NotifyIcon 129

        [DllImport("shell32.dll", EntryPoint = "Shell_NotifyIconA")]
        public static extern bool Shell_NotifyIcon(int dwMessage, ref NOTIFYICONDATA lpData);

        #endregion

        #region SetCursorPos 130

        /// <summary>
        ///  设置光标的位置
        /// </summary>
        /// <param name="x">X坐标的位置</param>
        /// <param name="y">Y坐标的位置</param>
        /// <returns>返回的结果值</returns>
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        #endregion

        #region SetWindowLong 131

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern long SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        #endregion

        #region SetLayeredWindowAttributes 132

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, int bAlpha, int dwFlags);

        #endregion

        #region SetParent 133

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        #endregion

        #region ShellExecute 134

        [DllImport("shell32.dll")]
        public static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        //edit
        //explore
        //find
        //open
        //print
        //WindowsAPI.ShellExecute(IntPtr.Zero, "open", "notepadp","D:\\path.txt", "D:\\", CommonConst.SW_SHOWDEFAULT);

        #endregion

        #region OpenProcess 135

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int fdwAccess, bool fInherit, int IDProcess);

        #endregion

        #region GetWindowThreadProcessId 136

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, ref int lpdwProcessId);

        #endregion

        #region CreateProcess 137

        [DllImport("Kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern bool CreateProcess(StringBuilder lpApplicationName, StringBuilder lpCommandLine, SECURITY_ATTRIBUTES lpProcessAttributes, SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, StringBuilder lpEnvironment, StringBuilder lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);
        #endregion

        #region TerminateProcess 138

        [DllImport("kernel32.dll")]
        public static extern bool TerminateProcess(IntPtr hProcess, int uExitCode);

        #endregion

        #region GetProcessId 139

        [DllImport("kernel32.dll")]
        public static extern int GetProcessId(IntPtr Process);

        #endregion

        #region Module32First 140

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool Module32First(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

        #endregion

        #region CreateToolhelp32Snapshot 141

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateToolhelp32Snapshot(int dwFlags, int th32ProcessID);

        #endregion

        #region EnumProcessModules 142

        [DllImport("psapi.dll")]
        public static extern bool EnumProcessModules(IntPtr hProcess, IntPtr[] lphModule, int cb, ref int lpcbNeeded);

        #endregion

        #region SetCapture 143

        [DllImport("user32.dll")]
        public static extern IntPtr SetCapture(IntPtr hWnd);

        #endregion

        #region SetComputerName 144

        [DllImport("kernel32.dll")]
        public static extern bool SetComputerName(string lpComputerName);

        #endregion

        #region SetCaretPos 145

        [DllImport("user32.dll")]
        public static extern bool SetCaretPos(int X, int Y);

        #endregion

        #region SetEnvironmentVariable 146

        [DllImport("kernel32.dll")]
        public static extern bool SetEnvironmentVariable(string lpName, string lpValue);

        #endregion

        #region SetScrollPos 147

        [DllImport("user32.dll")]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        #endregion

        #region SetScrollRange 148

        [DllImport("user32.dll")]
        public static extern bool SetScrollRange(IntPtr hWnd, int nBar, int nMinPos, int nMaxPos, bool bRedraw);

        #endregion

        #region EnumChildWindows 149

        public delegate bool ChildWindowsProc(IntPtr hwnd, int lParam);
        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, ChildWindowsProc lpEnumFunc, int lParam);

        #endregion

        #region GetWindow 150

        [DllImport("user32.dll", EntryPoint = "GetWindow")]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

        #endregion

        #region SetScrollInfo 151

        [DllImport("user32.dll")]
        public static extern int SetScrollInfo(IntPtr hwnd, int fnBar, SCROLLINFO lpsi, bool fRedraw);

        #endregion

        #region EnumDisplaySettings 152

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        #endregion

        #region EnumDisplayDevices 153

        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, int iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, int dwFlags);

        #endregion

        #region CallWindowProc 154

        [DllImport("user32", EntryPoint = "CallWindowProc")]
        public static extern int CallWindowProc(int lpPrevWndFunc, IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

        #region ChildWindowFromPoint 155

        [DllImport("user32.dll")]
        public static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point Point);

        #endregion

        #region Rectangle 156

        [DllImport("gdi32.dll")]
        public static extern bool Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        #endregion

        #region SetROP2 157

        [DllImport("gdi32.dll")]
        public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

        #endregion

        #region CreatePen 158

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, int crColor);

        #endregion

        #region SelectObject 159

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        #endregion

        #region EnableWindow 160

        [DllImport("user32.dll")]
        public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        #endregion

        #region BringWindowToTop 161

        [DllImport("user32.dll")]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        #endregion

        #region DeleteObject 162

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        #endregion

        #region ReleaseDC 163_重载_2

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hDC);

        /// <summary>
        /// 释放由调用GetDC或GetWindowDC函数获取的指定设备场景
        /// 对那些用CreateDC一类的DC创建函数生成的设备场景，不要用本函
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="hDC"></param>
        /// <returns>执行成功为-1||否则为-0</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr handle, IntPtr hDC);

        #endregion

        #region GetCommandLine 164

        [DllImport("kernel32.dll")]
        public static extern string GetCommandLine();

        #endregion

        #region RegisterHotKey 165

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, System.Windows.Forms.Keys vk);

        #endregion

        #region UnregisterHotKey 166

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        #endregion

        #region SHGetFileInfo 167

        [DllImport("shell32.dll")]
        public static extern int SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        #endregion

        #region ExtractAssociatedIcon 168

        [DllImport("shell32.dll")]
        public static extern IntPtr ExtractAssociatedIcon(IntPtr hInst, string lpIconPath, ref int lpiIcon);

        #endregion

        #region ExtractAssociatedIconEx 169

        [DllImport("shell32.dll")]
        public static extern IntPtr ExtractAssociatedIconEx(IntPtr hInst, string lpIconPath, ref int lpiIcon, ref int lpiIconId);

        #endregion

        #region FillRect 170

        [DllImport("user32.dll")]
        public static extern int FillRect(IntPtr hDC, ref Rectangle lprc, IntPtr hbr);

        #endregion

        #region CreateHatchBrush 171

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateHatchBrush(int fnStyle, int clrref);

        #endregion

        #region FlashWindo 172

        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hWnd, bool bInvert);

        #endregion

        #region FlashWindowEx 173

        [DllImport("user32.dll")]
        public static extern bool FlashWindowEx(ref FLASHWINFO pfwi);

        #endregion

        #region FindText 174

        [DllImport("comdlg32.dll")]
        public static extern IntPtr FindText(ref FINDREPLACE lpfr);

        #endregion

        #region ReplaceText 175

        [DllImport("comdlg32.dll")]
        public static extern IntPtr ReplaceText(ref FINDREPLACE lpfr);

        #endregion

        #region ChooseColor 176

        [DllImport("comdlg32.dll")]
        public static extern bool ChooseColor(ref CHOOSECOLOR lpcc);

        #endregion

        #region ChooseFont 177

        [DllImport("comdlg32.dll")]
        public static extern bool ChooseFont(ref CHOOSEFONT lpcf);

        #endregion

        #region CloseWindow 178

        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hWnd);

        #endregion

        #region CloseDesktop 179

        [DllImport("user32.dll")]
        public static extern bool CloseDesktop(IntPtr hDesktop);

        #endregion

        #region GetSystemMetrics 180

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        #endregion

        #region AppendMenu 181

        [DllImport("user32.dll")]
        public static extern bool AppendMenu(IntPtr hMenu, uint uFlags, uint uIDNewItem, string lpNewItem);

        #endregion

        #region AnyPopup 182

        [DllImport("user32.dll")]
        public static extern bool AnyPopup();

        #endregion

        #region CreateMenu 183

        [DllImport("user32.dll")]
        public static extern IntPtr CreateMenu();

        #endregion

        #region CreatePopupMenu 184

        [DllImport("user32.dll")]
        public static extern IntPtr CreatePopupMenu();

        #endregion

        #region DestroyMenu 185

        [DllImport("user32.dll")]
        public static extern bool DestroyMenu(IntPtr hMenu);

        #endregion

        #region GetMenu 186

        /// <summary>
        /// 获取窗体中的菜单句柄
        /// </summary>
        /// <param name="menuhandle">窗体句柄</param>
        /// <returns>返回菜单句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetMenu(IntPtr handle);

        /// <summary>
        /// 菜单中条目（菜单项）的数量
        /// </summary>
        /// <param name="menuHandle">菜单句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int GetMenuItemCount(IntPtr menuHandle);

        /// <summary>
        /// 获取菜单中的一级菜单
        /// </summary>
        /// <param name="menuHandle">菜单句柄</param>
        /// <param name="index">索引项 </param>
        /// <returns>返回一级菜单的句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetSubMenu(IntPtr menuHandle, int index);

        /// <summary>
        /// 获取菜单项的句柄
        /// </summary>
        /// <param name="subMenuhandle">子菜单句柄</param>
        /// <param name="index">索引项</param>
        /// <returns>返回菜单中的条目数量，返回-1意味着出错</returns>
        [DllImport("user32.dll")]
        public static extern uint GetMenuItemID(IntPtr subMenuhandle, int index);

        /// <summary>
        /// 用一个MENUITEMINFO结构取得（接收）与一个菜单条目有关的特定信息
        /// </summary>
        /// <param name="menuHandle">菜单的句柄</param>
        /// <param name="menuInfo">这个结构用于装载请求的信息</param>
        /// <returns>TRUE（非零）表示成功，否则返回零</returns>
        [DllImport("user32.dll")]
        public static extern bool GetMenuItemInfo(IntPtr menuHandle, ref MENUINFO menuInfo);

        /// <summary>
        /// 为一个菜单条目设置指定的信息，具体信息保存于MENUITEMINFO结构中
        /// </summary>
        /// <param name="menuHandle">菜单的句柄</param>
        /// <param name="menuInfo">这个结构用于装载请求的信息</param>
        /// <returns>TRUE（非零）表示成功，否则返回零</returns>
        [DllImport("user32.dll")]
        public static extern bool SetMenuInfo(IntPtr menuHandle, ref MENUINFO menuIfo);

        #endregion

        #region GetMenuInfo 187

        #endregion

        #region SetMenuInfo 188

        #endregion

        #region CreatePatternBrush 189

        [DllImport("gdi32")]
        public static extern IntPtr CreatePatternBrush(IntPtr hbmp);

        #endregion

        #region ModifyMenu 191

        [DllImport("user32.dll")]
        public static extern bool ModifyMenu(IntPtr hMnu, uint uPosition, uint uFlags, uint uIDNewItem, string lpNewItem);

        #endregion

        #region IsCharAlpha 192

        [DllImport("user32.dll")]
        public static extern bool IsCharAlpha(char ch);

        #endregion

        #region IsCharAlphaNumeric 193

        [DllImport("user32.dll")]
        public static extern bool IsCharAlphaNumeric(string ch);

        #endregion

        #region IsCharLower 194

        [DllImport("user32.dll")]
        public static extern bool IsCharLower(char ch);

        #endregion

        #region IsCharUpper 195

        [DllImport("user32.dll")]
        public static extern bool IsCharUpper(char ch);

        #endregion

        #region IsWindow 196

        [DllImport("user32.dll")]
        public static extern bool IsWindow(IntPtr hWnd);

        #endregion

        #region IsWindowVisible 198

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        #endregion

        #region IsIconic 199

        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        #endregion

        #region IsZoomed 200

        [DllImport("user32.dll")]
        public static extern bool IsZoomed(IntPtr hWnd);

        #endregion

        #endregion

        #region TOP 300

        #region PathIsContentType 201

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsContentType(string pszPath, string pszContentType);

        #endregion

        #region PathIsDirectory 202

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsDirectory(string pszPath);

        #endregion

        #region PathIsDirectoryEmpty 203

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsDirectoryEmpty(string pszPath);

        #endregion

        #region PathIsFileSpec 204

        /// <summary>
        /// 检查路径中是否带有 ‘:’ 和 ‘\’ 分隔符
        /// </summary>
        /// <param name="szfile"></param>
        /// <returns></returns>
        [DllImport("shlwapi.dll")]
        public static extern bool PathIsFileSpec(string lpszPath);

        #endregion

        #region PathGetArgs 205

        [DllImport("shlwapi.dll")]
        public static extern string PathGetArgs(string pszPath);
        //WindowsAPI.PathGetArgs("-t D:\\API.exe")

        #endregion

        #region PathIsPrefix 206

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsPrefix(string pszPrefix, string pszPath);

        #endregion

        #region PathIsRelative 207

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsRelative(string lpszPath);

        #endregion

        #region PathIsRoot 208

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsRoot(string pPath);

        #endregion

        #region PathIsSameRoot 209

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsSameRoot(string pszPath1, string pszPath2);

        #endregion

        #region PathIsURL 210

        [DllImport("shlwapi.dll")]
        public static extern bool PathIsURL(string pszPath);

        #endregion

        #region PathMatchSpec 211

        [DllImport("shlwapi.dll")]
        public static extern bool PathMatchSpec(string pszFile, string pszSpec);
        //WindowsAPI.PathMatchSpec("ftp://index.aspx","?.aspx")

        #endregion

        #region PathRemoveBackslash 212

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern string PathRemoveBackslash(StringBuilder lpszPath);

        #endregion

        #region PathRemoveArgs 213

        [DllImport("shlwapi.dll")]
        public static extern void PathRemoveArgs(StringBuilder pszPath);

        #endregion

        #region PathRemoveBlanks 214

        [DllImport("shlwapi.dll")]
        public static extern void PathRemoveBlanks(StringBuilder lpszString);

        #endregion

        #region PathRemoveExtension 215

        [DllImport("shlwapi.dll")]
        public static extern void PathRemoveExtension(StringBuilder pszPath);

        #endregion

        #region PathRenameExtension 216

        [DllImport("shlwapi.dll")]
        public static extern bool PathRenameExtension(StringBuilder pszPath, string pszExt);

        #endregion

        #region SetTextCharacterExtra 217

        [DllImport("gdi32.dll")]
        public static extern int SetTextCharacterExtra(IntPtr hdc, int nCharExtra);

        #endregion

        #region GetTextCharacterExtra 218

        [DllImport("gdi32.dll")]
        public static extern int GetTextCharacterExtra(IntPtr hdc);

        #endregion

        #region CreateFontIndirect 219

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFontIndirect(ref LOGFONT lplf);

        #endregion

        #region RegisterClass 220

        [DllImport("user32.dll", EntryPoint = "RegisterClass")]
        public static extern int RegisterClass(ref   WNDCLASS Class);

        #endregion

        #region DefWindowProc 221

        [DllImport("user32.dll", EntryPoint = "DefWindowProc")]
        public static extern int DefWindowProc(IntPtr hWnd, uint Msg, int wParam, int lParam);

        #endregion

        #region RegisterWindowMessage 222

        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessage")]
        public static extern uint RegisterWindowMessage(string lpString);

        #endregion

        #region GetThreadTimes 223

        [DllImport("kernel32.dll")]
        public static extern bool GetThreadTimes(IntPtr hThread, ref _FILETIME lpCreationTime, ref _FILETIME lpExitTime, ref _FILETIME lpKernelTime, ref _FILETIME lpUserTime);

        #endregion

        #region GetCurrentThread 224

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentThread();

        #endregion

        #region GetCurrentThreadId 225

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        #endregion

        #region GetThreadPriority 226

        [DllImport("kernel32.dll")]
        public static extern int GetThreadPriority(IntPtr hThread);

        #endregion

        #region SetThreadPriority 227

        [DllImport("kernel32.dll")]
        public static extern bool SetThreadPriority(IntPtr hThread, int nPriority);

        #endregion

        #region OpenThread 228

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);

        #endregion

        #region LoadIcon 229

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, string lpIconName);

        #endregion

        #region SetWindowRgn 230

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        #endregion

        #region SetWindowTheme 231

        [DllImport("uxtheme.dll")]
        public static extern IntPtr SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        #endregion

        #region GetMenuItemInfo 232

        [DllImport("user32.dll")]
        public static extern bool GetMenuItemInfo(IntPtr hMenu, uint uItem, bool fByPosition, ref MENUITEMINFO lpmii);
        //uint flag;
        //MENUITEMINFO mii = new MENUITEMINFO();
        //mii.cbSize = (uint)Marshal.SizeOf(mii);
        //mii.fMask = CommonConst.MIIM_STATE | CommonConst.MIIM_TYPE | CommonConst.MIIM_ID;
        //WindowsAPI.GetMenuItemInfo(syshwnd, (uint)i, true, ref mii);
        //flag = (uint)mii.fType;
        //string a = Marshal.PtrToStringAnsi(mii.dwTypeData);

        #endregion

        #region SetMenuItemInfo 234

        [DllImport("user32.dll")]
        public static extern bool SetMenuItemInfo(IntPtr hMenu, uint uItem, bool fByPosition, ref MENUITEMINFO lpmii);

        #endregion

        #region UpdateWindow 235

        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);

        #endregion

        #region GetWindowTheme 236

        [DllImport("uxtheme")]
        public static extern IntPtr GetWindowTheme(IntPtr hWnd);

        #endregion

        #region GetFileAttributes 237

        [DllImport("kernel32.dll")]
        public static extern int GetFileAttributes(string lpFileName);

        #endregion

        #region SetLocalTime 238

        [DllImport("kernel32.dll")]
        public static extern bool SetLocalTime(ref SYSTEMTIME lpSystemTime);

        #endregion

        #region RegCloseKey 239

        [DllImport("advapi32.dll")]
        public static extern long RegCloseKey(IntPtr hKey);

        #endregion

        #region RegCreateKeyEx 240

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern int RegCreateKeyEx(IntPtr hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesigner, SECURITY_ATTRIBUTES lpSecurityAttributes, out IntPtr hkResult, out int lpdwDisposition);

        #endregion

        #region ScreenToClient 241

        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, Point lpPoint);

        #endregion

        #region GetPixel 242

        [DllImport("gdi32.dll")]
        public static extern int GetPixel(IntPtr hdc, int nXPos, int nYPos);

        #endregion

        #region AnimateWindow 243

        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        #endregion

        #region GetPrivateProfileInt 244

        [DllImport("kernel32.dll")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

        #endregion

        #region GetPrivateProfileString 245

        [DllImport("kernel32.dll")]
        public static extern bool GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        #endregion

        #region GetPrivateProfileSection 246

        [DllImport("kernel32.dll")]
        public static extern bool GetPrivateProfileSection(string lpAppName, StringBuilder lpReturnedString, int nSize, string lpFileName);

        #endregion

        #region WritePrivateProfileString 247

        [DllImport("kernel32.dll")]
        public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        #endregion

        #region WritePrivateProfileSection 248

        [DllImport("kernel32.dll")]
        public static extern bool WritePrivateProfileSection(string lpAppName, string lpString, string lpFileName);

        #endregion

        #region WritePrivateProfileStruct 249

        [DllImport("kernel32.dll")]
        public static extern bool WritePrivateProfileStruct(string lpszSection, string lpszKey, StringBuilder lpStruct, uint uSizeStruct, string szFile);

        #endregion

        #region SystemParametersInfo 250

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fuWinIni);

        #endregion

        #region GetTextExtentPoint32 251

        [DllImport("gdi32.dll")]
        public static extern bool GetTextExtentPoint32(IntPtr hdc, string lpString, int c, ref Size lpSize);

        #endregion

        #region CreateCompatibleBitmap 252

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        #endregion

        #region CreateCompatibleDC 253

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        #endregion

        #region DeleteDC 254

        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hdc);

        #endregion

        #region GetWindowInfo 255

        [DllImport("user32.dll")]
        public static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

        #endregion

        #region GetWindowOrgEx 256

        [DllImport("gdi32.dll")]
        public static extern bool GetWindowOrgEx(IntPtr hdc, ref Point lpPoint);

        #endregion

        #region waveOutSetVolume 257

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, long dwVolume);

        #endregion

        #region waveOutGetVolume 258

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out long dwVolume);


        #endregion

        #region CreateWindowEx 259

        [DllImport("user32.dll")]
        public static extern IntPtr CreateWindowEx(int dwExStyle, string lpClassName, string lpWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        #endregion

        #region GetNextWindow 260

        //GW_HWNDNEXT
        //Returns a handle to the window below the given window.
        //GW_HWNDPREV
        //Returns a handle to the window above the given window.

        #endregion

        #region ChildWindowFromPointEx 261

        [DllImport("user32.dll")]
        public static extern IntPtr ChildWindowFromPointEx(IntPtr hwndParent, Point pt, uint uFlags);
        //CWP_ALL
        //Does not skip any child windows
        //CWP_SKIPINVISIBLE
        //Skips invisible child windows
        //CWP_SKIPDISABLED
        //Skips disabled child windows
        //CWP_SKIPTRANSPARENT
        //Skips transparent child windows

        #endregion

        #region OpenIcon 262

        [DllImport("user32.dll")]
        public static extern bool OpenIcon(IntPtr hWnd);

        #endregion

        #region CascadeWindows 263

        [DllImport("user32.dll")]
        public static extern int CascadeWindows(IntPtr hwndParent, uint wHow, ref Rectangle lpRect, uint cKids, IntPtr lpKids);

        #endregion

        #region TileWindows 264

        [DllImport("user32.dll")]
        public static extern int TileWindows(IntPtr hwndParent, uint wHow, ref Rectangle lpRect, uint cKids, IntPtr lpKids);

        #endregion

        #region ArrangeIconicWindows 265

        [DllImport("user32.dll")]
        public static extern uint ArrangeIconicWindows(IntPtr hWnd);

        #endregion

        #region CancelDC 266

        [DllImport("gdi32.dll")]
        public static extern bool CancelDC(IntPtr hdc);

        #endregion

        #region CopyRect 267

        [DllImport("user32.dll")]
        public static extern bool CopyRect(string lprcDst, ref Rectangle lprcSrc);

        #endregion

        #region CountClipboardFormats 268

        [DllImport("user32.dll")]
        public static extern int CountClipboardFormats();

        #endregion

        #region CreateThread 269

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateThread(SECURITY_ATTRIBUTES lpsa, int cbStack, IntPtr lpStartAddr, int lpvThreadParam, int fdwCreate, int lpIDThread);

        #endregion

        #region ThreadProc 270

        [DllImport("kernel32.dll")]
        public static extern int ThreadProc(int lpParameter);

        #endregion

        #region BeginDeferWindowPos 271

        [DllImport("user32.dll")]
        public static extern IntPtr BeginDeferWindowPos(int nNumWindows);

        #endregion

        #region DeferWindowPos 272

        [DllImport("user32.dll")]
        public static extern IntPtr DeferWindowPos(IntPtr hWinPosInfo, IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        #endregion

        #region EndDeferWindowPos 273

        [DllImport("user32.dll")]
        public static extern bool EndDeferWindowPos(IntPtr hWinPosInfo);

        #endregion

        #region Beep 274

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int dwFreq, int dwDuration);

        #endregion

        #region GetFileSize 275

        [DllImport("kernel32.dll")]
        public static extern int GetFileSize(IntPtr hFile, ref int lpFileSizeHigh);

        #endregion

        #region GetFileType 276

        [DllImport("kernel32.dll")]
        public static extern int GetFileType(IntPtr hFile);

        #endregion

        #region GetFileInformationByHandle 278

        [DllImport("kernel32.dll")]
        public static extern bool GetFileInformationByHandle(IntPtr hFile, ref BY_HANDLE_FILE_INFORMATION lpFileInformation);

        #endregion

        #region SetWindowText 279

        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string lpString);

        #endregion

        #region IsWindowUnicode 280

        [DllImport("user32.dll")]
        public static extern bool IsWindowUnicode(IntPtr hWnd);

        #endregion

        #region SetActiveWindow 281

        /// <summary>
        /// 激活窗体
        /// </summary>
        /// <param name="handle">窗体句柄</param>
        /// <returns>返回窗体句柄</returns>
        [DllImport("user32.dll")]
        static extern IntPtr SetActiveWindow(IntPtr handle);

        #endregion

        #region GetDCEx 282

        [DllImport("user32.dll")]
        public static extern IntPtr GetDCEx(IntPtr hWnd, Rectangle hrgnClip, int flags);

        #endregion

        #region SaveDC 283

        [DllImport("user32.dll")]
        public static extern int SaveDC(IntPtr hdc);

        #endregion

        #region ClientToScreen 284

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        #endregion

        #region MapWindowPoints 285

        [DllImport("user32.dll")]
        public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref Point lpPoints, uint cPoints);

        #endregion

        #region WindowFromDC 286

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromDC(IntPtr hDC);

        #endregion

        #region GetCompressedFileSize 287

        [DllImport("kernel32.dll")]
        public static extern int GetCompressedFileSize(string lpFileName, ref int lpFileSizeHigh);

        #endregion

        #region LockFile 288

        [DllImport("kernel32.dll")]
        public static extern bool LockFile(IntPtr hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh);

        #endregion

        #region CompareFileTime 289

        [DllImport("kernel32.dll")]
        public static extern long CompareFileTime(_FILETIME lpFileTime1, _FILETIME lpFileTime2);

        #endregion

        #region GetVolumeInformation 290

        [DllImport("kernel32.dll")]
        public static extern bool GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);

        #endregion

        #region IsRectEmpty 291

        [DllImport("user32.dll")]
        public static extern bool IsRectEmpty(ref Rectangle lprc);

        #endregion

        #region LogonUser 292

        [DllImport("advapi32.dll")]
        public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        #endregion

        #region VerifyVersionInfo 293

        [DllImport("kernel32.dll")]
        public static extern bool VerifyVersionInfo(ref OSVERSIONINFOEX lpVersionInfo, int dwTypeMask, int dwlConditionMask);

        #endregion

        #region GetModuleInformation 294

        [DllImport("psapi.dll")]
        public static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, ref MODULEINFO lpmodinfo, int cb);

        #endregion

        #region EnumProcesses 295

        [DllImport("psapi.dll")]
        public static extern bool EnumProcesses(int[] pProcessIds, int cb, ref int pBytesReturned);

        #endregion

        #region EnumThreadWindows 296

        public delegate bool ThreadWindowsProc(IntPtr hwnd, int lParam);
        [DllImport("user32.dll")]
        public static extern bool EnumThreadWindows(int dwThreadId, ThreadWindowsProc lpfn, int lParam);

        #endregion

        #region InternetGetConnectedState 297

        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(ref int lpdwFlags, int dwReserved);

        #endregion

        #region IsNetworkAlive 298

        [DllImport("Sensapi.dll")]
        public extern static bool IsNetworkAlive(ref int lpdwFlags);

        #endregion

        #region GetWindowRgn 299

        [DllImport("user32.dll")]
        public static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

        #endregion

        #region GetTimeZoneInformation 300

        [DllImport("kernel32.dll")]
        public static extern int GetTimeZoneInformation(ref TIME_ZONE_INFORMATION lpTimeZoneInformation);

        #endregion

        #endregion

        #region TOP 400

        #region GetTimeFormat 301

        [DllImport("kernel32.dll")]
        public static extern int GetTimeFormat(int Locale, int dwFlags, ref SYSTEMTIME lpTime, string lpFormat, StringBuilder lpTimeStr, int cchTime);
        //SYSTEMTIME st = api.WindowsTimeToSystemTime(DateTime.Now);
        //WindowsAPI.GetTimeFormat(0, CommonConst.TIME_FORCE24HOURFORMAT, ref st, "hh':'mm':'ss tt", sb, sb.Capacity);

        #endregion

        #region GetIconInfo 302

        [DllImport("user32.dll")]
        public static extern bool GetIconInfo(IntPtr hIcon, ref ICONINFO piconinfo);

        #endregion

        #region GetDateFormat 303

        [DllImport("kernel32.dll")]
        public static extern int GetDateFormat(int Locale, int dwFlags, ref SYSTEMTIME lpDate, string lpFormat, StringBuilder lpDateStr, int cchDate);
        //SYSTEMTIME st = api.WindowsTimeToSystemTime(DateTime.Now);
        //WindowsAPI.GetDateFormat(0, 0, ref st, "ddd',' MMM dd yyyy", sb, sb.Capacity);

        #endregion

        #region GetDriveType 304

        [DllImport("kernel32.dll")]
        public static extern uint GetDriveType(string lpRootPathName);

        #endregion

        #region BeginPath 305

        [DllImport("gdi32.dll")]
        public static extern bool BeginPath(IntPtr hdc);

        #endregion

        #region SetBkMode 306

        [DllImport("gdi32.dll")]
        public static extern int SetBkMode(IntPtr hdc, int iBkMode);

        #endregion

        #region EndPath 307

        [DllImport("gdi32.dll")]
        public static extern bool EndPath(IntPtr hdc);

        #endregion

        #region PathToRegion 308

        [DllImport("gdi32.dll")]
        public static extern IntPtr PathToRegion(IntPtr hdc);

        #endregion

        #region Ellipse 309

        [DllImport("gdi32.dll")]
        public static extern bool Ellipse(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        #endregion

        #region ZeroMemory 310

        [DllImport("kernel32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        #endregion

        #region StretchBlt 311

        [DllImport("gdi32.dll")]
        public static extern bool StretchBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, int dwRop);

        #endregion

        #region GetStretchBltMode 312

        [DllImport("gdi32.dll")]
        public static extern int GetStretchBltMode(IntPtr hdc);

        #endregion

        #region GetBinaryType 313

        [DllImport("kernel32.dll")]
        public static extern bool GetBinaryType(string lpApplicationName, ref int lpBinaryType);

        #endregion

        #region RestoreDC 314

        [DllImport("gdi32.dll")]
        public static extern bool RestoreDC(IntPtr hdc, int nSavedDC);

        #endregion

        #region GetDCOrgEx 315

        [DllImport("gdi32.dll")]
        public static extern bool GetDCOrgEx(IntPtr hdc, ref Point lpPoint);

        #endregion

        #region PatBlt 316

        [DllImport("gdi32.dll")]
        public static extern bool PatBlt(IntPtr hdc, int nXLeft, int nYLeft, int nWidth, int nHeight, int dwRop);

        #endregion

        #region PlgBlt 317

        [DllImport("gdi32.dll")]
        public static extern bool PlgBlt(IntPtr hdcDest, ref Point lpPoint, IntPtr hdcSrc, int nXSrc, int nYSrc, int nWidth, int nHeight, IntPtr hbmMask, int xMask, int yMask);

        #endregion

        #region MaskBlt 318

        [DllImport("gdi32.dll")]
        public static extern bool MaskBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, IntPtr hbmMask, int xMask, int yMask, int dwRop);

        #endregion

        #region TransparentBlt 319

        [DllImport("gdi32.dll")]
        public static extern bool TransparentBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int hHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, uint crTransparent);

        #endregion

        #region SetPixel 320

        [DllImport("gdi32.dll")]
        public static extern int SetPixel(IntPtr hdc, int X, int Y, int crColor);

        #endregion

        #region SetPixelV 321

        [DllImport("gdi32.dll")]
        public static extern bool SetPixelV(IntPtr hdc, int X, int Y, int crColor);

        #endregion

        #region LineTo 322

        [DllImport("gdi32.dll")]
        public static extern bool LineTo(IntPtr hdc, int nXEnd, int nYEnd);

        #endregion

        #region LineDDA 323

        [DllImport("gdi32.dll")]
        public static extern bool LineDDA(int nXStart, int nYStart, int nXEnd, int nYEnd, IntPtr lpLineFunc, IntPtr lpData);

        #endregion

        #region Polyline 324

        [DllImport("gdi32.dll")]
        public static extern bool Polyline(IntPtr hdc, ref Point lppt, int cPoints);

        #endregion

        #region PolylineTo 325

        [DllImport("gdi32.dll")]
        public static extern bool PolylineTo(IntPtr hdc, ref Point lppt, int cCount);

        #endregion

        #region PolyBezier 326

        [DllImport("gdi32.dll")]
        public static extern bool PolyBezier(IntPtr hdc, ref Point lppt, int cPoints);

        #endregion

        #region PolyDraw 327

        [DllImport("gdi32.dll")]
        public static extern bool PolyDraw(IntPtr hdc, ref Point lppt, ref byte lpbTypes, int cCount);

        #endregion

        #region InvalidateRect 328

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

        #endregion

        #region RedrawWindow 329

        [DllImport("user32.dll")]
        public static extern int RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

        #endregion

        #region GetMonitorInfo 331

        [DllImport("user32.dll")]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

        #endregion

        #region PrintWindow 332

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

        #endregion

        #region OffsetRect 333

        [DllImport("user32.dll")]
        public static extern bool OffsetRect(ref Rectangle lprc, int dx, int dy);

        #endregion

        #region SHFormatDrive 334

        [DllImport("shell32.dll")]
        public static extern int SHFormatDrive(IntPtr hwnd, uint drive, uint fmtID, uint options);

        #endregion

        #region ScaleViewportExtEx 335

        [DllImport("gdi32.dll")]
        public static extern bool ScaleViewportExtEx(IntPtr hdc, int Xnum, int Xdenom, int Ynum, int Ydenom, ref Size lpSize);

        #endregion

        #region ScaleWindowExtEx 336

        [DllImport("gdi32.dll")]
        public static extern bool ScaleWindowExtEx(IntPtr hdc, int Xnum, int Xdenom, int Ynum, int Ydenom, ref Size lpSize);

        #endregion

        #region GetCharWidth 337

        [DllImport("gdi32.dll")]
        public static extern bool GetCharWidth(IntPtr hdc, uint iFirstChar, uint iLastChar, ref int lpBuffer);

        #endregion

        #region SendInput 338

        [DllImport("User32.dll", EntryPoint = "SendInput", CharSet = CharSet.Auto)]
        public static extern UInt32 SendInput(UInt32 nInputs, INPUT[] pInputs, Int32 cbSize);

        #endregion

        #region LoadImage 339

        [DllImport("user32.dll")]
        public static extern IntPtr LoadImage(IntPtr hinst, string lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);

        #endregion

        #region LoadBitmap 340

        [DllImport("user32.dll")]
        public static extern IntPtr LoadBitmap(IntPtr hInstance, string lpBitmapName);

        #endregion

        #region ExitProcess 341

        [DllImport("kernel32.dll")]
        public static extern void ExitProcess(uint uExitCode);

        #endregion

        #region SHEmptyRecycleBin 342

        [DllImport("shell32.dll")]
        public static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, int dwFlags);

        #endregion

        #region InvalidateRect 343

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(int hWnd, ref Rectangle lpRect, bool bErase);

        #endregion

        #region InternetGetConnectedStateEx 344

        [DllImport("wininet.dll")]
        public static extern bool InternetGetConnectedStateEx(ref int lpdwFlags, string lpszConnectionName, int dwNameLen, int dwReserved);

        #endregion

        #region DrawText 345

        [DllImport("user32.dll")]
        public static extern int DrawText(IntPtr hDC, string lpString, int nCount, ref Rectangle lpRect, uint uFormat);

        #endregion

        #region PaintDesktop 346

        [DllImport("user32")]
        public static extern bool PaintDesktop(IntPtr hdc);

        #endregion

        #region IsChild 347

        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        #endregion

        #region GetNearestColor 348

        [DllImport("gdi32.dll")]
        public static extern int GetNearestColor(IntPtr hdc, int crColor);

        #endregion

        #region CreateBitmap 349

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint cPlanes, uint cBitsPerPel, IntPtr lpvBits);

        #endregion

        #region TextOut 350

        [DllImport("gdi32.dll")]
        public static extern bool TextOut(IntPtr hdc, int nXStart, int nYStart, string lpString, int cbString);

        #endregion

        #region ExtTextOut 351

        [DllImport("gdi32.dll")]
        public static extern bool ExtTextOut(IntPtr hdc, int X, int Y, uint fuOptions, ref Rectangle lprc, string lpString, uint cbCount, int[] lpDx);

        #endregion

        #region DrawTextEx 352

        [DllImport("gdi32.dll")]
        public static extern int DrawTextEx(IntPtr hdc, string lpchText, int cchText, Rectangle lprc, uint dwDTFormat, DRAWTEXTPARAMS lpDTParams);

        #endregion

        #region SendMessageTimeout 353

        [DllImport("user32.dll")]
        public static extern int SendMessageTimeout(IntPtr hWnd, uint uMsg, int wParam, int lParam, uint fuFlags, uint uTimeout, ref int lpdwResult);

        #endregion

        #region GetClassLong 354

        [DllImport("user32.dll")]
        public static extern int GetClassLong(IntPtr hWnd, int index);

        #endregion

        #region LockWorkStation 355

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        #endregion

        #endregion
    }
}
