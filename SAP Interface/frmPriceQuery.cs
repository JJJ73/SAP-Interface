using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAP_Interface.Properties;

namespace SAP_Interface
{
    public partial class formPriceQuery : Form
    {
        public bool Loaded = false;

        public formPriceQuery()
        {
            InitializeComponent();            
        }

        private void lblDB_Click(object sender, EventArgs e)
        {
            string fn = "";
            if (lblDB.Text == "???")
                fn = "";
            else
                fn = lblDB.Text;
            fn = FileSystem.Browse_File(fn, "Select Output Folder", "accdb");
            if (fn != "")
            {
                lblDB.Text = fn;
                Settings.Default.adoFile = fn;
                Settings.Default.Save();
            }                
        }

        private void Load_DB_Data()
        {
            string SQL = "SELECT * FROM [Prices] ORDER BY [Costing_Group], [Description]";
            RecordSet rstData = Global.DB.RecordSet_Query(SQL);
            if (rstData.HasRecords)
            {
                dgvSAP.DataSource = rstData.Data;
                dgvSAP.Columns["ID"].ReadOnly = true;
                dgvSAP.Columns["ID"].Frozen = true;
                dgvSAP.Columns["Costing_Group"].Frozen = true;
                dgvSAP.Columns["Part_No"].Frozen = true;
                dgvSAP.Columns["Description"].Frozen = true;
                dgvSAP.Columns["SAP_STD_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSAP.Columns["SAP_MM_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSAP.Columns["SAP_PO_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSAP.Columns["Manual_Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvSAP.Columns["SAP_STD_Price"].DefaultCellStyle.Format = "N2";
                dgvSAP.Columns["SAP_MM_Price"].DefaultCellStyle.Format = "N2";
                dgvSAP.Columns["SAP_PO_Price"].DefaultCellStyle.Format = "N2";
                dgvSAP.Columns["Manual_Price"].DefaultCellStyle.Format = "N2";

            }
        }

        private void cmdReload_Click(object sender, EventArgs e)
        {
            dgvSAP.DataSource = null;
            Load_DB_Data();
        }

        private void cmdQuerySAP_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; 
            pgbSAP.Maximum = dgvSAP.RowCount - 2;
            pgbSAP.Value = 0;
            pgbSAP.Visible = true;
                       
            for(int r = 0; r< dgvSAP.RowCount - 1; r++)
            {
                pgbSAP.Value = r;
                Check_SAP(r);
                Application.DoEvents();
            }
            this.Cursor = Cursors.Default;
            pgbSAP.Visible = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string SQL = "SELECT * FROM [Prices]";
            RecordSet rstData = Global.DB.RecordSet_Query(SQL);
            pgbSAP.Maximum = dgvSAP.RowCount - 2;
            pgbSAP.Value = 0;
            pgbSAP.Visible = true;
            for (int r = 0; r < dgvSAP.RowCount - 1; r++)
            {
                pgbSAP.Value = r;
                string ID = dgvSAP.Rows[r].Cells["ID"].Value.ToString();
                DataTable DT = rstData.Data.Clone();
                DataRow DR = DT.NewRow();
                for (int k = 1; k < DT.Columns.Count; k++)
                {
                    DR[k] = dgvSAP.Rows[r].Cells[k].Value;
                }
                DT.Rows.Add(DR);

                if (ID == "")
                {
                    Global.DB.RecordSet_AddNew("Prices", DT, 0);
                }
                else
                {
                    SQL = "SELECT * FROM [Prices] WHERE [ID] = " + ID;
                    Global.DB.RecordSet_Update(SQL, DT, 0);
                }
            }
            pgbSAP.Visible = false;

            cmdReload_Click(this, e);
            this.Cursor = Cursors.Default;
        }

        private void Check_SAP(int r)
        {
            string sapMaterial = dgvSAP.Rows[r].Cells["Part_No"].Value.ToString();
            MM_PriceData PriceInfo = new MM_PriceData();
            if (sapMaterial != "")
            {
                bool Check_PO = dgvSAP.Rows[r].Selected;
                PriceInfo = Global.conSAP.RFC_GetMaterialPrice(sapMaterial, Global.PlantDefaults.Plant, Global.PlantDefaults.Plant, Check_PO);
                if (PriceInfo.Material != "")
                {
                    dgvSAP.Rows[r].Cells["SAP_STD_Price"].Value = PriceInfo.Price_STD;
                    dgvSAP.Rows[r].Cells["SAP_MM_Price"].Value = PriceInfo.Price_MveAvge;
                    if (Check_PO)
                    {
                        if (PriceInfo.Price_PO != 0)
                        {
                            dgvSAP.Rows[r].Cells["SAP_PO_Price"].Value = PriceInfo.Price_PO;
                            dgvSAP.Rows[r].Cells["SAP_Currency"].Value = PriceInfo.Currency;
                            dgvSAP.Rows[r].Cells["Last_PO_Date"].Value = PriceInfo.LastPODate.ToShortDateString();
                        }
                        else
                        {
                            dgvSAP.Rows[r].Cells["SAP_PO_Price"].Value = DBNull.Value;
                            dgvSAP.Rows[r].Cells["SAP_Currency"].Value = "";
                            dgvSAP.Rows[r].Cells["Last_PO_Date"].Value = "";
                        }
                    }
                    dgvSAP.Rows[r].Cells["SAP_Desc"].Value = PriceInfo.Desc;
                    dgvSAP.Rows[r].Cells["SAP_Basic_Material"].Value = PriceInfo.Basic_Matl;
                }
            }
        }

        private void cmdQueryPO_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pgbSAP.Maximum = dgvSAP.SelectedRows.Count - 1;
            pgbSAP.Value = 0;
            pgbSAP.Visible = true;

            for (int r = 0; r < dgvSAP.SelectedRows.Count; r++)
            {
                pgbSAP.Value = r;
                Check_SAP(dgvSAP.SelectedRows[r].Index);
                Application.DoEvents();
            }
            this.Cursor = Cursors.Default;
            pgbSAP.Visible = false;        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            DialogResult Reply = MessageBox.Show("Do you want to save the current data in the Table to the Database?", "Saving Data to Database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (Reply == DialogResult.Yes)
            {
                cmdSave_Click(this, e);
                this.Close();
            }                
            else if (Reply == DialogResult.Cancel)
                return;
            else
                this.Close();
        }

        public void Reload()
        {
            formPriceQuery_Load(this, new EventArgs());
        }

        private void formPriceQuery_Load(object sender, EventArgs e)
        {
            Load_DB_Data();
            Loaded = true;
        }
    }
}
