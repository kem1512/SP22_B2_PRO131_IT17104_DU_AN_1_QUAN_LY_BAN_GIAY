using GUI_PresentationLayer.View;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;

namespace GUI_PresentationLayer.View
{
    public partial class FrmMain : Form
    {
        private FrmSales _frmSales;
        private IconButton currentBtn = new IconButton();
        private Panel leftBorderBtn = new Panel();
        private Form currentChildForm;
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        private bool isMinimized = false;
        public string Email { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            leftBorderBtn.Size = new Size(7, 85);
            pnlLeftBar.Controls.Add(leftBorderBtn);
            LoadData();
        }

        private void AddInvoice(string id)
        {
            InvoiceIcon invoiceIcon = new InvoiceIcon();
            invoiceIcon.Id = id;
            var invoice = _iInvoiceServices.GetInvoiceById(id);
            fpnlInvoice.Controls.Add(invoiceIcon);
            invoiceIcon.Status = invoice.InvoiceStatus ? "Đã hoàn thành" :
                !invoice.InvoiceStatus && invoice.Description != null ? "Đã hủy" :
                !invoice.InvoiceStatus && invoice.ShipperId != null ? "Đang giao hàng" : "Chưa hoàn thành";
            invoiceIcon.OnSelected += (sender, args) =>
            {
                _frmSales.InvoidId = invoice.InvoiceId;
                _frmSales.GetInfoFromInvoice(invoice.InvoiceId);
            };
        }

        public void FilterInvoice(string status)
        {
            if (status == "Tất cả")
            {
                foreach (InvoiceIcon x in fpnlInvoice.Controls)
                {
                    if (!x.Visible)
                    {
                        x.Visible = true;
                    }
                }
            }else if (status == "Đang giao hàng")
            {
                foreach (InvoiceIcon x in fpnlInvoice.Controls)
                {
                    x.Visible = x.Status.Equals(status);
                }
            }
        }

        public void LoadData()
        {
            fpnlInvoice.Controls.Clear();
            // Load hóa đơn
            var invoice = _iInvoiceServices.GetInvoices().Where(c => c.InvoiceStatus == false && c.Description == null).ToList();
            foreach (var x in invoice)
            {
                AddInvoice(x.InvoiceId);
            }
        }

        public void VisibleInvoice()
        {
            if (fpnlInvoice.Visible == false)
            {
                fpnlInvoice.Visible = true;
            }
            fpnlInvoice.Size = new Size(300, pnlLeftBar.Size.Height);
            fpnlInvoice.Location = new Point(0, 17);
            fpnlInvoice.BringToFront();
        }

        private void ActiveteButton(object senserBtn, Color color)
        {
            if (senserBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senserBtn;
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                btnHomeMain.IconChar = currentBtn.IconChar;
                lblTitleChild.Text = currentBtn.Text;
            }
        }

        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(form);
            pnlMain.Tag = form;
            form.BringToFront();
            form.Show();
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.Gold);
            var sale = new FrmSales(this);
            _frmSales = sale;
            OpenChildForm(sale);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.Red);
            OpenChildForm(new FrmProduct());
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlLeftBar.ClientRectangle.Contains(pnlLeftBar.PointToClient(Cursor.Position)))
            {
                fpnlInvoice.Visible = false;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.White);
            OpenChildForm(new FrmEmployee());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.BlueViolet);
            OpenChildForm(new FrmStatistics());
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.Azure);
            OpenChildForm(new FrmInvoice());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            pnlMain.Dock = DockStyle.None;
            this.WindowState = FormWindowState.Minimized;
            isMinimized = true;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.Red);
            OpenChildForm(new FrmCustomer());
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (isMinimized)
            {
                pnlMain.Dock = DockStyle.Fill;
                isMinimized = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbxEmployee.Width - 3, pbxEmployee.Height - 3);
            pbxEmployee.Region = new Region(gp);
            if (Email != null)
            {
                // Tìm nhân viên
                var employee = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == Email);
                if (employee != null)
                {
                    if (File.Exists(employee.EmployeeImage))
                    {
                        using (FileStream fileStream = new FileStream(employee.EmployeeImage, FileMode.Open))
                        {
                            pbxEmployee.Image = new Bitmap(fileStream);
                            lblName.Text = employee.FullName;
                        }
                    }
                    else
                    {
                        pbxEmployee.Image = Properties.Resources.failed;
                        lblName.Text = employee.FullName;
                    }
                }
            }
        }

        private void pbxLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, Color.Crimson);
            OpenChildForm(new FrmReport());
        }

        private void pbxEmployee_DoubleClick(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProfile(Email));
        }
    }
}
