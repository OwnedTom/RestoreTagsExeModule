using DarkPluginLib;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace RestoreTagsExeModule
{

    public class RestoreTagsExe : DarkPlugin
    {
        #region DarkPlugin Members

        public string Title
        {
            get
            {
                return "Restore Tags and Exe";
            }
        }
        public string Description
        {
            get
            {
                return "Replaces your current tags.dat or eldorado.exe with a clean version";
            }
        }
        public string Author
        {
            get
            {
                return "OwnedTom1";
            }
        }
        public string Url
        {
            get
            {
                return "Test";
            }
        }
        public string Version
        {
            get
            {
                //return Assembly.GetExecutingAssembly().GetName().Version.ToString();
                return "gibberish";
            }
        }
        public string Built
        {
            get
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("Plugins/" + Assembly.GetExecutingAssembly().GetName().Name + ".dll");
                return fi.LastWriteTime.ToString();
            }
        }
        public Form MainForm
        {
            get
            {
                return restoreTagsExeForm;
            }
        }

        public RestoreTagsExeModule.Form1 restoreTagsExeForm;
        public static bool runningForm = false;
        public void DarkPluginMain()
        {
            if (!runningForm)
            {
                restoreTagsExeForm = new RestoreTagsExeModule.Form1();
                restoreTagsExeForm.Show();
                runningForm = true;
            }
            else
            {
                DarkLog.WriteLine("Plugin already running!");

                restoreTagsExeForm.Show();
            }
        }

        #endregion
    }

}