using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model
{
    public class Right
    {
        public long ID { get; set; }
        //权限编码
        public int Code { get; set; }
        //权限名称
        public string Name { get; set; }
        //权限描述
        public string Desc { get; set; }
        //所属业务模块
        public BusinessModule BusinessModule { get; set; }
    }
}
