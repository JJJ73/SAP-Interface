namespace SAP_Interface
{
    partial class formPriceQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSAP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdQueryPO = new System.Windows.Forms.Button();
            this.cmdQuerySAP = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pgbSAP = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSAP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.lblDB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 24);
            this.panel1.TabIndex = 0;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.ForeColor = System.Drawing.Color.Blue;
            this.lblDB.Location = new System.Drawing.Point(136, 6);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(25, 13);
            this.lblDB.TabIndex = 1;
            this.lblDB.Text = "???";
            this.lblDB.Click += new System.EventHandler(this.lblDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Access DB Filename:";
            // 
            // dgvSAP
            // 
            this.dgvSAP.AllowUserToResizeRows = false;
            this.dgvSAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSAP, 3);
            this.dgvSAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSAP.Location = new System.Drawing.Point(3, 33);
            this.dgvSAP.Name = "dgvSAP";
            this.dgvSAP.Size = new System.Drawing.Size(966, 378);
            this.dgvSAP.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdQueryPO);
            this.panel2.Controls.Add(this.cmdQuerySAP);
            this.panel2.Controls.Add(this.cmdReload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 30);
            this.panel2.TabIndex = 2;
            // 
            // cmdQueryPO
            // 
            this.cmdQueryPO.Location = new System.Drawing.Point(592, 4);
            this.cmdQueryPO.Name = "cmdQueryPO";
            this.cmdQueryPO.Size = new System.Drawing.Size(73, 23);
            this.cmdQueryPO.TabIndex = 4;
            this.cmdQueryPO.Text = "Query PO";
            this.cmdQueryPO.UseVisualStyleBackColor = true;
            this.cmdQueryPO.Click += new System.EventHandler(this.cmdQueryPO_Click);
            // 
            // cmdQuerySAP
            // 
            this.cmdQuerySAP.Location = new System.Drawing.Point(466, 4);
            this.cmdQuerySAP.Name = "cmdQuerySAP";
            this.cmdQuerySAP.Size = new System.Drawing.Size(109, 23);
            this.cmdQuerySAP.TabIndex = 3;
            this.cmdQuerySAP.Text = "Query SAP";
            this.cmdQuerySAP.UseVisualStyleBackColor = true;
            this.cmdQuerySAP.Click += new System.EventHandler(this.cmdQuerySAP_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(3, 4);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(109, 23);
            this.cmdReload.TabIndex = 2;
            this.cmdReload.Text = "Reload DB Data";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdClose);
            this.panel4.Controls.Add(this.cmdSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(791, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 30);
            this.panel4.TabIndex = 6;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(93, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(83, 23);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(3, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(84, 23);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save to DB";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pgbSAP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(681, 426);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 12);
            this.panel3.TabIndex = 5;
            // 
            // pgbSAP
            // 
            this.pgbSAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbSAP.Location = new System.Drawing.Point(0, 0);
            this.pgbSAP.Name = "pgbSAP";
            this.pgbSAP.Size = new System.Drawing.Size(104, 12);
            this.pgbSAP.TabIndex = 4;
            this.pgbSAP.Visible = false;
            // 
            // formPriceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPriceQuery";
            this.Text = "Component Price Update";
            this.Load += new System.EventHandler(this.formPriceQuery_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSAP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Button cmdQuerySAP;
        private System.Windows.Forms.ProgressBar pgbSAP;
        private System.Windows.Forms.Button cmdQueryPO;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}