using Sakiny.Models.Interface;
using System.ComponentModel;

namespace Sakiny.Models
{
    public class NoEat:IBaseModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
