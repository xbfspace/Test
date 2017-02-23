using Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model
{
    //授权对象类型
    public enum GrantSubjectType
    {
        [GrantSubjectType("用户")]
        User = 0,
        [GrantSubjectType("角色")]
        Role =1,
        [GrantSubjectType("组织")]
        Organize = 2,
        [GrantSubjectType("职务")]
        Position =3,
        [GrantSubjectType("职级")]
        Rank =4,
        [GrantSubjectType("组织角色")]
        OrganizeRole =5,
        
    }
}
