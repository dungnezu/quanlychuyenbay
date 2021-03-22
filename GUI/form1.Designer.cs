namespace GUI
{
    partial class form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutbound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFlight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboSortBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancelFlight = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEditFlight = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnImportChanges = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flightnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aircraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Economyprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Businessprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstclassprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 137);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 62);
            this.panel1.TabIndex = 0;
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(123, 20);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(121, 21);
            this.cboFrom.TabIndex = 1;
            this.cboFrom.SelectedIndexChanged += new System.EventHandler(this.cboFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutbound);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 63);
            this.panel2.TabIndex = 1;
            // 
            // txtOutbound
            // 
            this.txtOutbound.Location = new System.Drawing.Point(123, 23);
            this.txtOutbound.Name = "txtOutbound";
            this.txtOutbound.Size = new System.Drawing.Size(121, 20);
            this.txtOutbound.TabIndex = 1;
            this.txtOutbound.TextChanged += new System.EventHandler(this.txtOutbound_TextChanged);
            this.txtOutbound.MouseLeave += new System.EventHandler(this.txtOutbound_MouseLeave);
            this.txtOutbound.MouseHover += new System.EventHandler(this.txtOutbound_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Outbound";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboTo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(312, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 62);
            this.panel3.TabIndex = 2;
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(89, 20);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(121, 21);
            this.cboTo.TabIndex = 1;
            this.cboTo.SelectedIndexChanged += new System.EventHandler(this.cboTo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "To";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFlight);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(312, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 63);
            this.panel4.TabIndex = 3;
            // 
            // txtFlight
            // 
            this.txtFlight.Location = new System.Drawing.Point(101, 21);
            this.txtFlight.Name = "txtFlight";
            this.txtFlight.Size = new System.Drawing.Size(109, 20);
            this.txtFlight.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flight Number";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboSortBy);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(543, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 62);
            this.panel5.TabIndex = 4;
            // 
            // cboSortBy
            // 
            this.cboSortBy.FormattingEnabled = true;
            this.cboSortBy.Items.AddRange(new object[] {
            "Date time",
            "Economy price",
            "Confirmed"});
            this.cboSortBy.Location = new System.Drawing.Point(89, 20);
            this.cboSortBy.Name = "cboSortBy";
            this.cboSortBy.Size = new System.Drawing.Size(121, 21);
            this.cboSortBy.TabIndex = 1;
            this.cboSortBy.SelectedIndexChanged += new System.EventHandler(this.cboSortBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sort by";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnApply);
            this.panel6.Location = new System.Drawing.Point(543, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 63);
            this.panel6.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(75, 21);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvDATA);
            this.panel7.Location = new System.Drawing.Point(3, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(785, 204);
            this.panel7.TabIndex = 1;
            // 
            // dgvDATA
            // 
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.FROMS,
            this.TOS,
            this.Flightnumber,
            this.Aircraft,
            this.Economyprice,
            this.Businessprice,
            this.Firstclassprice});
            this.dgvDATA.Location = new System.Drawing.Point(9, 3);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDATA.Size = new System.Drawing.Size(750, 198);
            this.dgvDATA.TabIndex = 0;
            this.dgvDATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellClick);
            this.dgvDATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDATA_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 378);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(785, 69);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCancelFlight);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 63);
            this.panel8.TabIndex = 0;
            // 
            // btnCancelFlight
            // 
            this.btnCancelFlight.Image = global::GUI.Properties.Resources.icons8_cancel_24;
            this.btnCancelFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelFlight.Location = new System.Drawing.Point(35, 17);
            this.btnCancelFlight.Name = "btnCancelFlight";
            this.btnCancelFlight.Size = new System.Drawing.Size(101, 34);
            this.btnCancelFlight.TabIndex = 0;
            this.btnCancelFlight.Text = "Cancel Flight";
            this.btnCancelFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelFlight.UseVisualStyleBackColor = true;
            this.btnCancelFlight.Click += new System.EventHandler(this.btnCancelFlight_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnEditFlight);
            this.panel9.Location = new System.Drawing.Point(199, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 63);
            this.panel9.TabIndex = 1;
            // 
            // btnEditFlight
            // 
            this.btnEditFlight.Image = global::GUI.Properties.Resources.icons8_edit_24;
            this.btnEditFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFlight.Location = new System.Drawing.Point(48, 17);
            this.btnEditFlight.Name = "btnEditFlight";
            this.btnEditFlight.Size = new System.Drawing.Size(87, 34);
            this.btnEditFlight.TabIndex = 0;
            this.btnEditFlight.Text = "Edit Flight";
            this.btnEditFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFlight.UseVisualStyleBackColor = true;
            this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnImportChanges);
            this.panel10.Location = new System.Drawing.Point(395, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(387, 63);
            this.panel10.TabIndex = 2;
            // 
            // btnImportChanges
            // 
            this.btnImportChanges.Image = global::GUI.Properties.Resources.icons8_import_24;
            this.btnImportChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportChanges.Location = new System.Drawing.Point(195, 17);
            this.btnImportChanges.Name = "btnImportChanges";
            this.btnImportChanges.Size = new System.Drawing.Size(116, 34);
            this.btnImportChanges.TabIndex = 0;
            this.btnImportChanges.Text = "Import Changes";
            this.btnImportChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportChanges.UseVisualStyleBackColor = true;
            this.btnImportChanges.Click += new System.EventHandler(this.btnImportChanges_Click);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 70;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 55;
            // 
            // FROMS
            // 
            this.FROMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FROMS.DataPropertyName = "FROMS";
            this.FROMS.HeaderText = "From";
            this.FROMS.Name = "FROMS";
            this.FROMS.Width = 55;
            // 
            // TOS
            // 
            this.TOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TOS.DataPropertyName = "TOS";
            this.TOS.HeaderText = "To";
            this.TOS.Name = "TOS";
            this.TOS.Width = 45;
            // 
            // Flightnumber
            // 
            this.Flightnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Flightnumber.DataPropertyName = "Flightnumber";
            this.Flightnumber.HeaderText = "Flight number";
            this.Flightnumber.Name = "Flightnumber";
            this.Flightnumber.Width = 95;
            // 
            // Aircraft
            // 
            this.Aircraft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Aircraft.DataPropertyName = "Aircraft";
            this.Aircraft.HeaderText = "Aircraft";
            this.Aircraft.Name = "Aircraft";
            this.Aircraft.Width = 65;
            // 
            // Economyprice
            // 
            this.Economyprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Economyprice.DataPropertyName = "Economyprice";
            this.Economyprice.HeaderText = "Economy price";
            this.Economyprice.Name = "Economyprice";
            this.Economyprice.Width = 102;
            // 
            // Businessprice
            // 
            this.Businessprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Businessprice.DataPropertyName = "Businessprice";
            this.Businessprice.HeaderText = "Business price";
            this.Businessprice.Name = "Businessprice";
            // 
            // Firstclassprice
            // 
            this.Firstclassprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Firstclassprice.DataPropertyName = "Firstclassprice";
            this.Firstclassprice.HeaderText = "First class price";
            this.Firstclassprice.Name = "Firstclassprice";
            this.Firstclassprice.Width = 104;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "form1";
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFlight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboSortBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCancelFlight;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnEditFlight;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnImportChanges;
        private System.Windows.Forms.TextBox txtOutbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flightnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Economyprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Businessprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstclassprice;
    }
}

