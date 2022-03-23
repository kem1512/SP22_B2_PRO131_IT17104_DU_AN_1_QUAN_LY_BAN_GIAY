using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Categories : iDAL_Categories
    {
        private QuanLyBanGiayEntities _db;
        public List<Brand> GetBrands()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Brand.ToList();
            }
        }

        public List<Category> GetCategories()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Category.ToList();
            }
        }

        public List<Color> GetColors()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Color.ToList();
            }
        }

        public List<Material> GetMaterials()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Material.ToList();
            }
        }

        public List<Size> GetSizes()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Size.ToList();
            }
        }
    }
}
