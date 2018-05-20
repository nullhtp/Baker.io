using System.Data;

namespace Baker.io.Repositories
{
    public class UnitRepository : BaseRepository<Unit>
    {
        public UnitRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}