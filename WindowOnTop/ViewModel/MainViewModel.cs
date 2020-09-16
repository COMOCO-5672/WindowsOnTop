using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WindowOnTop.Util;
using WindowOnTop.Windows;
using Point = System.Windows.Point;

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
            k_hook.KeyPressEvent += K_hook_KeyPressEvent;
            k_hook.KeyDownEvent += K_hook_KeyDownEvent;
            k_hook.Start();
        }

        private void K_hook_KeyDownEvent(object sender, KeyEventArgs e)
        {
            Windows.Point p = new Windows.Point();  // Û±ÍŒª÷√

            if (e.KeyValue==(int)Keys.E && (int)Control.ModifierKeys==((int)Keys.Alt+(int)Keys.Control))
            {
                if (WindowsAPI.GetCursorPos(ref p))
                {
                    IntPtr ptr = WindowsAPI.WindowFromPoint(p);

                    WindowsAPI.SetWindowPos(ptr, new IntPtr(-1), 0, 0, 0, 0, 1 | 2);
                }
            }

            if (e.KeyValue == (int)Keys.R && (int)Control.ModifierKeys == ((int)Keys.Alt + (int)Keys.Control))
            {
                if (WindowsAPI.GetCursorPos(ref p))
                {
                    IntPtr ptr =WindowsAPI.WindowFromPoint(p);

                    WindowsAPI.SetWindowPos(ptr, new IntPtr(1), 0, 0, 0, 0, 1 | 2);
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

    }
}