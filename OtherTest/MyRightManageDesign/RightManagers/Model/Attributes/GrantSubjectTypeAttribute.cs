using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model.Attributes
{
    public class GrantSubjectTypeAttribute:Attribute
    {
        public readonly string Name;
        public GrantSubjectTypeAttribute(string name) {
            Name = name;
        }
    }
}
