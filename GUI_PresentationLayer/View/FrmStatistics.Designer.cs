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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTurnover = new System.Windows.Forms.Panel();
            this.dgdtpcDateBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.dgdtpcDateEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblTurnover = new System.Windows.Forms.Label();
            this.sctnBot = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlTurnover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).BeginInit();
            this.sctnBot.Panel1.SuspendLayout();
            this.sctnBot.Panel2.SuspendLayout();
            this.sctnBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.pnlTurnover);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 311);
            this.panel2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 84);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1313, 225);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
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
            this.sctnBot.Panel1.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 256);
            this.dataGridView1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlTurnover.ResumeLayout(false);
            this.pnlTurnover.PerformLayout();
            this.sctnBot.Panel1.ResumeLayout(false);
            this.sctnBot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sctnBot)).EndInit();
            this.sctnBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}