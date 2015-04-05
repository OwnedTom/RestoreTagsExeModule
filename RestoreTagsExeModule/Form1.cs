using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkPluginLib;

namespace RestoreTagsExeModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String curDir;
        public String freshFileDir;
        public String freshTagsPath;
        public String freshExePath;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            curDir = Directory.GetCurrentDirectory();
            freshFileDir = curDir + "/Fresh Files/";
            if(!Directory.Exists(freshFileDir))
            {
                Directory.CreateDirectory(freshFileDir);
            }
            freshTagsPath = freshFileDir + "tags.dat";
            freshExePath = freshFileDir + "eldorado.exe";
            if(!(File.Exists(freshExePath) || File.Exists(freshTagsPath)))
            {
                Byte[] zipBytes = Properties.Resources.fresh;
                using (Stream zipToOpen = new MemoryStream(zipBytes))
                {
                    using (ZipArchive freshZip = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry tagsEntry = freshZip.GetEntry("tags.dat");
                        ZipArchiveEntry exeEntry = freshZip.GetEntry("eldorado.exe");
                        if(!File.Exists(freshExePath))
                        {
                            exeEntry.ExtractToFile(freshExePath);
                        }
                        if(!File.Exists(freshTagsPath))
                        {
                            tagsEntry.ExtractToFile(freshTagsPath);
                        }
                    }
                }
                
            }
        }

        private void btnRestoreTags_Click(object sender, EventArgs e)
        {
            using(FileStream srcTagsStream = new FileStream(freshTagsPath,FileMode.Open))
            {
                using(FileStream destTagsStream = new FileStream(DarkSettings.HaloOnlineFolder + "/maps/tags.dat", FileMode.Open))
                {
                    try
                    {
                        srcTagsStream.CopyTo(destTagsStream);
                        MessageBox.Show("Tags.dat has been restored back to default.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void btnRestoreExe_Click(object sender, EventArgs e)
        {
            using (FileStream srcExeStream = new FileStream(freshExePath, FileMode.Open))
            {
                using (FileStream destExeStream = new FileStream(DarkSettings.HaloOnlineFolder + "eldorado.exe", FileMode.Open))
                {
                    try
                    {
                        srcExeStream.CopyTo(destExeStream);
                        MessageBox.Show("Eldorado.exe has been restored back to default");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            RestoreTagsExe.runningForm = false;
            e.Cancel = true;
        }


    }
}
