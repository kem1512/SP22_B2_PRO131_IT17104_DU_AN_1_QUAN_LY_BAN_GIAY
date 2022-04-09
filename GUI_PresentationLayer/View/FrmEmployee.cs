using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using BUS_BussinessLayer.Utilities;
using DAL_DataAccessLayer.Entities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmEmployee : Form
    {
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        private iRoleServices _iRoleServices = new RoleServices();
        public FrmEmployee()
        {
            InitializeComponent();
            LoadData();
        }
        private string ValidateEmployee()
        {
            if (txtName.Text == "")
            {
                return "Không được để trống tên";
            }
            if (txtEmail.Text == "")
            {
                return "Không được để trống email";
            }
            if (txtAddress.Text == "")
            {
                return "Không được để trống địa chỉ";
            }
            if (txtPhone.Text == "")
            {
                return "Không được để trống số điện thoại";
            }
            if (!rbtnFemale.Checked && !rbtnMale.Checked)
            {
                return "Vui lòng chọn giới tính";
            }
            if (cmbRoles.SelectedIndex == -1)
            {
                return "Vui lòng chọn vai trò";
            }
            if ((DateTime.Now.Year - dgdtpcStaff.Value.Year) < 18)
            {
                return "Chưa đủ 18 tuổi!";
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee() is null)
            {
                if (_iEmployeeServices.GetEmployees().Any(c => c.Email == txtEmail.Text))
                {
                    MessageBox.Show("Nhân viên đã tồn tại!");
                }
                else
                {
                    var employeeId = !_iEmployeeServices.GetEmployees().Any() ? "NV1" : "NV" + _iEmployeeServices.GetEmployees().Max(c => int.Parse(c.EmployeeId.Replace("NV", "")) + 1);
                    if (MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var em = new Employee()
                        {
                            EmployeeId = employeeId,
                            FullName = txtName.Text,
                            Email = txtEmail.Text,
                            Phone = txtPhone.Text,
                            Address = txtAddress.Text,
                            DateOfBirth = DateTime.Parse(dgdtpcStaff.Value.ToShortDateString()),
                            Gender = rbtnMale.Checked ? true : false,
                            EmployeeImage = pbxEmployee.Tag.ToString(),
                            RoleId = cmbRoles.SelectedValue.ToString(),
                            Status = true,
                            Pass = "123"
                        };
                        MessageBox.Show(_iEmployeeServices.AddEmployee(em));
                        LoadData();
                        if (MessageBox.Show("Bạn có muốn gửi mã QR đến cho nhân viên?", "Thông báo",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SendSMS.SendMailQr(em.Email, "Welcome to Shop", "Chào mừng bạn đến với shop, đây là mật khẩu của bạn", GenerateCode.CreateQRCode(em.Email, em.Pass));
                            MessageBox.Show("Gửi thành công!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(ValidateEmployee());
            }
        }

        private void dgrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dgridEmployee.Rows[e.RowIndex];
                var employee = _iEmployeeServices.GetEmployeeById(row.Cells[0].Value.ToString());
                if (File.Exists(employee.EmployeeImage))
                {
                    using (FileStream fileStream = new FileStream(employee.EmployeeImage, FileMode.Open))
                    {
                        pbxEmployee.Image = new Bitmap(fileStream);
                        pbxEmployee.Tag = fileStream.Name;
                    }
                }
                else
                {
                    pbxEmployee.Image = Properties.Resources.failed;
                }
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Nam")
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
                txtOld.Text = DateTime.Now.Year - employee.DateOfBirth.Year + "";
                txtAddress.Text = row.Cells[5].Value.ToString();
                dgdtpcStaff.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                cmbRoles.SelectedValue = row.Cells[7].Value.ToString();
            }
        }

        private void LoadData()
        {
            dgridEmployee.Rows.Clear();
            var result = _iEmployeeServices.GetEmployees();
            foreach (var x in result.Where(c => c.Status))
            {
                dgridEmployee.Rows.Add(x.EmployeeId, x.FullName, x.Email, x.Phone, x.Gender ? "Nam" : "Nữ",
                    x.Address, x.DateOfBirth.ToShortDateString(), x.RoleId, "Xoá");
            }

            dgrid_Disable.Rows.Clear();
            foreach (var d in result.Where(c => !c.Status))
            {
                dgrid_Disable.Rows.Add(d.EmployeeId, d.FullName, d.Email, d.Phone, d.Gender ? "Nam" : "Nữ",
                    d.Address, d.DateOfBirth.ToShortDateString(), d.RoleId, "Phục hồi", "Xóa");
            }

            cmbRoles.DataSource = _iRoleServices.GetRoles();
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleId";
        }

        private void dgrid_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(
                        _iEmployeeServices.DisableEmployee(dgridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
        }
        
        private void pbxRoles_Click(object sender, EventArgs e)
        {
            FrmProperties properties = new FrmProperties(FrmProperties.Properties.Role);
            properties.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateEmployee() is null)
            {
                var employee = _iEmployeeServices.GetEmployeeById(dgridEmployee.Rows[dgridEmployee.CurrentRow.Index].Cells[0].Value.ToString());
                if (MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_iEmployeeServices.UpdateEmployee(new Employee()
                    {
                        EmployeeId = employee.EmployeeId,
                        FullName = txtName.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Address = txtAddress.Text,
                        DateOfBirth = DateTime.Parse(dgdtpcStaff.Value.ToShortDateString()),
                        Gender = rbtnMale.Checked ? true : false,
                        EmployeeImage = pbxEmployee.Tag.ToString(),
                        RoleId = cmbRoles.SelectedValue.ToString(),
                    }));
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show(ValidateEmployee());
            }
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            if (dgridEmployee.CurrentRow != null)
            {
                var row = dgridEmployee.Rows[dgridEmployee.CurrentRow.Index];
                if (MessageBox.Show(
                        $"Bạn có chắc muốn gửi lại mã QR cho nhân viên {row.Cells[1].Value}",
                        "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var em = _iEmployeeServices.GetEmployeeById(row.Cells[0].Value.ToString());
                    var image = GenerateCode.CreateQRCode(em.Email, em.Pass);
                    SendSMS.SendMailQr(em.Email, "Gửi lại  mã QR", "Nè", image);
                }
            }
        }

        private void dgrid_Disable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(
                        _iEmployeeServices.RecoveryEmployee(dgrid_Disable.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(
                        _iEmployeeServices.RemoveEmployee(dgrid_Disable.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
        }

        private void pbxEmployee_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    pbxEmployee.Image = new Bitmap(fileStream);
                    pbxEmployee.Tag = fileStream.Name;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                GenerateDoucument.ToExcel(dgridEmployee, openFileDialog.FileName);
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgridEmployee.Rows)
            {
                if (true)
                {

                }
                else
                {
                    x.Visible = x.Cells[1].Value.ToString().Contains(txtSearch.Text);
                }
            }
        }

        void Send(string email,string filename)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = "THÔNG BÁO";
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(filename);
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kem15122002@gmail.com", "badao12345");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Gửi thông báo thành công","Thông báo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            var lstE = _iEmployeeServices.GetEmployees().Where(c => c.Status).Select(c => c.Email).ToList();
            string att = null;
            if (att==null)
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog()==DialogResult.OK)
                {
                    att = op.FileName;
                }
            }
            foreach (var em in lstE)
            {
                Send(em,att);
            }
        }
    }
}
