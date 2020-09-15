namespace SharpCommon.Windows
{
    public class WindowsConst
    {
        #region GENERIC

        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;

        #endregion

        #region CREATEOPEN

        public const int CREATE_NEW = 1;
        public const int CREATE_ALWAYS = 2;
        public const int OPEN_EXISTING = 3;
        public const int OPEN_ALWAYS = 4;

        #endregion

        #region FILE_SHARE

        public const int FILE_SHARE_READ = 0x1;
        public const int FILE_SHARE_WRITE = 0x2;
        public const uint FILE_FLAG_NO_BUFFERING = 0x20000000;
        public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;

        #endregion

        #region FO

        public const int FO_MOVE = 0x01;
        public const int FO_COPY = 0x02;
        public const int FO_DELETE = 0x03;
        public const int FO_RENAME = 0x04;

        #endregion

        #region FOF

        public const int FOF_MULTIDESTFILES = 0x01;
        public const int FOF_CONFIRMMOUSE = 0x02;
        public const int FOF_SILENT = 0x04;
        public const int FOF_RENAMEONCOLLISION = 0x08;
        public const int FOF_NOCONFIRMATION = 0x10;
        public const int FOF_WANTMAPPINGHANDLE = 0x20;
        public const int FOF_ALLOWUNDO = 0x40;
        public const int FOF_FILESONLY = 0x80;
        public const int FOF_SIMPLEPROGRESS = 0x0100;
        public const int FOF_NOCONFIRMMKDIR = 0x0200;

        #endregion

        #region WS

        public const int WS_OVERLAPPED = 0x0;
        public const uint WS_POPUP = 0x80000000;
        public const int WS_CHILD = 0x40000000;
        public const int WS_MINIMIZE = 0x20000000;
        public const int WS_VISIBLE = 0x10000000;
        public const int WS_DISABLED = 0x8000000;
        public const int WS_CLIPSIBLINGS = 0x4000000;
        public const int WS_CLIPCHILDREN = 0x2000000;
        public const int WS_MAXIMIZE = 0x1000000;
        public const int WS_CAPTION = 0xC00000;
        public const int WS_BORDER = 0x800000;
        public const int WS_DLGFRAME = 0x400000;
        public const int WS_VSCROLL = 0x200000;
        public const int WS_HSCROLL = 0x100000;
        public const int WS_SYSMENU = 0x80000;
        public const int WS_THICKFRAME = 0x40000;
        public const int WS_GROUP = 0x20000;
        public const int WS_TABSTOP = 0x10000;
        public const int WS_MINIMIZEBOX = 0x20000;
        public const int WS_MAXIMIZEBOX = 0x10000;
        public const int WS_TILED = WS_OVERLAPPED;
        public const int WS_ICONIC = WS_MINIMIZE;
        public const int WS_SIZEBOX = WS_THICKFRAME;
        public const int WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
        public const int WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
        public const uint WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU);
        public const int WS_CHILDWINDOW = (WS_CHILD);

        public const int WS_EX_WINDOWEDGE = 0x100; //窗口具有凸起的3D边框 
        public const int WS_EX_CLIENTEDGE = 0x200; //窗口具有阴影边界 
        public const int WS_EX_TOOLWINDOW = 0x80; //小标题工具窗口 
        public const int WS_EX_TOPMOST = 0x8; //窗口总在顶层 
        public const int WS_EX_OVERLAPPEDWINDOW = (WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE); //WS_EX-CLIENTEDGE和WS_EX_WINDOWEDGE的组合 
        public const int WS_EX_PALETTEWINDOW = (WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST); //WS_EX_WINDOWEDGE和WS_EX_TOOLWINDOW和WS_EX_TOPMOST的组合 
        public const int WS_EX_DLGMODALFRAME = 0x1; //带双边的窗口 
        public const int WS_EX_NOPARENTNOTIFY = 0x4; //窗口在创建和销毁时不向父窗口发送WM_PARENTNOTIFY消息 
        public const int WS_EX_TRANSPARENT = 0x20; //窗口透眀 
        public const int WS_EX_MDICHILD = 0x40; //MDI子窗口 
        public const int WS_EX_CONTEXTHELP = 0x400; //标题栏包含问号联机帮助按钮 
        public const int WS_EX_RIGHT = 0x1000; //窗口具有右对齐属性 
        public const int WS_EX_RTLREADING = 0x2000; //窗口文本自右向左显示 
        public const int WS_EX_LEFTSCROLLBAR = 0x4000; //标题栏在客户区的左边 
        public const int WS_EX_CONTROLPARENT = 0x10000; //允许用户使用Tab键在窗口的子窗口间搜索 
        public const int WS_EX_STATICEDGE = 0x20000; //为不接受用户输入的项创建一个三维边界风格 
        public const int WS_EX_APPWINDOW = 0x40000; //在任务栏上显示顶层窗口的标题按钮 
        public const int WS_EX_LAYERED = 0x80000; //窗口具有透眀属性(Win2000)以上 
        public const int WS_EX_NOINHERITLAYOUT = 0x100000; //窗口布局不传递给子窗口(Win2000)以上 
        public const int WS_EX_LAYOUTRTL = 0x400000; //水平起点在右边的窗口 
        public const int WS_EX_NOACTIVATE = 0x8000000; //窗口不会变成前台窗口(Win2000)以上 
        public const int WS_EX_LEFT = 0x0; //窗口具有左对齐属性 
        public const int WS_EX_LTRREADING = 0x0; //窗口文本自左向右显示 
        public const int WS_EX_RIGHTSCROLLBAR = 0x0; //垂直滚动条在窗口的右边界 
        public const int WS_EX_ACCEPTFILES = 0x10; //接受文件拖曳 
        public const int WS_EX_COMPOSITED = 0x2000000; //窗体所有子窗口使用双缓冲从低到高绘制(XP) 

        #endregion

        #region WM

        public const int WM_CLICK = 0x00F5;
        public const int WM_NULL = 0x0000;
        public const int WM_CREATE = 0x0001;
        public const int WM_DESTROY = 0x0002;
        public const int WM_MOVE = 0x0003;
        public const int WM_SIZE = 0x0005;
        public const int WM_ACTIVATE = 0x0006;
        public const int WM_SETFOCUS = 0x0007;
        public const int WM_KILLFOCUS = 0x0008;
        public const int WM_ENABLE = 0x000A;
        public const int WM_SETREDRAW = 0x000B;
        public const int WM_SETTEXT = 0x000C;
        public const int WM_GETTEXT = 0x000D;
        public const int WM_GETTEXTLENGTH = 0x000E;
        public const int WM_PAINT = 0x000F;
        public const int WM_CLOSE = 0x0010;
        public const int WM_QUERYENDSESSION = 0x0011;
        public const int WM_QUIT = 0x0012;
        public const int WM_QUERYOPEN = 0x0013;
        public const int WM_ERASEBKGND = 0x0014;
        public const int WM_SYSCOLORCHANGE = 0x0015;
        public const int WM_ENDSESSION = 0x0016;
        public const int WM_SYSTEMERROR = 0x0017;
        public const int WM_SHOWWINDOW = 0x0018;
        public const int WM_CTLCOLOR = 0x0019;
        public const int WM_WININICHANGE = 0x001A;
        public const int WM_SETTINGCHANGE = WM_WININICHANGE;
        public const int WM_DEVMODECHANGE = 0x001B;
        public const int WM_ACTIVATEAPP = 0x001C;
        public const int WM_FONTCHANGE = 0x001D;
        public const int WM_TIMECHANGE = 0x001E;
        public const int WM_CANCELMODE = 0x001F;
        public const int WM_SETCURSOR = 0x0020;
        public const int WM_MOUSEACTIVATE = 0x0021;
        public const int WM_CHILDACTIVATE = 0x0022;
        public const int WM_QUEUESYNC = 0x0023;
        public const int WM_GETMINMAXINFO = 0x0024;
        public const int WM_PAINTICON = 0x0026;
        public const int WM_ICONERASEBKGND = 0x0027;
        public const int WM_NEXTDLGCTL = 0x0028;
        public const int WM_SPOOLERSTATUS = 0x002A;
        public const int WM_DRAWITEM = 0x002B;
        public const int WM_MEASUREITEM = 0x002C;
        public const int WM_DELETEITEM = 0x002D;
        public const int WM_VKEYTOITEM = 0x002E;
        public const int WM_CHARTOITEM = 0x002F;
        public const int WM_SETFONT = 0x0030;
        public const int WM_GETFONT = 0x0031;
        public const int WM_SETHOTKEY = 0x0032;
        public const int WM_GETHOTKEY = 0x0033;
        public const int WM_QUERYDRAGICON = 0x0037;
        public const int WM_COMPAREITEM = 0x0039;
        public const int WM_GETOBJECT = 0x003D;
        public const int WM_COMPACTING = 0x0041;
        public const int WM_COMMNOTIFY = 0x0044;
        public const int WM_WINDOWPOSCHANGING = 0x0046;
        public const int WM_WINDOWPOSCHANGED = 0x0047;
        public const int WM_POWER = 0x0048;
        public const int WM_COPYDATA = 0x004A;
        public const int WM_CANCELJOURNAL = 0x004B;
        public const int WM_NOTIFY = 0x004E;
        public const int WM_INPUTLANGCHANGEREQUEST = 0x0050;
        public const int WM_INPUTLANGCHANGE = 0x0051;
        public const int WM_TCARD = 0x0052;
        public const int WM_HELP = 0x0053;
        public const int WM_USERCHANGED = 0x0054;
        public const int WM_NOTIFYFORMAT = 0x0055;
        public const int WM_CONTEXTMENU = 0x007B;
        public const int WM_STYLECHANGING = 0x007C;
        public const int WM_STYLECHANGED = 0x007D;
        public const int WM_DISPLAYCHANGE = 0x007E;
        public const int WM_GETICON = 0x007F;
        public const int WM_SETICON = 0x0080;
        public const int WM_NCCREATE = 0x0081;
        public const int WM_NCDESTROY = 0x0082;
        public const int WM_NCCALCSIZE = 0x0083;
        public const int WM_NCHITTEST = 0x0084;
        public const int WM_NCPAINT = 0x0085;
        public const int WM_NCACTIVATE = 0x0086;
        public const int WM_GETDLGCODE = 0x0087;
        public const int WM_NCMOUSEMOVE = 0x00A0;
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int WM_NCLBUTTONUP = 0x00A2;
        public const int WM_NCLBUTTONDBLCLK = 0x00A3;
        public const int WM_NCRBUTTONDOWN = 0x00A4;
        public const int WM_NCRBUTTONUP = 0x00A5;
        public const int WM_NCRBUTTONDBLCLK = 0x00A6;
        public const int WM_NCMBUTTONDOWN = 0x00A7;
        public const int WM_NCMBUTTONUP = 0x00A8;
        public const int WM_NCMBUTTONDBLCLK = 0x00A9;
        public const int WM_NCXBUTTONDOWN = 0x00AB;
        public const int WM_NCXBUTTONUP = 0x00AC;
        public const int WM_NCXBUTTONDBLCLK = 0x00AD;
        public const int WM_INPUT = 0x00FF;
        public const int WM_KEYFIRST = 0x0100;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int WM_CHAR = 0x0102;
        public const int WM_DEADCHAR = 0x0103;
        public const int WM_SYSKEYDOWN = 0x0104;
        public const int WM_SYSKEYUP = 0x0105;
        public const int WM_SYSCHAR = 0x0106;
        public const int WM_SYSDEADCHAR = 0x0107;
        public const int WM_UNICHAR = 0x0109;
        public const int WM_KEYLAST = 0x0109;
        public const int WM_INITDIALOG = 0x0110;
        public const int WM_COMMAND = 0x0111;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int WM_TIMER = 0x0113;
        public const int WM_HSCROLL = 0x0114;
        public const int WM_VSCROLL = 0x0115;
        public const int WM_INITMENU = 0x0116;
        public const int WM_INITMENUPOPUP = 0x0117;
        public const int WM_MENUSELECT = 0x011F;
        public const int WM_MENUCHAR = 0x0120;
        public const int WM_ENTERIDLE = 0x0121;
        public const int WM_MENURBUTTONUP = 0x0122;
        public const int WM_MENUDRAG = 0x0123;
        public const int WM_MENUGETOBJECT = 0x0124;
        public const int WM_UNINITMENUPOPUP = 0x0125;
        public const int WM_MENUCOMMAND = 0x0126;
        public const int WM_CHANGEUISTATE = 0x0127;
        public const int WM_UPDATEUISTATE = 0x0128;
        public const int WM_QUERYUISTATE = 0x0129;
        public const int WM_CTLCOLORMSGBOX = 0x0132;
        public const int WM_CTLCOLOREDIT = 0x0133;
        public const int WM_CTLCOLORLISTBOX = 0x0134;
        public const int WM_CTLCOLORBTN = 0x0135;
        public const int WM_CTLCOLORDLG = 0x0136;
        public const int WM_CTLCOLORSCROLLBAR = 0x0137;
        public const int WM_CTLCOLORSTATIC = 0x0138;
        public const int WM_MOUSEFIRST = 0x0200;
        public const int WM_MOUSEMOVE = 0x0200;
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_LBUTTONDBLCLK = 0x0203;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_RBUTTONUP = 0x0205;
        public const int WM_RBUTTONDBLCLK = 0x0206;
        public const int WM_MBUTTONDOWN = 0x0207;
        public const int WM_MBUTTONUP = 0x0208;
        public const int WM_MBUTTONDBLCLK = 0x0209;
        public const int WM_MOUSEWHEEL = 0x020A;
        public const int WM_MOUSELAST = 0x020A;
        public const int WM_PARENTNOTIFY = 0x0210;
        public const int WM_ENTERMENULOOP = 0x0211;
        public const int WM_EXITMENULOOP = 0x0212;
        public const int WM_NEXTMENU = 0x0213;
        public const int WM_SIZING = 532;
        public const int WM_CAPTURECHANGED = 533;
        public const int WM_MOVING = 534;
        public const int WM_POWERBROADCAST = 536;
        public const int WM_DEVICECHANGE = 537;
        public const int WM_IME_STARTCOMPOSITION = 0x010D;
        public const int WM_IME_ENDCOMPOSITION = 0x010E;
        public const int WM_IME_COMPOSITION = 0x010F;
        public const int WM_IME_KEYLAST = 0x010F;
        public const int WM_IME_SETCONTEXT = 0x0281;
        public const int WM_IME_NOTIFY = 0x0282;
        public const int WM_IME_CONTROL = 0x0283;
        public const int WM_IME_COMPOSITIONFULL = 0x0284;
        public const int WM_IME_SELECT = 0x0285;
        public const int WM_IME_CHAR = 0x0286;
        public const int WM_IME_REQUEST = 0x0288;
        public const int WM_IME_KEYDOWN = 0x0290;
        public const int WM_IME_KEYUP = 0x0291;
        public const int WM_MDICREATE = 0x0220;
        public const int WM_MDIDESTROY = 0x0221;
        public const int WM_MDIACTIVATE = 0x0222;
        public const int WM_MDIRESTORE = 0x0223;
        public const int WM_MDINEXT = 0x0224;
        public const int WM_MDIMAXIMIZE = 0x0225;
        public const int WM_MDITILE = 0x0226;
        public const int WM_MDICASCADE = 0x0227;
        public const int WM_MDIICONARRANGE = 0x0228;
        public const int WM_MDIGETACTIVE = 0x0229;
        public const int WM_MDISETMENU = 0x0230;
        public const int WM_ENTERSIZEMOVE = 0x0231;
        public const int WM_EXITSIZEMOVE = 0x0232;
        public const int WM_DROPFILES = 0x0233;
        public const int WM_MDIREFRESHMENU = 0x0234;
        public const int WM_MOUSEHOVER = 0x02A1;
        public const int WM_MOUSELEAVE = 0x02A3;
        public const int WM_NCMOUSEHOVER = 0x02A0;
        public const int WM_NCMOUSELEAVE = 0x02A2;
        public const int WM_WTSSESSION_CHANGE = 0x02B1;
        public const int WM_TABLET_FIRST = 0x02C0;
        public const int WM_TABLET_LAST = 0x02DF;
        public const int WM_CUT = 0x0300;
        public const int WM_COPY = 0x0301;
        public const int WM_PASTE = 0x0302;
        public const int WM_CLEAR = 0x0303;
        public const int WM_UNDO = 0x0304;
        public const int WM_RENDERFORMAT = 0x0305;
        public const int WM_RENDERALLFORMATS = 0x0306;
        public const int WM_DESTROYCLIPBOARD = 0x0307;
        public const int WM_DRAWCLIPBOARD = 0x0308;
        public const int WM_PAINTCLIPBOARD = 0x0309;
        public const int WM_VSCROLLCLIPBOARD = 0x030A;
        public const int WM_SIZECLIPBOARD = 0x030B;
        public const int WM_ASKCBFORMATNAME = 0x030C;
        public const int WM_CHANGECBCHAIN = 0x030D;
        public const int WM_HSCROLLCLIPBOARD = 0x030E;
        public const int WM_QUERYNEWPALETTE = 0x030F;
        public const int WM_PALETTEISCHANGING = 0x0310;
        public const int WM_PALETTECHANGED = 0x0311;
        public const int WM_HOTKEY = 0x0312;
        public const int WM_PRINT = 791;
        public const int WM_PRINTCLIENT = 792;
        public const int WM_APPCOMMAND = 0x0319;
        public const int WM_THEMECHANGED = 0x031A;
        public const int WM_HANDHELDFIRST = 856;
        public const int WM_HANDHELDLAST = 863;
        public const int WM_PENWINFIRST = 0x0380;
        public const int WM_PENWINLAST = 0x038F;
        public const int WM_COALESCE_FIRST = 0x0390;
        public const int WM_COALESCE_LAST = 0x039F;
        public const int WM_DDE_FIRST = 0x03E0;
        public const int WM_DWMCOMPOSITIONCHANGED = 0x031E;
        public const int WM_DWMNCRENDERINGCHANGED = 0x031F;
        public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;
        public const int WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321;
        public const int WM_APP = 0x8000;
        public const int WM_USER = 0x0400;

        #endregion

        #region SW

        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_NORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_MAXIMIZE = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOW = 5;
        public const int SW_MINIMIZE = 6;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_RESTORE = 9;
        public const int SW_SHOWDEFAULT = 10;
        public const int SW_FORCEMINIMIZE = 11;
        public const int SW_MAX = 11;

        #endregion

        #region OF

        public const int OF_READ = 0x00000000;
        public const int OF_WRITE = 0x00000001;
        public const int OF_READWRITE = 0x00000002;
        public const int OF_SHARE_COMPAT = 0x00000000;
        public const int OF_SHARE_EXCLUSIVE = 0x00000010;
        public const int OF_SHARE_DENY_WRITE = 0x00000020;
        public const int OF_SHARE_DENY_READ = 0x00000030;
        public const int OF_SHARE_DENY_NONE = 0x00000040;
        public const int OF_PARSE = 0x00000100;
        public const int OF_DELETE = 0x00000200;
        public const int OF_VERIFY = 0x00000400;
        public const int OF_CANCEL = 0x00000800;
        public const int OF_CREATE = 0x00001000;
        public const int OF_PROMPT = 0x00002000;
        public const int OF_EXIST = 0x00004000;
        public const int OF_REOPEN = 0x00008000;

        #endregion

        #region SWP

        public const int SWP_DRAWFRAME = 0x0020; //围绕窗口画一个框 
        public const int SWP_HIDEWINDOW = 0x0080; //隐藏窗口 
        public const int SWP_NOACTIVATE = 0x0010; //不激活窗口 
        public const int SWP_NOMOVE = 0x0002; //保持当前位置（x和y设定将被忽略） 
        public const int SWP_NOREDRAW = 0x0008; //窗口不自动重画 
        public const int SWP_NOSIZE = 0x0001;//保持当前大小（cx和cy会被忽略） 
        public const int SWP_NOZORDER = 0x0004;//保持窗口在列表的当前位置（hWndInsertAfter将被忽略） 
        public const int SWP_SHOWWINDOW = 0x0040; //显示窗口 
        public const int SWP_FRAMECHANGED = 0x0020; //强迫一条WM_NCCALCSIZE消息进入窗口，即使窗口的大小没有改变

        #endregion

        #region HWND

        public const int HWND_TOP = 0;
        public const int HWND_BOTTOM = 1;
        public const int HWND_TOPMOST = -1;
        public const int HWND_NOTTOPMOST = -2;

        #endregion

        #region PROCESSOR

        //处理器类型
        public const int PROCESSOR_INTEL_386 = 386;
        public const int PROCESSOR_INTEL_486 = 486;
        public const int PROCESSOR_INTEL_PENTIUM = 586;
        public const int PROCESSOR_MIPS_R4000 = 4000;
        public const int PROCESSOR_ALPHA_21064 = 21064;

        #endregion

        #region EWX

        public const int SE_PRIVILEGE_ENABLED = 0x00000002;
        public const int TOKEN_QUERY = 0x00000008;
        public const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        public const int EWX_LOGOFF = 0x00000000;
        public const int EWX_SHUTDOWN = 0x00000001;
        public const int EWX_REBOOT = 0x00000002;
        public const int EWX_FORCE = 0x00000004;
        public const int EWX_POWEROFF = 0x00000008;
        public const int EWX_FORCEIFHUNG = 0x00000010;

        #endregion

        #region Virtual Key

        public const int VK_LBUTTON = 0x1;
        public const int VK_RBUTTON = 0x2;
        public const int VK_CANCEL = 0x3;
        public const int VK_MBUTTON = 0x4;
        public const int VK_BACK = 0x8;
        public const int VK_TAB = 0x9;
        public const int VK_CLEAR = 0xC;
        public const int VK_RETURN = 0xD;
        /// <summary>
        /// Shift
        /// </summary>
        public const int VK_SHIFT = 0x10;
        /// <summary>
        /// Ctrl
        /// </summary>
        public const int VK_CONTROL = 0x11;
        /// <summary>
        /// Alt
        /// </summary>
        public const int VK_MENU = 0x12;
        public const int VK_PAUSE = 0x13;
        public const int VK_CAPITAL = 0x14;
        public const int VK_ESCAPE = 0x1B;
        public const int VK_SPACE = 0x20;
        public const int VK_PRIOR = 0x21;
        public const int VK_NEXT = 0x22;
        public const int VK_END = 0x23;
        public const int VK_HOME = 0x24;
        public const int VK_LEFT = 0x25;
        public const int VK_UP = 0x26;
        public const int VK_RIGHT = 0x27;
        public const int VK_DOWN = 0x28;
        public const int VK_SELECT = 0x29;
        public const int VK_PRINT = 0x2A;
        public const int VK_EXECUTE = 0x2B;
        public const int VK_SNAPSHOT = 0x2C;
        public const int VK_INSERT = 0x2D;
        public const int VK_DELETE = 0x2E;
        public const int VK_HELP = 0x2F;
        public const int VK_NUMPAD0 = 0x60;
        public const int VK_NUMPAD1 = 0x61;
        public const int VK_NUMPAD2 = 0x62;
        public const int VK_NUMPAD3 = 0x63;
        public const int VK_NUMPAD4 = 0x64;
        public const int VK_NUMPAD5 = 0x65;
        public const int VK_NUMPAD6 = 0x66;
        public const int VK_NUMPAD7 = 0x67;
        public const int VK_NUMPAD8 = 0x68;
        public const int VK_NUMPAD9 = 0x69;
        public const int VK_MULTIPLY = 0x6A;
        public const int VK_ADD = 0x6B;
        public const int VK_SEPARATOR = 0x6C;
        public const int VK_SUBTRACT = 0x6D;
        public const int VK_DECIMAL = 0x6E;
        public const int VK_DIVIDE = 0x6F;
        public const int VK_F1 = 0x70;
        public const int VK_F2 = 0x71;
        public const int VK_F3 = 0x72;
        public const int VK_F4 = 0x73;
        public const int VK_F5 = 0x74;
        public const int VK_F6 = 0x75;
        public const int VK_F7 = 0x76;
        public const int VK_F8 = 0x77;
        public const int VK_F9 = 0x78;
        public const int VK_F10 = 0x79;
        public const int VK_F11 = 0x7A;
        public const int VK_F12 = 0x7B;
        public const int VK_F13 = 0x7C;
        public const int VK_F14 = 0x7D;
        public const int VK_F15 = 0x7E;
        public const int VK_F16 = 0x7F;
        public const int VK_F17 = 0x80;
        public const int VK_F18 = 0x81;
        public const int VK_F19 = 0x82;
        public const int VK_F20 = 0x83;
        public const int VK_F21 = 0x84;
        public const int VK_F22 = 0x85;
        public const int VK_F23 = 0x86;
        public const int VK_F24 = 0x87;
        public const int VK_NUMLOCK = 0x90;
        public const int VK_SCROLL = 0x91;
        public const int VK_LSHIFT = 0xA0;
        public const int VK_RSHIFT = 0xA1;
        public const int VK_LCONTROL = 0xA2;
        public const int VK_RCONTROL = 0xA3;
        public const int VK_LMENU = 0xA4;
        public const int VK_RMENU = 0xA5;
        public const int VK_ATTN = 0xF6;
        public const int VK_CRSEL = 0xF7;
        public const int VK_EXSEL = 0xF8;
        public const int VK_EREOF = 0xF9;
        public const int VK_PLAY = 0xFA;
        public const int VK_ZOOM = 0xFB;
        public const int VK_NONAME = 0xFC;
        public const int VK_PA1 = 0xFD;
        public const int VK_OEM_CLEAR = 0xFE;

        #endregion

        #region SC

        public const int SC_SIZE = 0xF000;
        public const int SC_MOVE = 0xF010;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_NEXTWINDOW = 0xF040;
        public const int SC_PREVWINDOW = 0xF050;
        public const int SC_CLOSE = 0xF060;
        public const int SC_VSCROLL = 0xF070;
        public const int SC_HSCROLL = 0xF080;
        public const int SC_MOUSEMENU = 0xF090;
        public const int SC_KEYMENU = 0xF100;
        public const int SC_ARRANGE = 0xF110;
        public const int SC_RESTORE = 0xF120;
        public const int SC_TASKLIST = 0xF130;
        public const int SC_SCREENSAVE = 0xF140;
        public const int SC_HOTKEY = 0xF150;
        public const int SC_DEFAULT = 0xF160;
        public const int SC_MONITORPOWER = 0xF170;
        public const int SC_CONTEXTHELP = 0xF180;
        public const int SC_SEPARATOR = 0xF00F;
        public const int SC_ICON = SC_MINIMIZE;
        public const int SC_ZOOM = SC_MAXIMIZE;

        #endregion

        #region MF

        public const int MF_INSERT = 0x00000000;
        public const int MF_CHANGE = 0x00000080;
        public const int MF_APPEND = 0x00000100;
        public const int MF_DELETE = 0x00000200;
        public const int MF_REMOVE = 0x00001000;
        public const int MF_BYCOMMAND = 0x00000000;
        public const int MF_BYPOSITION = 0x00000400;
        public const int MF_SEPARATOR = 0x00000800;
        public const int MF_ENABLED = 0x00000000;
        public const int MF_GRAYED = 0x00000001;
        public const int MF_DISABLED = 0x00000002;
        public const int MF_UNCHECKED = 0x00000000;
        public const int MF_CHECKED = 0x00000008;
        public const int MF_USECHECKBITMAPS = 0x00000200;
        public const int MF_STRING = 0x00000000;
        public const int MF_BITMAP = 0x00000004;
        public const int MF_OWNERDRAW = 0x00000100;
        public const int MF_POPUP = 0x00000010;
        public const int MF_MENUBARBREAK = 0x00000020;
        public const int MF_MENUBREAK = 0x00000040;
        public const int MF_UNHILITE = 0x00000000;
        public const int MF_HILITE = 0x00000080;
        public const int MF_DEFAULT = 0x00001000;
        public const int MF_SYSMENU = 0x00002000;
        public const int MF_HELP = 0x00004000;
        public const int MF_RIGHTJUSTIFY = 0x00004000;
        public const int MF_MOUSESELECT = 0x00008000;
        public const int MF_END = 0x00000080;

        #endregion

        #region SE

        public const int SE_ERR_ACCESSDENIED = 5; //拒绝访问 
        public const int SE_ERR_ASSOCINCOMPLETE = 27; // 文件关联信息不完整 
        public const int SE_ERR_DDEBUSY = 30; // DDE繁忙 
        public const int SE_ERR_DDEFAIL = 29; // DDE操作失败 
        public const int SE_ERR_DDETIMEOUT = 28; // DDE操作超时 
        public const int SE_ERR_DLLNOTFOUND = 32; // 没有找到动态链接库 
        public const int SE_ERR_FNF = 2; // 没有找到文件 
        public const int SE_ERR_NOASSOC = 31; // 没有找到文件关联 
        public const int SE_ERR_OOM = 8; // 内存不足 
        public const int SE_ERR_PNF = 3; // 没有找到路径 
        public const int SE_ERR_SHARE = 26; // 不能操作一个以打开的文件 

        #endregion

        #region SEE

        public const int SEE_MASK_CLASSKEY = 0x3;
        public const int SEE_MASK_CLASSNAME = 0x1;
        public const int SEE_MASK_CONNECTNETDRV = 0x80;
        public const int SEE_MASK_DOENVSUBST = 0x200;
        public const int SEE_MASK_FILEANDURL = 0x4000000;
        public const int SEE_MASK_FLAG_DDEWAIT = 0x100;
        public const int SEE_MASK_FLAG_LOG_USAGE = 0x4000000;
        public const int SEE_MASK_FLAG_NO_UI = 0x400;
        public const int SEE_MASK_HMONITOR = 0x200000;
        public const int SEE_MASK_HOTKEY = 0x20;
        public const int SEE_MASK_ICON = 0x10;
        public const int SEE_MASK_IDLIST = 0x4;
        public const int SEE_MASK_INVOKEIDLIST = 0xC;
        public const int SEE_MASK_NO_CONSOLE = 0x8000;
        public const int SEE_MASK_NOASYNC = 0x100000;
        public const int SEE_MASK_NOCLOSEPROCESS = 0x40;
        public const int SEE_MASK_NOZONECHECKS = 0x800000;
        public const int SEE_MASK_UNICODE = 0x100000;

        #endregion

        #region OFN

        public const int OFN_READONLY = 0x1;
        public const int OFN_OVERWRITEPROMPT = 0x2;
        public const int OFN_HIDEREADONLY = 0x4;
        public const int OFN_NOCHANGEDIR = 0x8;
        public const int OFN_SHOWHELP = 0x10;
        public const int OFN_ENABLEHOOK = 0x20;
        public const int OFN_ENABLETEMPLATE = 0x40;
        public const int OFN_ENABLETEMPLATEHANDLE = 0x80;
        public const int OFN_NOVALIDATE = 0x100;
        public const int OFN_ALLOWMULTISELECT = 0x200;
        public const int OFN_EXTENSIONDIFFERENT = 0x400;
        public const int OFN_PATHMUSTEXIST = 0x800;
        public const int OFN_FILEMUSTEXIST = 0x1000;
        public const int OFN_CREATEPROMPT = 0x2000;
        public const int OFN_SHAREAWARE = 0x4000;
        public const int OFN_NOREADONLYRETURN = 0x8000;
        public const int OFN_NOTESTFILECREATE = 0x10000;
        public const int OFN_NONETWORKBUTTON = 0x20000;
        public const int OFN_NOLONGNAMES = 0x40000;
        public const int OFN_EXPLORER = 0x80000;
        public const int OFN_NODEREFERENCELINKS = 0x100000;
        public const int OFN_LONGNAMES = 0x200000;
        public const int OFN_SHAREFALLTHROUGH = 2;
        public const int OFN_SHARENOWARN = 1;
        public const int OFN_SHAREWARN = 0;

        #endregion

        #region STARTF

        public const int STARTF_USESHOWWINDOW = 0x1;
        public const int STARTF_USESIZE = 0x2;
        public const int STARTF_USEPOSITION = 0x4;
        public const int STARTF_USECOUNTCHARS = 0x8;
        public const int STARTF_USEFILLATTRIBUTE = 0x10;
        public const int STARTF_RUNFULLSCREEN = 0x20;
        public const int STARTF_FORCEONFEEDBACK = 0x40;
        public const int STARTF_FORCEOFFFEEDBACK = 0x80;
        public const int STARTF_USESTDHANDLES = 0x100;

        #endregion

        #region ERROR

        public const int ERROR_SUCCESS = 0;
        public const int ERROR_INVALID_FUNCTION = 1;
        public const int ERROR_FILE_NOT_FOUND = 2;
        public const int ERROR_PATH_NOT_FOUND = 3;
        public const int ERROR_TOO_MANY_OPEN_FILES = 4;
        public const int ERROR_ACCESS_DENIED = 5;
        public const int ERROR_INVALID_HANDLE = 6;
        public const int ERROR_ARENA_TRASHED = 7;
        public const int ERROR_NOT_ENOUGH_MEMORY = 8;
        public const int ERROR_INVALID_BLOCK = 9;
        public const int ERROR_BAD_ENVIRONMENT = 10;
        public const int ERROR_BAD_FORMAT = 11;
        public const int ERROR_INVALID_ACCESS = 12;
        public const int ERROR_INVALID_DATA = 13;
        public const int ERROR_OUTOFMEMORY = 14;
        public const int ERROR_INVALID_DRIVE = 15;
        public const int ERROR_CURRENT_DIRECTORY = 16;
        public const int ERROR_NOT_SAME_DEVICE = 17;
        public const int ERROR_NO_MORE_FILES = 18;
        public const int ERROR_WRITE_PROTECT = 19;
        public const int ERROR_BAD_UNIT = 20;
        public const int ERROR_NOT_READY = 21;
        public const int ERROR_BAD_COMMAND = 22;
        public const int ERROR_CRC = 23;
        public const int ERROR_BAD_LENGTH = 24;
        public const int ERROR_SEEK = 25;
        public const int ERROR_NOT_DOS_DISK = 26;
        public const int ERROR_SECTOR_NOT_FOUND = 27;
        public const int ERROR_OUT_OF_PAPER = 28;
        public const int ERROR_WRITE_FAULT = 29;
        public const int ERROR_READ_FAULT = 30;
        public const int ERROR_GEN_FAILURE = 31;
        public const int ERROR_SHARING_VIOLATION = 32;
        public const int ERROR_LOCK_VIOLATION = 33;
        public const int ERROR_WRONG_DISK = 34;
        public const int ERROR_SHARING_BUFFER_EXCEEDED = 36;
        public const int ERROR_HANDLE_EOF = 38;
        public const int ERROR_HANDLE_DISK_FULL = 39;
        public const int ERROR_NOT_SUPPORTED = 50;
        public const int ERROR_REM_NOT_LIST = 51;
        public const int ERROR_DUP_NAME = 52;
        public const int ERROR_BAD_NETPATH = 53;
        public const int ERROR_NETWORK_BUSY = 54;
        public const int ERROR_DEV_NOT_EXIST = 55;
        public const int ERROR_TOO_MANY_CMDS = 56;
        public const int ERROR_ADAP_HDW_ERR = 57;
        public const int ERROR_BAD_NET_RESP = 58;
        public const int ERROR_UNEXP_NET_ERR = 59;
        public const int ERROR_BAD_REM_ADAP = 60;
        public const int ERROR_PRINTQ_FULL = 61;
        public const int ERROR_NO_SPOOL_SPACE = 62;
        public const int ERROR_PRINT_CANCELLED = 63;
        public const int ERROR_NETNAME_DELETED = 64;
        public const int ERROR_NETWORK_ACCESS_DENIED = 65;
        public const int ERROR_BAD_DEV_TYPE = 66;
        public const int ERROR_BAD_NET_NAME = 67;
        public const int ERROR_TOO_MANY_NAMES = 68;
        public const int ERROR_TOO_MANY_SESS = 69;
        public const int ERROR_SHARING_PAUSED = 70;
        public const int ERROR_REQ_NOT_ACCEP = 71;
        public const int ERROR_REDIR_PAUSED = 72;
        public const int ERROR_FILE_EXISTS = 80;
        public const int ERROR_CANNOT_MAKE = 82;
        public const int ERROR_FAIL_I24 = 83;
        public const int ERROR_OUT_OF_STRUCTURES = 84;
        public const int ERROR_ALREADY_ASSIGNED = 85;
        public const int ERROR_INVALID_PASSWORD = 86;
        public const int ERROR_INVALID_PARAMETER = 87;
        public const int ERROR_NET_WRITE_FAULT = 88;
        public const int ERROR_NO_PROC_SLOTS = 89;
        public const int ERROR_TOO_MANY_SEMAPHORES = 100;
        public const int ERROR_EXCL_SEM_ALREADY_OWNED = 101;
        public const int ERROR_SEM_IS_SET = 102;
        public const int ERROR_TOO_MANY_SEM_REQUESTS = 103;
        public const int ERROR_INVALID_AT_INTERRUPT_TIME = 104;
        public const int ERROR_SEM_OWNER_DIED = 105;
        public const int ERROR_SEM_USER_LIMIT = 106;
        public const int ERROR_DISK_CHANGE = 107;
        public const int ERROR_DRIVE_LOCKED = 108;
        public const int ERROR_BROKEN_PIPE = 109;
        public const int ERROR_OPEN_FAILED = 110;
        public const int ERROR_BUFFER_OVERFLOW = 111;
        public const int ERROR_DISK_FULL = 112;
        public const int ERROR_NO_MORE_SEARCH_HANDLES = 113;
        public const int ERROR_INVALID_TARGET_HANDLE = 114;
        public const int ERROR_INVALID_CATEGORY = 117;
        public const int ERROR_INVALID_VERIFY_SWITCH = 118;
        public const int ERROR_BAD_DRIVER_LEVEL = 119;
        public const int ERROR_CALL_NOT_IMPLEMENTED = 120;
        public const int ERROR_SEM_TIMEOUT = 121;
        public const int ERROR_INSUFFICIENT_BUFFER = 122;
        public const int ERROR_INVALID_NAME = 123;
        public const int ERROR_INVALID_LEVEL = 124;
        public const int ERROR_NO_VOLUME_LABEL = 125;
        public const int ERROR_MOD_NOT_FOUND = 126;
        public const int ERROR_PROC_NOT_FOUND = 127;
        public const int ERROR_WAIT_NO_CHILDREN = 128;
        public const int ERROR_CHILD_NOT_COMPLETE = 129;
        public const int ERROR_DIRECT_ACCESS_HANDLE = 130;
        public const int ERROR_NEGATIVE_SEEK = 131;
        public const int ERROR_SEEK_ON_DEVICE = 132;
        public const int ERROR_IS_JOIN_TARGET = 133;
        public const int ERROR_IS_JOINED = 134;
        public const int ERROR_IS_SUBSTED = 135;
        public const int ERROR_NOT_JOINED = 136;
        public const int ERROR_NOT_SUBSTED = 137;
        public const int ERROR_JOIN_TO_JOIN = 138;
        public const int ERROR_SUBST_TO_SUBST = 139;
        public const int ERROR_JOIN_TO_SUBST = 140;
        public const int ERROR_SUBST_TO_JOIN = 141;
        public const int ERROR_BUSY_DRIVE = 142;
        public const int ERROR_SAME_DRIVE = 143;
        public const int ERROR_DIR_NOT_ROOT = 144;
        public const int ERROR_DIR_NOT_EMPTY = 145;
        public const int ERROR_IS_SUBST_PATH = 146;
        public const int ERROR_IS_JOIN_PATH = 147;
        public const int ERROR_PATH_BUSY = 148;
        public const int ERROR_IS_SUBST_TARGET = 149;
        public const int ERROR_SYSTEM_TRACE = 150;
        public const int ERROR_INVALID_EVENT_COUNT = 151;
        public const int ERROR_TOO_MANY_MUXWAITERS = 152;
        public const int ERROR_INVALID_LIST_FORMAT = 153;
        public const int ERROR_LABEL_TOO_LONG = 154;
        public const int ERROR_TOO_MANY_TCBS = 155;
        public const int ERROR_SIGNAL_REFUSED = 156;
        public const int ERROR_DISCARDED = 157;
        public const int ERROR_NOT_LOCKED = 158;
        public const int ERROR_BAD_THREADID_ADDR = 159;
        public const int ERROR_BAD_ARGUMENTS = 160;
        public const int ERROR_BAD_PATHNAME = 161;
        public const int ERROR_SIGNAL_PENDING = 162;
        public const int ERROR_MAX_THRDS_REACHED = 164;
        public const int ERROR_LOCK_FAILED = 167;
        public const int ERROR_BUSY = 170;
        public const int ERROR_CANCEL_VIOLATION = 173;
        public const int ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;
        public const int ERROR_INVALID_SEGMENT_NUMBER = 180;
        public const int ERROR_INVALID_ORDINAL = 182;
        public const int ERROR_ALREADY_EXISTS = 183;
        public const int ERROR_INVALID_FLAG_NUMBER = 186;
        public const int ERROR_SEM_NOT_FOUND = 187;
        public const int ERROR_INVALID_STARTING_CODESEG = 188;
        public const int ERROR_INVALID_STACKSEG = 189;
        public const int ERROR_INVALID_MODULETYPE = 190;
        public const int ERROR_INVALID_EXE_SIGNATURE = 191;
        public const int ERROR_EXE_MARKED_INVALID = 192;
        public const int ERROR_BAD_EXE_FORMAT = 193;
        public const int ERROR_ITERATED_DATA_EXCEEDS_64k = 194;
        public const int ERROR_INVALID_MINALLOCSIZE = 195;
        public const int ERROR_DYNLINK_FROM_INVALID_RING = 196;
        public const int ERROR_IOPL_NOT_ENABLED = 197;
        public const int ERROR_INVALID_SEGDPL = 198;
        public const int ERROR_AUTODATASEG_EXCEEDS_64k = 199;
        public const int ERROR_RING2SEG_MUST_BE_MOVABLE = 200;
        public const int ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;
        public const int ERROR_INFLOOP_IN_RELOC_CHAIN = 202;
        public const int ERROR_ENVVAR_NOT_FOUND = 203;
        public const int ERROR_NO_SIGNAL_SENT = 205;
        public const int ERROR_FILENAME_EXCED_RANGE = 206;
        public const int ERROR_RING2_STACK_IN_USE = 207;
        public const int ERROR_META_EXPANSION_TOO_LONG = 208;
        public const int ERROR_INVALID_SIGNAL_NUMBER = 209;
        public const int ERROR_THREAD_1_INACTIVE = 210;
        public const int ERROR_LOCKED = 212;
        public const int ERROR_TOO_MANY_MODULES = 214;
        public const int ERROR_NESTING_NOT_ALLOWED = 215;
        public const int ERROR_BAD_PIPE = 230;
        public const int ERROR_PIPE_BUSY = 231;
        public const int ERROR_NO_DATA = 232;
        public const int ERROR_PIPE_NOT_CONNECTED = 233;
        public const int ERROR_MORE_DATA = 234;
        public const int ERROR_VC_DISCONNECTED = 240;
        public const int ERROR_INVALID_EA_NAME = 254;
        public const int ERROR_EA_LIST_INCONSISTENT = 255;
        public const int ERROR_NO_MORE_ITEMS = 259;
        public const int ERROR_CANNOT_COPY = 266;
        public const int ERROR_DIRECTORY = 267;
        public const int ERROR_EAS_DIDNT_FIT = 275;
        public const int ERROR_EA_FILE_CORRUPT = 276;
        public const int ERROR_EA_TABLE_FULL = 277;
        public const int ERROR_INVALID_EA_HANDLE = 278;
        public const int ERROR_EAS_NOT_SUPPORTED = 282;
        public const int ERROR_NOT_OWNER = 288;
        public const int ERROR_TOO_MANY_POSTS = 298;
        public const int ERROR_MR_MID_NOT_FOUND = 317;
        public const int ERROR_INVALID_ADDRESS = 487;
        public const int ERROR_ARITHMETIC_OVERFLOW = 534;
        public const int ERROR_PIPE_CONNECTED = 535;
        public const int ERROR_PIPE_LISTENING = 536;
        public const int ERROR_EA_ACCESS_DENIED = 994;
        public const int ERROR_OPERATION_ABORTED = 995;
        public const int ERROR_IO_INCOMPLETE = 996;
        public const int ERROR_IO_PENDING = 997;
        public const int ERROR_NOACCESS = 998;
        public const int ERROR_SWAPERROR = 999;
        public const int ERROR_STACK_OVERFLOW = 1001;
        public const int ERROR_INVALID_MESSAGE = 1002;
        public const int ERROR_CAN_NOT_COMPLETE = 1003;
        public const int ERROR_INVALID_FLAGS = 1004;
        public const int ERROR_UNRECOGNIZED_VOLUME = 1005;
        public const int ERROR_FILE_INVALID = 1006;
        public const int ERROR_FULLSCREEN_MODE = 1007;
        public const int ERROR_NO_TOKEN = 1008;
        public const int ERROR_BADDB = 1009;
        public const int ERROR_BADKEY = 1010;
        public const int ERROR_CANTOPEN = 1011;
        public const int ERROR_CANTREAD = 1012;
        public const int ERROR_CANTWRITE = 1013;
        public const int ERROR_REGISTRY_RECOVERED = 1014;
        public const int ERROR_REGISTRY_CORRUPT = 1015;
        public const int ERROR_REGISTRY_IO_FAILED = 1016;
        public const int ERROR_NOT_REGISTRY_FILE = 1017;
        public const int ERROR_KEY_DELETED = 1018;
        public const int ERROR_NO_LOG_SPACE = 1019;
        public const int ERROR_KEY_HAS_CHILDREN = 1020;
        public const int ERROR_CHILD_MUST_BE_VOLATILE = 1021;
        public const int ERROR_NOTIFY_ENUM_DIR = 1022;
        public const int ERROR_DEPENDENT_SERVICES_RUNNING = 1051;
        public const int ERROR_INVALID_SERVICE_CONTROL = 1052;
        public const int ERROR_SERVICE_REQUEST_TIMEOUT = 1053;
        public const int ERROR_SERVICE_NO_THREAD = 1054;
        public const int ERROR_SERVICE_DATABASE_LOCKED = 1055;
        public const int ERROR_SERVICE_ALREADY_RUNNING = 1056;
        public const int ERROR_INVALID_SERVICE_ACCOUNT = 1057;
        public const int ERROR_SERVICE_DISABLED = 1058;
        public const int ERROR_CIRCULAR_DEPENDENCY = 1059;
        public const int ERROR_SERVICE_DOES_NOT_EXIST = 1060;
        public const int ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061;
        public const int ERROR_SERVICE_NOT_ACTIVE = 1062;
        public const int ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063;
        public const int ERROR_EXCEPTION_IN_SERVICE = 1064;
        public const int ERROR_DATABASE_DOES_NOT_EXIST = 1065;
        public const int ERROR_SERVICE_SPECIFIC_ERROR = 1066;
        public const int ERROR_PROCESS_ABORTED = 1067;
        public const int ERROR_SERVICE_DEPENDENCY_FAIL = 1068;
        public const int ERROR_SERVICE_LOGON_FAILED = 1069;
        public const int ERROR_SERVICE_START_HANG = 1070;
        public const int ERROR_INVALID_SERVICE_LOCK = 1071;
        public const int ERROR_SERVICE_MARKED_FOR_DELETE = 1072;
        public const int ERROR_SERVICE_EXISTS = 1073;
        public const int ERROR_ALREADY_RUNNING_LKG = 1074;
        public const int ERROR_SERVICE_DEPENDENCY_DELETED = 1075;
        public const int ERROR_BOOT_ALREADY_ACCEPTED = 1076;
        public const int ERROR_SERVICE_NEVER_STARTED = 1077;
        public const int ERROR_DUPLICATE_SERVICE_NAME = 1078;
        public const int ERROR_END_OF_MEDIA = 1100;
        public const int ERROR_FILEMARK_DETECTED = 1101;
        public const int ERROR_BEGINNING_OF_MEDIA = 1102;
        public const int ERROR_SETMARK_DETECTED = 1103;
        public const int ERROR_NO_DATA_DETECTED = 1104;
        public const int ERROR_PARTITION_FAILURE = 1105;
        public const int ERROR_INVALID_BLOCK_LENGTH = 1106;
        public const int ERROR_DEVICE_NOT_PARTITIONED = 1107;
        public const int ERROR_UNABLE_TO_LOCK_MEDIA = 1108;
        public const int ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109;
        public const int ERROR_MEDIA_CHANGED = 1110;
        public const int ERROR_BUS_RESET = 1111;
        public const int ERROR_NO_MEDIA_IN_DRIVE = 1112;
        public const int ERROR_NO_UNICODE_TRANSLATION = 1113;
        public const int ERROR_DLL_INIT_FAILED = 1114;
        public const int ERROR_SHUTDOWN_IN_PROGRESS = 1115;
        public const int ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116;
        public const int ERROR_IO_DEVICE = 1117;
        public const int ERROR_SERIAL_NO_DEVICE = 1118;
        public const int ERROR_IRQ_BUSY = 1119;
        public const int ERROR_MORE_WRITES = 1120;
        public const int ERROR_COUNTER_TIMEOUT = 1121;
        public const int ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122;
        public const int ERROR_FLOPPY_WRONG_CYLINDER = 1123;
        public const int ERROR_FLOPPY_UNKNOWN_ERROR = 1124;
        public const int ERROR_FLOPPY_BAD_REGISTERS = 1125;
        public const int ERROR_DISK_RECALIBRATE_FAILED = 1126;
        public const int ERROR_DISK_OPERATION_FAILED = 1127;
        public const int ERROR_DISK_RESET_FAILED = 1128;
        public const int ERROR_EOM_OVERFLOW = 1129;
        public const int ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130;
        public const int ERROR_POSSIBLE_DEADLOCK = 1131;
        public const int ERROR_MAPPED_ALIGNMENT = 1132;
        public const int ERROR_INVALID_PIXEL_FORMAT = 2000;
        public const int ERROR_BAD_DRIVER = 2001;
        public const int ERROR_INVALID_WINDOW_STYLE = 2002;
        public const int ERROR_METAFILE_NOT_SUPPORTED = 2003;
        public const int ERROR_TRANSFORM_NOT_SUPPORTED = 2004;
        public const int ERROR_CLIPPING_NOT_SUPPORTED = 2005;
        public const int ERROR_UNKNOWN_PRINT_MONITOR = 3000;
        public const int ERROR_PRINTER_DRIVER_IN_USE = 3001;
        public const int ERROR_SPOOL_FILE_NOT_FOUND = 3002;
        public const int ERROR_SPL_NO_STARTDOC = 3003;
        public const int ERROR_SPL_NO_ADDJOB = 3004;
        public const int ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005;
        public const int ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006;
        public const int ERROR_WINS_INTERNAL = 4000;
        public const int ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001;
        public const int ERROR_STATIC_INIT = 4002;
        public const int ERROR_INC_BACKUP = 4003;
        public const int ERROR_FULL_BACKUP = 4004;
        public const int ERROR_REC_NON_EXISTENT = 4005;
        public const int ERROR_RPL_NOT_ALLOWED = 4006;

        #endregion

        #region HT

        public const int HTERROR = (-2);
        public const int HTTRANSPARENT = (-1);
        public const int HTNOWHERE = 0;
        public const int HTCLIENT = 1;
        public const int HTCAPTION = 2;
        public const int HTSYSMENU = 3;
        public const int HTGROWBOX = 4;
        public const int HTSIZE = HTGROWBOX;
        public const int HTMENU = 5;
        public const int HTHSCROLL = 6;
        public const int HTVSCROLL = 7;
        public const int HTMINBUTTON = 8;
        public const int HTMAXBUTTON = 9;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;
        public const int HTBORDER = 18;
        public const int HTREDUCE = HTMINBUTTON;
        public const int HTZOOM = HTMAXBUTTON;
        public const int HTSIZEFIRST = HTLEFT;
        public const int HTSIZELAST = HTBOTTOMRIGHT;

        #endregion

        #region IDC

        public const int IDC_APPSTARTING = 32650;
        public const int IDC_ARROW = 32512;
        public const int IDC_CROSS = 32515;
        public const int IDC_ICON = 32641;
        public const int IDC_IBEAM = 32513;
        public const int IDC_NO = 32648;
        public const int IDC_SIZE = 32640;
        public const int IDC_SIZEALL = 32646;
        public const int IDC_SIZENESW = 32643;
        public const int IDC_SIZENS = 32645;
        public const int IDC_SIZENWSE = 32642;
        public const int IDC_SIZEWE = 32644;
        public const int IDC_UPARROW = 32516;
        public const int IDC_WAIT = 32514;

        #endregion

        #region GWL

        public const int GWL_WNDPROC = (-4);
        public const int GWL_HINSTANCE = (-6);
        public const int GWL_HWNDPARENT = (-8);
        public const int GWL_STYLE = (-16);
        public const int GWL_EXSTYLE = (-20);
        public const int GWL_USERDATA = (-21);
        public const int GWL_ID = (-12);

        #endregion

        #region WPF

        public const int WPF_SETMINPOSITION = 1;
        public const int WPF_RESTORETOMAXIMIZED = 2;
        public const int WPF_ASYNCWINDOWPLACEMENT = 4;

        #endregion

        #region NIM

        public const int NIM_ADD = 0x00000000;
        public const int NIM_MODIFY = 0x00000001;
        public const int NIM_DELETE = 0x00000002;
        public const int NIM_SETFOCUS = 0x00000003;
        public const int NIM_SETVERSION = 0x00000004;
        public const int NOTIFYICON_VERSION = 3;

        #endregion

        #region LWA

        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;
        //其中dwFlags有LWA_ALPHA和LWA_COLORKEY 
        //LWA_ALPHA被设置的话,通过bAlpha决定透明度. 
        //LWA_COLORKEY被设置的话,则指定被透明掉的颜色为crKey,其他颜色则正常显示. 
        //注:要使使窗体拥有透明效果,首先要有WS_EX_LAYERED扩展属性(旧sdk也没有的).

        #endregion

        #region TH32CS

        public const uint TH32CS_SNAPHEAPLIST = 0x1;
        public const uint TH32CS_SNAPPROCESS = 0x2;
        public const uint TH32CS_SNAPTHREAD = 0x4;
        public const uint TH32CS_SNAPMODULE = 0x8;
        public const uint TH32CS_SNAPALL = (TH32CS_SNAPHEAPLIST | TH32CS_SNAPPROCESS | TH32CS_SNAPTHREAD | TH32CS_SNAPMODULE);
        public const uint TH32CS_INHERIT = 0x80000000;

        #endregion

        #region SB

        public const int SB_HORZ = 0;
        public const int SB_VERT = 1;
        public const int SB_CTL = 2;
        public const int SB_BOTH = 3;
        public const int SB_LINEUP = 0;
        public const int SB_LINELEFT = 0;
        public const int SB_LINEDOWN = 1;
        public const int SB_LINERIGHT = 1;
        public const int SB_PAGEUP = 2;
        public const int SB_PAGELEFT = 2;
        public const int SB_PAGEDOWN = 3;
        public const int SB_PAGERIGHT = 3;
        public const int SB_THUMBPOSITION = 4;
        public const int SB_THUMBTRACK = 5;
        public const int SB_TOP = 6;
        public const int SB_LEFT = 6;
        public const int SB_BOTTOM = 7;
        public const int SB_RIGHT = 7;
        public const int SB_ENDSCROLL = 8;

        #endregion

        #region GW

        public const uint GW_HWNDFIRST = 0;
        public const uint GW_HWNDLAST = 1;
        public const uint GW_HWNDNEXT = 2;
        public const uint GW_HWNDPREV = 3;
        public const uint GW_OWNER = 4;
        public const uint GW_CHILD = 5;
        public const uint GW_MAX = 5;
        public const uint GW_ENABLEDPOPUP = 6;

        #endregion

        #region CDS

        public const int CDS_UPDATEREGISTRY = 0x00000001;
        public const int CDS_TEST = 0x00000002;
        public const int CDS_FULLSCREEN = 0x00000004;
        public const int CDS_GLOBAL = 0x00000008;
        public const int CDS_SET_PRIMARY = 0x00000010;
        public const int CDS_VIDEOPARAMETERS = 0x00000020;
        public const int CDS_RESET = 0x40000000;
        public const int CDS_NORESET = 0x10000000;

        #endregion

        #region SIF

        public const int SIF_RANGE = 0x0001;
        public const int SIF_PAGE = 0x0002;
        public const int SIF_POS = 0x0004;
        public const int SIF_DISABLENOSCROLL = 0x0008;
        public const int SIF_TRACKPOS = 0x0010;
        public const int SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS);

        #endregion

        #region PROCESS

        public const int PROCESS_QUERY_INFORMATION = 0x400;
        public const int PROCESS_VM_READ = 16;
        public const int PROCESS_ALL_ACCESS = 0x001F0FFF;

        #endregion

        #region ENUM

        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int ENUM_REGISTRY_SETTINGS = -2;

        #endregion

        #region DISPLAY_DEVICE

        public const int DISPLAY_DEVICE_ATTACHED_TO_DESKTOP = 0x00000001;
        public const int DISPLAY_DEVICE_MULTI_DRIVER = 0x00000002;
        public const int DISPLAY_DEVICE_PRIMARY_DEVICE = 0x00000004;
        public const int DISPLAY_DEVICE_MIRRORING_DRIVER = 0x00000008;
        public const int DISPLAY_DEVICE_VGA_COMPATIBLE = 0x00000010;

        #endregion

        #region R2

        public const int R2_BLACK = 1;
        public const int R2_NOTMERGEPEN = 2;
        public const int R2_MASKNOTPEN = 3;
        public const int R2_NOTCOPYPEN = 4;
        public const int R2_MASKPENNOT = 5;
        public const int R2_NOT = 6;
        public const int R2_XORPEN = 7;
        public const int R2_NOTMASKPEN = 8;
        public const int R2_MASKPEN = 9;
        public const int R2_NOTXORPEN = 10;
        public const int R2_NOP = 11;
        public const int R2_MERGENOTPEN = 12;
        public const int R2_COPYPEN = 13;
        public const int R2_MERGEPENNOT = 14;
        public const int R2_MERGEPEN = 15;
        public const int R2_WHITE = 16;
        public const int R2_LAST = 16;

        #endregion

        #region PS

        public const int PS_SOLID = 0;
        public const int PS_DASH = 1;
        public const int PS_DOT = 2;
        public const int PS_DASHDOT = 3;
        public const int PS_DASHDOTDOT = 4;
        public const int PS_NULL = 5;
        public const int PS_INSIDEFRAME = 6;
        public const int PS_USERSTYLE = 7;
        public const int PS_ALTERNATE = 8;
        public const int PS_STYLE_MASK = 0xF;
        public const int PS_ENDCAP_ROUND = 0x0;
        public const int PS_ENDCAP_SQUARE = 0x100;
        public const int PS_ENDCAP_FLAT = 0x200;
        public const int PS_ENDCAP_MASK = 0xF00;
        public const int PS_JOIN_ROUND = 0x0;
        public const int PS_JOIN_BEVEL = 0x1000;
        public const int PS_JOIN_MITER = 0x2000;
        public const int PS_JOIN_MASK = 0xF000;
        public const int PS_COSMETIC = 0x0;
        public const int PS_GEOMETRIC = 0x10000;
        public const int PS_TYPE_MASK = 0xF0000;

        #endregion

        #region EM

        public const int EM_GETSEL = 0x00B0;
        public const int EM_SETSEL = 0x00B1;
        public const int EM_GETRECT = 0x00B2;
        public const int EM_SETRECT = 0x00B3;
        public const int EM_SETRECTNP = 0x00B4;
        public const int EM_SCROLL = 0x00B5;
        public const int EM_LINESCROLL = 0x00B6;
        public const int EM_SCROLLCARET = 0x00B7;
        public const int EM_GETMODIFY = 0x00B8;
        public const int EM_SETMODIFY = 0x00B9;
        public const int EM_GETLINECOUNT = 0x00BA;
        public const int EM_LINEINDEX = 0x00BB;
        public const int EM_SETHANDLE = 0x00BC;
        public const int EM_GETHANDLE = 0x00BD;
        public const int EM_GETTHUMB = 0x00BE;
        public const int EM_LINELENGTH = 0x00C1;
        public const int EM_REPLACESEL = 0x00C2;
        public const int EM_GETLINE = 0x00C4;
        public const int EM_LIMITTEXT = 0x00C5;
        public const int EM_CANUNDO = 0x00C6;
        public const int EM_UNDO = 0x00C7;
        public const int EM_FMTLINES = 0x00C8;
        public const int EM_LINEFROMCHAR = 0x00C9;
        public const int EM_SETTABSTOPS = 0x00CB;
        public const int EM_SETPASSWORDCHAR = 0x00CC;
        public const int EM_EMPTYUNDOBUFFER = 0x00CD;
        public const int EM_GETFIRSTVISIBLELINE = 0x00CE;
        public const int EM_SETREADONLY = 0x00CF;
        public const int EM_SETWORDBREAKPROC = 0x00D0;
        public const int EM_GETWORDBREAKPROC = 0x00D1;
        public const int EM_GETPASSWORDCHAR = 0x00D2;
        public const int EM_SETMARGINS = 0x00D3;
        public const int EM_GETMARGINS = 0x00D4;
        public const int EM_SETLIMITTEXT = EM_LIMITTEXT;   /* ;win40 Name change */
        public const int EM_GETLIMITTEXT = 0x00D5;
        public const int EM_POSFROMCHAR = 0x00D6;
        public const int EM_CHARFROMPOS = 0x00D7;
        public const int EM_SETIMESTATUS = 0x00D8;
        public const int EM_GETIMESTATUS = 0x00D9;

        #endregion

        #region MOD

        public const uint MOD_ALT = 0x0001;
        public const uint MOD_CONTROL = 0x0002;
        public const uint MOD_SHIFT = 0x0004;
        public const uint MOD_WIN = 0x0008;

        #endregion

        #region HS

        public const int HS_HORIZONTAL = 0;
        public const int HS_VERTICAL = 1;
        public const int HS_FDIAGONAL = 2;
        public const int HS_BDIAGONAL = 3;
        public const int HS_CROSS = 4;
        public const int HS_DIAGCROSS = 5;

        #endregion

        #region FLASHW

        public const int FLASHW_STOP = 0;
        public const int FLASHW_CAPTION = 0x00000001;
        public const int FLASHW_TRAY = 0x00000002;
        public const int FLASHW_ALL = (FLASHW_CAPTION | FLASHW_TRAY);
        public const int FLASHW_TIMER = 0x00000004;
        public const int FLASHW_TIMERNOFG = 0x0000000C;

        #endregion

        #region FR

        public const int FR_DOWN = 0x00000001;
        public const int FR_WHOLEWORD = 0x00000002;
        public const int FR_MATCHCASE = 0x00000004;
        public const int FR_FINDNEXT = 0x00000008;
        public const int FR_REPLACE = 0x00000010;
        public const int FR_REPLACEALL = 0x00000020;
        public const int FR_DIALOGTERM = 0x00000040;
        public const int FR_SHOWHELP = 0x00000080;
        public const int FR_ENABLEHOOK = 0x00000100;
        public const int FR_ENABLETEMPLATE = 0x00000200;
        public const int FR_NOUPDOWN = 0x00000400;
        public const int FR_NOMATCHCASE = 0x00000800;
        public const int FR_NOWHOLEWORD = 0x00001000;
        public const int FR_ENABLETEMPLATEHANDLE = 0x00002000;
        public const int FR_HIDEUPDOWN = 0x00004000;
        public const int FR_HIDEMATCHCASE = 0x00008000;
        public const int FR_HIDEWHOLEWORD = 0x00010000;
        public const int FR_RAW = 0x00020000;
        public const int FR_MATCHDIAC = 0x20000000;
        public const int FR_MATCHKASHIDA = 0x40000000;
        public const uint FR_MATCHALEFHAMZA = 0x80000000;

        #endregion

        #region CC

        public const int CC_RGBINIT = 0x00000001;
        public const int CC_FULLOPEN = 0x00000002;
        public const int CC_PREVENTFULLOPEN = 0x00000004;
        public const int CC_SHOWHELP = 0x00000008;
        public const int CC_ENABLEHOOK = 0x00000010;
        public const int CC_ENABLETEMPLATE = 0x00000020;
        public const int CC_ENABLETEMPLATEHANDLE = 0x00000040;
        public const int CC_SOLIDCOLOR = 0x00000080;
        public const int CC_ANYCOLOR = 0x00000100;

        #endregion

        #region CF

        public const int CF_SCREENFONTS = 0x00000001;
        public const int CF_PRINTERFONTS = 0x00000002;
        public const int CF_BOTH = (CF_SCREENFONTS | CF_PRINTERFONTS);
        public const long CF_SHOWHELP = 0x00000004L;
        public const long CF_ENABLEHOOK = 0x00000008L;
        public const long CF_ENABLETEMPLATE = 0x00000010L;
        public const long CF_ENABLETEMPLATEHANDLE = 0x00000020L;
        public const long CF_INITTOLOGFONTSTRUCT = 0x00000040L;
        public const long CF_USESTYLE = 0x00000080L;
        public const long CF_EFFECTS = 0x00000100L;
        public const long CF_APPLY = 0x00000200L;
        public const long CF_ANSIONLY = 0x00000400L;
        public const long CF_SCRIPTSONLY = CF_ANSIONLY;
        public const long CF_NOVECTORFONTS = 0x00000800L;
        public const long CF_NOOEMFONTS = CF_NOVECTORFONTS;
        public const long CF_NOSIMULATIONS = 0x00001000L;
        public const long CF_LIMITSIZE = 0x00002000L;
        public const long CF_FIXEDPITCHONLY = 0x00004000L;
        public const long CF_WYSIWYG = 0x00008000L; // must also have CF_SCREENFONTS & CF_PRlongERFONTS;
        public const long CF_FORCEFONTEXIST = 0x00010000L;
        public const long CF_SCALABLEONLY = 0x00020000L;
        public const long CF_TTONLY = 0x00040000L;
        public const long CF_NOFACESEL = 0x00080000L;
        public const long CF_NOSTYLESEL = 0x00100000L;
        public const long CF_NOSIZESEL = 0x00200000L;
        public const long CF_SELECTSCRIPT = 0x00400000L;
        public const long CF_NOSCRIPTSEL = 0x00800000L;
        public const long CF_NOVERTFONTS = 0x01000000L;

        #endregion

        #region FONTNAME

        public const int ANSI_CHARSET = 0;
        public const int ARABIC_CHARSET = 178;
        public const int BALTIC_CHARSET = 186;
        public const int CHINESEBIG5_CHARSET = 136;
        public const int DEFAULT_CHARSET = 1;
        public const int EASTEUROPE_CHARSET = 238;
        public const int GB2312_CHARSET = 134;
        public const int GREEK_CHARSET = 161;
        public const int HANGEUL_CHARSET = 129;
        public const int HEBREW_CHARSET = 177;
        public const int JOHAB_CHARSET = 130;
        public const int MAC_CHARSET = 77;
        public const int OEM_CHARSET = 255;
        public const int RUSSIAN_CHARSET = 204;
        public const int SHIFTJIS_CHARSET = 128;
        public const int SYMBOL_CHARSET = 2;
        public const int THAI_CHARSET = 222;
        public const int TURKISH_CHARSET = 162;

        #endregion

        #region FONTSTYLE

        public const int SIMULATED_FONTTYPE = 0x8000;
        public const int PRINTER_FONTTYPE = 0x4000;
        public const int SCREEN_FONTTYPE = 0x2000;
        public const int BOLD_FONTTYPE = 0x0100;
        public const int ITALIC_FONTTYPE = 0x0200;
        public const int REGULAR_FONTTYPE = 0x0400;

        #endregion

        #region SM

        public const int SM_CXSCREEN = 0;
        public const int SM_CYSCREEN = 1;
        public const int SM_CXVSCROLL = 2;
        public const int SM_CYHSCROLL = 3;
        public const int SM_CYCAPTION = 4;
        public const int SM_CXBORDER = 5;
        public const int SM_CYBORDER = 6;
        public const int SM_CXDLGFRAME = 7;
        public const int SM_CYDLGFRAME = 8;
        public const int SM_CYVTHUMB = 9;
        public const int SM_CXHTHUMB = 10;
        public const int SM_CXICON = 11;
        public const int SM_CYICON = 12;
        public const int SM_CXCURSOR = 13;
        public const int SM_CYCURSOR = 14;
        public const int SM_CYMENU = 15;
        public const int SM_CXFULLSCREEN = 16;
        public const int SM_CYFULLSCREEN = 17;
        public const int SM_CYKANJIWINDOW = 18;
        public const int SM_MOUSEPRESENT = 19;
        public const int SM_CYVSCROLL = 20;
        public const int SM_CXHSCROLL = 21;
        public const int SM_DEBUG = 22;
        public const int SM_SWAPBUTTON = 23;
        public const int SM_RESERVED1 = 24;
        public const int SM_RESERVED2 = 25;
        public const int SM_RESERVED3 = 26;
        public const int SM_RESERVED4 = 27;
        public const int SM_CXMIN = 28;
        public const int SM_CYMIN = 29;
        public const int SM_CXSIZE = 30;
        public const int SM_CYSIZE = 31;
        public const int SM_CXFRAME = 32;
        public const int SM_CYFRAME = 33;
        public const int SM_CXMINTRACK = 34;
        public const int SM_CYMINTRACK = 35;
        public const int SM_CXDOUBLECLK = 36;
        public const int SM_CYDOUBLECLK = 37;
        public const int SM_CXICONSPACING = 38;
        public const int SM_CYICONSPACING = 39;
        public const int SM_MENUDROPALIGNMENT = 40;
        public const int SM_PENWINDOWS = 41;
        public const int SM_DBCSENABLED = 42;
        public const int SM_CMOUSEBUTTONS = 43;
        public const int SM_CXFIXEDFRAME = SM_CXDLGFRAME;  /* ;win40 name change */
        public const int SM_CYFIXEDFRAME = SM_CYDLGFRAME;  /* ;win40 name change */
        public const int SM_CXSIZEFRAME = SM_CXFRAME;    /* ;win40 name change */
        public const int SM_CYSIZEFRAME = SM_CYFRAME;    /* ;win40 name change */
        public const int SM_SECURE = 44;
        public const int SM_CXEDGE = 45;
        public const int SM_CYEDGE = 46;
        public const int SM_CXMINSPACING = 47;
        public const int SM_CYMINSPACING = 48;
        public const int SM_CXSMICON = 49;
        public const int SM_CYSMICON = 50;
        public const int SM_CYSMCAPTION = 51;
        public const int SM_CXSMSIZE = 52;
        public const int SM_CYSMSIZE = 53;
        public const int SM_CXMENUSIZE = 54;
        public const int SM_CYMENUSIZE = 55;
        public const int SM_ARRANGE = 56;
        public const int SM_CXMINIMIZED = 57;
        public const int SM_CYMINIMIZED = 58;
        public const int SM_CXMAXTRACK = 59;
        public const int SM_CYMAXTRACK = 60;
        public const int SM_CXMAXIMIZED = 61;
        public const int SM_CYMAXIMIZED = 62;
        public const int SM_NETWORK = 63;
        public const int SM_CLEANBOOT = 67;
        public const int SM_CXDRAG = 68;
        public const int SM_CYDRAG = 69;
        public const int SM_SHOWSOUNDS = 70;
        public const int SM_CXMENUCHECK = 71;  /* Use instead of GetMenuCheckMarkDimensions()! */
        public const int SM_CYMENUCHECK = 72;
        public const int SM_SLOWMACHINE = 73;
        public const int SM_MIDEASTENABLED = 74;
        public const int SM_MOUSEWHEELPRESENT = 75;
        public const int SM_XVIRTUALSCREEN = 76;
        public const int SM_YVIRTUALSCREEN = 77;
        public const int SM_CXVIRTUALSCREEN = 78;
        public const int SM_CYVIRTUALSCREEN = 79;
        public const int SM_CMONITORS = 80;
        public const int SM_SAMEDISPLAYFORMAT = 81;
        public const int SM_IMMENABLED = 82;
        public const int SM_CXFOCUSBORDER = 83;
        public const int SM_CYFOCUSBORDER = 84;
        public const int SM_CMETRICS = 76;
        public const int SM_REMOTESESSION = 0x1000;
        public const int SM_SHUTTINGDOWN = 0x2000;

        #endregion

        #region MIM

        public const int MIM_MAXHEIGHT = 0x00000001;
        public const int MIM_BACKGROUND = 0x00000002;
        public const int MIM_HELPID = 0x00000004;
        public const int MIM_MENUDATA = 0x00000008;
        public const int MIM_STYLE = 0x00000010;
        public const uint MIM_APPLYTOSUBMENUS = 0x80000000;

        #endregion

        #region MNS

        public const uint MNS_NOCHECK = 0x80000000;
        public const int MNS_MODELESS = 0x40000000;
        public const int MNS_DRAGDROP = 0x20000000;
        public const int MNS_AUTODISMISS = 0x10000000;
        public const int MNS_NOTIFYBYPOS = 0x08000000;
        public const int MNS_CHECKORBMP = 0x04000000;

        #endregion

        #region CS

        public const int CS_VREDRAW = 0x0001;
        public const int CS_HREDRAW = 0x0002;
        public const int CS_DBLCLKS = 0x0008;
        public const int CS_OWNDC = 0x0020;
        public const int CS_CLASSDC = 0x0040;
        public const int CS_PARENTDC = 0x0080;
        public const int CS_NOCLOSE = 0x0200;
        public const int CS_SAVEBITS = 0x0800;
        public const int CS_BYTEALIGNCLIENT = 0x1000;
        public const int CS_BYTEALIGNWINDOW = 0x2000;
        public const int CS_GLOBALCLASS = 0x4000;
        public const int CS_IME = 0x00010000;
        public const int CS_DROPSHADOW = 0x00020000;

        #endregion

        #region COLOR

        public const int CTLCOLOR_MSGBOX = 0;
        public const int CTLCOLOR_EDIT = 1;
        public const int CTLCOLOR_LISTBOX = 2;
        public const int CTLCOLOR_BTN = 3;
        public const int CTLCOLOR_DLG = 4;
        public const int CTLCOLOR_SCROLLBAR = 5;
        public const int CTLCOLOR_STATIC = 6;
        public const int CTLCOLOR_MAX = 7;
        public const int COLOR_SCROLLBAR = 0;
        public const int COLOR_BACKGROUND = 1;
        public const int COLOR_ACTIVECAPTION = 2;
        public const int COLOR_INACTIVECAPTION = 3;
        public const int COLOR_MENU = 4;
        public const int COLOR_WINDOW = 5;
        public const int COLOR_WINDOWFRAME = 6;
        public const int COLOR_MENUTEXT = 7;
        public const int COLOR_WINDOWTEXT = 8;
        public const int COLOR_CAPTIONTEXT = 9;
        public const int COLOR_ACTIVEBORDER = 10;
        public const int COLOR_INACTIVEBORDER = 11;
        public const int COLOR_APPWORKSPACE = 12;
        public const int COLOR_HIGHLIGHT = 13;
        public const int COLOR_HIGHLIGHTTEXT = 14;
        public const int COLOR_BTNFACE = 15;
        public const int COLOR_BTNSHADOW = 16;
        public const int COLOR_GRAYTEXT = 17;
        public const int COLOR_BTNTEXT = 18;
        public const int COLOR_INACTIVECAPTIONTEXT = 19;
        public const int COLOR_BTNHIGHLIGHT = 20;
        public const int COLOR_3DDKSHADOW = 21;
        public const int COLOR_3DLIGHT = 22;
        public const int COLOR_INFOTEXT = 23;
        public const int COLOR_INFOBK = 24;
        public const int COLOR_HOTLIGHT = 26;
        public const int COLOR_GRADIENTACTIVECAPTION = 27;
        public const int COLOR_GRADIENTINACTIVECAPTION = 28;
        public const int COLOR_MENUHILIGHT = 29;
        public const int COLOR_MENUBAR = 30;
        public const int COLOR_DESKTOP = COLOR_BACKGROUND;
        public const int COLOR_3DFACE = COLOR_BTNFACE;
        public const int COLOR_3DSHADOW = COLOR_BTNSHADOW;
        public const int COLOR_3DHIGHLIGHT = COLOR_BTNHIGHLIGHT;
        public const int COLOR_3DHILIGHT = COLOR_BTNHIGHLIGHT;
        public const int COLOR_BTNHILIGHT = COLOR_BTNHIGHLIGHT;

        #endregion

        #region NIF

        public const int NIF_MESSAGE = 0x00000001;
        public const int NIF_ICON = 0x00000002;
        public const int NIF_TIP = 0x00000004;
        public const int NIF_STATE = 0x00000008;
        public const int NIF_INFO = 0x00000010;
        public const int NIF_GUID = 0x00000020;

        #endregion

        #region NIIF

        public const int NIIF_NONE = 0x00000000;
        public const int NIIF_INFO = 0x00000001;
        public const int NIIF_WARNING = 0x00000002;
        public const int NIIF_ERROR = 0x00000003;
        public const int NIIF_ICON_MASK = 0x0000000F;
        public const int NIIF_NOSOUND = 0x00000010;

        #endregion

        #region NIN

        public const int NIN_SELECT = (WM_USER + 0);
        public const int NINF_KEY = 0x1;
        public const int NIN_KEYSELECT = (NIN_SELECT | NINF_KEY);
        public const int NIN_BALLOONSHOW = (WM_USER + 2);
        public const int NIN_BALLOONHIDE = (WM_USER + 3);
        public const int NIN_BALLOONTIMEOUT = (WM_USER + 4);
        public const int NIN_BALLOONUSERCLICK = (WM_USER + 5);

        #endregion

        #region NIS

        public const int NIS_HIDDEN = 0x00000001;
        public const int NIS_SHAREDICON = 0x00000002;

        #endregion

        #region THREAD

        public const int MAXLONG = 0x7FFFFFFF;
        public const int THREAD_BASE_PRIORITY_MIN = -2;
        public const int THREAD_BASE_PRIORITY_MAX = 2;
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;
        public const int THREAD_BASE_PRIORITY_IDLE = -15;
        public const int THREAD_PRIORITY_LOWEST = THREAD_BASE_PRIORITY_MIN;
        public const int THREAD_PRIORITY_BELOW_NORMAL = (THREAD_PRIORITY_LOWEST + 1);
        public const int THREAD_PRIORITY_NORMAL = 0;
        public const int THREAD_PRIORITY_HIGHEST = THREAD_BASE_PRIORITY_MAX;
        public const int THREAD_PRIORITY_ABOVE_NORMAL = (THREAD_PRIORITY_HIGHEST - 1);
        public const int THREAD_PRIORITY_ERROR_RETURN = (MAXLONG);
        public const int THREAD_PRIORITY_TIME_CRITICAL = THREAD_BASE_PRIORITY_LOWRT;
        public const int THREAD_PRIORITY_IDLE = THREAD_BASE_PRIORITY_IDLE;

        #endregion

        #region IDI

        public const int IDI_APPLICATION = 32512;
        public const int IDI_HAND = 32513;
        public const int IDI_QUESTION = 332514;
        public const int IDI_EXCLAMATION = 32515;
        public const int IDI_ASTERISK = 32516;
        public const int IDI_WINLOGO = 32517;

        #endregion

        #region BitBlt

        public const int SRCCOPY = 0x00CC0020; /* dest = source                   */
        public const int SRCPAINT = 0x00EE0086; /* dest = source OR dest           */
        public const int SRCAND = 0x008800C6; /* dest = source AND dest          */
        public const int SRCINVERT = 0x00660046; /* dest = source XOR dest          */
        public const int SRCERASE = 0x00440328; /* dest = source AND (NOT dest )   */
        public const int NOTSRCCOPY = 0x00330008; /* dest = (NOT source)             */
        public const int NOTSRCERASE = 0x001100A6; /* dest = (NOT src) AND (NOT dest) */
        public const int MERGECOPY = 0x00C000CA; /* dest = (source AND pattern)     */
        public const int MERGEPAINT = 0x00BB0226; /* dest = (NOT source) OR dest     */
        public const int PATCOPY = 0x00F00021; /* dest = pattern                  */
        public const int PATPAINT = 0x00FB0A09; /* dest = DPSnoo                   */
        public const int PATINVERT = 0x005A0049; /* dest = pattern XOR dest         */
        public const int DSTINVERT = 0x00550009; /* dest = (NOT dest)               */
        public const int BLACKNESS = 0x00000042; /* dest = BLACK                    */
        public const int WHITENESS = 0x00FF0062; /* dest = WHITE                    */
        public const uint NOMIRRORBITMAP = 0x80000000; /* Do not Mirror the bitmap in this call */
        public const int CAPTUREBLT = 0x40000000;

        #endregion

        #region MIIM

        public const int MIIM_STATE = 0x00000001;
        public const int MIIM_ID = 0x00000002;
        public const int MIIM_SUBMENU = 0x00000004;
        public const int MIIM_CHECKMARKS = 0x00000008;
        public const int MIIM_TYPE = 0x00000010;
        public const int MIIM_DATA = 0x00000020;
        public const int MIIM_STRING = 0x00000040;
        public const int MIIM_BITMAP = 0x00000080;
        public const int MIIM_FTYPE = 0x00000100;

        #endregion

        #region MFT

        public const int MFT_STRING = MF_STRING;
        public const int MFT_BITMAP = MF_BITMAP;
        public const int MFT_MENUBARBREAK = MF_MENUBARBREAK;
        public const int MFT_MENUBREAK = MF_MENUBREAK;
        public const int MFT_OWNERDRAW = MF_OWNERDRAW;
        public const int MFT_RADIOCHECK = 0x00000200;
        public const int MFT_SEPARATOR = MF_SEPARATOR;
        public const int MFT_RIGHTORDER = 0x00002000;
        public const int MFT_RIGHTJUSTIFY = MF_RIGHTJUSTIFY;

        #endregion

        #region MFS

        public const int MFS_GRAYED = 0x00000003;
        public const int MFS_DISABLED = MFS_GRAYED;
        public const int MFS_CHECKED = MF_CHECKED;
        public const int MFS_HILITE = MF_HILITE;
        public const int MFS_ENABLED = MF_ENABLED;
        public const int MFS_UNCHECKED = MF_UNCHECKED;
        public const int MFS_UNHILITE = MF_UNHILITE;
        public const int MFS_DEFAULT = MF_DEFAULT;

        #endregion

        #region MB

        public const int MB_OK = 0x00000000;
        public const int MB_OKCANCEL = 0x00000001;
        public const int MB_ABORTRETRYIGNORE = 0x00000002;
        public const int MB_YESNOCANCEL = 0x00000003;
        public const int MB_YESNO = 0x00000004;
        public const int MB_RETRYCANCEL = 0x00000005;
        public const int MB_CANCELTRYCONTINUE = 0x00000006;
        public const int MB_ICONHAND = 0x00000010;
        public const int MB_ICONQUESTION = 0x00000020;
        public const int MB_ICONEXCLAMATION = 0x00000030;
        public const int MB_ICONASTERISK = 0x00000040;
        public const int MB_USERICON = 0x00000080;
        public const int MB_ICONWARNING = MB_ICONEXCLAMATION;
        public const int MB_ICONERROR = MB_ICONHAND;
        public const int MB_ICONINFORMATION = MB_ICONASTERISK;
        public const int MB_ICONSTOP = MB_ICONHAND;
        public const int MB_DEFBUTTON1 = 0x00000000;
        public const int MB_DEFBUTTON2 = 0x00000100;
        public const int MB_DEFBUTTON3 = 0x00000200;
        public const int MB_DEFBUTTON4 = 0x00000300;
        public const int MB_APPLMODAL = 0x00000000;
        public const int MB_SYSTEMMODAL = 0x00001000;
        public const int MB_TASKMODAL = 0x00002000;
        public const int MB_HELP = 0x00004000; // Help Button
        public const int MB_NOFOCUS = 0x00008000;
        public const int MB_SETFOREGROUND = 0x00010000;
        public const int MB_DEFAULT_DESKTOP_ONLY = 0x00020000;
        public const int MB_TOPMOST = 0x00040000;
        public const int MB_RIGHT = 0x00080000;
        public const int MB_RTLREADING = 0x00100000;
        public const int MB_SERVICE_NOTIFICATION = 0x00200000;
        //public const int MB_SERVICE_NOTIFICATION = 0x00040000;
        public const int MB_SERVICE_NOTIFICATION_NT3X = 0x00040000;
        public const int MB_TYPEMASK = 0x0000000F;
        public const int MB_ICONMASK = 0x000000F0;
        public const int MB_DEFMASK = 0x00000F00;
        public const int MB_MODEMASK = 0x00003000;
        public const int MB_MISCMASK = 0x0000C000;

        #endregion

        #region SHGFI

        public const int SHGFI_ICON = 0x000000100;   // get icon;
        public const int SHGFI_DISPLAYNAME = 0x000000200;   // get display name;
        public const int SHGFI_TYPENAME = 0x000000400;    // get type name;
        public const int SHGFI_ATTRIBUTES = 0x000000800;    // get attributes;
        public const int SHGFI_ICONLOCATION = 0x000001000;    // get icon location;
        public const int SHGFI_EXETYPE = 0x000002000;    // return exe type;
        public const int SHGFI_SYSICONINDEX = 0x000004000;   // get system icon index;
        public const int SHGFI_LINKOVERLAY = 0x000008000;    // put a link overlay on icon;
        public const int SHGFI_SELECTED = 0x000010000;    // show icon in selected state;
        public const int SHGFI_ATTR_SPECIFIED = 0x000020000;    // get only specified attributes;
        public const int SHGFI_LARGEICON = 0x000000000;     // get large icon;
        public const int SHGFI_SMALLICON = 0x000000001;    // get small icon;
        public const int SHGFI_OPENICON = 0x000000002;    // get open icon;
        public const int SHGFI_SHELLICONSIZE = 0x000000004;    // get shell size icon;
        public const int SHGFI_PIDL = 0x000000008;    // pszPath is a pidl;
        public const int SHGFI_USEFILEATTRIBUTES = 0x000000010;    // use passed dwFileAttribute;
        public const int SHGFI_ADDOVERLAYS = 0x000000020;     // apply the appropriate overlays;
        public const int SHGFI_OVERLAYINDEX = 0x000000040;

        #endregion

        #region FILE_ATTRIBUTE

        public const int FILE_ATTRIBUTE_READONLY = 0x00000001;
        public const int FILE_ATTRIBUTE_HIDDEN = 0x00000002;
        public const int FILE_ATTRIBUTE_SYSTEM = 0x00000004;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        public const int FILE_ATTRIBUTE_ARCHIVE = 0x00000020;
        public const int FILE_ATTRIBUTE_INROM = 0x00000040;
        public const int FILE_ATTRIBUTE_ENCRYPTED = 0x00000040;
        public const int FILE_ATTRIBUTE_NORMAL = 0x00000080;
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x00000100;
        public const int FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;
        public const int MODULE_ATTR_NOT_TRUSTED = 0x00000200;
        public const int FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;
        public const int MODULE_ATTR_NODEBUG = 0x00000400;
        public const int FILE_ATTRIBUTE_COMPRESSED = 0x00000800;
        public const int FILE_ATTRIBUTE_OFFLINE = 0x00001000;
        public const int FILE_ATTRIBUTE_ROMSTATICREF = 0x00001000;
        public const int FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;
        public const int FILE_ATTRIBUTE_ROMMODULE = 0x00002000;

        #endregion

        #region AW

        public const int AW_HOR_POSITIVE = 0x00000001;
        public const int AW_HOR_NEGATIVE = 0x00000002;
        public const int AW_VER_POSITIVE = 0x00000004;
        public const int AW_VER_NEGATIVE = 0x00000008;
        public const int AW_CENTER = 0x00000010;
        public const int AW_HIDE = 0x00010000;
        public const int AW_ACTIVATE = 0x00020000;
        public const int AW_SLIDE = 0x00040000;
        public const int AW_BLEND = 0x00080000;

        #endregion

        #region SPI

        public const int SPI_GETBEEP = 0x0001;
        public const int SPI_SETBEEP = 0x0002;
        public const int SPI_GETMOUSE = 0x0003;
        public const int SPI_SETMOUSE = 0x0004;
        public const int SPI_GETBORDER = 0x0005;
        public const int SPI_SETBORDER = 0x0006;
        public const int SPI_GETKEYBOARDSPEED = 0x000A;
        public const int SPI_SETKEYBOARDSPEED = 0x000B;
        public const int SPI_LANGDRIVER = 0x000C;
        public const int SPI_ICONHORIZONTALSPACING = 0x000D;
        public const int SPI_GETSCREENSAVETIMEOUT = 0x000E;
        public const int SPI_SETSCREENSAVETIMEOUT = 0x000F;
        public const int SPI_GETSCREENSAVEACTIVE = 0x0010;
        public const int SPI_SETSCREENSAVEACTIVE = 0x0011;
        public const int SPI_GETGRIDGRANULARITY = 0x0012;
        public const int SPI_SETGRIDGRANULARITY = 0x0013;
        public const int SPI_SETDESKWALLPAPER = 0x0014;
        public const int SPI_SETDESKPATTERN = 0x0015;
        public const int SPI_GETKEYBOARDDELAY = 0x0016;
        public const int SPI_SETKEYBOARDDELAY = 0x0017;
        public const int SPI_ICONVERTICALSPACING = 0x0018;
        public const int SPI_GETICONTITLEWRAP = 0x0019;
        public const int SPI_SETICONTITLEWRAP = 0x001A;
        public const int SPI_GETMENUDROPALIGNMENT = 0x001B;
        public const int SPI_SETMENUDROPALIGNMENT = 0x001C;
        public const int SPI_SETDOUBLECLKWIDTH = 0x001D;
        public const int SPI_SETDOUBLECLKHEIGHT = 0x001E;
        public const int SPI_GETICONTITLELOGFONT = 0x001F;
        public const int SPI_SETDOUBLECLICKTIME = 0x0020;
        public const int SPI_SETMOUSEBUTTONSWAP = 0x0021;
        public const int SPI_SETICONTITLELOGFONT = 0x0022;
        public const int SPI_GETFASTTASKSWITCH = 0x0023;
        public const int SPI_SETFASTTASKSWITCH = 0x0024;
        public const int SPI_SETDRAGFULLWINDOWS = 0x0025;
        public const int SPI_GETDRAGFULLWINDOWS = 0x0026;
        public const int SPI_GETNONCLIENTMETRICS = 0x0029;
        public const int SPI_SETNONCLIENTMETRICS = 0x002A;
        public const int SPI_GETMINIMIZEDMETRICS = 0x002B;
        public const int SPI_SETMINIMIZEDMETRICS = 0x002C;
        public const int SPI_GETICONMETRICS = 0x002D;
        public const int SPI_SETICONMETRICS = 0x002E;
        public const int SPI_SETWORKAREA = 0x002F;
        public const int SPI_GETWORKAREA = 0x0030;
        public const int SPI_SETPENWINDOWS = 0x0031;
        public const int SPI_GETHIGHCONTRAST = 0x0042;
        public const int SPI_SETHIGHCONTRAST = 0x0043;
        public const int SPI_GETKEYBOARDPREF = 0x0044;
        public const int SPI_SETKEYBOARDPREF = 0x0045;
        public const int SPI_GETSCREENREADER = 0x0046;
        public const int SPI_SETSCREENREADER = 0x0047;
        public const int SPI_GETANIMATION = 0x0048;
        public const int SPI_SETANIMATION = 0x0049;
        public const int SPI_GETFONTSMOOTHING = 0x004A;
        public const int SPI_SETFONTSMOOTHING = 0x004B;
        public const int SPI_SETDRAGWIDTH = 0x004C;
        public const int SPI_SETDRAGHEIGHT = 0x004D;
        public const int SPI_SETHANDHELD = 0x004E;
        public const int SPI_GETLOWPOWERTIMEOUT = 0x004F;
        public const int SPI_GETPOWEROFFTIMEOUT = 0x0050;
        public const int SPI_SETLOWPOWERTIMEOUT = 0x0051;
        public const int SPI_SETPOWEROFFTIMEOUT = 0x0052;
        public const int SPI_GETLOWPOWERACTIVE = 0x0053;
        public const int SPI_GETPOWEROFFACTIVE = 0x0054;
        public const int SPI_SETLOWPOWERACTIVE = 0x0055;
        public const int SPI_SETPOWEROFFACTIVE = 0x0056;
        public const int SPI_SETCURSORS = 0x0057;
        public const int SPI_SETICONS = 0x0058;
        public const int SPI_GETDEFAULTINPUTLANG = 0x0059;
        public const int SPI_SETDEFAULTINPUTLANG = 0x005A;
        public const int SPI_SETLANGTOGGLE = 0x005B;
        public const int SPI_GETWINDOWSEXTENSION = 0x005C;
        public const int SPI_SETMOUSETRAILS = 0x005D;
        public const int SPI_GETMOUSETRAILS = 0x005E;
        public const int SPI_SETSCREENSAVERRUNNING = 0x0061;
        public const int SPI_SCREENSAVERRUNNING = SPI_SETSCREENSAVERRUNNING;
        public const int SPI_GETFILTERKEYS = 0x0032;
        public const int SPI_SETFILTERKEYS = 0x0033;
        public const int SPI_GETTOGGLEKEYS = 0x0034;
        public const int SPI_SETTOGGLEKEYS = 0x0035;
        public const int SPI_GETMOUSEKEYS = 0x0036;
        public const int SPI_SETMOUSEKEYS = 0x0037;
        public const int SPI_GETSHOWSOUNDS = 0x0038;
        public const int SPI_SETSHOWSOUNDS = 0x0039;
        public const int SPI_GETSTICKYKEYS = 0x003A;
        public const int SPI_SETSTICKYKEYS = 0x003B;
        public const int SPI_GETACCESSTIMEOUT = 0x003C;
        public const int SPI_SETACCESSTIMEOUT = 0x003D;
        public const int SPI_GETSERIALKEYS = 0x003E;
        public const int SPI_SETSERIALKEYS = 0x003F;
        public const int SPI_GETSOUNDSENTRY = 0x0040;
        public const int SPI_SETSOUNDSENTRY = 0x0041;
        public const int SPI_GETSNAPTODEFBUTTON = 0x005F;
        public const int SPI_SETSNAPTODEFBUTTON = 0x0060;
        public const int SPI_GETMOUSEHOVERWIDTH = 0x0062;
        public const int SPI_SETMOUSEHOVERWIDTH = 0x0063;
        public const int SPI_GETMOUSEHOVERHEIGHT = 0x0064;
        public const int SPI_SETMOUSEHOVERHEIGHT = 0x0065;
        public const int SPI_GETMOUSEHOVERTIME = 0x0066;
        public const int SPI_SETMOUSEHOVERTIME = 0x0067;
        public const int SPI_GETWHEELSCROLLLINES = 0x0068;
        public const int SPI_SETWHEELSCROLLLINES = 0x0069;
        public const int SPI_GETMENUSHOWDELAY = 0x006A;
        public const int SPI_SETMENUSHOWDELAY = 0x006B;
        public const int SPI_GETSHOWIMEUI = 0x006E;
        public const int SPI_SETSHOWIMEUI = 0x006F;
        public const int SPI_GETMOUSESPEED = 0x0070;
        public const int SPI_SETMOUSESPEED = 0x0071;
        public const int SPI_GETSCREENSAVERRUNNING = 0x0072;
        public const int SPI_GETDESKWALLPAPER = 0x0073;
        public const int SPI_GETACTIVEWINDOWTRACKING = 0x1000;
        public const int SPI_SETACTIVEWINDOWTRACKING = 0x1001;
        public const int SPI_GETMENUANIMATION = 0x1002;
        public const int SPI_SETMENUANIMATION = 0x1003;
        public const int SPI_GETCOMBOBOXANIMATION = 0x1004;
        public const int SPI_SETCOMBOBOXANIMATION = 0x1005;
        public const int SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;
        public const int SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;
        public const int SPI_GETGRADIENTCAPTIONS = 0x1008;
        public const int SPI_SETGRADIENTCAPTIONS = 0x1009;
        public const int SPI_GETKEYBOARDCUES = 0x100A;
        public const int SPI_SETKEYBOARDCUES = 0x100B;
        public const int SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES;
        public const int SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES;
        public const int SPI_GETACTIVEWNDTRKZORDER = 0x100C;
        public const int SPI_SETACTIVEWNDTRKZORDER = 0x100D;
        public const int SPI_GETHOTTRACKING = 0x100E;
        public const int SPI_SETHOTTRACKING = 0x100F;
        public const int SPI_GETMENUFADE = 0x1012;
        public const int SPI_SETMENUFADE = 0x1013;
        public const int SPI_GETSELECTIONFADE = 0x1014;
        public const int SPI_SETSELECTIONFADE = 0x1015;
        public const int SPI_GETTOOLTIPANIMATION = 0x1016;
        public const int SPI_SETTOOLTIPANIMATION = 0x1017;
        public const int SPI_GETTOOLTIPFADE = 0x1018;
        public const int SPI_SETTOOLTIPFADE = 0x1019;
        public const int SPI_GETCURSORSHADOW = 0x101A;
        public const int SPI_SETCURSORSHADOW = 0x101B;
        public const int SPI_GETMOUSESONAR = 0x101C;
        public const int SPI_SETMOUSESONAR = 0x101D;
        public const int SPI_GETMOUSECLICKLOCK = 0x101E;
        public const int SPI_SETMOUSECLICKLOCK = 0x101F;
        public const int SPI_GETMOUSEVANISH = 0x1020;
        public const int SPI_SETMOUSEVANISH = 0x1021;
        public const int SPI_GETFLATMENU = 0x1022;
        public const int SPI_SETFLATMENU = 0x1023;
        public const int SPI_GETDROPSHADOW = 0x1024;
        public const int SPI_SETDROPSHADOW = 0x1025;
        public const int SPI_GETUIEFFECTS = 0x103E;
        public const int SPI_SETUIEFFECTS = 0x103F;
        public const int SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;
        public const int SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;
        public const int SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;
        public const int SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;
        public const int SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;
        public const int SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;
        public const int SPI_GETCARETWIDTH = 0x2006;
        public const int SPI_SETCARETWIDTH = 0x2007;
        public const int SPI_GETMOUSECLICKLOCKTIME = 0x2008;
        public const int SPI_SETMOUSECLICKLOCKTIME = 0x2009;
        public const int SPI_GETFONTSMOOTHINGTYPE = 0x200A;
        public const int SPI_SETFONTSMOOTHINGTYPE = 0x200B;
        public const int FE_FONTSMOOTHINGSTANDARD = 0x0001;
        public const int FE_FONTSMOOTHINGCLEARTYPE = 0x0002;
        public const int FE_FONTSMOOTHINGDOCKING = 0x8000;
        public const int SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;
        public const int SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;
        public const int SPI_GETFOCUSBORDERWIDTH = 0x200E;
        public const int SPI_SETFOCUSBORDERWIDTH = 0x200F;
        public const int SPI_GETFOCUSBORDERHEIGHT = 0x2010;
        public const int SPI_SETFOCUSBORDERHEIGHT = 0x2011;

        #endregion

        #region SPIF

        public const int SPIF_UPDATEINIFILE = 0x0001;
        public const int SPIF_SENDWININICHANGE = 0x0002;
        public const int SPIF_SENDCHANGE = SPIF_SENDWININICHANGE;

        #endregion

        #region MDITILE

        public const int MDITILE_VERTICAL = 0x0000;
        public const int MDITILE_HORIZONTAL = 0x0001;
        public const int MDITILE_SKIPDISABLED = 0x0002;
        public const int MDITILE_ZORDER = 0x0004;

        #endregion

        #region Thread

        public const int DEBUG_PROCESS = 0x00000001;
        public const int DEBUG_ONLY_THIS_PROCESS = 0x00000002;
        public const int CREATE_SUSPENDED = 0x00000004;
        public const int DETACHED_PROCESS = 0x00000008;
        public const int CREATE_NEW_CONSOLE = 0x00000010;
        public const int NORMAL_PRIORITY_CLASS = 0x00000020;
        public const int IDLE_PRIORITY_CLASS = 0x00000040;
        public const int HIGH_PRIORITY_CLASS = 0x00000080;
        public const int REALTIME_PRIORITY_CLASS = 0x00000100;
        public const int CREATE_NEW_PROCESS_GROUP = 0x00000200;
        public const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;
        public const int CREATE_SEPARATE_WOW_VDM = 0x00000800;
        public const int CREATE_SHARED_WOW_VDM = 0x00001000;
        public const int CREATE_FORCEDOS = 0x00002000;
        public const int BELOW_NORMAL_PRIORITY_CLASS = 0x00004000;
        public const int ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;
        public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 0x00010000;
        public const int CREATE_BREAKAWAY_FROM_JOB = 0x01000000;
        public const int CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000;
        public const int CREATE_DEFAULT_ERROR_MODE = 0x04000000;
        public const int CREATE_NO_WINDOW = 0x08000000;
        public const int PROFILE_USER = 0x10000000;
        public const int PROFILE_KERNEL = 0x20000000;
        public const int PROFILE_SERVER = 0x40000000;
        public const uint CREATE_IGNORE_SYSTEM_DEFAULT = 0x80000000;
        //public const int THREAD_PRIORITY_LOWEST = THREAD_BASE_PRIORITY_MIN;
        //public const int THREAD_PRIORITY_BELOW_NORMAL = THREAD_PRIORITY_LOWEST + 1;
        //public const int THREAD_PRIORITY_NORMAL = 0;
        //public const int THREAD_PRIORITY_HIGHEST = THREAD_BASE_PRIORITY_MAX;
        //public const int THREAD_PRIORITY_ABOVE_NORMAL = THREAD_PRIORITY_HIGHEST - 1;
        //public const int THREAD_PRIORITY_ERROR_RETURN = MAXLONG;
        //public const int THREAD_PRIORITY_TIME_CRITICAL = THREAD_BASE_PRIORITY_LOWRT;
        //public const int THREAD_PRIORITY_IDLE = THREAD_BASE_PRIORITY_IDLE;

        #endregion

        #region DCX

        public const int DCX_WINDOW = 0x00000001;
        public const int DCX_CACHE = 0x00000002;
        public const int DCX_NORESETATTRS = 0x00000004;
        public const int DCX_CLIPCHILDREN = 0x00000008;
        public const int DCX_CLIPSIBLINGS = 0x00000010;
        public const int DCX_PARENTCLIP = 0x00000020;
        public const int DCX_EXCLUDERGN = 0x00000040;
        public const int DCX_INTERSECTRGN = 0x00000080;
        public const int DCX_EXCLUDEUPDATE = 0x00000100;
        public const int DCX_INTERSECTUPDATE = 0x00000200;
        public const int DCX_LOCKWINDOWUPDATE = 0x00000400;
        public const int DCX_VALIDATE = 0x00200000;

        #endregion

        #region DM

        public const int DM_SPECVERSION = 0x0401;
        public const int DM_ORIENTATION = 0x00000001;
        public const int DM_PAPERSIZE = 0x00000002;
        public const int DM_PAPERLENGTH = 0x00000004;
        public const int DM_PAPERWIDTH = 0x00000008;
        public const int DM_SCALE = 0x00000010;
        public const int DM_POSITION = 0x00000020;
        public const int DM_NUP = 0x00000040;
        public const int DM_COPIES = 0x00000100;
        public const int DM_DEFAULTSOURCE = 0x00000200;
        public const int DM_PRINTQUALITY = 0x00000400;
        public const int DM_COLOR = 0x00000800;
        public const int DM_DUPLEX = 0x00001000;
        public const int DM_YRESOLUTION = 0x00002000;
        public const int DM_TTOPTION = 0x00004000;
        public const int DM_COLLATE = 0x00008000;
        public const int DM_FORMNAME = 0x00010000;
        public const int DM_LOGPIXELS = 0x00020000;
        public const int DM_BITSPERPEL = 0x00040000;
        public const int DM_PELSWIDTH = 0x00080000;
        public const int DM_PELSHEIGHT = 0x00100000;
        public const int DM_DISPLAYFLAGS = 0x00200000;
        public const int DM_DISPLAYFREQUENCY = 0x00400000;
        public const int DM_ICMMETHOD = 0x00800000;
        public const int DM_ICMINTENT = 0x01000000;
        public const int DM_MEDIATYPE = 0x02000000;
        public const int DM_DITHERTYPE = 0x04000000;
        public const int DM_PANNINGWIDTH = 0x08000000;
        public const int DM_PANNINGHEIGHT = 0x10000000;

        #endregion

        #region LOGON32

        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_LOGON_NETWORK = 3;
        public const int LOGON32_LOGON_BATCH = 4;
        public const int LOGON32_LOGON_SERVICE = 5;
        public const int LOGON32_LOGON_UNLOCK = 7;
        public const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;
        public const int LOGON32_LOGON_NEW_CREDENTIALS = 9;
        public const int LOGON32_PROVIDER_DEFAULT = 0;
        public const int LOGON32_PROVIDER_WINNT35 = 1;
        public const int LOGON32_PROVIDER_WINNT40 = 2;
        public const int LOGON32_PROVIDER_WINNT50 = 3;

        #endregion

        #region VER

        public const int VER_BUILDNUMBER = 0x0000004;
        public const int VER_MAJORVERSION = 0x0000002;
        public const int VER_MINORVERSION = 0x0000001;
        public const int VER_PLATFORMID = 0x0000008;
        public const int VER_SERVICEPACKMAJOR = 0x0000020;
        public const int VER_SERVICEPACKMINOR = 0x0000010;
        public const int VER_SUITENAME = 0x0000040;
        public const int VER_PRODUCT_TYPE = 0x0000080;
        public const int VER_EQUAL = 1;
        public const int VER_GREATER = 2;
        public const int VER_GREATER_EQUAL = 3;
        public const int VER_LESS = 4;
        public const int VER_LESS_EQUAL = 5;
        public const int VER_AND = 6;
        public const int VER_OR = 7;
        public const int VER_SUITE_BACKOFFICE = 0x00000004;
        public const int VER_SUITE_BLADE = 0x00000400;
        public const int VER_SUITE_COMPUTE_SERVER = 0x00004000;
        public const int VER_SUITE_DATACENTER = 0x00000080;
        public const int VER_SUITE_ENTERPRISE = 0x00000002;
        public const int VER_SUITE_EMBEDDEDNT = 0x00000040;
        public const int VER_SUITE_PERSONAL = 0x00000200;
        public const int VER_SUITE_SINGLEUSERTS = 0x00000100;
        public const int VER_SUITE_SMALLBUSINESS = 0x00000001;
        public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
        public const int VER_SUITE_STORAGE_SERVER = 0x00002000;
        public const int VER_SUITE_TERMINAL = 0x00000010;
        public const int VER_SUITE_WH_SERVER = 0x00008000;
        public const int VER_NT_DOMAIN_CONTROLLER = 0x0000002;
        public const int VER_NT_SERVER = 0x0000003;
        public const int VER_NT_WORKSTATION = 0x0000001;

        #endregion

        #region INTERNET

        public const int INTERNET_CONNECTION_MODEM = 0x01;
        public const int INTERNET_CONNECTION_LAN = 0x02;
        public const int INTERNET_CONNECTION_PROXY = 0x04;
        public const int INTERNET_CONNECTION_MODEM_BUSY = 0x08;  /* no longer used */
        public const int INTERNET_RAS_INSTALLED = 0x10;
        public const int INTERNET_CONNECTION_OFFLINE = 0x20;
        public const int INTERNET_CONNECTION_CONFIGURED = 0x40;

        #endregion

        #region NETWORK

        public const int NETWORK_ALIVE_LAN = 0x00000001;
        public const int NETWORK_ALIVE_WAN = 0x00000002;
        public const int NETWORK_ALIVE_AOL = 0x00000004;

        #endregion

        #region TIME

        public const int TIME_NOMINUTESORSECONDS = 0x00000001;  // do not use minutes or seconds
        public const int TIME_NOSECONDS = 0x00000002;  // do not use seconds
        public const int TIME_NOTIMEMARKER = 0x00000004;  // do not use time marker
        public const int TIME_FORCE24HOURFORMAT = 0x00000008;  // always use 24 hour format

        #endregion

        #region DATE

        public const int DATE_SHORTDATE = 0x00000001;  // use short date picture
        public const int DATE_LONGDATE = 0x00000002;  // use long date picture
        public const int DATE_USE_ALT_CALENDAR = 0x00000004;  // use alternate calendar (if any)
        public const int DATE_YEARMONTH = 0x00000008;  // use year month picture
        public const int DATE_LTRREADING = 0x00000010;  // add marks for left to right reading order layout
        public const int DATE_RTLREADING = 0x00000020;  // add marks for right to left reading order layout

        #endregion

        #region DRIVE

        public const int DRIVE_UNKNOWN = 0;
        public const int DRIVE_NO_ROOT_DIR = 1;
        public const int DRIVE_REMOVABLE = 2;
        public const int DRIVE_FIXED = 3;
        public const int DRIVE_REMOTE = 4;
        public const int DRIVE_CDROM = 5;
        public const int DRIVE_RAMDISK = 6;

        #endregion

        #region Background Modes

        public const int TRANSPARENT = 1;
        public const int OPAQUE = 2;
        public const int BKMODE_LAST = 2;

        #endregion

        #region BitBlt

        public const int BLACKONWHITE = 1;
        public const int WHITEONBLACK = 2;
        public const int COLORONCOLOR = 3;
        public const int HALFTONE = 4;
        public const int MAXSTRETCHBLTMODE = 4;

        #endregion

        #region SCS

        public const int SCS_32BIT_BINARY = 0;
        public const int SCS_DOS_BINARY = 1;
        public const int SCS_WOW_BINARY = 2;
        public const int SCS_PIF_BINARY = 3;
        public const int SCS_POSIX_BINARY = 4;
        public const int SCS_OS216_BINARY = 5;
        public const int SCS_64BIT_BINARY = 6;

        #endregion

        #region PT

        public const int PT_CLOSEFIGURE = 0x01;
        public const int PT_LINETO = 0x02;
        public const int PT_BEZIERTO = 0x04;
        public const int PT_MOVETO = 0x06;

        #endregion

        #region RDW

        public const int RDW_INVALIDATE = 0x0001;
        public const int RDW_INTERNALPAINT = 0x0002;
        public const int RDW_ERASE = 0x0004;
        public const int RDW_VALIDATE = 0x0008;
        public const int RDW_NOINTERNALPAINT = 0x0010;
        public const int RDW_NOERASE = 0x0020;
        public const int RDW_NOCHILDREN = 0x0040;
        public const int RDW_ALLCHILDREN = 0x0080;
        public const int RDW_UPDATENOW = 0x0100;
        public const int RDW_ERASENOW = 0x0200;
        public const int RDW_FRAME = 0x0400;
        public const int RDW_NOFRAME = 0x0800;

        #endregion

        #region KEYEVENTF

        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;
        public const int KEYEVENTF_UNICODE = 0x0004;
        public const int KEYEVENTF_SCANCODE = 0x0008;

        #endregion

        #region PW

        public const int PW_CLIENTONLY = 0x00000001;

        #endregion

        #region SHFMT

        public const int SHFMT_OPT_FULL = 0x0001;
        public const int SHFMT_OPT_SYSONLY = 0x0002;
        public const int SHFMT_ID_DEFAULT = 0xFFFF;
        //0 快速
        //1 完全
        //2 只复制系统文件 
        //3 只复制系统文件 
        //4 快速
        //5 完全
        //6 只复制系统文件 
        //7 只复制系统文件 
        //8 快速
        //9 完全

        #endregion

        #region INPUT

        public const int INPUT_MOUSE = 0;
        public const int INPUT_KEYBOARD = 1;
        public const int INPUT_HARDWARE = 2;

        #endregion

        #region MOUSEEVENTF

        public const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        public const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        public const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        public const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        public const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        public const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */

        #endregion

        #region IMAGE

        public const int IMAGE_BITMAP = 0;
        public const int IMAGE_ICON = 1;
        public const int IMAGE_CURSOR = 2;
        public const int IMAGE_ENHMETAFILE = 3;

        #endregion

        #region LR

        public const int LR_DEFAULTCOLOR = 0x0000;
        public const int LR_MONOCHROME = 0x0001;
        public const int LR_COLOR = 0x0002;
        public const int LR_COPYRETURNORG = 0x0004;
        public const int LR_COPYDELETEORG = 0x0008;
        public const int LR_LOADFROMFILE = 0x0010;
        public const int LR_LOADTRANSPARENT = 0x0020;
        public const int LR_DEFAULTSIZE = 0x0040;
        public const int LR_VGACOLOR = 0x0080;
        public const int LR_LOADMAP3DCOLORS = 0x1000;
        public const int LR_CREATEDIBSECTION = 0x2000;
        public const int LR_COPYFROMRESOURCE = 0x4000;
        public const int LR_SHARED = 0x8000;

        #endregion

        #region SHERB

        public const int SHERB_NOCONFIRMATION = 0x00000001;
        public const int SHERB_NOPROGRESSUI = 0x00000002;
        public const int SHERB_NOSOUND = 0x00000004;

        #endregion

        #region DT

        public const int DT_TOP = 0x00000000;
        public const int DT_LEFT = 0x00000000;
        public const int DT_CENTER = 0x00000001;
        public const int DT_RIGHT = 0x00000002;
        public const int DT_VCENTER = 0x00000004;
        public const int DT_BOTTOM = 0x00000008;
        public const int DT_WORDBREAK = 0x00000010;
        public const int DT_SINGLELINE = 0x00000020;
        public const int DT_EXPANDTABS = 0x00000040;
        public const int DT_TABSTOP = 0x00000080;
        public const int DT_NOCLIP = 0x00000100;
        public const int DT_EXTERNALLEADING = 0x00000200;
        public const int DT_CALCRECT = 0x00000400;
        public const int DT_NOPREFIX = 0x00000800;
        public const int DT_INTERNAL = 0x00001000;
        public const int DT_EDITCONTROL = 0x00002000;
        public const int DT_PATH_ELLIPSIS = 0x00004000;
        public const int DT_END_ELLIPSIS = 0x00008000;
        public const int DT_MODIFYSTRING = 0x00010000;
        public const int DT_RTLREADING = 0x00020000;
        public const int DT_WORD_ELLIPSIS = 0x00040000;
        public const int DT_NOFULLWIDTHCHARBREAK = 0x00080000;
        public const int DT_HIDEPREFIX = 0x00100000;
        public const int DT_PREFIXONLY = 0x00200000;

        #endregion

        #region GCL

        public const int GCL_MENUNAME = -8;
        public const int GCL_HBRBACKGROUND = -10;
        public const int GCL_HCURSOR = -12;
        public const int GCL_HICON = -14;
        public const int GCL_HMODULE = -16;
        public const int GCL_CBWNDEXTRA = -18;
        public const int GCL_CBCLSEXTRA = -20;
        public const int GCL_WNDPROC = -24;
        public const int GCL_STYLE = -26;
        public const int GCW_ATOM = -32;
        public const int GCL_HICONSM = -34;
        public const int ICON_SMALL = 0;
        public const int ICON_BIG = 1;
        public const int SMTO_ABORTIFHUNG = 0x2;

        #endregion

        #region TreeView

        public const int TVGN_CARET = 0x00000009;
        public const int TVM_SELECTITEM = 0x0000110b;
        public const int TVGN_ROOT = 0x00000000;
        public const int TVM_GETNEXTITEM = 0x0000110a;
        public const int TVIF_TEXT = 0x0001;
        public const int TVGN_NEXT = 0x00000001;
        public const int TVM_GETITEM = 0x0000110c;
        public const int TVGN_CHILD = 0x00000004;
        public const int GMEM_FIXED = 0x0000;
        public const int TVM_EXPAND = 4354;
        public const int TVE_EXPAND = 2;

        #endregion

        #region DateTimePicker
        public const int GDT_VALID = 0x00000000;
        public const int GDT_NONE = 0x00000001;
        public const int DTM_FIRST = 0x1000;
        public const int DTM_GETSYSTEMTIME = (DTM_FIRST + 1);
        public const int DTM_SETSYSTEMTIME = (DTM_FIRST + 2);
        public const int DTM_GETRANGE = (DTM_FIRST + 3);
        public const int DTM_SETRANGE = (DTM_FIRST + 4);
        public const int DTM_SETFORMAT = (DTM_FIRST + 5);
        public const int DTM_SETMCCOLOR = (DTM_FIRST + 6);
        public const int DTM_GETMCCOLOR = (DTM_FIRST + 7);
        public const int DTM_SETMCFONT = (DTM_FIRST + 9);
        public const int DTM_GETMCFONT = (DTM_FIRST + 10); 
        #endregion

        public const int MEM_COMMIT = 0x1000;
        public const int MEM_RESERVE = 0x2000;
        public const int MEM_DECOMMIT = 0x4000;
        public const int MEM_RELEASE = 0x8000;
        public const int MEM_FREE = 0x10000;
        public const int MEM_PRIVATE = 0x20000;
        public const int MEM_MAPPED = 0x40000;
        public const int MEM_RESET = 0x80000;
        public const int MEM_TOP_DOWN = 0x100000;

        public const int PAGE_NOACCESS = 0x01;
        public const int PAGE_READONLY = 0x02;
        public const int PAGE_READWRITE = 0x04;
        public const int PAGE_WRITECOPY = 0x08;
        public const int PAGE_EXECUTE = 0x10;
        public const int PAGE_EXECUTE_READ = 0x20;
        public const int PAGE_EXECUTE_READWRITE = 0x40;
        public const int PAGE_EXECUTE_WRITECOPY = 0x80;
        public const int PAGE_GUARD = 0x100;
        public const int PAGE_NOCACHE = 0x200;
        public const int PAGE_WRITECOMBINE = 0x400;
    }
}
