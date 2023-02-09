using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Core.Interfaces.Services;
using RestApiDDD.Domain.Entitys;

namespace RestApiDDD.Domaim.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            :base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente; 
        }
    }
}
