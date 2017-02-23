using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model
{
    /// <summary>
    /// 权限优先级别
    /// </summary>
    public enum RightPriority
    {
        Deny=0,//拒绝优先
        Allow=1,//允许优先
    }
}
