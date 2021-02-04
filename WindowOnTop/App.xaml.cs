using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using GalaSoft.MvvmLight.Threading;
using Lierda.WPFHelper;
using WindowOnTop.Util;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;

namespace WindowOnTop
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private Mutex mutex;

        LierdaCracker cracker=new LierdaCracker();

        private System.Windows.Forms.NotifyIcon notifiy = null;
        public App()
        {
            this.Startup += App_Startup;
            this.Exit += App_Exit;
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            notifiy.Dispose();

            TaskBarUtil.RefreshNotificationArea();
        }

        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            cracker.Cracker(10); // 黑科技，资源回收
            base.OnStartup(e);
            DispatcherHelper.Initialize();
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
            //ShutdownMode = ShutdownMode.OnExplicitShutdown;

            notifiy = new System.Windows.Forms.NotifyIcon();

            notifiy.BalloonTipText = "程序正在运行";

            notifiy.Icon = new Icon( Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Icon.ico"));

            notifiy.Text = "托盘图标";

            notifiy.Visible = true;

            notifiy.ShowBalloonTip(1000);

            notifiy.MouseClick += Notifiy_MouseClick;

            var menu1 = new MenuItem("菜单项1");

            MenuItem menu2 = new MenuItem("菜单项2");

            MenuItem menu = new MenuItem("菜单", new MenuItem[] { menu1 , menu2 });

            MenuItem exit = new MenuItem("exit");

            exit.Click += Exit_Click;

            System.Windows.Forms.MenuItem[] childen = new System.Windows.Forms.MenuItem[] { menu, exit };

            notifiy.ContextMenu = new System.Windows.Forms.ContextMenu(childen);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show("确定要关闭吗?", "退出", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                notifiy.Dispose();

                TaskBarUtil.RefreshNotificationArea();

                System.Windows.Application.Current.Shutdown();
            }
        }

        private void Notifiy_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                MessageBox.Show("我被点击了");
            }
        }

        /// <summary>
        /// 全局异常退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {

            e.Handled = true;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            bool ret;

            mutex =new Mutex(true,"Window on Top",out ret);

            if (!ret)
            {
                Environment.Exit(0);
            }
        }


    }
}
