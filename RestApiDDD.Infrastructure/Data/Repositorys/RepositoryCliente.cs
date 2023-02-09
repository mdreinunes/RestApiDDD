using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Entitys;

namespace RestApiDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;  
        }
    }
}
