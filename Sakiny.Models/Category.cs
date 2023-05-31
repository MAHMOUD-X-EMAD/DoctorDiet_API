using Sakiny.Models.Interface;
using System.ComponentModel;

namespace Sakiny.Models
{
    public class Category:IBaseModel<int>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Meal> Meals { get; set;}

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
