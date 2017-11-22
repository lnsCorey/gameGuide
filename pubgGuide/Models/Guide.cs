using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pubgGuide.Data;


namespace pubgGuide.Models
{
    class Guide
    {
        public String DataSourceName { get; set; }
        
        //Public List of Equipment Categories
        public List<PubgEquipmentCategory> EquipmentCategories { get; set; }
        
        //Public List of Equipment from Selected Category
        public Int32 SelectedEquipmentCategoryId { get; set; }
        public String SelectedEquipmentName { get; set; }
    

        public Guide(String dataSource)
        {
            DataSourceName = dataSource;
            EquipmentCategories = EquipmentData.GetEquipmentCategories();
        }

        public void AddCategory(PubgEquipmentCategory category)
        {
            if (!EquipmentCategories.Contains(category))
            {
                EquipmentCategories.Add(category);
                EquipmentData.AddCategory(category);
            }
        }

        public void DeleteCategory(PubgEquipmentCategory category)
        {
            if (!EquipmentCategories.Contains(category))
            {
                EquipmentCategories.Remove(category);
                EquipmentData.DeleteCategory(category);
            }
        }

        public void Update(PubgEquipmentCategory category)
        {
            EquipmentData.AddCategory(category);
        }
    }
}
