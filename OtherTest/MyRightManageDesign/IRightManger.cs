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
        bool GrantRightToUser(BusinessModuleInstance businessModule, Right right, User user);
        bool GrantRightsToUser(BusinessModuleInstance businessModule, IEnumerable<Right> rights, User user);
        #endregion


        #region query
        /// <summary>
        /// 查询业务模块向对象授予的所有权限(只针对单种对象类型如:用户、角色...)
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="grantType"></param>
        /// <returns></returns>
        IEnumerable<Right> QueryRightByBusinessModule(int businessModuleId,GrantSubjectType subjectType,int subjectId,GrantType grantType);
        /// <summary>
        /// 查询权限结果（只针对单种对象类型：如用户、角色...）  对象对指定权限的验证结果是【拒绝】还是【允许】
        /// </summary>
        /// <param name="businessModuleId"></param>
        /// <param name="rightId"></param>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <returns></returns>

        RightResult QueryRightResult(int businessModuleId,int rightId,GrantSubjectType subjectType,int subjectId);
        /// <summary>
        /// 查询合并后的权限结果
        /// 如：用户张三属于组织总经理部，角色为秘书，给张三授予允许【查看】权限、授予总经理部拒绝【查看】权限、授予秘书允许【查看】权限
        /// 若【查看】这个权限项的优先级设置为拒绝优先，则权限结果是张三不允许【查看】
        /// </summary>
        /// <param name="businessModuleId"></param>
        /// <param name="rightId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        RightResult QueryMergedRightResult(int businessModuleId,int rightId,int userId);
        #endregion
    }
}
