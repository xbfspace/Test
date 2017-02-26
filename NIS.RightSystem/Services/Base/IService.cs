using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Services.Base
{
    public interface IService<PK,Entity> where Entity:class
    {
        long Add(Entity entity);
        bool Remove(Entity entity);
        bool Update(Entity entity);
        Entity Get(PK key);
        IEnumerable<Entity> GetAll();
    }
}
