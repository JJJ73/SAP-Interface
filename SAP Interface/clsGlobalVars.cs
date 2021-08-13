using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP_Interface
{
    class Global
    {
        public static DB_Connect DB;
        public static SAP_Connection conSAP;
        public static SAP_Organigation PlantDefaults = new SAP_Organigation() { Plant = "A100", ValArea = "A100", SalesOrg = "S001", DistrChan = "10" };
        public static SAP_Configuration configSAP = new SAP_Configuration() { AppServerHost = "10.80.213.13", Client = "580", UserName = "JJordaan", Password = "Smirre@202108", SystemID = "AEQ" };
        public static SQL_Connection dbSQL = new SQL_Connection() { Server = @"SGB-PTA-L-JJORD\SQLEXPRESS", DatabaseName = "Design_WO", WindowsAuthentication = true };
        //public SAP_Configuration configSAP = new SAP_Configuration() { AppServerHost = "10.80.213.12", Client = "580", UserName = "ABBLP01", Password = "pieter13", SystemID = "ABB" };
    }
}
