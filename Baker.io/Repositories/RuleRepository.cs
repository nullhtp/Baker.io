using System.Data;

namespace Baker.io.Repositories
{
    public class RuleRepository : BaseRepository<Operation>
    {
        public RuleRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}