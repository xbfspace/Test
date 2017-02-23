using Arch.Data.Test.OtherTest.MyRightManageDesign.Privilege;
using Arch.Data.Test.OtherTest.MyRightManageDesign.RightManagers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arch.Data.Test.OtherTest.MyRightManageDesign
{
    public interface IRightManger
    {
        #region grant
        bool GrantRightToRole(BusinessModuleInstance businessModule, Right right, Role role);
        bool GrantRightToRole(BusinessModuleInstance businessModule, Right right, User user);
        #endregion


        #region query
        /// <summary>
        /// 查询业务模块向对象授予的所有权限
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="grantType"></param>
        /// <returns></returns>
        IEnumerable<Right> QueryRightByBusinessModule(int businessModuleId,GrantSubjectType subjectType,int subjectId,GrantType grantType);

        //Right GetDenyRight(GrantSubjectType subjectType,int subjectId,int businessModule,int rightId);
        //Right GetAllowRight(GrantSubjectType subjectType, int subjectId, int businessModule, int rightId);
        #endregion
    }
}
