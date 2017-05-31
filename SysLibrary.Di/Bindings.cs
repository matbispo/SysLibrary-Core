
using Autofac;
using SysLibrary.AppService.AppServices.AppServices;
using SysLibrary.AppService.AppServices.Interfaces;
using SysLibrary.Data.Context;
using SysLibrary.Data.Repositories;
using SysLibrary.Domain.Interfaces.Repositories;
using SysLibrary.Domain.Interfaces.Services;
using SysLibrary.Domain.Services;

namespace SysLibrary.DI
{
    public class Bindings: Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // Context
            builder.RegisterType<ContextDb>().As<IContextDb>().InstancePerLifetimeScope();

            // repositories
            builder.RegisterType<AdminRepository>().As<IAdminRepository>();
            builder.RegisterType<AssuntoRepository>().As<IAssuntoRepository>();
            builder.RegisterType<AutorRepository>().As<IAutorRepository>();
            builder.RegisterType<EditoraRepository>().As<IEditoraRepository>();
            builder.RegisterType<EmprestimoRepository>().As<IEmprestimoRepository>();
            builder.RegisterType<LivroEmprestimoRepository>().As<ILivroEmprestimoRepository>();
            builder.RegisterType<LivroRepository>().As<ILivroRepository>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterGeneric(typeof(RepositoryBase<>)).As(typeof(IRepositoryBase<>));

            // services
            builder.RegisterType<AdminService>().As<IAdminService>();
            builder.RegisterType<AssuntoService>().As<IAssuntoService>();
            builder.RegisterType<AutorService>().As<IAutorService>();
            builder.RegisterType<EditoraService>().As<IEditoraService>();
            builder.RegisterType<EmprestimoService>().As<IEmprestimoService>();
            builder.RegisterType<LivroEmprestimoRepository>().As<ILivroEmprestimoRepository>();
            builder.RegisterType<LivroService>().As<ILivroService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            builder.RegisterGeneric(typeof(ServiceBase<>)).As(typeof(IServiceBase<>));

            //AppServices
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
        /*    builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();
            builder.RegisterType<AdminAppService>().As<IAdminAppService>().InstancePerLifetimeScope();*/
            
        }
    }
}
