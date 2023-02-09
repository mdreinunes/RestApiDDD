using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Core.Interfaces.Services;
using RestApiDDD.Domain.Entitys;

namespace RestApiDDD.Domaim.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            :base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto; 
        }
    }
}
