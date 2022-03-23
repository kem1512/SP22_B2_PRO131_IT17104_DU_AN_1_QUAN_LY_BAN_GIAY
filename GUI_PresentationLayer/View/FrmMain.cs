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

namespace GUI_PresentationLayer.View
{
    public partial class FrmMain : Form
    {
        private IconButton currentBtn = new IconButton();
        private Panel leftBorderBtn = new Panel();
        private Form currentChildForm;
        public FrmMain()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            leftBorderBtn.Size = new Size(7, 85);
            pnlLeftBar.Controls.Add(leftBorderBtn);
        }

        public void HackerMan()
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            panel1.Size = new Size(300, pnlLeftBar.Size.Height);
            panel1.Location = new Point(0, 17);
            panel1.BringToFront();
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
            OpenChildForm(new FrmSales(this));
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
                panel1.Visible = false;
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
            OpenChildForm(new FrmOrder());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
