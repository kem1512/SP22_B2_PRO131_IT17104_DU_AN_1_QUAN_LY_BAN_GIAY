using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

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
    }
}
