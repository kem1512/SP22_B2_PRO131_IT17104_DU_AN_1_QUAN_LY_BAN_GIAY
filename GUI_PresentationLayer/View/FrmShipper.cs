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
    public partial class FrmShipper : Form
    {
        private iShipperServices _iShipperServices = new ShipperServices();
        public FrmShipper()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            rbtnOnl.Checked = true;

            dgridShipper.Rows.Clear();
            foreach (var x in _iShipperServices.GetListShipper())
            {
                dgridShipper.Rows.Add(x.ShipperId, x.ShipperName, x.ShipperPhone, x.ShipperStatus,"Xóa");
            }
        }

        private string ValidateShipper()
        {
            if (txtName.Text == "")
            {
                return "Bạn chưa nhập tên!";
            }

            if (txtPhone.Text == "")
            {
                return "Bạn chưa nhập số điện thoại";
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateShipper() is null)
            {
                if (_iShipperServices.GetListShipper().Any(c => c.ShipperPhone == txtPhone.Text))
                {
                    MessageBox.Show("Shipper đã tồn tại!");
                }
                else
                {
                    var shipperId = !_iShipperServices.GetListShipper().Any() ? "SP1" : "SP" + _iShipperServices.GetListShipper().Max(c => int.Parse(c.ShipperId.Replace("SP", "")) + 1);
                    if (MessageBox.Show("Bạn có chắc muôn thêm không?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iShipperServices.AddShipper(new Shipper()
                        {
                            ShipperId = shipperId,
                            ShipperName = txtName.Text,
                            ShipperPhone = txtPhone.Text,
                            ShipperStatus = rbtnOnl.Checked ? true : false,
                        }));
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show(ValidateShipper());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateShipper() is null)
            {
                if (MessageBox.Show("Bạn có chắc muôn sửa không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    if (dgridShipper.CurrentRow != null)
                    {
                        MessageBox.Show(_iShipperServices.UpdateShipper(new Shipper()
                        {
                            ShipperId = dgridShipper.Rows[dgridShipper.CurrentRow.Index]
                                .Cells[0].Value.ToString(),
                            ShipperName = txtName.Text,
                            ShipperPhone = txtPhone.Text,
                            ShipperStatus = rbtnOnl.Checked ? true : false,
                        }));
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show(ValidateShipper());
            }
        }

        private void dgridShipper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex.Equals(4))
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iShipperServices.RemoveShipper(dgridShipper.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        LoadData();
                    }
                }
            }
        }

        private void dgridShipper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dgridShipper.Rows[e.RowIndex];
                var shipper = _iShipperServices.GetShipperById(row.Cells[0].Value.ToString());
                if (shipper != null)
                {
                    txtName.Text = shipper.ShipperName;
                    txtPhone.Text = shipper.ShipperPhone;
                    if (shipper.ShipperStatus)
                    {
                        rbtnOnl.Checked = true;
                    }
                    else
                    {
                        rbtnOff.Checked = true;
                    }
                }
            }
        }
    }
}
