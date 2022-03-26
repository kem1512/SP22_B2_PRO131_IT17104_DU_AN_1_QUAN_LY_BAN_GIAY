using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Material
    {
        List<Material> GetMaterials();
        Material GetMaterialById(string id);
        Material GetMaterialByName(string name);

        string AddMaterial(Material material);

        string RemoveMaterial(Material material);

        string UpdateMaterial(Material material);
    }
}
