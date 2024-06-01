﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   
    #region ---------- Code cua HungTuLenh 
    public class Zone
    {
        
        public Zone(byte comid, string comname, string zonename, byte comstatus, decimal priceph, string cpumodel, string gpumodel, string hddmodel, string ssdmodel, string mousemodel, string keyboardmodel, string monitormodel)
        {
            this.ComId = comid;
            this.ComName = comname;
            this.ZoneName = zonename;
            this.ComStatus = comstatus;
            this.PricePh = priceph;
            this.CpuModel = cpumodel;
            this.Gpumodel = gpumodel;
            this.HddModel = hddmodel;
            this.SsdModel = ssdmodel;
            this.MouseModel = mousemodel;
            this.KeyboardModel = keyboardmodel;
            this.MonitorModel = monitormodel;

        }
        public Zone (DataRow row)
        {
            this.ComId = (byte)row["computerid"];
            this.ComName = row["computername"].ToString(); ;
            this.ZoneName = row["zonename"].ToString(); ;
            this.ComStatus = (byte)row["computerstatus"]; ;
            this.PricePh = (decimal)row["priceperhour"]; ;
            this.CpuModel = row["cpumodel"].ToString(); ;
            this.Gpumodel = row["gpumodel"].ToString(); ;
            this.HddModel = row["hddmodel"].ToString(); ;
            this.SsdModel = row["ssdmodel"].ToString(); ;
            this.MouseModel = row["mousemodel"].ToString(); ;
            this.KeyboardModel = row["keyboardmodel"].ToString();;
            this.MonitorModel = row["monitormodel"].ToString(); ;
        }

        public Zone() { }

        private byte comId;
        private string comName;
        private string zoneName;
        private byte comStatus;
        private decimal pricePh;
        private string cpuModel;
        private string gpumodel;
        private string hddModel;
        private string ssdModel;
        private string mouseModel;
        private string keyboardModel;
        private string monitorModel;


        public string ComName { get => comName; set => comName = value; }
        public byte ComId { get => comId; set => comId = value; }
        public byte ComStatus { get => comStatus; set => comStatus = value; }
        public decimal PricePh { get => pricePh; set => pricePh = value; }
        public string ZoneName { get => zoneName; set => zoneName = value; }
        public string CpuModel { get => cpuModel; set => cpuModel = value; }
        public string HddModel { get => hddModel; set => hddModel = value; }
        public string SsdModel { get => ssdModel; set => ssdModel = value; }
        public string MouseModel { get => mouseModel; set => mouseModel = value; }
        public string KeyboardModel { get => keyboardModel; set => keyboardModel = value; }
        public string MonitorModel { get => monitorModel; set => monitorModel = value; }
        public string Gpumodel { get => gpumodel; set => gpumodel = value; }
    }
    public static class ComputerZone
    {
        public static byte zoneId { get; set; }
    }
    #endregion
}