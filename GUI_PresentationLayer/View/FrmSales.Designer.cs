﻿namespace GUI_PresentationLayer.View
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShipCost = new System.Windows.Forms.Label();
            this.lblShipper = new System.Windows.Forms.Label();
            this.lblTotalPriceLeft = new System.Windows.Forms.Label();
            this.lblMoneyGiveLeft = new System.Windows.Forms.Label();
            this.lblMoneyLeftLeft = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtShipCost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblTotalPriceRight = new System.Windows.Forms.Label();
            this.lblMoneyGiveRight = new System.Windows.Forms.Label();
            this.lblMoneyLeftRight = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.dgridProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.dgridOrder = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnViewOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.tlpRight.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).BeginInit();
            this.gbxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridOrder)).BeginInit();
            this.tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Location = new System.Drawing.Point(134, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 41);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tlpRight
            // 
            this.tlpRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRight.ColumnCount = 3;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.23457F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.76543F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpRight.Controls.Add(this.cmbShipper, 1, 5);
            this.tlpRight.Controls.Add(this.txtPhone, 1, 2);
            this.tlpRight.Controls.Add(this.txtAddress, 1, 1);
            this.tlpRight.Controls.Add(this.lblAddress, 0, 1);
            this.tlpRight.Controls.Add(this.lblName, 0, 0);
            this.tlpRight.Controls.Add(this.lblPhone, 0, 2);
            this.tlpRight.Controls.Add(this.label4, 0, 3);
            this.tlpRight.Controls.Add(this.lblShipCost, 0, 4);
            this.tlpRight.Controls.Add(this.lblShipper, 0, 5);
            this.tlpRight.Controls.Add(this.lblTotalPriceLeft, 0, 6);
            this.tlpRight.Controls.Add(this.lblMoneyGiveLeft, 0, 7);
            this.tlpRight.Controls.Add(this.lblMoneyLeftLeft, 0, 8);
            this.tlpRight.Controls.Add(this.radioButton1, 1, 3);
            this.tlpRight.Controls.Add(this.radioButton2, 2, 3);
            this.tlpRight.Controls.Add(this.txtShipCost, 1, 4);
            this.tlpRight.Controls.Add(this.cmbName, 1, 0);
            this.tlpRight.Controls.Add(this.btnConfirm, 0, 9);
            this.tlpRight.Controls.Add(this.btnOk, 1, 9);
            this.tlpRight.Controls.Add(this.lblCancel, 2, 9);
            this.tlpRight.Controls.Add(this.lblTotalPriceRight, 1, 6);
            this.tlpRight.Controls.Add(this.lblMoneyGiveRight, 1, 7);
            this.tlpRight.Controls.Add(this.lblMoneyLeftRight, 1, 8);
            this.tlpRight.Location = new System.Drawing.Point(1050, 75);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 10;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.42971F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4297F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4297F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4297F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4297F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4297F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.343763F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.343763F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.343763F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39049F));
            this.tlpRight.Size = new System.Drawing.Size(458, 670);
            this.tlpRight.TabIndex = 0;
            // 
            // cmbShipper
            // 
            this.cmbShipper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpRight.SetColumnSpan(this.cmbShipper, 2);
            this.cmbShipper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(177, 359);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(276, 39);
            this.cmbShipper.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpRight.SetColumnSpan(this.txtPhone, 2);
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhone.LineThickness = 4;
            this.txtPhone.Location = new System.Drawing.Point(179, 152);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(272, 41);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpRight.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddress.LineThickness = 4;
            this.txtAddress.Location = new System.Drawing.Point(179, 83);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 41);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(3, 92);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 22);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(3, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Khách hàng";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(3, 161);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 22);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nơi nhận hàng";
            // 
            // lblShipCost
            // 
            this.lblShipCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShipCost.AutoSize = true;
            this.lblShipCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblShipCost.Location = new System.Drawing.Point(3, 299);
            this.lblShipCost.Name = "lblShipCost";
            this.lblShipCost.Size = new System.Drawing.Size(147, 22);
            this.lblShipCost.TabIndex = 5;
            this.lblShipCost.Text = "Phí vận chuyển";
            // 
            // lblShipper
            // 
            this.lblShipper.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShipper.AutoSize = true;
            this.lblShipper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblShipper.Location = new System.Drawing.Point(3, 368);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(79, 22);
            this.lblShipper.TabIndex = 6;
            this.lblShipper.Text = "Shipper";
            // 
            // lblTotalPriceLeft
            // 
            this.lblTotalPriceLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalPriceLeft.AutoSize = true;
            this.lblTotalPriceLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceLeft.Location = new System.Drawing.Point(3, 430);
            this.lblTotalPriceLeft.Name = "lblTotalPriceLeft";
            this.lblTotalPriceLeft.Size = new System.Drawing.Size(95, 22);
            this.lblTotalPriceLeft.TabIndex = 7;
            this.lblTotalPriceLeft.Text = "Tổng tiền";
            // 
            // lblMoneyGiveLeft
            // 
            this.lblMoneyGiveLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMoneyGiveLeft.AutoSize = true;
            this.lblMoneyGiveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMoneyGiveLeft.Location = new System.Drawing.Point(3, 485);
            this.lblMoneyGiveLeft.Name = "lblMoneyGiveLeft";
            this.lblMoneyGiveLeft.Size = new System.Drawing.Size(105, 22);
            this.lblMoneyGiveLeft.TabIndex = 8;
            this.lblMoneyGiveLeft.Text = "Khách đưa";
            // 
            // lblMoneyLeftLeft
            // 
            this.lblMoneyLeftLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMoneyLeftLeft.AutoSize = true;
            this.lblMoneyLeftLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMoneyLeftLeft.Location = new System.Drawing.Point(3, 540);
            this.lblMoneyLeftLeft.Name = "lblMoneyLeftLeft";
            this.lblMoneyLeftLeft.Size = new System.Drawing.Size(95, 22);
            this.lblMoneyLeftLeft.TabIndex = 9;
            this.lblMoneyLeftLeft.Text = "Tiền thừa";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(191, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 22);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tại cửa hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(339, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 22);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ship hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtShipCost
            // 
            this.txtShipCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpRight.SetColumnSpan(this.txtShipCost, 2);
            this.txtShipCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShipCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShipCost.HintForeColor = System.Drawing.Color.Empty;
            this.txtShipCost.HintText = "";
            this.txtShipCost.isPassword = false;
            this.txtShipCost.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtShipCost.LineIdleColor = System.Drawing.Color.Gray;
            this.txtShipCost.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtShipCost.LineThickness = 4;
            this.txtShipCost.Location = new System.Drawing.Point(179, 290);
            this.txtShipCost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtShipCost.Name = "txtShipCost";
            this.txtShipCost.Size = new System.Drawing.Size(272, 41);
            this.txtShipCost.TabIndex = 15;
            this.txtShipCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbName
            // 
            this.cmbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpRight.SetColumnSpan(this.cmbName, 2);
            this.cmbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(177, 19);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(276, 30);
            this.cmbName.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.White;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Xác nhận";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.White;
            this.btnConfirm.IdleForecolor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(5, 584);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(162, 67);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.ActiveBorderThickness = 1;
            this.btnOk.ActiveCornerRadius = 20;
            this.btnOk.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOk.ActiveForecolor = System.Drawing.Color.White;
            this.btnOk.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.ButtonText = "Thanh toán";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleCornerRadius = 20;
            this.btnOk.IdleFillColor = System.Drawing.Color.White;
            this.btnOk.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOk.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOk.Location = new System.Drawing.Point(177, 584);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(154, 67);
            this.btnOk.TabIndex = 21;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCancel
            // 
            this.lblCancel.ActiveBorderThickness = 1;
            this.lblCancel.ActiveCornerRadius = 20;
            this.lblCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.lblCancel.ActiveForecolor = System.Drawing.Color.White;
            this.lblCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.lblCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCancel.BackColor = System.Drawing.Color.White;
            this.lblCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblCancel.BackgroundImage")));
            this.lblCancel.ButtonText = "Hủy";
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblCancel.IdleBorderThickness = 1;
            this.lblCancel.IdleCornerRadius = 20;
            this.lblCancel.IdleFillColor = System.Drawing.Color.White;
            this.lblCancel.IdleForecolor = System.Drawing.Color.Red;
            this.lblCancel.IdleLineColor = System.Drawing.Color.Red;
            this.lblCancel.Location = new System.Drawing.Point(346, 584);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(5);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(101, 67);
            this.lblCancel.TabIndex = 22;
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceRight
            // 
            this.lblTotalPriceRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalPriceRight.AutoSize = true;
            this.lblTotalPriceRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceRight.Location = new System.Drawing.Point(175, 430);
            this.lblTotalPriceRight.Name = "lblTotalPriceRight";
            this.lblTotalPriceRight.Size = new System.Drawing.Size(68, 22);
            this.lblTotalPriceRight.TabIndex = 24;
            this.lblTotalPriceRight.Text = "0 VNĐ";
            // 
            // lblMoneyGiveRight
            // 
            this.lblMoneyGiveRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMoneyGiveRight.AutoSize = true;
            this.lblMoneyGiveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMoneyGiveRight.Location = new System.Drawing.Point(175, 485);
            this.lblMoneyGiveRight.Name = "lblMoneyGiveRight";
            this.lblMoneyGiveRight.Size = new System.Drawing.Size(68, 22);
            this.lblMoneyGiveRight.TabIndex = 25;
            this.lblMoneyGiveRight.Text = "0 VNĐ";
            // 
            // lblMoneyLeftRight
            // 
            this.lblMoneyLeftRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMoneyLeftRight.AutoSize = true;
            this.lblMoneyLeftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMoneyLeftRight.Location = new System.Drawing.Point(175, 540);
            this.lblMoneyLeftRight.Name = "lblMoneyLeftRight";
            this.lblMoneyLeftRight.Size = new System.Drawing.Size(68, 22);
            this.lblMoneyLeftRight.TabIndex = 26;
            this.lblMoneyLeftRight.Text = "0 VNĐ";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProduct.Controls.Add(this.dgridProduct);
            this.gbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProduct.Location = new System.Drawing.Point(25, 72);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(1002, 336);
            this.gbxProduct.TabIndex = 6;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Sản phẩm";
            // 
            // dgridProduct
            // 
            this.dgridProduct.AllowUserToAddRows = false;
            this.dgridProduct.AllowUserToDeleteRows = false;
            this.dgridProduct.AllowUserToResizeColumns = false;
            this.dgridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridProduct.ColumnHeadersHeight = 50;
            this.dgridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgridProduct.DoubleBuffered = true;
            this.dgridProduct.EnableHeadersVisualStyles = false;
            this.dgridProduct.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dgridProduct.Location = new System.Drawing.Point(3, 34);
            this.dgridProduct.MultiSelect = false;
            this.dgridProduct.Name = "dgridProduct";
            this.dgridProduct.ReadOnly = true;
            this.dgridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridProduct.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgridProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridProduct.RowTemplate.Height = 110;
            this.dgridProduct.Size = new System.Drawing.Size(996, 296);
            this.dgridProduct.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Ảnh";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "Kho";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 20F;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbxOrder
            // 
            this.gbxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOrder.Controls.Add(this.dgridOrder);
            this.gbxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrder.Location = new System.Drawing.Point(28, 422);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(1002, 326);
            this.gbxOrder.TabIndex = 7;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Đơn hàng";
            // 
            // dgridOrder
            // 
            this.dgridOrder.AllowUserToAddRows = false;
            this.dgridOrder.AllowUserToDeleteRows = false;
            this.dgridOrder.AllowUserToResizeColumns = false;
            this.dgridOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgridOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgridOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgridOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgridOrder.ColumnHeadersHeight = 50;
            this.dgridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column6,
            this.dataGridViewImageColumn2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgridOrder.DoubleBuffered = true;
            this.dgridOrder.EnableHeadersVisualStyles = false;
            this.dgridOrder.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridOrder.HeaderForeColor = System.Drawing.Color.White;
            this.dgridOrder.Location = new System.Drawing.Point(3, 26);
            this.dgridOrder.MultiSelect = false;
            this.dgridOrder.Name = "dgridOrder";
            this.dgridOrder.ReadOnly = true;
            this.dgridOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgridOrder.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgridOrder.RowTemplate.Height = 100;
            this.dgridOrder.Size = new System.Drawing.Size(996, 297);
            this.dgridOrder.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Ảnh";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tổng tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 25F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.ActiveBorderThickness = 1;
            this.btnViewOrder.ActiveCornerRadius = 20;
            this.btnViewOrder.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewOrder.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewOrder.BackColor = System.Drawing.Color.White;
            this.btnViewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewOrder.BackgroundImage")));
            this.btnViewOrder.ButtonText = "Xem hóa đơn chờ";
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.IdleBorderThickness = 1;
            this.btnViewOrder.IdleCornerRadius = 20;
            this.btnViewOrder.IdleFillColor = System.Drawing.Color.White;
            this.btnViewOrder.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.Location = new System.Drawing.Point(1286, 3);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(222, 62);
            this.btnViewOrder.TabIndex = 23;
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // tlpFilter
            // 
            this.tlpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFilter.ColumnCount = 4;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.Controls.Add(this.cmbBrand, 0, 0);
            this.tlpFilter.Controls.Add(this.cmbPrice, 2, 0);
            this.tlpFilter.Controls.Add(this.cmbColor, 1, 0);
            this.tlpFilter.Controls.Add(this.lblFilter, 0, 0);
            this.tlpFilter.Location = new System.Drawing.Point(464, 8);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(566, 62);
            this.tlpFilter.TabIndex = 24;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(87, 14);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(154, 33);
            this.cmbBrand.TabIndex = 28;
            // 
            // cmbPrice
            // 
            this.cmbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(407, 14);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(156, 33);
            this.cmbPrice.TabIndex = 27;
            // 
            // cmbColor
            // 
            this.cmbColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(247, 14);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(154, 33);
            this.cmbColor.TabIndex = 26;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(22, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(40, 20);
            this.lblFilter.TabIndex = 25;
            this.lblFilter.Text = "Lọc";
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(31, 16);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(95, 45);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 25;
            this.pbxSearch.TabStop = false;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 760);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tlpFilter);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.gbxOrder);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tlpRight);
            this.Controls.Add(this.gbxProduct);
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).EndInit();
            this.gbxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridOrder)).EndInit();
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShipCost;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.Label lblTotalPriceLeft;
        private System.Windows.Forms.Label lblMoneyGiveLeft;
        private System.Windows.Forms.Label lblMoneyLeftLeft;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtShipCost;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbxProduct;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridProduct;
        private System.Windows.Forms.GroupBox gbxOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridOrder;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.ComboBox cmbName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        private Bunifu.Framework.UI.BunifuThinButton2 lblCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewOrder;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cmbShipper;
        private System.Windows.Forms.Label lblTotalPriceRight;
        private System.Windows.Forms.Label lblMoneyGiveRight;
        private System.Windows.Forms.Label lblMoneyLeftRight;
    }
}