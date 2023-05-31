using Autofac;
using DoctorDiet.Repository.Interfaces;
using DoctorDiet.Repository.Reposetories;
using DoctorDiet.Repository.UnitOfWork;
using DoctorDiet.Data;
using DoctorDiet.Services;
using DoctorDiet.Models;

namespace DoctorDiet.API.Config
{
    public class AutoFacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(Context)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericRepository<,>)).As(typeof(IGenericRepository<,>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(CommentRepository)).As(typeof(ICommentRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(AccountRepository)).As(typeof(IAccountRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(AccountService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(AdminService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(OwnerService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ReportService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(CommentService).Assembly).InstancePerLifetimeScope();
           // builder.RegisterAssemblyTypes(typeof(ApartmentImageService).Assembly).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ApartmentService).Assembly).InstancePerLifetimeScope();

        }
    }
}
