using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WindowOnTop.Util;

namespace WindowOnTop.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Init();
            LoadCommand=new RelayCommand(() => Load());
        }

        public RelayCommand LoadCommand { get; set; }

        private KeyboardHook k_hook;
        private void Init()
        {
            k_hook=new KeyboardHook();
            //k_hook.KeyPressEvent += K_hook_KeyPressEvent;
            k_hook.KeyDownEvent += K_hook_KeyDownEvent;
            k_hook.Start();
        }

        private void K_hook_KeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue==(int)Keys.E && Control.ModifierKeys==Keys.Control )
            {
                if (GetCursorPos(out Point p))
                {
                    IntPtr ptr = WindowFromPoint(p);
                    SetWindowPos(ptr, -1, 0, 0, 0, 0, 1 | 2);
                }
            }

            if (e.KeyValue==(int)Keys.R && Control.ModifierKeys==Keys.Shift)
            {
                if (GetCursorPos(out Point p))
                {
                    IntPtr ptr = WindowFromPoint(p);
                    SetWindowPos(ptr, 1, 0, 0, 0, 0, 1 | 2);
                }
            }
        }

        private void K_hook_KeyPressEvent(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            int i = (int) e.KeyChar;

        }

        private void Load()
        {

        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr WindowFromPoint(Point Point);

        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);

    }
}