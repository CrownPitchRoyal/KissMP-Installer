using Microsoft.Win32;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KissMP_Updater
{
    public partial class FMain : Form
    {
        public string UserFolderPath = "";
        public bool UserFolderValid = false;

        public string BridgeInstallDir = "";

        public int stage = 0;

        public bool callType = false;

        public string GameExePath = "";

        public bool done = false;

        public FMain()
        {
            InitializeComponent();

            //CHECK IF ALREADY installed and offer uninstall/repair/Update
            //Check if folder exists in Roaming and if it has any contents
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BridgeKissMP"))
            {
                //EXISTS load options
            }

            //string asd = Environment.GetFolderPath(Environment.SpecialFolder.

            //Check if user has internet connection
            if (!HasConnection())
            {
                MessageBox.Show("Internet connection is required to complete the instalation!\nPlease check your connectivity and try again.");
                this.Close();

                //MAKE AN OFFLINE INSTALLER
                //Either let user provide his zip or contain the zip within the program?
            }

            //Clear names so user doesn't see them
            gbStage1.Text = "";
            gbStage2.Text = "";
            gbStage3.Text = "";
            gbStage0.Text = "";

            //If stage 0 we display stage1
            if (stage == 0)
            {
                btnBack.Enabled = false;
                gbStage1.Visible = true;
                gbStage1.Dock = DockStyle.Fill;

                //Suggest install in AppData Roaming folder
                //Bridge
                l1PathBR.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BridgeKissMP";
                //Mod
                //l1PathUF.Text = @"D:\SteamLibrary\steamapps\common\BeamUserFolder\0.23";
                //l1PathUF.Text = @"...\BeamUserFolder\0.23";
                //Get reg



                try
                {
                    RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"Software\BeamNG\BeamNG.drive", false);
                    if (myKey != null) //if key has no value don't check for it
                    {
                        String value = (String)myKey.GetValue("userpath_override");
                        if (!String.IsNullOrEmpty(value))//IF entry exists the path was modified and is different from appdata/local
                        {
                            l1PathUF.Text = value;
                        }
                    }
                    else //Else path unmodified and is in appdata/local
                    {
                        l1PathUF.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\BeamNG.drive\";
                    }
                }
                catch (Exception err) { EH(err); }
            }
        }

        //Button to select BeamNG.drive UserData folder
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        UserFolderPath = fbd.SelectedPath;
                        BridgeInstallDir = UserFolderPath + "\\BridgeKissMP";
                        l1PathUF.Text = UserFolderPath;
                        l1PathBR.Text = BridgeInstallDir;
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }

        //Button to select Bridge Install dir
        private void btn1SelectBridgeInstallDir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        BridgeInstallDir = fbd.SelectedPath + "\\BridgeKissMP";
                        l1PathBR.Text = BridgeInstallDir;
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }



        /// <summary>
        /// Error handler, open Msg box and displays error.
        /// Accepts err as Exception
        /// </summary>
        /// <param name="err">Type: Exception</param>
        public void EH(Exception err)
        {
            try
            {
                MessageBox.Show(err.ToString());
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (stage == 2)
                {
                    gbStage2.Visible = false;
                    gbStage3.Visible = true;
                    gbStage3.Dock = DockStyle.Fill;

                    btnCancel.Enabled = false;
                    btnContinue.Text = "Exit";
                    btnContinue.Enabled = true;

                    if (done == false)
                    {
                        Application.Exit();
                    }
                    done = false;
                }
                if (stage == 0)
                {
                    if (Directory.Exists(UserFolderPath + "\\mods"))
                    {//DIR EXISTS
                        UserFolderValid = true;
                        stage = 1;
                        callType = true;
                        btnContinue_Click(sender, e);
                    }
                    else//DIr doesn't exist
                    {
                        MessageBox.Show("Mods folder doesn't exist!\nMake sure you selected the right directory!\nYou selected:\n\n" + UserFolderPath);
                        UserFolderValid = false;
                    }
                }
                else if (stage == 1)
                {
                    //if (callType)
                    //{
                    //    callType = false;
                    //    return;
                    //}

                    if (((Control)sender).Name == "btnBack")
                    {
                        gbStage1.Visible = true;
                        gbStage2.Visible = false;
                        btnBack.Enabled = false;
                        btnContinue.Text = "Next -->";
                        stage = 0;
                    }
                    else if (((Control)sender).Name == "btnContinue")
                    {
                        //Hide prev stage
                        gbStage1.Visible = false;

                        //DISPLAY NEXT stage elements
                        gbStage2.Visible = true;
                        gbStage2.Dock = DockStyle.Fill;
                        btnBack.Enabled = true;
                        btnContinue.Text = "Install";

                        //INSTALATION
                        btnBack.Enabled = false;
                        btnContinue.Enabled = false;
                        Install();//Downloads and extracts

                        btnContinue.Enabled = true;
                        btnContinue.Text = "Finish";

                        done = true;
                        stage = 2;
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }


        /// <summary>
        /// Close app if "YES"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to cancel installation of KissMP?", "Caution!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception err) { EH(err); }
        }


        /// <summary>
        /// Will download latest zip from github and extract it to l1PathBR.Text
        /// </summary>
        private void Install()
        {
            try
            {
                rtb2ProgressText.Text += "\nChecking for existing files...";
                pb2ProgressBar.Value = 0;

                string tempDir = "";

                if (l1PathBR.Text.Length > 0)
                {
                    tempDir = l1PathBR.Text;
                }
                else tempDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BridgeKissMP";


                //Check if folder exists in AppData\Roaming if not make a new one
                if (!Directory.Exists(tempDir))
                {
                    rtb2ProgressText.Text += "\nCreating directory: " + tempDir + "...";
                    Directory.CreateDirectory(tempDir);
                    pb2ProgressBar.Value = 2;
                }
                else //Make sure we have a clear dir if any other files were updated, recreate dir
                {
                    rtb2ProgressText.Text += "\nFound directory: " + tempDir + "...";

                    rtb2ProgressText.Text += "\nDeleting directory: " + tempDir + "...";
                    Directory.Delete(tempDir, true);

                    rtb2ProgressText.Text += "\nRecreating directory: " + tempDir + "...";
                    Directory.CreateDirectory(tempDir);
                    pb2ProgressBar.Value = 2;
                }


                rtb2ProgressText.Text += "\nSending http request to github: https://api.github.com/repos/TheHellBox/KISS-multiplayer/releases/latest...";
                pb2ProgressBar.Value = 4;
                //GET LINK OF LATEST TheHellBox release
                var client = new RestClient("https://api.github.com/");
                var request = new RestRequest("repos/TheHellBox/KISS-multiplayer/releases/latest");

                request.AddHeader("Accept", "application / json");
                request.AddHeader("User-Agent", "PostmanRuntime/7.28.0");
                request.AddHeader("Host", "api.github.com");

                var responseGet = client.Get(request);
                if (responseGet.StatusCode == HttpStatusCode.OK)
                {
                    rtb2ProgressText.Text += "\nResponse: OK";
                    pb2ProgressBar.Value = 6;
                }
                else
                {
                    rtb2ProgressText.Text += "\nResponse: " + responseGet.StatusCode.ToString();
                    gbStage2.Visible = false;
                    gbStage1.Visible = true;
                    return;
                }

                string iscem = "browser_download_url";
                string iscem2 = ".zip";
                var json = ((RestSharp.RestResponseBase)responseGet).Content;

                string link = json.Substring(json.IndexOf(iscem) + iscem.Length + 3);
                string link2 = link.Substring(0, link.IndexOf(iscem2) + iscem2.Length);

                rtb2ProgressText.Text += "\nDownloading latest release...";
                //DOWNLOAD
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                webClient.DownloadFile(new Uri(link2), tempDir + "\\kissmp.zip");
                rtb2ProgressText.Text += "\nkissmp.zip downloaded successfuly.";
                pb2ProgressBar.Value = 14;


                //EXTRACT
                if (Directory.Exists(tempDir))
                {
                    rtb2ProgressText.Text += "\nExtracting kissmp.zip to " + tempDir;
                    pb2ProgressBar.Value = 16;
                    ZipFile.ExtractToDirectory(tempDir + "\\kissmp.zip", tempDir);
                    rtb2ProgressText.Text += "\nkissmp.zip extracted to " + tempDir;
                    pb2ProgressBar.Value = 18;

                    rtb2ProgressText.Text += "\nDeleting kissmp.zip...";
                    pb2ProgressBar.Value = 20;
                    //DELETE DOWNLOADED FILE
                    if (File.Exists(tempDir + "\\kissmp.zip"))
                    {
                        File.Delete(tempDir + "\\kissmp.zip");
                    }
                }
                else
                {
                    rtb2ProgressText.Text += "\nDir not found, creating... " + tempDir;
                    pb2ProgressBar.Value = 16;
                    Directory.CreateDirectory(tempDir);
                    rtb2ProgressText.Text += "\nExtracting kissmp.zip to " + tempDir;
                    pb2ProgressBar.Value = 18;
                    ZipFile.ExtractToDirectory(tempDir + "\\kissmp.zip", tempDir);
                    rtb2ProgressText.Text += "\nkissmp.zip extracted to " + tempDir;
                    pb2ProgressBar.Value = 19;

                    //DELETE DOWNLOADED FILE
                    if (File.Exists(tempDir + "\\kissmp.zip"))
                    {
                        rtb2ProgressText.Text += "\nDeleting kissmp.zip...";
                        pb2ProgressBar.Value = 20;
                        File.Delete(tempDir + "\\kissmp.zip");
                        rtb2ProgressText.Text += "\nkissmp.zip deleted";
                        pb2ProgressBar.Value = 24;
                    }
                }

                string[] list = Directory.GetDirectories(tempDir);

                string ExtractedFolder = "";
                string ExtractedFolder1 = "";
                string bridgePath = "";


                //Copy KISSMultiplayer.zip to Mods folder
                if (list.Length > 0)
                {
                    ExtractedFolder = list[0];
                    if (File.Exists(ExtractedFolder + "\\KISSMultiplayer.zip"))
                    {
                        if (Directory.Exists(UserFolderPath + "\\mods"))
                        {
                            if (File.Exists(UserFolderPath + "\\mods\\KISSMultiplayer.zip"))
                            {
                                rtb2ProgressText.Text += "\nPrepearing dir...";
                                pb2ProgressBar.Value = 30;
                                File.Delete(UserFolderPath + "\\mods\\KISSMultiplayer.zip");
                            }
                            File.Copy(ExtractedFolder + "\\KISSMultiplayer.zip", UserFolderPath + "\\mods\\KISSMultiplayer.zip");
                            rtb2ProgressText.Text += "\nCopied KISSMultiplayer.zip to " + UserFolderPath + "\\mods\\KISSMultiplayer.zip";
                            pb2ProgressBar.Value = 36;
                        }
                    }
                }
                //Copies kissmp-bridge.exe to a folder that user provided and makes a shortcut if user checked it
                if (Directory.Exists(ExtractedFolder))
                {
                    string[] list1 = Directory.GetDirectories(ExtractedFolder);
                    foreach (var item in list1)
                    {
                        if (item.Contains("windows"))
                        {
                            ExtractedFolder1 = item;
                        }
                    }
                    if (Directory.Exists(ExtractedFolder1))
                    {
                        string[] list2 = Directory.GetFiles(ExtractedFolder1);
                        foreach (var item in list2)
                        {
                            if (item.Contains("bridge"))
                            {
                                bridgePath = item;
                            }
                        }
                        if (!Directory.Exists(BridgeInstallDir))
                        {
                            rtb2ProgressText.Text += "\n" + BridgeInstallDir + " doesn't exist!";
                            Directory.CreateDirectory(BridgeInstallDir);
                            rtb2ProgressText.Text += "\nCreated " + BridgeInstallDir;
                            pb2ProgressBar.Value = 36;
                        }
                        if (File.Exists(BridgeInstallDir + "\\" + bridgePath.Replace(ExtractedFolder1 + "\\", "")))
                        {
                            File.Delete(BridgeInstallDir + "\\" + bridgePath.Replace(ExtractedFolder1 + "\\", ""));
                            rtb2ProgressText.Text += "\nFound old files, cleaning...";
                        }

                        rtb2ProgressText.Text += "\nCopying " + bridgePath;
                        File.Copy(bridgePath, BridgeInstallDir + "\\" + bridgePath.Replace(ExtractedFolder1 + "\\", ""));
                        rtb2ProgressText.Text += "\nCopied to " + BridgeInstallDir + "\\" + bridgePath.Replace(ExtractedFolder1 + "\\", "");
                        pb2ProgressBar.Value = 40;


                        

                        try
                        {
                            rtb2ProgressText.Text += "\nDownloading icon...";
                            pb2ProgressBar.Value = 44;
                            WebClient webClient2 = new WebClient();
                            webClient2.DownloadFile("https://crownpitchroyal.com/bridge.ico", BridgeInstallDir + "\\bridge.ico");
                            rtb2ProgressText.Text += "\nCopying bridge.ico to " + BridgeInstallDir;
                            pb2ProgressBar.Value = 48;
                        }
                        catch (Exception)
                        {
                            rtb2ProgressText.Text += "\nERROR downloading icon, skipping...";
                        }
                        


                        if (File.Exists(BridgeInstallDir + "\\KissMP.bat"))
                        {
                            File.Delete(BridgeInstallDir + "\\KissMP.bat");
                        }
                        //Makes a simple bat file that runs the bridge and game via steam
                        using (StreamWriter writer = new StreamWriter(BridgeInstallDir + "\\KissMP.bat"))
                        {
                            writer.WriteLine("chcp 65001");

                            if (cbSteam.Checked)
                            {
                                writer.WriteLine(@"start """" steam://rungameid/284160\");
                            }
                            else
                            {
                                if (tbNotSteam.Text.Length > 0)
                                {
                                    writer.WriteLine(@"start """" " + tbNotSteam.Text);
                                }
                                else
                                {
                                    MessageBox.Show("Game Installation directory not valid. Game launch excluded from startup script.");
                                }
                            }
                            writer.WriteLine(@"start """" " + BridgeInstallDir);
                        }

                        //DELETE Extracted files
                        if (Directory.Exists(BridgeInstallDir))
                        {
                            string tempFolder = "";
                            string[] list4 = Directory.GetDirectories(BridgeInstallDir);
                            foreach (var item in list4)
                            {
                                if (item.Contains("KissMP"))
                                {
                                    tempFolder = item;
                                }
                            }
                            if (Directory.Exists(tempFolder))
                            {
                                Directory.Delete(tempFolder, true);
                                rtb2ProgressText.Text += "\nRemoved temp files...";
                                pb2ProgressBar.Value = 54;
                            }
                        }



                        //Make shortcut if checked
                        if (cbShortDesktop.Checked) { rtb2ProgressText.Text += "\nCreated Desktop Shortcut"; CreateShortcut(0); }

                        if (cbShortStart.Checked) { rtb2ProgressText.Text += "\nCreated Start Menu Shortcut!"; CreateShortcut(1); }

                        rtb2ProgressText.Text += "\n\nDone!";
                        pb2ProgressBar.Value = 100;
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }




        /// <summary>
        /// Check internet conectivity
        /// </summary>
        /// <returns></returns>
        public bool HasConnection()
        {
            string host = "google.com";
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success) {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err) { EH(err); }
            return false;
        }

        /// <summary>
        /// Check if text is in stage1 textboxes, if not don't let user continue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void l1PathBR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((Control)sender).Name == "l1PathUF")
                {
                    UserFolderPath = l1PathUF.Text;
                }
                if (((Control)sender).Name == "l1PathBR")
                {
                    BridgeInstallDir = l1PathBR.Text;
                }

                if (BridgeInstallDir.Length > 0 && UserFolderPath.Length > 0)
                {
                    btnContinue.Enabled = true;
                }
            }
            catch (Exception err) { EH(err); }
        }


        /// <summary>
        /// Creates a shortcut
        /// </summary>
        /// <param name="location">0 = Desktop, 1 = Start menu</param>
        public void CreateShortcut(int location)
        {
            try
            {
                string shortcutName = "Bridge - KissMP";

                string dir = "";

                if (location == 0) //0 = Desktop
                {
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                }
                else if (location == 1) //1 = Start menu
                {
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                }

                if (File.Exists(dir + "\\" + shortcutName + ".url"))
                {
                    File.Delete(dir + "\\" + shortcutName + ".url");
                }
                using (StreamWriter writer = new StreamWriter(dir + "\\" + shortcutName + ".url"))
                {
                    string app = BridgeInstallDir + "\\KissMP.bat";
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + BridgeInstallDir + "\\bridge.ico");
                }
            }
            catch (Exception err) { EH(err); }
        }


        /// <summary>
        /// RTB autoscroll to bottom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            rtb2ProgressText.SelectionStart = rtb2ProgressText.Text.Length;
            rtb2ProgressText.ScrollToCaret();
        }


        //KissMP Picture onClick
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://kissmp.online/");
        }

        private void cbSteam_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cbSteam.Checked)
                {
                    btnNotSteam.Visible = true;
                    lNotSteam.Visible = true;
                    tbNotSteam.Visible = true;
                }
                else
                {
                    btnNotSteam.Visible = false;
                    lNotSteam.Visible = false;
                    tbNotSteam.Visible = false;
                }
            }
            catch (Exception err) { EH(err); }
        }

        private void btnNotSteam_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new OpenFileDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                    {
                        GameExePath = fbd.FileName;
                        lNotSteam.Text = GameExePath;
                    }
                }
            }
            catch (Exception err) { EH(err); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kissmp.online/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.com/invite/ANPsDkeVVF");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TheHellBox/KISS-multiplayer/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.patreon.com/TheHellBox");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kissmp.online/docs/");
        }
    }
}
