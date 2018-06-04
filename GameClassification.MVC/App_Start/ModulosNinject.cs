using GameClassification.Application;
using GameClassification.Application.Interface;
using GameClassification.Domain.Interfaces;
using GameClassification.Domain.Interfaces.Services;
using GameClassification.Domain.Services;
using GameClassification.Infra.Data.Repositories;
using Ninject.Modules;

namespace GameClassification.MVC.App_Start
{
    public class ModulosNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();


            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IProdutoService>().To<ProdutoService>();


            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();

        }
    }
}