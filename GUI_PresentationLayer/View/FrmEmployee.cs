using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
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
            loadData();
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
            if (txtPassword.Text == "")
            {
                return "Không được để trống mật khẩu";
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
                return "Vui lòng chọn giới tính, mày bê đê à";
            }
            if (cmbRoles.SelectedIndex == -1)
            {
                return "Vui lòng chọn vai trò";
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Cursor == Cursors.Hand)
            {
                if (ValidateEmployee() is null)
                {
                    var employeeID = !_iEmployeeServices.GetEmployees().Any() ? "NV1" : "NV" + _iEmployeeServices.GetEmployees().Max(c => int.Parse(c.EmployeeId.Replace("NV", "")) + 1);
                    if (MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show(_iEmployeeServices.AddEmployee(new Employee()
                        {
                            EmployeeId = employeeID,
                            FullName = txtName.Text,
                            Email = txtEmail.Text,
                            Phone = txtPhone.Text,
                            Address = txtAddress.Text,
                            DateOfBirth = DateTime.Parse(dgdtpcStaff.Value.ToShortDateString()),
                            Gender = rbtnMale.Checked ? true : false,
                            EmployeeImage = pbxProduct.Tag.ToString(),
                            Pass = txtPassword.Text
                        }));
                    }
                }
                else
                {
                    MessageBox.Show(ValidateEmployee());
                }

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnEdit.Cursor = Cursors.Hand;
                btnAdd.Cursor = Cursors.No;
                var row = dgrid_Employee.Rows[e.RowIndex];
                var employee = _iEmployeeServices.GetEmployeeById(row.Cells[0].Value.ToString());
                using (FileStream fileStream = new FileStream(employee.EmployeeImage, FileMode.Open))
                {
                    pbxProduct.Image = new Bitmap(fileStream);
                    pbxProduct.Tag = fileStream.Name;
                }

                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString()=="Nam")
                {
                    rbtnMale.Checked=true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
                txtAddress.Text = row.Cells[5].Value.ToString();
                dgdtpcStaff.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                cmbRoles.SelectedValue = row.Cells[7].Value.ToString();
            }
        }

        void loadData()
        {
            dgrid_Employee.Rows.Clear();
            var result = _iEmployeeServices.GetEmployees();
            foreach (var x in result.Where(c=>c.RoleId!="R2"))
            {
                using (FileStream fileStream = new FileStream(x.EmployeeImage, FileMode.Open))
                {
                    dgrid_Employee.Rows.Add(x.EmployeeId, x.FullName, x.Email, x.Phone, x.Gender ? "Nam" : "Nu",
                        x.Address, x.DateOfBirth, x.RoleId,"Xoá");
                }
            }
            dgrid_Disabled.Rows.Clear();
            var dis = _iEmployeeServices.GetEmployees();
            foreach (var d in dis.Where(c=>c.RoleId=="R2"))
            {
                using (FileStream fileStream = new FileStream(d.EmployeeImage, FileMode.Open))
                {
                    dgrid_Employee.Rows.Add(d.EmployeeId, d.FullName, d.Email, d.Phone, d.Gender ? "Nam" : "Nu",
                        d.Address, d.DateOfBirth, d.RoleId);
                }
            }

            cmbRoles.DataSource = _iRoleServices.GetListRole();
            cmbRoles.DisplayMember = "RoleName";
            cmbRoles.ValueMember = "RoleId";
        }

        private void dgrid_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==8)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    MessageBox.Show(
                        _iEmployeeServices.RemoveEmployee(dgrid_Employee.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    loadData();
                }
            }
        }
    }
}
