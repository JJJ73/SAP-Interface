using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAP.Middleware.Connector;

namespace SAP_Interface
{
    public partial class formBOM : Form
    {
        //SAP_Connection SAP;
        //DB_Connect DB;
        //SAP_Organigation PlantDefaults = new SAP_Organigation() { Plant = "A100", ValArea = "A100", SalesOrg = "S001", DistrChan = "10" };

        public bool Loaded = false;

        public formBOM()
        {
            InitializeComponent();
            this.Cursor = Cursors.Default;

            //Crearte Reference to SQL Database Connection
            //SQL_Connection dbSQL = new SQL_Connection() { Server = @"DESKTOP-M7TP51D\SQLEXPRESS", DatabaseName = "Design_WO" };
            //DB = new DB_Connect(dbSQL, false);

            //Create Reference to SAP Destination
            //SAP_Configuration config = new SAP_Configuration();
            //config.UserName = "JJordaan";
            //SAP = new SAP_Connection(DB, config);

            if (Global.conSAP.IsConnected)
            {
                lblSAP.Text = "Connected to SAP Host - " + Global.conSAP.Destination.AppServerHost.ToString();
            }
            else
            {
                lblSAP.Text = "SAP Not Connected";
                MessageBox.Show(Global.conSAP.ErrorMessage);
            }
        }

        private void cmdGetTable_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                var Part = Global.conSAP.RFC_MaterialMaster_Exist("1ZZA468002-BD");
                if (Part.Exist)
                {
                    Console.Beep();
                    MessageBox.Show("Material Exist", "SAP Material Exist Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        private void TEST_GetMaterialDetails()
        {
            //PlantDefaults.SLoc = "WOM";
            //var Part = SAP.RFC_GetMaterialMasterData(DB, "1ZZA275003-ED", PlantDefaults); //Use DB too get SLoc            
            //Part = SAP.RFC_GetMaterialMasterData("1ZXX466039-XXX", PlantDefaults);  //Material does not exist            
            //Part = SAP.RFC_GetMaterialMasterData(DB, "1ZZA468002-BD", PlantDefaults); //Use DB too get SLoc
            //Global.PlantDefaults.SLoc = "SFM";
            var Part = Global.conSAP.RFC_MaterialMaster_Get(txtSAPNo.Text, Global.PlantDefaults);  //"1ZZA138001-C"
            if (Part.Status.Exist)
            {

            }
        }

        private void TEST_CreateMaterial()
        {
            SAP_Message msgResult = new SAP_Message();

            //Minimum Material details for material to be created - CAD Data
            SAP_MaterialMaster Part = new SAP_MaterialMaster();

            Part.MatType = "ROH";  //User defined in BOM_Viewer Tool  - Make = HALB; Buy = ROH
            Part.Material = "TEST_JJJ01"; //CAD
            Part.Description = "ROH TEST PART"; //CAD
            Part.BasicMaterial = "Mild Steel Profiles";  //From CAD.  If not defined in CAD then User defined in BOM_Viewer Tool
            Part.BaseUoM = "EA";  //CAD - wrong material to trigger ALT UOM
            Part.IndStdDesc = "BF";  //User defined in BOM_Viewer Tool - Specific for WO = T/B; For Stock = BT/TF            
            Part.NettWeight = 182.8f;  //User defined or in CAD
            Part.InitPrice = 2342.84f;  //User price

            /*
            Part.MatType = "HALB";  //User defined in BOM_Viewer Tool  - Make = HALB; Buy = ROH
            Part.Material = "REF_HALB_T"; //CAD
            Part.Description = "REFERENCE HALB T-ITEM"; //CAD
            Part.BasicMaterial = "";  //From CAD.  If not defined in CAD then User defined in BOM_Viewer Tool
            Part.BaseUOM = "EA";  //CAD
            Part.IndStdDesc = "T";  //User defined in BOM_Viewer Tool - Specific for WO = T/B; For Stock = BT/TF            
            Part.NettWeight = 154.243f;  //User defined or in CAD
            Part.InitPrice = 4548.54f;            
            */

            /*
            Part.MatType = "HALB";  //User defined
            Part.Material = "REF_HALB_TF"; //CAD
            Part.Description = "REFERENCE HALB TF-ITEM"; //CAD
            Part.Description = Part.Description.ToUpper();
            Part.BasicMaterial = "";  //User defined
            Part.BaseUOM = "EA";  //CAD
            Part.IndStdDesc = "TF";  //User defined            
            Part.NettWeight = 0.0f;  //User defined
            Part.InitPrice = 4548.54f;
            */

            if (Part.isDefined)
                msgResult = Global.conSAP.RFC_MaterialMaster_Create(Global.DB, Part, Global.PlantDefaults);

            if (!msgResult.hasError)
            {
                Console.Beep();
                MessageBox.Show(msgResult.Text, "Create New Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(msgResult.Text, "Create New Material Error: " + msgResult.ID + " - " + msgResult.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TEST_GetMaterialPrice()
        {
            //Get Material Price Data - TEST
            //SImulate the list of Past numbers that need to be read from SQL DB
            List<string> SAPNo = new List<string>();
            SAPNo.Add("1ZZA468002-BD");
            //SAPNo.Add("JJJ");
            //SAPNo.Add("1ZZA466003-J");
            //SAPNo.Add("1ZZA212001-SA");
            //SAPNo.Add("1ZZA212001-TA");
            /*SAPNo.Add("1ZZA212001-VA");
            SAPNo.Add("1ZZA212001-XA");
            SAPNo.Add("1ZZA212001-ZA");
            SAPNo.Add("1ZZA212001-WA");
            SAPNo.Add("1ZZA212001-DD");
            SAPNo.Add("1ZZA212008-DB");
            SAPNo.Add("1ZZA212008-EB");
            SAPNo.Add("1ZZA212008-FD");
            SAPNo.Add("1ZZA212008-HD");
            SAPNo.Add("1ZZA212008-JB");
            SAPNo.Add("1ZZA212008-JD");
            SAPNo.Add("1ZZA212008-JF");
            SAPNo.Add("1ZZA212008-KD");
            SAPNo.Add("1ZZA212008-KF");
            SAPNo.Add("1ZZA212008-LD");
            SAPNo.Add("1ZZA212008-LF");
            SAPNo.Add("1ZZA212008-MC");
            SAPNo.Add("1ZZA212008-MD");
            SAPNo.Add("1ZZA212008-MF");
            SAPNo.Add("1ZZA212008-MJ");
            SAPNo.Add("1ZZA212008-ND");
            SAPNo.Add("1ZZA212008-NF");
            SAPNo.Add("1ZZA212008-NJ");
            SAPNo.Add("1ZZA212008-PF");*/

            var SAP_Prices = Global.conSAP.RFC_GetMaterialPrice(SAPNo, Global.PlantDefaults, true);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                TEST_GetMaterialDetails();
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                TEST_CreateMaterial();
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                var BOM_Data = Global.conSAP.RFC_BOM_GetLevel(txtSAPNo.Text, "A100", "1");
                dgvSAPData.DataSource = BOM_Data.T_STPO;
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                var BOM_Data = Global.conSAP.RFC_BOM_GetLevel(txtSAPNo.Text, "A100", "1");
                dgvSAPData.DataSource = BOM_Data.T_STKO;
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        public void Reload()
        {
            formBOM_Load(this, new EventArgs());
        }

        private void formBOM_Load(object sender, EventArgs e)
        {
            Loaded = true;
        }
    }
}