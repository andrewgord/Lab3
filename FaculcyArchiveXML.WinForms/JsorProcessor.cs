using Newtonsoft.Json;

namespace FaculcyArchiveXML.WinForms
{
    public class JsonProcessor
    {
        private string jsonFilePath = "path/to/your/file.json";

        public JsonProcessor(string jsonFilePath)
        {
            this.jsonFilePath = jsonFilePath;
        }
        public List<Material> GetAllMaterials()
        {
            var json = File.ReadAllText(jsonFilePath);
            var materials = JsonConvert.DeserializeObject<List<Material>>(json);

            return materials ?? new List<Material>();
        }

        public Material GetMaterialById(int id)
        {
            return GetAllMaterials().FirstOrDefault(material => material.Id == id);
        }

        public void AddMaterial(Material newMaterial)
        {
            var materials = GetAllMaterials();
            newMaterial.Id = materials.Count + 1;
            materials.Add(newMaterial);

            SaveMaterialsToFile(materials);
        }

        public void UpdateMaterial(Material updatedMaterial)
        {
            var materials = GetAllMaterials();
            var existingMaterial = materials.FirstOrDefault(material => material.Id == updatedMaterial.Id);

            if (existingMaterial != null)
            {
                existingMaterial.Author = updatedMaterial.Author;
                existingMaterial.Title = updatedMaterial.Title;
                existingMaterial.FaculcyName = updatedMaterial.FaculcyName;
                existingMaterial.Department = updatedMaterial.Department;
                existingMaterial.MaterialType = updatedMaterial.MaterialType;
                existingMaterial.Volume = updatedMaterial.Volume;
                existingMaterial.CreationDate = updatedMaterial.CreationDate;

                SaveMaterialsToFile(materials);
            }
            else
            {
                throw new ArgumentException("Material not found");
            }
        }

        public void DeleteMaterial(int id)
        {
            var materials = GetAllMaterials();
            var materialToRemove = materials.FirstOrDefault(material => material.Id == id);

            if (materialToRemove != null)
            {
                materials.Remove(materialToRemove);
                SaveMaterialsToFile(materials);
            }
            else
            {
                throw new ArgumentException("Material not found");
            }
        }

        private void SaveMaterialsToFile(List<Material> materials)
        {
            var json = JsonConvert.SerializeObject(materials, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}
