using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Data.Entities
{
    [Table("right_assign")]
    public class RightAssign
    {
        public int ID { get; set; }
        public int BusinessInstance { get; set; }
        public int Right { get; set; }
        public int Subject { get; set; }
        public int SubjectType { get; set; }
        public int BusinessTemplate { get; set; }
    }
}
