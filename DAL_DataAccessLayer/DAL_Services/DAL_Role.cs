using System;
using System.Collections.Generic;
using System.Linq;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Role : iDAL_Role
    {
        private QuanLyBanGiayEntities _db;

        public string AddRole(Role role)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (role != null)
                    {
                        _db.Role.Add(role);
                        _db.SaveChanges();
                        return "Thêm thành công";
                    }

                    return "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateRole(Role role)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var rol = _db.Role.FirstOrDefault(c => c.RoleId == role.RoleId);
                    if (role != null && rol != null)
                    {
                        rol.RoleName = role.RoleName;
                        _db.SaveChanges();
                        return "Sửa thành công";
                    }

                    return "Sửa thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveRole(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var rol = _db.Role.FirstOrDefault(c => c.RoleId == id);
                    var em = _db.Employee.Where(c => c.RoleId == id);
                    if (rol != null)
                    {
                        if (em.Any())
                        {
                            foreach (var x in em)
                            {
                                var invoice = _db.Invoice.Where(c => c.EmployeeId == x.EmployeeId);
                                if (invoice.Any())
                                {
                                    foreach (var y in invoice)
                                    {
                                        var invoiceDetail = _db.InvoiceDetail.Where(c => c.InvoiceId == y.InvoiceId);
                                        if (invoiceDetail.Any())
                                        {
                                            foreach (var z in invoiceDetail)
                                            {
                                                _db.InvoiceDetail.Remove(z);
                                            }
                                        }
                                        _db.Invoice.Remove(y);
                                    }
                                }
                                _db.Employee.Remove(x);
                            }
                            _db.Role.Remove(rol);
                            _db.SaveChanges();
                            return "Xoá thành công";
                        }
                    }
                }

                return "Xoá thất bại";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public Role GetRoleById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Role.FirstOrDefault(c => c.RoleId == id);
            }
        }

        public List<Role> GetRole()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Role.ToList();
            }
        }
    }
}
