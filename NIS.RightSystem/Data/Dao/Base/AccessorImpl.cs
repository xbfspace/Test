using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NIS.RightSystem.Data.Dao.AccessorInterface.Base
{
    public class AccessorImpl<PK, Entity> : IAccessor<PK, Entity> where Entity : class
    {
        protected static IDbConnection dbConnection; 
        public AccessorImpl() {
            if (dbConnection==null) {
                var connStr=ConfigurationManager.ConnectionStrings["NIS.RightSystem"].ConnectionString;
                dbConnection= new SqlConnection(connStr);
            }
        }
        public virtual long Add(Entity entity)
        {
            return dbConnection.Insert(entity);
        }

        public virtual Entity Get(PK key)
        {
            return dbConnection.Get<Entity>(key);
        }

        public virtual bool Remove(Entity entity)
        {
            return dbConnection.Delete(entity);
        }

        public virtual bool Update(Entity entity)
        {
            return dbConnection.Update(entity);
        }

        public virtual IEnumerable<Entity> GetAll() {
            return dbConnection.GetAll<Entity>();
        }
    }
}
