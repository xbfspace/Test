using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model
{
    //业务模块
    public class BusinessModule
    {
        //标识
        public long ID { get; set; }
        //业务模块编码 如：Portal$AddressBook
        public string Code { get; set; }
        //业务模块名称  如： 门户>>通讯录权限
        public string Name { get; set; }
        //业务模块描述
        public string Desc { get; set; }
    }
}
