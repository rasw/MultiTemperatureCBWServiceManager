using AkvaData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace MultiTemperatureCBWServiceManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool isDirty = false;
        string appSetFilePath = @"C:\AkvaData\Service\Settings\AkvaDataMulti.xml";

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!SetupBaseFolders())
            {
                Logger.WriteToLog("Could not creat base folder structure");
                this.Dispose();
            }

            LoadValues();   // load the saved values

        }

        bool SetupBaseFolders()
        {
            try
            {
                if (!Directory.Exists(@"C:\AkvaData")) { Directory.CreateDirectory(@"C:\AkvaData"); }
                if (!Directory.Exists(@"C:\AkvaData\Service")) { Directory.CreateDirectory(@"C:\AkvaData\Service"); }
                if (!Directory.Exists(@"C:\AkvaData\Service\Settings")) { Directory.CreateDirectory(@"C:\AkvaData\Service\Settings"); }
                if (!Directory.Exists(@"C:\AkvaData\Service\Settings\Recovery")) { Directory.CreateDirectory(@"C:\AkvaData\Service\Settings\Recovery"); }

                return true; // success
            }
            catch
            {
                return false; // failed
            }
        }

        private void CheckServiceStatus()
        {
            var ctl = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "AkvaDataMulti");
            if (ctl != null)
            {
                // "Stopped"  "Running"
                string status = ctl.Status.ToString();
                lblServiceStatus.Text = "Service Status: " + status;

                if (status.StartsWith("R"))
                {
                    btnStartService.Enabled = false;
                    btnStopService.Enabled = true;
                    btnStartService.Enabled = false;
                    btnStopService.Enabled = true;

                    pnlStatus.BackColor = System.Drawing.Color.YellowGreen;
                }

                if (status.StartsWith("S"))
                {
                    btnStartService.Enabled = true;
                    btnStopService.Enabled = false;
                    btnStartService.Enabled = true;
                    btnStopService.Enabled = false;
                   
                    pnlStatus.BackColor = System.Drawing.Color.SlateGray;
                }
            }
            else
            {
                lblServiceStatus.Text = "Service Status: Not Installed.";
                btnStartService.Enabled = false;
                btnStopService.Enabled = false;
            
                pnlStatus.BackColor = System.Drawing.Color.Crimson;
            }
        }

        private void SaveSettings()
        {
            try
            {
                string appSetFile = appSetFilePath;
                AppSettings appSet = new AppSettings(appSetFile);

                appSet.setValue("CBW_TempModule_Enabled", chkCBW_Enabled.Checked.ToString());
               
                decimal a = numUpDwn_CBWInterval.Value * 1000;
                appSet.setValue("CBW_Timer1_Interval", a.ToString());
               
                appSet.setValue("DataLogFileFullPath", txtLogFileFullPath.Text.Trim());

                appSet.setValue("CBWTempModuleIPaddress", txtIPaddress.Text.Trim());
                appSet.setValue("CBWTempModulePassword", txtPassword.Text.Trim());
                appSet.setValue("CBWport", txtPort.Text.Trim());
                isDirty = false;

                CreateRecovery(appSetFile);
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("SaveSettings -> " + ex.Message);
                isDirty = false;
            }
        }

        private void CreateRecovery(string CurrentXMLsettingsFullPath)
        {
            if (File.Exists(CurrentXMLsettingsFullPath))
            {
                string recoveryFileFullPath = @"C:\AkvaData\Service\Settings\Recovery";
                string filename = Path.GetFileNameWithoutExtension(CurrentXMLsettingsFullPath);
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString("00");
                string day = DateTime.Now.Day.ToString("00");
                string hrs = DateTime.Now.Hour.ToString("00");
                string mins = DateTime.Now.Minute.ToString("00");
                string sec = DateTime.Now.Second.ToString("00");

                string recoveryFileNameOnly = filename + "_" + year + month + day + "_" + hrs + mins + sec + ".xml";

                File.Copy(CurrentXMLsettingsFullPath, Path.Combine(recoveryFileFullPath, recoveryFileNameOnly), true);
            }
        }

        private void LoadValues()
        {
            try
            {
                AppSettings appSet = new AppSettings(appSetFilePath);

                try { chkCBW_Enabled.Checked = Convert.ToBoolean(appSet.getValue("CBW_TempModule_Enabled")); } catch { chkCBW_Enabled.Checked = false; }
                
                try
                {
                    decimal a = Convert.ToDecimal(appSet.getValue("CBW_Timer1_Interval"));
                    numUpDwn_CBWInterval.Value = a /= 1000;
                }
                catch
                {
                    numUpDwn_CBWInterval.Value = 60;
                }  // 1 min

                txtIPaddress.Text = appSet.getValue("CBWTempModuleIPaddress");
                txtPassword.Text = appSet.getValue("CBWTempModulePassword");
                txtPort.Text = appSet.getValue("CBWport");
                isDirty = false;
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("LoadValues -> " + ex.Message);
                isDirty = false;
            }
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            StartStopService(true);     // start service
            btnStartService.Enabled = false;
            btnStopService.Enabled = false;
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            StartStopService(false);     // stop service
            btnStartService.Enabled = false;
            btnStopService.Enabled = false;
        }

        private void StartStopService(bool StartStop)  // true = start
        {
            ServiceController service = new ServiceController("AkvaDataMulti");
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(30000);

                if (StartStop)
                {  // start
                    lblServiceStatus.Text = "Service Status: Starting.";
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                else
                {
                    lblServiceStatus.Text = "Service Status: Stopping.";
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
                CheckServiceStatus();   // display status
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("StartStopService -> " + ex.Message);
                CheckServiceStatus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseLogFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                AppSettings appSet = new AppSettings(appSetFilePath);

                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    string year = DateTime.Now.Year.ToString();
                    string month = DateTime.Now.Month.ToString("00");
                    string day = DateTime.Now.Day.ToString("00");
                    string hrs = DateTime.Now.Hour.ToString("00");
                    string mins = DateTime.Now.Minute.ToString("00");
                    string sec = DateTime.Now.Second.ToString("00");

                    string fileName = "TemperatureLog_" + year + month + day + "_" + hrs + mins + ".txt";

                    txtLogFileFullPath.Text = folderBrowserDialog1.SelectedPath.Trim() + @"\" + fileName;


                    appSet.setValue("DataLogFileFullPath", txtLogFileFullPath.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                Logger.WriteToLog("btnBrowseLogFilePath_Click -> " + ex.Message);
            }

        }

        private void tmrServiceCheckStatus_Tick(object sender, EventArgs e)
        {
            CheckServiceStatus();
        }
    }
}
