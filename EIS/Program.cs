using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace EIS
{
    static class Program
    {
        private const int SW_SHOWNOACTIVATE = 4;

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr handle);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int cmdShow);

        static EIS.Forms.FormMain formMain;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*AppDomain.CurrentDomain.UnhandledException +=
            new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException +=
                    new ThreadExceptionEventHandler(Application_ThreadException);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #if !DEBUG
            Process currentProcess = Process.GetCurrentProcess();

            Process[] processes = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process process in processes)
            {
                if (process.Id == currentProcess.Id)
                {
                    continue;
                }
                else
                {
                    if (process.SessionId == currentProcess.SessionId)
                    {
                        SetForegroundWindow(process.MainWindowHandle);
                        ShowWindow(process.MainWindowHandle, SW_SHOWNOACTIVATE);
                        return;
                    }
                }
            }   
            #endif
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            formMain = new Forms.FormMain();
            Application.Run(formMain);
        }
        // Выход из приложения.
        static void Application_ApplicationExit(object sender, EventArgs e)
        {
#if !DEBUG
            if (formMain != null)
            {
                string path;
                if (string.IsNullOrEmpty(formMain.pathUpdate))
                {
                    if (formMain.backgroundWorkerUpdater.IsBusy)
                    {
                        //MessageBox.Show("busy");
                        while (formMain.backgroundWorkerUpdater.IsBusy)
                        {
                        }
                    }
                    if (string.IsNullOrEmpty(formMain.pathUpdate))
                    {
                        if (formMain.eisSettings.UpdateSettings.DownloadPath.IndexOf("ftp") == 0)  // начинается с ФТП
                        {
                            //MessageBox.Show("frpbeg");
                            EIS.ChekerDownloaderFromFTP checkFTP = new ChekerDownloaderFromFTP(formMain.eisSettings.UpdateSettings.DownloadPath);
                            checkFTP.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                            checkFTP.FTPUser = "ftpuser";
                            checkFTP.FTPPassword = "qazwsxedc";
                            //MessageBox.Show("frpbeg2");
                            path = checkFTP.PrepareUpdates();
                            //MessageBox.Show("frpend");
                        }
                        else
                        {
                            EIS.ChekerDownloaderFromFolder check = new ChekerDownloaderFromFolder(formMain.eisSettings.UpdateSettings.DownloadPath);
                            check.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                            path = check.PrepareUpdates();
                        }
                    }
                    else
                        path = formMain.pathUpdate;
                }
                else
                    path = formMain.pathUpdate;

                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        //MessageBox.Show(path);
                        Process.Start("EISUpdate.exe", path);
                        //MessageBox.Show("end");
                    }
                    catch { }
                }
            }
#endif
        }

        #region Глобальная ловля исключений
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            try
            {
                MessageBox.Show(args.ExceptionObject.ToString());
                WriteEventLog(args.ExceptionObject.ToString());
                //MessageBox.Show();
                //    ... // Тут показываем исключение/пишем в лог
            }
            catch (Exception ex)
            {
                try
                {
                    MessageBox.Show(ex.ToString());
                    WriteEventLog(ex.ToString());
                    //      AlertWarning(null, "Fatal error: " + ex.ToString());
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs args)
        {
            try
            {
                MessageBox.Show(args.Exception.ToString());
                WriteEventLog(args.Exception.ToString());
                ///... // Тут показываем исключение/пишем в лог
            }
            catch (Exception ex)
            {
                try
                {
                    MessageBox.Show(ex.ToString());
                    WriteEventLog(ex.ToString());
                    //                        AlertWarning(null, "Fatal error: " + ex.ToString());
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        static void WriteEventLog(string message)
        {
            // Create the source, if it does not already exist.
            if (!EventLog.SourceExists("EIS"))
            {
                //An event log source should not be created and immediately used.
                //There is a latency time to enable the source, it should be created
                //prior to executing the application that uses the source.
                //Execute this sample a second time to use the new source.
                EventLog.CreateEventSource("EIS", "EISLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Exiting, execute the application a second time to use the source.");
                // The source is created.  Exit the application to allow it to be registered.
                return;
            }

            // Create an EventLog instance and assign its source.
            EventLog myLog = new EventLog();
            myLog.Source = "EIS";

            // Write an informational entry to the event log.    
            myLog.WriteEntry(message);
        }
        #endregion
    }

}
