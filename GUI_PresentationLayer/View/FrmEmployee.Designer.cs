namespace GUI_PresentationLayer.View
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbxProduct = new FontAwesome.Sharp.IconPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnStaff = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.tlpBot = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.dgdtpcStaff = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.dgridProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            this.tlpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.tlpLeft.SuspendLayout();
            this.tlpBot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtEmail, 2);
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(5, 405);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 34);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackColor = System.Drawing.Color.White;
            this.pbxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpLeft.SetColumnSpan(this.pbxProduct, 2);
            this.pbxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbxProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxProduct.IconSize = 264;
            this.pbxProduct.Location = new System.Drawing.Point(3, 3);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(344, 264);
            this.pbxProduct.TabIndex = 0;
            this.pbxProduct.TabStop = false;
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
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 378);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.AutoSize = true;
            this.tlpLeft.SetColumnSpan(this.lblPassword, 2);
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 465);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(191, 22);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Mật khẩu đăng nhập";
            // 
            // tlpFilter
            // 
            this.tlpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFilter.ColumnCount = 4;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.Controls.Add(this.comboBox6, 0, 0);
            this.tlpFilter.Controls.Add(this.comboBox7, 2, 0);
            this.tlpFilter.Controls.Add(this.comboBox8, 1, 0);
            this.tlpFilter.Controls.Add(this.lblFilter, 0, 0);
            this.tlpFilter.Location = new System.Drawing.Point(448, 19);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(566, 62);
            this.tlpFilter.TabIndex = 34;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(87, 14);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(154, 33);
            this.comboBox6.TabIndex = 28;
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(407, 14);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(156, 33);
            this.comboBox7.TabIndex = 27;
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(247, 14);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(154, 33);
            this.comboBox8.TabIndex = 26;
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
            this.pbxSearch.Location = new System.Drawing.Point(24, 29);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(95, 45);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 33;
            this.pbxSearch.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(127, 33);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 41);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tlpLeft
            // 
            this.tlpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.ColumnCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpLeft.Controls.Add(this.btnEdit, 0, 7);
            this.tlpLeft.Controls.Add(this.txtEmail, 0, 4);
            this.tlpLeft.Controls.Add(this.pbxProduct, 0, 0);
            this.tlpLeft.Controls.Add(this.lblName, 0, 1);
            this.tlpLeft.Controls.Add(this.lblEmail, 0, 3);
            this.tlpLeft.Controls.Add(this.lblPassword, 0, 5);
            this.tlpLeft.Controls.Add(this.txtPassword, 0, 6);
            this.tlpLeft.Controls.Add(this.txtName, 0, 2);
            this.tlpLeft.Controls.Add(this.btnAdd, 0, 7);
            this.tlpLeft.Location = new System.Drawing.Point(1043, 91);
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
            this.tlpLeft.TabIndex = 31;
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
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(5, 492);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 34);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLeft.SetColumnSpan(this.txtName, 2);
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // rbtnMale
            // 
            this.rbtnMale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(21, 33);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(68, 26);
            this.rbtnMale.TabIndex = 23;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnStaff
            // 
            this.rbtnStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnStaff.AutoSize = true;
            this.rbtnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStaff.Location = new System.Drawing.Point(139, 33);
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.Size = new System.Drawing.Size(112, 26);
            this.rbtnStaff.TabIndex = 26;
            this.rbtnStaff.TabStop = true;
            this.rbtnStaff.Text = "Nhân viên";
            this.rbtnStaff.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdmin.Location = new System.Drawing.Point(18, 33);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(93, 26);
            this.rbtnAdmin.TabIndex = 25;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Quản lý";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(3, 138);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 22);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Giới tính";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(129, 35);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(54, 26);
            this.rbtnFemale.TabIndex = 24;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // tlpBot
            // 
            this.tlpBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBot.ColumnCount = 6;
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.980039F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.35329F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.083833F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.14771F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.66866F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpBot.Controls.Add(this.txtPhone, 2, 1);
            this.tlpBot.Controls.Add(this.lblAddress, 0, 0);
            this.tlpBot.Controls.Add(this.lblPhone, 2, 0);
            this.tlpBot.Controls.Add(this.lblDate, 4, 0);
            this.tlpBot.Controls.Add(this.txtAddress, 0, 1);
            this.tlpBot.Controls.Add(this.lblRoles, 2, 2);
            this.tlpBot.Controls.Add(this.dgdtpcStaff, 4, 1);
            this.tlpBot.Controls.Add(this.panel1, 1, 2);
            this.tlpBot.Controls.Add(this.lblGender, 0, 2);
            this.tlpBot.Controls.Add(this.panel2, 3, 2);
            this.tlpBot.Location = new System.Drawing.Point(27, 506);
            this.tlpBot.Name = "tlpBot";
            this.tlpBot.RowCount = 3;
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.37164F));
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.63819F));
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.24623F));
            this.tlpBot.Size = new System.Drawing.Size(987, 199);
            this.tlpBot.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpBot.SetColumnSpan(this.txtPhone, 2);
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
            this.txtPhone.Location = new System.Drawing.Point(333, 51);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(324, 44);
            this.txtPhone.TabIndex = 29;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 22);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhone.AutoSize = true;
            this.tlpBot.SetColumnSpan(this.lblPhone, 2);
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(331, 24);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 22);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(668, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 22);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Ngày sinh";
            // 
            // txtAddress
            // 
            this.tlpBot.SetColumnSpan(this.txtAddress, 2);
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
            this.txtAddress.Location = new System.Drawing.Point(5, 51);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(318, 43);
            this.txtAddress.TabIndex = 22;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRoles
            // 
            this.lblRoles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(331, 138);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(69, 22);
            this.lblRoles.TabIndex = 20;
            this.lblRoles.Text = "Vai trò";
            // 
            // dgdtpcStaff
            // 
            this.dgdtpcStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdtpcStaff.BackColor = System.Drawing.Color.SeaGreen;
            this.dgdtpcStaff.BorderRadius = 0;
            this.tlpBot.SetColumnSpan(this.dgdtpcStaff, 2);
            this.dgdtpcStaff.ForeColor = System.Drawing.Color.White;
            this.dgdtpcStaff.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dgdtpcStaff.FormatCustom = null;
            this.dgdtpcStaff.Location = new System.Drawing.Point(669, 52);
            this.dgdtpcStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdtpcStaff.Name = "dgdtpcStaff";
            this.dgdtpcStaff.Size = new System.Drawing.Size(314, 44);
            this.dgdtpcStaff.TabIndex = 28;
            this.dgdtpcStaff.Value = new System.DateTime(2022, 3, 21, 11, 0, 16, 508);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(101, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 93);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnAdmin);
            this.panel2.Controls.Add(this.rbtnStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(410, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 93);
            this.panel2.TabIndex = 31;
            // 
            // gbxProduct
            // 
            this.gbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProduct.Controls.Add(this.dgridProduct);
            this.gbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProduct.Location = new System.Drawing.Point(24, 91);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(990, 396);
            this.gbxProduct.TabIndex = 35;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Sản phẩm";
            // 
            // dgridProduct
            // 
            this.dgridProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridProduct.DoubleBuffered = true;
            this.dgridProduct.EnableHeadersVisualStyles = false;
            this.dgridProduct.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridProduct.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgridProduct.Location = new System.Drawing.Point(3, 33);
            this.dgridProduct.Name = "dgridProduct";
            this.dgridProduct.ReadOnly = true;
            this.dgridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridProduct.RowHeadersWidth = 51;
            this.dgridProduct.RowTemplate.Height = 24;
            this.dgridProduct.Size = new System.Drawing.Size(984, 357);
            this.dgridProduct.TabIndex = 0;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1405, 755);
            this.Controls.Add(this.tlpFilter);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tlpLeft);
            this.Controls.Add(this.tlpBot);
            this.Controls.Add(this.gbxProduct);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.tlpBot.ResumeLayout(false);
            this.tlpBot.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private FontAwesome.Sharp.IconPictureBox pbxProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox pbxSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tlpBot;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnStaff;
        private Bunifu.Framework.UI.BunifuDatepicker dgdtpcStaff;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.GroupBox gbxProduct;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridProduct;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
    }
}