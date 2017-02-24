using Arch.Data.Test.OtherTest.MyRightManageDesign.Privilege;
using Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.Test.UserRights
{

    public class UserRightTest
    {
        private static readonly IRightManger RightManager = new RightManager();

        //授予   张三   门户》通讯录》中国核建   查看       权限
        //       主体   业务模块                 权限
        public static void GrantRightToUser() {
            //权限主体
            var user = new User();
            user.ID = 1;
            user.Name = "张三";
            //业务模块模板
            var businessModuleTemplate = new BusinessModuleTemplate();
            businessModuleTemplate.Code = "Portal$AddressBook$Orgnize${0}";
            businessModuleTemplate.Name = "门户》通讯录》{0}";
            //业务模块
            var businessModuleInstance = new BusinessModuleInstance();
            businessModuleInstance.Code = "Portal$AddressBook$Organize$1";
            businessModuleInstance.Name = "门户》通讯录》中国核建";
            var right = new Right();
            right.ID = 1;
            right.Code = 1;
            right.Name = "查看用户";
            right.BusinessModuleTemplate = businessModuleTemplate;
            RightManager.GrantRightToUser(businessModuleInstance, right, user);
        }

        
    }
}
