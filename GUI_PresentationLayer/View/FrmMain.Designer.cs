namespace GUI_PresentationLayer.View
{
    partial class FrmMain
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.pbxLogout = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxEmployee = new System.Windows.Forms.PictureBox();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChild = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnHomeMain = new FontAwesome.Sharp.IconPictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.fpnlInvoice = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLeftBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            this.pnlBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1624, 17);
            this.pnlTopBar.TabIndex = 7;
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.AutoScroll = true;
            this.pnlLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlLeftBar.Controls.Add(this.btnReport);
            this.pnlLeftBar.Controls.Add(this.pbxLogout);
            this.pnlLeftBar.Controls.Add(this.btnCustomer);
            this.pnlLeftBar.Controls.Add(this.btnOrder);
            this.pnlLeftBar.Controls.Add(this.btnThongKe);
            this.pnlLeftBar.Controls.Add(this.btnStaff);
            this.pnlLeftBar.Controls.Add(this.btnProduct);
            this.pnlLeftBar.Controls.Add(this.btnHome);
            this.pnlLeftBar.Controls.Add(this.pnlLogo);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 17);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(272, 678);
            this.pnlLeftBar.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 75;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 770);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReport.Size = new System.Drawing.Size(251, 85);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pbxLogout
            // 
            this.pbxLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pbxLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxLogout.FlatAppearance.BorderSize = 0;
            this.pbxLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbxLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbxLogout.ForeColor = System.Drawing.Color.White;
            this.pbxLogout.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.pbxLogout.IconColor = System.Drawing.Color.Red;
            this.pbxLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxLogout.IconSize = 75;
            this.pbxLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pbxLogout.Location = new System.Drawing.Point(0, 855);
            this.pbxLogout.Name = "pbxLogout";
            this.pbxLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pbxLogout.Size = new System.Drawing.Size(251, 85);
            this.pbxLogout.TabIndex = 9;
            this.pbxLogout.Text = "Đăng xuất";
            this.pbxLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pbxLogout.UseVisualStyleBackColor = false;
            this.pbxLogout.Click += new System.EventHandler(this.pbxLogout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnCustomer.IconColor = System.Drawing.Color.White;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 75;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 685);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomer.Size = new System.Drawing.Size(251, 85);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.Otter;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 75;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 600);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Size = new System.Drawing.Size(251, 85);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Hóa đơn";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Opera;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 75;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 515);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(251, 85);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.IconSize = 75;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 430);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStaff.Size = new System.Drawing.Size(251, 85);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.HollyBerry;
            this.btnProduct.IconColor = System.Drawing.Color.White;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.IconSize = 75;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 345);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProduct.Size = new System.Drawing.Size(251, 85);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 75;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 260);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(251, 85);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lblName);
            this.pnlLogo.Controls.Add(this.pbxEmployee);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(251, 260);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 219);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 29);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.Location = new System.Drawing.Point(33, 12);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(194, 195);
            this.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployee.TabIndex = 8;
            this.pbxEmployee.TabStop = false;
            this.pbxEmployee.Click += new System.EventHandler(this.pbxEmployee_DoubleClick);
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlBottomBar.Controls.Add(this.btnMinimize);
            this.pnlBottomBar.Controls.Add(this.btnMaximize);
            this.pnlBottomBar.Controls.Add(this.lblTitleChild);
            this.pnlBottomBar.Controls.Add(this.btnExit);
            this.pnlBottomBar.Controls.Add(this.btnHomeMain);
            this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomBar.Location = new System.Drawing.Point(272, 17);
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.Size = new System.Drawing.Size(1352, 120);
            this.pnlBottomBar.TabIndex = 9;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 24;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1178, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 28);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 24;
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximize.Location = new System.Drawing.Point(1238, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(54, 28);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitleChild
            // 
            this.lblTitleChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitleChild.AutoSize = true;
            this.lblTitleChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChild.ForeColor = System.Drawing.Color.White;
            this.lblTitleChild.Location = new System.Drawing.Point(133, 44);
            this.lblTitleChild.Name = "lblTitleChild";
            this.lblTitleChild.Size = new System.Drawing.Size(130, 29);
            this.lblTitleChild.TabIndex = 1;
            this.lblTitleChild.Text = "Trang chủ";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 24;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(1298, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHomeMain
            // 
            this.btnHomeMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHomeMain.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMain.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHomeMain.IconColor = System.Drawing.Color.White;
            this.btnHomeMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHomeMain.IconSize = 69;
            this.btnHomeMain.Location = new System.Drawing.Point(58, 12);
            this.btnHomeMain.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnHomeMain.Name = "btnHomeMain";
            this.btnHomeMain.Size = new System.Drawing.Size(69, 106);
            this.btnHomeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHomeMain.TabIndex = 0;
            this.btnHomeMain.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(272, 137);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1352, 558);
            this.pnlMain.TabIndex = 10;
            // 
            // fpnlInvoice
            // 
            this.fpnlInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlInvoice.BackColor = System.Drawing.Color.DimGray;
            this.fpnlInvoice.Location = new System.Drawing.Point(1326, 591);
            this.fpnlInvoice.Name = "fpnlInvoice";
            this.fpnlInvoice.Size = new System.Drawing.Size(296, 100);
            this.fpnlInvoice.TabIndex = 0;
            this.fpnlInvoice.Visible = false;
            this.fpnlInvoice.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1624, 695);
            this.Controls.Add(this.fpnlInvoice);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.pnlLeftBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).EndInit();
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlLeftBar;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlBottomBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label lblTitleChild;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconPictureBox btnHomeMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel fpnlInvoice;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton pbxLogout;
        private FontAwesome.Sharp.IconButton btnReport;
        private System.Windows.Forms.PictureBox pbxEmployee;
    }
}

