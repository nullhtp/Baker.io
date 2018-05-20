using System.Collections.Generic;
using System.Data;
using Dapper.FastCrud;


namespace Baker.io.Repositories
{
    public class BaseRepository <T>
    {
        protected IDbConnection Connection;
        
        public BaseRepository(IDbConnection connection)
        {
            OrmConfiguration.DefaultDialect = SqlDialect.PostgreSql;
            Connection = connection;
        }

        public void Insert(T item)
        {
            Connection.Insert(item);
        }

        public bool Update(T item)
        {
            return Connection.Update(item);
        }

        public bool Delete(T item)
        {
            return Connection.Delete(item);
        }

        public T Get(T item)
        {
            return Connection.Get(item);
        }

        public IEnumerable<T> GetAll()
        {
            return Connection.Find<T>();
        } 
    }
}