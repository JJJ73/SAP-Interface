using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Interface
{
    public partial class formRouting : Form
    {
        public bool Loaded = false;

        public formRouting()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            formRouting_Load(this, new EventArgs());
        }

        private void formRouting_Load(object sender, EventArgs e)
        {
            if (txtSAPNo.Text != "") button3_Click(this, new EventArgs());
            Loaded = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                var BOM_Data = Global.conSAP.RFC_BOM_GetLevel(txtSAPNo.Text, "A100", "1");
                txtBOMNo.Text = BOM_Data.BOM_ID;
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Global.conSAP.IsConnected)
            {
                var BOM_Routing = Global.conSAP.RFC_Routing_Exist(txtBOMNo.Text); //, "A100", "1");
                //txtBOMNo.Text = BOM_Data.BOM_ID;
            }
            else
                MessageBox.Show("No SAP Connection", "SAP Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Cursor = Cursors.Default;
        }
    }
}
