using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Role : iDAL_Roles
    {
        private QuanLyBanGiayEntities _db;

        public string AddRole(Roles role)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (role != null)
                    {
                        _db.Roles.Add(role);
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

        public string UpdateRole(Roles role)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var rol = _db.Roles.FirstOrDefault(c => c.RoleId == role.RoleId);
                    if (role != null && rol != null)
                    {
                        rol.RoleName = role.RoleName;
                        _db.SaveChanges();
                        return "Sửa thành công";
                    }

                    return "Thêm thất bại";
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
                    var rol = _db.Roles.FirstOrDefault(c => c.RoleId == id);
                    if (rol != null)
                    {
                        _db.Roles.Remove(rol);
                        _db.SaveChanges();
                        return "Xoá thành công";
                    }
                }

                return "Xoá thất bại";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public Roles GetRoleById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Roles.FirstOrDefault(c => c.RoleId == id);
            }
        }

        public List<Roles> GetRoles()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Roles.ToList();
            }
        }
    }
}
