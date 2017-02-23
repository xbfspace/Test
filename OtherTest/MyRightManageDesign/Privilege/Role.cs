using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.Privilege
{
    public class Role
    {
        //标识
        public long ID { get; set; }
        //角色编码
        public string Code { get; set; }
        //角色名称
        public string Name { get; set; }
        //角色描述
        public string Desc { get; set; }
    }
}
