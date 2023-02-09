using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Entitys;

namespace RestApiDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext)
            :base(sqlContext)
        {
            this.sqlContext = sqlContext;   
        }
    }
}
