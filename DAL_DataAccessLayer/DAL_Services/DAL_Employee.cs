using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
    
namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Employee : iDAL_Employee
    {
        private QuanLyBanGiayEntities _db;

        private static string GetFullPath()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;
            if (directoryInfo != null)
            {
                var path = directoryInfo.FullName + @"\Images\Employee\";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                return path;
            }
            return null;
        }
        public string AddEmployee(Employee employee)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (employee != null)
                    {
                        _db.Employee.Add(employee);
                        var image = GetFullPath() + employee.EmployeeId + Path.GetExtension(employee.EmployeeImage);
                        if (File.Exists(image))
                        {
                            File.Delete(image);
                        }
                        if (employee.EmployeeImage != null) File.Copy(employee.EmployeeImage, image);
                        employee.EmployeeImage = image;
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

        public string UpdateEmployee(Employee employee)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var em = _db.Employee.FirstOrDefault(c => c.EmployeeId == employee.EmployeeId);
                    if (employee != null && em != null)
                    {
                        em.Address = employee.Address;
                        em.DateOfBirth = employee.DateOfBirth;
                        em.Email = employee.Email;
                        em.FullName = employee.FullName;
                        em.Gender = employee.Gender;
                        em.Phone = employee.Phone;
                        em.RoleId = employee.RoleId;
                        var image = GetFullPath() + employee.EmployeeId + Path.GetExtension(employee.EmployeeImage);

                        //Tìm ảnh cũ
                        if (em.EmployeeImage != employee.EmployeeImage)
                        {
                            if (File.Exists(image))
                            {
                                File.Delete(image);
                            }
                            // Xóa ảnh cũ và copy ảnh mới
                            File.Delete(em.EmployeeImage);
                            if (employee.EmployeeImage != null) File.Copy(employee.EmployeeImage, image);
                            // Sửa lại đường dẫn ảnh
                            em.EmployeeImage = image;
                        }
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

        public string RemoveEmployee(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var em = _db.Employee.FirstOrDefault(c => c.EmployeeId == id);
                    if (em != null)
                    {
                        foreach (var x in _db.Invoice.Where(c => c.EmployeeId == em.EmployeeId))
                        {
                            foreach (var y in _db.InvoiceDetail.Where(c => c.InvoiceId == x.InvoiceId))
                            {
                                x.InvoiceDetail.Remove(y);
                            }
                            _db.Invoice.Remove(x);
                        }
                        _db.Employee.Remove(em);
                        _db.SaveChanges();
                        return "Xoá thành công";
                    }
                    return "Xoá thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public Employee GetEmployeeById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Employee.FirstOrDefault(c => c.EmployeeId == id);
            }
        }

        public List<Employee> GetEmployees()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Employee.ToList();
            }
        }

        public string DisableEmployee(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var employee = _db.Employee.FirstOrDefault(c => c.EmployeeId == id);
                if (id != null && employee != null)
                {
                    employee.Status = false;
                    _db.SaveChanges();
                    return "Xóa thành công!";
                }
                return "Xóa thất bại!";
            }
        }

        public string RecoveryEmployee(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var employee = _db.Employee.FirstOrDefault(c => c.EmployeeId == id);
                if (id != null && employee != null)
                {
                    employee.Status = true;
                    _db.SaveChanges();
                    return "Phục hồi thành công!";
                }
                return "Phục hồi thất bại!";
            }
        }
    }
}
