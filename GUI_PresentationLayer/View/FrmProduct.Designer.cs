namespace GUI_PresentationLayer.View
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBot = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrandBot = new System.Windows.Forms.ComboBox();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pbxEditBrand = new FontAwesome.Sharp.IconPictureBox();
            this.pbxEditMat = new FontAwesome.Sharp.IconPictureBox();
            this.pbxEditColor = new FontAwesome.Sharp.IconPictureBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.pbxEditCat = new FontAwesome.Sharp.IconPictureBox();
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.cmbColorBot = new System.Windows.Forms.ComboBox();
            this.pbxEditSize = new FontAwesome.Sharp.IconPictureBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBrandTop = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.cmbColorTop = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgridProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditSize)).BeginInit();
            this.tlpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.tlpFilter.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBot
            // 
            this.tlpBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBot.ColumnCount = 6;
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5802F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.419799F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5802F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.419799F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5802F));
            this.tlpBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.419799F));
            this.tlpBot.Controls.Add(this.cmbSize, 0, 3);
            this.tlpBot.Controls.Add(this.lblBrand, 0, 0);
            this.tlpBot.Controls.Add(this.cmbBrandBot, 0, 1);
            this.tlpBot.Controls.Add(this.lblMat, 2, 0);
            this.tlpBot.Controls.Add(this.lblColor, 4, 0);
            this.tlpBot.Controls.Add(this.pbxEditBrand, 1, 1);
            this.tlpBot.Controls.Add(this.pbxEditMat, 3, 1);
            this.tlpBot.Controls.Add(this.pbxEditColor, 5, 1);
            this.tlpBot.Controls.Add(this.lblSize, 0, 2);
            this.tlpBot.Controls.Add(this.lblCat, 2, 2);
            this.tlpBot.Controls.Add(this.pbxEditCat, 3, 3);
            this.tlpBot.Controls.Add(this.cmbMat, 2, 1);
            this.tlpBot.Controls.Add(this.cmbCat, 2, 3);
            this.tlpBot.Controls.Add(this.cmbColorBot, 4, 1);
            this.tlpBot.Controls.Add(this.pbxEditSize, 1, 3);
            this.tlpBot.Location = new System.Drawing.Point(26, 494);
            this.tlpBot.Name = "tlpBot";
            this.tlpBot.RowCount = 4;
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.44444F));
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.55556F));
            this.tlpBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBot.Size = new System.Drawing.Size(988, 199);
            this.tlpBot.TabIndex = 1;
            // 
            // cmbSize
            // 
            this.cmbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.IntegralHeight = false;
            this.cmbSize.Location = new System.Drawing.Point(3, 150);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(251, 39);
            this.cmbSize.TabIndex = 33;
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(3, 13);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(139, 22);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Hãng sản xuất";
            // 
            // cmbBrandBot
            // 
            this.cmbBrandBot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBrandBot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandBot.FormattingEnabled = true;
            this.cmbBrandBot.IntegralHeight = false;
            this.cmbBrandBot.ItemHeight = 31;
            this.cmbBrandBot.Location = new System.Drawing.Point(3, 52);
            this.cmbBrandBot.Name = "cmbBrandBot";
            this.cmbBrandBot.Size = new System.Drawing.Size(251, 39);
            this.cmbBrandBot.TabIndex = 12;
            // 
            // lblMat
            // 
            this.lblMat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(331, 13);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(90, 22);
            this.lblMat.TabIndex = 14;
            this.lblMat.Text = "Chất liệu";
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(659, 13);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(84, 22);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Màu sắc";
            // 
            // pbxEditBrand
            // 
            this.pbxEditBrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxEditBrand.BackColor = System.Drawing.Color.White;
            this.pbxEditBrand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditBrand.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.pbxEditBrand.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxEditBrand.Location = new System.Drawing.Point(277, 57);
            this.pbxEditBrand.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pbxEditBrand.Name = "pbxEditBrand";
            this.pbxEditBrand.Size = new System.Drawing.Size(32, 32);
            this.pbxEditBrand.TabIndex = 24;
            this.pbxEditBrand.TabStop = false;
            this.pbxEditBrand.Click += new System.EventHandler(this.pbxEditBrand_Click);
            // 
            // pbxEditMat
            // 
            this.pbxEditMat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxEditMat.BackColor = System.Drawing.Color.White;
            this.pbxEditMat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditMat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.pbxEditMat.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxEditMat.Location = new System.Drawing.Point(605, 57);
            this.pbxEditMat.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pbxEditMat.Name = "pbxEditMat";
            this.pbxEditMat.Size = new System.Drawing.Size(32, 32);
            this.pbxEditMat.TabIndex = 26;
            this.pbxEditMat.TabStop = false;
            // 
            // pbxEditColor
            // 
            this.pbxEditColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxEditColor.BackColor = System.Drawing.Color.White;
            this.pbxEditColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditColor.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.pbxEditColor.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxEditColor.Location = new System.Drawing.Point(933, 57);
            this.pbxEditColor.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pbxEditColor.Name = "pbxEditColor";
            this.pbxEditColor.Size = new System.Drawing.Size(32, 32);
            this.pbxEditColor.TabIndex = 28;
            this.pbxEditColor.TabStop = false;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(3, 111);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(104, 22);
            this.lblSize.TabIndex = 21;
            this.lblSize.Text = "Kích thước";
            // 
            // lblCat
            // 
            this.lblCat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(331, 111);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(91, 22);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "Loại giày";
            // 
            // pbxEditCat
            // 
            this.pbxEditCat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxEditCat.BackColor = System.Drawing.Color.White;
            this.pbxEditCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditCat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.pbxEditCat.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxEditCat.Location = new System.Drawing.Point(605, 157);
            this.pbxEditCat.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pbxEditCat.Name = "pbxEditCat";
            this.pbxEditCat.Size = new System.Drawing.Size(32, 32);
            this.pbxEditCat.TabIndex = 25;
            this.pbxEditCat.TabStop = false;
            // 
            // cmbMat
            // 
            this.cmbMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.IntegralHeight = false;
            this.cmbMat.Location = new System.Drawing.Point(331, 52);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(251, 39);
            this.cmbMat.TabIndex = 30;
            // 
            // cmbCat
            // 
            this.cmbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.IntegralHeight = false;
            this.cmbCat.Location = new System.Drawing.Point(331, 150);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(251, 39);
            this.cmbCat.TabIndex = 29;
            // 
            // cmbColorBot
            // 
            this.cmbColorBot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColorBot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorBot.FormattingEnabled = true;
            this.cmbColorBot.IntegralHeight = false;
            this.cmbColorBot.Location = new System.Drawing.Point(659, 52);
            this.cmbColorBot.Name = "cmbColorBot";
            this.cmbColorBot.Size = new System.Drawing.Size(251, 39);
            this.cmbColorBot.TabIndex = 32;
            // 
            // pbxEditSize
            // 
            this.pbxEditSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxEditSize.BackColor = System.Drawing.Color.White;
            this.pbxEditSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditSize.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.pbxEditSize.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxEditSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxEditSize.Location = new System.Drawing.Point(277, 157);
            this.pbxEditSize.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pbxEditSize.Name = "pbxEditSize";
            this.pbxEditSize.Size = new System.Drawing.Size(32, 32);
            this.pbxEditSize.TabIndex = 27;
            this.pbxEditSize.TabStop = false;
            // 
            // tlpRight
            // 
            this.tlpRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRight.ColumnCount = 2;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRight.Controls.Add(this.txtQuantity, 0, 4);
            this.tlpRight.Controls.Add(this.lblName, 0, 1);
            this.tlpRight.Controls.Add(this.txtName, 0, 2);
            this.tlpRight.Controls.Add(this.lblQuantity, 0, 3);
            this.tlpRight.Controls.Add(this.lblPrice, 1, 3);
            this.tlpRight.Controls.Add(this.txtPrice, 1, 4);
            this.tlpRight.Controls.Add(this.lblNote, 0, 5);
            this.tlpRight.Controls.Add(this.txtNote, 0, 6);
            this.tlpRight.Controls.Add(this.btnAdd, 0, 7);
            this.tlpRight.Controls.Add(this.btnEdit, 1, 7);
            this.tlpRight.Controls.Add(this.pbxProduct, 0, 0);
            this.tlpRight.Location = new System.Drawing.Point(1043, 82);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 8;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.25108F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.843902F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812356F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.41892F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.657529F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.41892F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.74672F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85058F));
            this.tlpRight.Size = new System.Drawing.Size(350, 644);
            this.tlpRight.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.HintText = "";
            this.txtQuantity.isPassword = false;
            this.txtQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineThickness = 4;
            this.txtQuantity.Location = new System.Drawing.Point(5, 352);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 32);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 248);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpRight.SetColumnSpan(this.txtName, 2);
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
            this.txtName.Location = new System.Drawing.Point(5, 275);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 33);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 325);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 22);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(178, 325);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 22);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá bán";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 4;
            this.txtPrice.Location = new System.Drawing.Point(180, 352);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 32);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(3, 401);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(79, 22);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.tlpRight.SetColumnSpan(this.txtNote, 2);
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(3, 426);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(344, 127);
            this.txtNote.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnAdd.Location = new System.Drawing.Point(5, 569);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 61);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.Red;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.Red;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnEdit.Location = new System.Drawing.Point(180, 571);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 57);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpRight.SetColumnSpan(this.pbxProduct, 2);
            this.pbxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxProduct.Location = new System.Drawing.Point(3, 3);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(344, 227);
            this.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProduct.TabIndex = 11;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_DoubleClick);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(26, 20);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(95, 45);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 27;
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
            this.txtSearch.Location = new System.Drawing.Point(129, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 41);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tlpFilter
            // 
            this.tlpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFilter.ColumnCount = 4;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.32833F));
            this.tlpFilter.Controls.Add(this.cmbBrandTop, 0, 0);
            this.tlpFilter.Controls.Add(this.cmbPrice, 2, 0);
            this.tlpFilter.Controls.Add(this.cmbColorTop, 1, 0);
            this.tlpFilter.Controls.Add(this.lblFilter, 0, 0);
            this.tlpFilter.Location = new System.Drawing.Point(448, 10);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(566, 62);
            this.tlpFilter.TabIndex = 28;
            // 
            // cmbBrandTop
            // 
            this.cmbBrandTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrandTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandTop.FormattingEnabled = true;
            this.cmbBrandTop.Location = new System.Drawing.Point(87, 14);
            this.cmbBrandTop.Name = "cmbBrandTop";
            this.cmbBrandTop.Size = new System.Drawing.Size(154, 33);
            this.cmbBrandTop.TabIndex = 28;
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
            // cmbColorTop
            // 
            this.cmbColorTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbColorTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorTop.FormattingEnabled = true;
            this.cmbColorTop.Location = new System.Drawing.Point(247, 14);
            this.cmbColorTop.Name = "cmbColorTop";
            this.cmbColorTop.Size = new System.Drawing.Size(154, 33);
            this.cmbColorTop.TabIndex = 26;
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
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1341, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "VNĐ";
            // 
            // tabDelete
            // 
            this.tabDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDelete.Controls.Add(this.tabProduct);
            this.tabDelete.Controls.Add(this.tabPage2);
            this.tabDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDelete.ItemSize = new System.Drawing.Size(200, 30);
            this.tabDelete.Location = new System.Drawing.Point(23, 82);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.SelectedIndex = 0;
            this.tabDelete.Size = new System.Drawing.Size(991, 400);
            this.tabDelete.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDelete.TabIndex = 1;
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.White;
            this.tabProduct.Controls.Add(this.dgridProduct);
            this.tabProduct.Location = new System.Drawing.Point(4, 34);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(983, 362);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Sản phẩm";
            // 
            // dgridProduct
            // 
            this.dgridProduct.AllowUserToAddRows = false;
            this.dgridProduct.AllowUserToDeleteRows = false;
            this.dgridProduct.AllowUserToResizeColumns = false;
            this.dgridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridProduct.ColumnHeadersHeight = 50;
            this.dgridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridProduct.DoubleBuffered = true;
            this.dgridProduct.EnableHeadersVisualStyles = false;
            this.dgridProduct.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dgridProduct.Location = new System.Drawing.Point(3, 3);
            this.dgridProduct.MultiSelect = false;
            this.dgridProduct.Name = "dgridProduct";
            this.dgridProduct.ReadOnly = true;
            this.dgridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridProduct.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgridProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridProduct.RowTemplate.Height = 110;
            this.dgridProduct.Size = new System.Drawing.Size(977, 356);
            this.dgridProduct.TabIndex = 2;
            this.dgridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridProduct_CellClick);
            this.dgridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridProduct_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đã xóa";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1405, 755);
            this.Controls.Add(this.tabDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tlpFilter);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tlpRight);
            this.Controls.Add(this.tlpBot);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.tlpBot.ResumeLayout(false);
            this.tlpBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditSize)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpBot;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrandBot;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblSize;
        private FontAwesome.Sharp.IconPictureBox pbxEditBrand;
        private FontAwesome.Sharp.IconPictureBox pbxEditCat;
        private FontAwesome.Sharp.IconPictureBox pbxEditMat;
        private FontAwesome.Sharp.IconPictureBox pbxEditSize;
        private FontAwesome.Sharp.IconPictureBox pbxEditColor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private System.Windows.Forms.PictureBox pbxSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.ComboBox cmbBrandTop;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.ComboBox cmbColorTop;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.ComboBox cmbColorBot;
        private System.Windows.Forms.TabControl tabDelete;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbxProduct;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
    }
}