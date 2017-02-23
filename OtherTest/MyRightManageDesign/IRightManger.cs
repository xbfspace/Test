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
        bool GrantRightToRole(Right right,Role role,GrantType grantType);
        bool GrantRightToUser(Right right,User user,GrantType grantType);
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

        #endregion
    }
}
