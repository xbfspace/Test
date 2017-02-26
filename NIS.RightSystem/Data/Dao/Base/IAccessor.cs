using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Data.Dao.AccessorInterface.Base
{
    public interface IAccessor<PK,Entity> where Entity:class
    {
        long Add(Entity entity);
        bool Remove(Entity entity);
        bool Update(Entity entity);
        Entity Get(PK key);
        IEnumerable<Entity> GetAll();
    }
}
