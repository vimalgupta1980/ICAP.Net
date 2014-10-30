using System;
using System.Resources;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Data;

namespace ini
{
    public class DBBase
    {
        public string C_Name = null;
        public string Reveresal = null;
        public string CostRecord = null;
        public string MBDirectory = null;

        public DBBase()
        {

        }
    }

    public class DBConnectioin : DBBase
    {
        private INI ini;
        public static string conStr = null;

        public DBConnectioin()
        {
            ini = new INI();
        }

        private void Read()
        {
            ini.GetPara();
            this.C_Name = ini.C_Name;
            this.Reveresal = ini.Reveresal;
            this.CostRecord = ini.CostRecord;
            this.MBDirectory = ini.MBDirectory;
        }

        public void Write()
        {
            ini.C_Name = this.C_Name;
            ini.Reveresal = this.Reveresal;
            ini.CostRecord = this.CostRecord;
            ini.MBDirectory = this.MBDirectory;
            ini.SetPara();
        }

        public void GetConString()
        {
            this.Read();
            //conStr = "workstation id=" + this.C_Name + ";data source=" + this.C_Name + ";initial catalog=" + this.Reveresal + ";user id=" + this.loginName + ";password=" + this.passWord;
        }
    }

    public class INI : DBBase
    {
        protected string path = null;
        protected string fileName = "Config.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public INI()
        {
            this.path = Directory.GetCurrentDirectory();
        }

        private bool Write(string section, string key, string value)
        {
            try
            {
                WritePrivateProfileString(section, key, value, this.path + "\\" + this.fileName);  
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string Read(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path + "\\" + this.fileName);
            return temp.ToString();
        }

        public void GetPara()
        {
            this.C_Name = Read("Info", "C_Name");
            this.Reveresal = Read("Info", "Reveresal");
            this.CostRecord = Read("Info", "CostRecord");
            this.MBDirectory = Read("Info", "MBDirectory");
        }

        public void SetPara()
        {
            Write("Info", "C_Name", this.C_Name);
            Write("Info", "Reveresal", this.Reveresal);
            Write("Info", "CostRecord", this.CostRecord);
            Write("Info", "MBDirectory", this.MBDirectory);
        }
    }

}
