using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRANHIGS.Classes.StaticClasses
{
    static public class ResourcesList
    {
        public static List<GameResourcesType> resourcesList = new List<GameResourcesType>()
            {
                new GameResourcesType(){ ResourcesType = "Специалист", ResourcesValue = "Младший Специалист"},
                new GameResourcesType(){ ResourcesType = "Специалист", ResourcesValue = "Специалист"},
                new GameResourcesType(){ ResourcesType = "Специалист", ResourcesValue = "Старший Специалист"},
                new GameResourcesType(){ ResourcesType = "Деньги", ResourcesValue = "10"},
                new GameResourcesType(){ ResourcesType = "Деньги", ResourcesValue = "20"},
                new GameResourcesType(){ ResourcesType = "Деньги", ResourcesValue = "50"},
                new GameResourcesType(){ ResourcesType = "Деньги", ResourcesValue = "100"},
                new GameResourcesType(){ ResourcesType = "Деньги", ResourcesValue = "500"},
            };
    }
}
