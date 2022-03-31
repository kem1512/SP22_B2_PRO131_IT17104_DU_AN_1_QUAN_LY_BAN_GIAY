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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTurnover = new System.Windows.Forms.Panel();
            this.dgdtpcDateBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.dgdtpcDateEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblTurnover = new System.Windows.Forms.Label();
            this.dgridTurnover = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sctnBot = new System.Windows.Forms.SplitContainer();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlTurnover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTurnover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).BeginInit();
            this.sctnBot.Panel1.SuspendLayout();
            this.sctnBot.Panel2.SuspendLayout();
            this.sctnBot.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1339, 118);
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
            this.panel2.Controls.Add(this.pnlTurnover);
            this.panel2.Controls.Add(this.dgridTurnover);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 311);
            this.panel2.TabIndex = 2;
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
            this.pnlTurnover.Size = new System.Drawing.Size(1313, 84);
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
            this.dgdtpcDateBegin.Location = new System.Drawing.Point(363, 17);
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
            this.lblDateBegin.Location = new System.Drawing.Point(240, 29);
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
            this.dgdtpcDateEnd.Location = new System.Drawing.Point(916, 17);
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
            this.lblDateEnd.Location = new System.Drawing.Point(793, 29);
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
            // dgridTurnover
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridTurnover.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridTurnover.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgridTurnover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridTurnover.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridTurnover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridTurnover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTurnover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridTurnover.DoubleBuffered = true;
            this.dgridTurnover.EnableHeadersVisualStyles = false;
            this.dgridTurnover.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgridTurnover.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgridTurnover.Location = new System.Drawing.Point(0, 0);
            this.dgridTurnover.Name = "dgridTurnover";
            this.dgridTurnover.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgridTurnover.RowHeadersWidth = 51;
            this.dgridTurnover.RowTemplate.Height = 24;
            this.dgridTurnover.Size = new System.Drawing.Size(1313, 309);
            this.dgridTurnover.TabIndex = 1;
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
            this.sctnBot.Panel1.Controls.Add(this.pnlBrand);
            // 
            // sctnBot.Panel2
            // 
            this.sctnBot.Panel2.Controls.Add(this.pnlCancel);
            this.sctnBot.Size = new System.Drawing.Size(1313, 318);
            this.sctnBot.SplitterDistance = 672;
            this.sctnBot.SplitterWidth = 10;
            this.sctnBot.TabIndex = 3;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrand.Controls.Add(this.cmbFilter);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(670, 60);
            this.pnlBrand.TabIndex = 0;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(431, 9);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(215, 39);
            this.cmbFilter.TabIndex = 2;
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
            // pnlCancel
            // 
            this.pnlCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancel.Controls.Add(this.lblCancel);
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCancel.Location = new System.Drawing.Point(0, 0);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(629, 60);
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
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 768);
            this.Controls.Add(this.sctnBot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            this.panel2.ResumeLayout(false);
            this.pnlTurnover.ResumeLayout(false);
            this.pnlTurnover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTurnover)).EndInit();
            this.sctnBot.Panel1.ResumeLayout(false);
            this.sctnBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).EndInit();
            this.sctnBot.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTurnover;
        private System.Windows.Forms.Label lblDateEnd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgridTurnover;
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
    }
}