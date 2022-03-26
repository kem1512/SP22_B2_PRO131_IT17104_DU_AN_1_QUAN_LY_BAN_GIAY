using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace BUS_BussinessLayer.BUS_Services
{
    public class MaterialServices : iMaterialServices
    {
        private iDAL_Material _iDalMaterial;

        public MaterialServices()
        {
            _iDalMaterial = new DAL_Material();
        }
        public List<Material> GetMaterials()
        {
            return _iDalMaterial.GetMaterials();
        }

        public Material GetMaterialById(string id)
        {
            return _iDalMaterial.GetMaterialById(id);
        }

        public Material GetMaterialByName(string name)
        {
            return _iDalMaterial.GetMaterialByName(name);
        }

        public string AddMaterial(Material material)
        {
            return _iDalMaterial.AddMaterial(material);
        }

        public string RemoveMaterial(Material material)
        {
            return _iDalMaterial.RemoveMaterial(material);
        }

        public string UpdateMaterial(Material material)
        {
            return _iDalMaterial.UpdateMaterial(material);
        }
    }
}
