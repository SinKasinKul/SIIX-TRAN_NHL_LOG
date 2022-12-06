using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace TRAN_NHL_LOG
{
    public partial class Main : Form
    {
        readonly ConnectDB ConDB = new ConnectDB();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            rTBResult.ReadOnly = true;
            string dateLogShow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lbDateTime.Text = dateLogShow;

            var appSettings = ConfigurationManager.AppSettings;
            string pahtFileLog = appSettings.Get("pahtFileLog");
            string Cus = appSettings.Get("Customer");
            string Server = appSettings.Get("Server");
            string MC = appSettings.Get("CLIENT");
            string Process = appSettings.Get("Process");
            string cycleTime = appSettings.Get("cycleTime");
            string mainType = appSettings.Get("mainType");

            lbcycleTime.Text = cycleTime;
            tBPW.PasswordChar = '*';
            int TimeSec = Int32.Parse(cycleTime);

            //int sec = 60;

            Int32 TimeInt = (TimeSec * 1000);
            this.timerLogdata.Interval = TimeInt;
            timerLogdata.Tick += new EventHandler(timerLogdata_Tick);

            lbNameMC.Text = MC;
            lbNProcess.Text = Process;
            lbMCPath.Text = pahtFileLog;
            lbNproject.Text = Server;

            lbStatus.Text = "Not Start";

            lbPW.Hide();
            tBPW.Hide();

            this.timerLogdata.Enabled = true;
            PrintResult("Application Start...");
        }
        public void PrintResult(string RText)
        {
            string dateLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                rTBResult.Text += dateLog + "----> " + RText;
                //rTBResult.Text += RText;
                rTBResult.Text += Environment.NewLine;
            }
            catch
            {
                rTBResult.Text = "";
            }
        }
        public void logError(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_Error\\" + Date;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Error_" + Date + ".txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't export file.");
            }
        }
        private void ReadFileLog()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string pahtFileLog = appSettings.Get("pahtFileLog");
            string rowSelect = appSettings.Get("rowSelect");
            int rowsSelect = Int32.Parse(rowSelect);

            string[] entries = Directory.GetDirectories(pahtFileLog);
            lbStatus.Text = "Running...";
            lbStatus.BackColor = Color.Red;
            foreach (string f in entries)
            {
                //PrintResult("Path : " + f);
                string[] txtList = Directory.GetFiles(f, "summary*txt");
                foreach (string sf in txtList)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(File.OpenRead(sf)))
                        {
                            List<string> listA = new List<String>();
                            List<string> listB = new List<String>();
                            List<string> listC = new List<String>();
                            List<string> listD = new List<String>();
                            List<string> listE = new List<String>();
                            List<string> listF = new List<String>();
                            List<string> listG = new List<String>();
                            List<string> listH = new List<String>();
                            List<string> listI = new List<String>();
                            int C = 0;

                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                if (!String.IsNullOrWhiteSpace(line))
                                {
                                    string[] values = line.Split(',');
                                    if (values.Length >= 8)
                                    {
                                        listA.Add(values[0]);
                                        listB.Add(values[1]);
                                        listC.Add(values[2]);
                                        listD.Add(values[3]);
                                        listE.Add(values[4]);
                                        listF.Add(values[5]);
                                        listG.Add(values[6]);
                                        listH.Add(values[7]);
                                        listI.Add(values[8]);
                                    }
                                }
                                C++;
                            }
                            string[] vlogDate;
                            string[] vSNT;
                            string[] vBarcode;
                            string[] vBarcode2;
                            string[] vBarcode3;
                            string[] vType;
                            string[] vStatus;

                            string LBarcode;
                            string LBarcode2;

                            vlogDate = listA.ToArray();
                            vSNT = listB.ToArray();
                            vBarcode = listC.ToArray();
                            vBarcode2 = listD.ToArray();
                            vBarcode3 = listE.ToArray();
                            vType = listF.ToArray();
                            vStatus = listG.ToArray();
                            //PrintResult("Rows: " + C);

                            int cStart = (C - rowsSelect) <= 0 ? 0 : (C - rowsSelect);
                            Int64 j = 0, s = 0, d = 0;
                            for (int i = cStart; i < C; i++)
                            {
                                try
                                {

                                    if (vBarcode.ElementAtOrDefault(i) != null)
                                    {
                                        //string Result = "Test";
                                        string Result = ConDB.TRAN_FCT_LOG(vlogDate[i].Trim(), vSNT[i].Trim(), vBarcode[i], vBarcode2[i], vBarcode3[i].Trim(), vType[i].Trim(), vStatus[i].Trim());
                                        if (CBShowDetail.Checked == true)
                                        {
                                            PrintResult(i + " Barcode: " + vlogDate[i] + " ---> " + Result);
                                        }

                                        if (Result == "success")
                                        {
                                            s++;
                                        }
                                        else if (Result == "Duplicate")
                                        {
                                            d++;
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    if (CBShowDetail.Checked == true)
                                    {
                                        PrintResult("Rows : Not Found --> " + sf + e);
                                    }
                                }
                                j++;
                            }
                            if (s > 0)
                            {
                                PrintResult("Path : " + sf);
                                PrintResult("Barcode Check: " + j + " S/N-->Success: " + s + " S/N-->Duplicate: " + d);
                                PrintResult("<--------------------END---------------->");
                            }
                            else
                            {
                                PrintResult("Path : " + sf + "--> Readed");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        PrintResult("Rows : Not Found!!!" + e);
                    }
                }
            }
        }
        private void bgWLog_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ReadFileLog();
            }
            catch
            {
                PrintResult("App error : " + "Error");
            }
        }
        private void bgWLog_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string dateLogShow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lbDateTime.Text = dateLogShow;
            PrintResult("Process finish...");
            lbStatus.Text = "Finish...";
            lbStatus.BackColor = Color.DimGray;
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            string dateLogShow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lbDateTime.Text = dateLogShow;
            this.timerLogdata.Enabled = true;
            if (!bgWLog.IsBusy)
            {
                rTBResult.Text = ("");
                bgWLog.RunWorkerAsync();
            }
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            this.timerLogdata.Enabled = false;
            lbStatus.Text = "Stop!!!";
        }
        private void timerLogdata_Tick(object sender, EventArgs e)
        {
            if (!bgWLog.IsBusy)
            {
                rTBResult.Text = ("");
                bgWLog.RunWorkerAsync();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbPW.Show();
            tBPW.Show();
            string passWord = tBPW.Text;

            if (passWord == "siix@admin" & bgWLog.IsBusy != true)
            {
                e.Cancel = false;
            }
            else
            {
                tBPW.Focus();
                e.Cancel = true;
            }
        }
    }
}
