using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIS.RightSystem.Data.Entities
{
    [Table("business_instance")]
    public class BusinessIntance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Remark { get; set; }

        public int BusinessTemplate { get; set; }
    }
}
