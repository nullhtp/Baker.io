using System.Data;

namespace Baker.io.Repositories
{
    public class OperationRepository : BaseRepository<Operation>
    {
        public OperationRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}