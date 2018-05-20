using System.Data;

namespace Baker.io.Repositories
{
    public class ElementRepository : BaseRepository<Element>
    {
        public ElementRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}