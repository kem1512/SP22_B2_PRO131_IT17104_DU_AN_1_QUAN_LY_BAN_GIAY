namespace GUI_PresentationLayer.View
{
    partial class FrmStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_Revenue = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlTurnover = new System.Windows.Forms.Panel();
            this.dgdtpcDateBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.dgdtpcDateEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblTurnover = new System.Windows.Forms.Label();
            this.sctnBot = new System.Windows.Forms.SplitContainer();
            this.dgrid_Brand = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.dgrid_Cancel = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Revenue)).BeginInit();
            this.pnlTurnover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).BeginInit();
            this.sctnBot.Panel1.SuspendLayout();
            this.sctnBot.Panel2.SuspendLayout();
            this.sctnBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Brand)).BeginInit();
            this.pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Cancel)).BeginInit();
            this.pnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1466, 118);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgrid_Revenue);
            this.panel2.Controls.Add(this.pnlTurnover);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1442, 311);
            this.panel2.TabIndex = 2;
            // 
            // dgrid_Revenue
            // 
            this.dgrid_Revenue.AllowUserToAddRows = false;
            this.dgrid_Revenue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_Revenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_Revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Revenue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgrid_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Revenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Revenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_Revenue.ColumnHeadersHeight = 50;
            this.dgrid_Revenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgrid_Revenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Revenue.DoubleBuffered = true;
            this.dgrid_Revenue.EnableHeadersVisualStyles = false;
            this.dgrid_Revenue.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgrid_Revenue.HeaderForeColor = System.Drawing.Color.White;
            this.dgrid_Revenue.Location = new System.Drawing.Point(0, 84);
            this.dgrid_Revenue.Name = "dgrid_Revenue";
            this.dgrid_Revenue.ReadOnly = true;
            this.dgrid_Revenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrid_Revenue.RowHeadersWidth = 51;
            this.dgrid_Revenue.RowTemplate.Height = 24;
            this.dgrid_Revenue.Size = new System.Drawing.Size(1440, 225);
            this.dgrid_Revenue.StandardTab = true;
            this.dgrid_Revenue.TabIndex = 5;
            // 
            // pnlTurnover
            // 
            this.pnlTurnover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTurnover.Controls.Add(this.dgdtpcDateBegin);
            this.pnlTurnover.Controls.Add(this.lblDateBegin);
            this.pnlTurnover.Controls.Add(this.dgdtpcDateEnd);
            this.pnlTurnover.Controls.Add(this.lblDateEnd);
            this.pnlTurnover.Controls.Add(this.lblTurnover);
            this.pnlTurnover.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTurnover.Location = new System.Drawing.Point(0, 0);
            this.pnlTurnover.Name = "pnlTurnover";
            this.pnlTurnover.Size = new System.Drawing.Size(1440, 84);
            this.pnlTurnover.TabIndex = 4;
            // 
            // dgdtpcDateBegin
            // 
            this.dgdtpcDateBegin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgdtpcDateBegin.BackColor = System.Drawing.Color.SeaGreen;
            this.dgdtpcDateBegin.BorderRadius = 0;
            this.dgdtpcDateBegin.ForeColor = System.Drawing.Color.White;
            this.dgdtpcDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dgdtpcDateBegin.FormatCustom = null;
            this.dgdtpcDateBegin.Location = new System.Drawing.Point(490, 17);
            this.dgdtpcDateBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdtpcDateBegin.Name = "dgdtpcDateBegin";
            this.dgdtpcDateBegin.Size = new System.Drawing.Size(335, 48);
            this.dgdtpcDateBegin.TabIndex = 7;
            this.dgdtpcDateBegin.Value = new System.DateTime(2022, 3, 21, 10, 20, 29, 183);
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBegin.Location = new System.Drawing.Point(367, 29);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(84, 25);
            this.lblDateBegin.TabIndex = 6;
            this.lblDateBegin.Text = "Từ ngày";
            // 
            // dgdtpcDateEnd
            // 
            this.dgdtpcDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgdtpcDateEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.dgdtpcDateEnd.BorderRadius = 0;
            this.dgdtpcDateEnd.ForeColor = System.Drawing.Color.White;
            this.dgdtpcDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dgdtpcDateEnd.FormatCustom = null;
            this.dgdtpcDateEnd.Location = new System.Drawing.Point(1043, 17);
            this.dgdtpcDateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdtpcDateEnd.Name = "dgdtpcDateEnd";
            this.dgdtpcDateEnd.Size = new System.Drawing.Size(335, 48);
            this.dgdtpcDateEnd.TabIndex = 5;
            this.dgdtpcDateEnd.Value = new System.DateTime(2022, 3, 21, 10, 20, 29, 183);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnd.Location = new System.Drawing.Point(920, 29);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(96, 25);
            this.lblDateEnd.TabIndex = 2;
            this.lblDateEnd.Text = "Đến ngày";
            // 
            // lblTurnover
            // 
            this.lblTurnover.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnover.Location = new System.Drawing.Point(0, 0);
            this.lblTurnover.Name = "lblTurnover";
            this.lblTurnover.Size = new System.Drawing.Size(192, 82);
            this.lblTurnover.TabIndex = 0;
            this.lblTurnover.Text = "Doanh thu";
            this.lblTurnover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sctnBot
            // 
            this.sctnBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sctnBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sctnBot.Location = new System.Drawing.Point(13, 438);
            this.sctnBot.Name = "sctnBot";
            // 
            // sctnBot.Panel1
            // 
            this.sctnBot.Panel1.Controls.Add(this.dgrid_Brand);
            this.sctnBot.Panel1.Controls.Add(this.pnlBrand);
            // 
            // sctnBot.Panel2
            // 
            this.sctnBot.Panel2.Controls.Add(this.dgrid_Cancel);
            this.sctnBot.Panel2.Controls.Add(this.pnlCancel);
            this.sctnBot.Size = new System.Drawing.Size(1440, 318);
            this.sctnBot.SplitterDistance = 736;
            this.sctnBot.SplitterWidth = 10;
            this.sctnBot.TabIndex = 3;
            // 
            // dgrid_Brand
            // 
            this.dgrid_Brand.AllowUserToAddRows = false;
            this.dgrid_Brand.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_Brand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_Brand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Brand.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgrid_Brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Brand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Brand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_Brand.ColumnHeadersHeight = 50;
            this.dgrid_Brand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgrid_Brand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Brand.DoubleBuffered = true;
            this.dgrid_Brand.EnableHeadersVisualStyles = false;
            this.dgrid_Brand.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgrid_Brand.HeaderForeColor = System.Drawing.Color.White;
            this.dgrid_Brand.Location = new System.Drawing.Point(0, 60);
            this.dgrid_Brand.Name = "dgrid_Brand";
            this.dgrid_Brand.ReadOnly = true;
            this.dgrid_Brand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrid_Brand.RowHeadersWidth = 51;
            this.dgrid_Brand.RowTemplate.Height = 24;
            this.dgrid_Brand.Size = new System.Drawing.Size(734, 256);
            this.dgrid_Brand.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 108.3779F;
            this.Column1.HeaderText = "Mã hoá đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 108.3779F;
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 74.86631F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrand.Controls.Add(this.cmbFilter);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(734, 60);
            this.pnlBrand.TabIndex = 0;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(495, 9);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(215, 39);
            this.cmbFilter.TabIndex = 2;
            this.cmbFilter.SelectionChangeCommitted += new System.EventHandler(this.cmbFilter_SelectionChangeCommitted);
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(42, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(256, 25);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Số giày bán được theo hãng";
            // 
            // dgrid_Cancel
            // 
            this.dgrid_Cancel.AllowUserToAddRows = false;
            this.dgrid_Cancel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_Cancel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_Cancel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Cancel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgrid_Cancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Cancel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Cancel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid_Cancel.ColumnHeadersHeight = 50;
            this.dgrid_Cancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgrid_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Cancel.DoubleBuffered = true;
            this.dgrid_Cancel.EnableHeadersVisualStyles = false;
            this.dgrid_Cancel.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgrid_Cancel.HeaderForeColor = System.Drawing.Color.White;
            this.dgrid_Cancel.Location = new System.Drawing.Point(0, 60);
            this.dgrid_Cancel.Name = "dgrid_Cancel";
            this.dgrid_Cancel.ReadOnly = true;
            this.dgrid_Cancel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrid_Cancel.RowHeadersWidth = 51;
            this.dgrid_Cancel.RowTemplate.Height = 24;
            this.dgrid_Cancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Cancel.Size = new System.Drawing.Size(692, 256);
            this.dgrid_Cancel.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã hoá đơn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên khách hàng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lí do huỷ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giá trị hoá đơn";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // pnlCancel
            // 
            this.pnlCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancel.Controls.Add(this.lblCancel);
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCancel.Location = new System.Drawing.Point(0, 0);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(692, 60);
            this.pnlCancel.TabIndex = 1;
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(42, 18);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(154, 25);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = "Đơn hàng bị hủy";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã nhân viên";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mã hoá đơn";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ngày đặt hàng";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Giá trị hoá đơn";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1466, 768);
            this.Controls.Add(this.sctnBot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Revenue)).EndInit();
            this.pnlTurnover.ResumeLayout(false);
            this.pnlTurnover.PerformLayout();
            this.sctnBot.Panel1.ResumeLayout(false);
            this.sctnBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).EndInit();
            this.sctnBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Brand)).EndInit();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Cancel)).EndInit();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTurnover;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.SplitContainer sctnBot;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Panel pnlTurnover;
        private Bunifu.Framework.UI.BunifuDatepicker dgdtpcDateEnd;
        private Bunifu.Framework.UI.BunifuDatepicker dgdtpcDateBegin;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgrid_Revenue;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgrid_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgrid_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}