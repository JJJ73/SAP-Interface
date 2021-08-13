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
    public partial class frmMain : Form
    {

        private formPriceQuery frmPrice;
        private formBOM frmBOM;
        private formRouting frmRouting;
        private enum PageIndex { Price, BOM, Routing}
        private PageIndex inxPage = PageIndex.BOM;              

        public frmMain()
        {
            InitializeComponent();

            frmPrice = new formPriceQuery() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBOM = new formBOM() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmRouting = new formRouting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(frmPrice);
            panel.Controls.Add(frmBOM);
            panel.Controls.Add(frmRouting);
            tabControl.SelectedIndex = (int)inxPage;
            tabControl_SelectedIndexChanged(this, new EventArgs());
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel.Controls)
                ctrl.Visible = false;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    inxPage = PageIndex.Price;
                    frmPrice.Loaded = false;
                    break;

                case 1:
                    inxPage = PageIndex.BOM;
                    frmBOM.Loaded = false;
                    break;

                case 2:
                    inxPage = PageIndex.Routing;
                    frmRouting.Loaded = false;
                    break;
            }
            panel.Controls[(int)inxPage].Show();
            panel.Controls[(int)inxPage].Visible = true;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if(!frmPrice.Loaded) frmPrice.Reload();
                    break;

                case 1:
                    if(!frmBOM.Loaded) frmBOM.Reload();
                    break;

                case 2:
                    if(!frmRouting.Loaded) frmRouting.Reload();
                    break;
            }
        }
    }
}