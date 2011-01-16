﻿using System;
using System.ComponentModel;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneGap
{
    public partial class MainPage : PhoneApplicationPage
    {
        private NativeExecution native;

        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.native = new NativeExecution(ref webBrowser1);

            // Load all content files into IsolatedStorage in a separate thread to avoid issues with it taking longer that the system will allow for startup
            var isoLoader = new BackgroundWorker
                                {
                                    WorkerReportsProgress = false,
                                    WorkerSupportsCancellation = false
                                };
            isoLoader.DoWork += isoLoader_DoWork;
            isoLoader.RunWorkerCompleted += this.isoLoader_RunWorkerCompleted;
            isoLoader.RunWorkerAsync();
        }


        private void isoLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("www/index.html", UriKind.Relative));
        }

        private static void isoLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            SaveFilesInWwwFolderToIsoStore();
        }

        private static void SaveFilesInWwwFolderToIsoStore()
        {
#if DEBUG
            // This deletes all existing files in IsolatedStorage - Useful in testing
            // In live should not do this, but only load files once - this speeds subsequent loading of the app
            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                isoStore.Remove();
            }
#endif
            string[] files = AllFilesInWwwFolder();

            using (var isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!isoStore.FileExists(files[0]))
                {
                    foreach (string f in files)
                    {
                        var sr = Application.GetResourceStream(new Uri(f, UriKind.Relative));

                        // T4 Template includes all files in source folder(s). This may include some which are not in the project
                        if (sr != null)
                        {
                            using (var br = new BinaryReader(sr.Stream))
                            {
                                byte[] data = br.ReadBytes((int)sr.Stream.Length);
                                SaveFileToIsoStore(f, data);
                            }
                        }
                    }
                }
            }
        }

        private static void SaveFileToIsoStore(string fileName, byte[] data)
        {
            string strBaseDir = string.Empty;
            const string DelimStr = "/";
            char[] delimiter = DelimStr.ToCharArray();
            string[] dirsPath = fileName.Split(delimiter);

            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                // Recreate the directory structure
                for (int i = 0; i < dirsPath.Length - 1; i++)
                {
                    strBaseDir = Path.Combine(strBaseDir, dirsPath[i]);
                    isoStore.CreateDirectory(strBaseDir);
                }

                if (!isoStore.FileExists(fileName))
                {
                    using (var bw = new BinaryWriter(isoStore.CreateFile(fileName)))
                    {
                        bw.Write(data);
                    }
                }
            }
        }

        private void webBrowser1_ScriptNotify(object sender, NotifyEventArgs e)
        {
            this.native.ProcessJavascriptCommand(e.Value);
        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            this.native.OrientationChanged(e.Orientation.ToString());

            base.OnOrientationChanged(e);
        }
    }
}