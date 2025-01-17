﻿namespace GUI_PresentationLayer.View
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabDisable = new System.Windows.Forms.TabPage();
            this.dgridDisable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dgrid_Disabled = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgridCustomer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxProduct = new FontAwesome.Sharp.IconPictureBox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddMulti = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabDisable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDisable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Disabled)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.tlpLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(6, 547);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 62);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabDisable
            // 
            this.tabDisable.BackColor = System.Drawing.Color.White;
            this.tabDisable.Controls.Add(this.dgridDisable);
            this.tabDisable.Controls.Add(this.dgrid_Disabled);
            this.tabDisable.Location = new System.Drawing.Point(4, 34);
            this.tabDisable.Name = "tabDisable";
            this.tabDisable.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisable.Size = new System.Drawing.Size(1102, 405);
            this.tabDisable.TabIndex = 1;
            this.tabDisable.Text = "Đã xóa";
            // 
            // dgridDisable
            // 
            this.dgridDisable.AllowUserToAddRows = false;
            this.dgridDisable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgridDisable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridDisable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridDisable.BackgroundColor = System.Drawing.Color.White;
            this.dgridDisable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridDisable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridDisable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridDisable.ColumnHeadersHeight = 54;
            this.dgridDisable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewLinkColumn1,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridDisable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgridDisable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridDisable.DoubleBuffered = true;
            this.dgridDisable.EnableHeadersVisualStyles = false;
            this.dgridDisable.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridDisable.HeaderForeColor = System.Drawing.Color.White;
            this.dgridDisable.Location = new System.Drawing.Point(3, 3);
            this.dgridDisable.Name = "dgridDisable";
            this.dgridDisable.ReadOnly = true;
            this.dgridDisable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridDisable.RowHeadersWidth = 51;
            this.dgridDisable.RowTemplate.Height = 70;
            this.dgridDisable.Size = new System.Drawing.Size(1096, 399);
            this.dgridDisable.TabIndex = 1;
            this.dgridDisable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridDisable_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 116.5149F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 116.5149F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 116.5149F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 116.5149F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lần mua hàng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.FillWeight = 64.17112F;
            this.dataGridViewLinkColumn1.HeaderText = "";
            this.dataGridViewLinkColumn1.MinimumWidth = 4;
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 69.76938F;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dgrid_Disabled
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_Disabled.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_Disabled.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_Disabled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Disabled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Disabled.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_Disabled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Disabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Disabled.DoubleBuffered = true;
            this.dgrid_Disabled.EnableHeadersVisualStyles = false;
            this.dgrid_Disabled.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgrid_Disabled.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgrid_Disabled.Location = new System.Drawing.Point(3, 3);
            this.dgrid_Disabled.Name = "dgrid_Disabled";
            this.dgrid_Disabled.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrid_Disabled.RowHeadersWidth = 51;
            this.dgrid_Disabled.RowTemplate.Height = 24;
            this.dgrid_Disabled.Size = new System.Drawing.Size(1096, 399);
            this.dgrid_Disabled.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabDisable);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(220, 30);
            this.tabControl1.Location = new System.Drawing.Point(17, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 443);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 41;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.White;
            this.tabCustomer.Controls.Add(this.dgridCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 34);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1102, 405);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Khách hàng";
            // 
            // dgridCustomer
            // 
            this.dgridCustomer.AllowUserToAddRows = false;
            this.dgridCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgridCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgridCustomer.ColumnHeadersHeight = 54;
            this.dgridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.Phone,
            this.Address,
            this.Column5,
            this.Column6});
            this.dgridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridCustomer.DoubleBuffered = true;
            this.dgridCustomer.EnableHeadersVisualStyles = false;
            this.dgridCustomer.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgridCustomer.Location = new System.Drawing.Point(3, 3);
            this.dgridCustomer.Name = "dgridCustomer";
            this.dgridCustomer.ReadOnly = true;
            this.dgridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridCustomer.RowHeadersWidth = 51;
            this.dgridCustomer.RowTemplate.Height = 70;
            this.dgridCustomer.Size = new System.Drawing.Size(1096, 399);
            this.dgridCustomer.TabIndex = 0;
            this.dgridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridCustomer_CellClick);
            this.dgridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridCustomer_CellContentClick);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 378);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Số điện thoại";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.tlpLeft.SetColumnSpan(this.lblPassword, 2);
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 465);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 22);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Địa chỉ";
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackColor = System.Drawing.Color.White;
            this.pbxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpLeft.SetColumnSpan(this.pbxProduct, 2);
            this.pbxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxProduct.IconChar = FontAwesome.Sharp.IconChar.User;
            this.pbxProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxProduct.IconSize = 264;
            this.pbxProduct.Location = new System.Drawing.Point(3, 3);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(344, 264);
            this.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProduct.TabIndex = 0;
            this.pbxProduct.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtPhone, 2);
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(5, 405);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(340, 34);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.OnValueChanged += new System.EventHandler(this.txtPhone_OnValueChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 291);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ và tên";
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(18, 39);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(95, 45);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 39;
            this.pbxSearch.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtName, 2);
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(5, 318);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 34);
            this.txtName.TabIndex = 32;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 4;
            this.txtSearch.Location = new System.Drawing.Point(121, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 41);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            // 
            // tlpLeft
            // 
            this.tlpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.ColumnCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpLeft.Controls.Add(this.btnEdit, 0, 7);
            this.tlpLeft.Controls.Add(this.txtPhone, 0, 4);
            this.tlpLeft.Controls.Add(this.pbxProduct, 0, 0);
            this.tlpLeft.Controls.Add(this.lblName, 0, 1);
            this.tlpLeft.Controls.Add(this.lblEmail, 0, 3);
            this.tlpLeft.Controls.Add(this.lblPassword, 0, 5);
            this.tlpLeft.Controls.Add(this.txtAddress, 0, 6);
            this.tlpLeft.Controls.Add(this.txtName, 0, 2);
            this.tlpLeft.Controls.Add(this.btnAdd, 0, 7);
            this.tlpLeft.Location = new System.Drawing.Point(1159, 106);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 8;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.05755F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.119224F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.27383F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.119224F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.27383F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.119224F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.27383F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.76329F));
            this.tlpLeft.Size = new System.Drawing.Size(350, 614);
            this.tlpLeft.TabIndex = 37;
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.Red;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.Red;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.White;
            this.btnEdit.IdleForecolor = System.Drawing.Color.Red;
            this.btnEdit.IdleLineColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(180, 547);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 62);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 4;
            this.txtAddress.Location = new System.Drawing.Point(5, 492);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(340, 34);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddMulti
            // 
            this.btnAddMulti.ActiveBorderThickness = 1;
            this.btnAddMulti.ActiveCornerRadius = 20;
            this.btnAddMulti.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddMulti.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddMulti.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMulti.BackColor = System.Drawing.Color.White;
            this.btnAddMulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMulti.BackgroundImage")));
            this.btnAddMulti.ButtonText = "Thêm hàng loạt";
            this.btnAddMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMulti.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddMulti.IdleBorderThickness = 1;
            this.btnAddMulti.IdleCornerRadius = 20;
            this.btnAddMulti.IdleFillColor = System.Drawing.Color.White;
            this.btnAddMulti.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddMulti.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddMulti.Location = new System.Drawing.Point(1085, 14);
            this.btnAddMulti.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMulti.Name = "btnAddMulti";
            this.btnAddMulti.Size = new System.Drawing.Size(241, 62);
            this.btnAddMulti.TabIndex = 44;
            this.btnAddMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.ButtonText = "Xuất Excel";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleCornerRadius = 20;
            this.btnExcel.IdleFillColor = System.Drawing.Color.White;
            this.btnExcel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExcel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.Location = new System.Drawing.Point(1348, 14);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(161, 62);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Mã khách hàng";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số đơn đã đặt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1527, 755);
            this.Controls.Add(this.btnAddMulti);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tlpLeft);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.tabDisable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDisable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Disabled)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.TabPage tabDisable;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgrid_Disabled;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridCustomer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private FontAwesome.Sharp.IconPictureBox pbxProduct;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.PictureBox pbxSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridDisable;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddMulti;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
    }
}