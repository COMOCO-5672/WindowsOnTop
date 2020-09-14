using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Threading;
using Lierda.WPFHelper;

namespace WindowOnTop
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private Mutex mutex;

        LierdaCracker cracker=new LierdaCracker();

        public App()
        {
            this.Startup += App_Startup;
            this.Exit += App_Exit;
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            cracker.Cracker(10);
            base.OnStartup(e);
            DispatcherHelper.Initialize();
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
            //ShutdownMode = ShutdownMode.OnExplicitShutdown;
            StartupUri=new Uri("MainWindow.xaml",UriKind.RelativeOrAbsolute);
        }

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
