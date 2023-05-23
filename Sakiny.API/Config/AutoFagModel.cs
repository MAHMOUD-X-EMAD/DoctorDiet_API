using Autofac;
using Sakiny.Data;

namespace Sakiny.API.Config
{
    public class AutoFagModel: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(Context)).InstancePerLifetimeScope();
            
        }
    }
}
