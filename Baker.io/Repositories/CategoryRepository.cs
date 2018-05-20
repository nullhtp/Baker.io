using System.Data;

namespace Baker.io.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}