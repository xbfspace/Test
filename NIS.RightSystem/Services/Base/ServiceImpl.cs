using NIS.RightSystem.Data.Dao.AccessorInterface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Services.Base
{
    public class ServiceImpl<PK, Entity> : IService<PK, Entity> where Entity : class
    {
        protected static IAccessor<PK, Entity> Accessor;
        public ServiceImpl() {
            if (Accessor==null) {
                Accessor = new AccessorImpl<PK, Entity>();
            }
        }
        public virtual long Add(Entity entity)
        {
           return Accessor.Add(entity);
        }

        public virtual Entity Get(PK key)
        {
            return Accessor.Get(key);
        }

        public virtual bool Remove(Entity entity)
        {
            return Accessor.Remove(entity);
        }

        public virtual bool Update(Entity entity)
        {
            return Accessor.Update(entity);
        }

        public virtual IEnumerable<Entity> GetAll() {
            return Accessor.GetAll();
        }
    }
}
